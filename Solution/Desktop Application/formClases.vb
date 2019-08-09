Public Class formClases

#Region "Declarations"
    Private listClases_Base As List(Of Clase)
    Private listClases_FiltradaYOrdenada As List(Of Clase)
    Private SkipFilterData As Boolean = False
    Private BusquedaAplicada As Boolean = False

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        'datagridviewMain.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        'datagridviewMain.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub formClases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetAppearance()

        SkipFilterData = True

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        SkipFilterData = False

        OrdenColumna = columnNombre
        OrdenTipo = SortOrder.Ascending

        RefreshData()

        FormResize()
    End Sub

    Private Sub FormResize() Handles MyBase.Resize
        If Me.WindowState <> FormWindowState.Minimized Then
            'listviewClases.Columns(0).Width = listviewClases.Width - 60
        End If
    End Sub

    Private Sub formClases_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        listClases_Base = Nothing
        listClases_FiltradaYOrdenada = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PosicionIDClase As Integer = 0, Optional ByVal RestaurarPosicionActual As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Using dbContext As New CSEstructuraContext(True)
            listClases_Base = dbContext.Clase.OrderBy(Function(c) c.Nombre).ToList
        End Using

        If RestaurarPosicionActual Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PosicionIDClase = 0
            Else
                PosicionIDClase = CInt(datagridviewMain.CurrentRow.Cells(columnIDClase.Name).Value)
            End If
        End If

        FilterData()

        If PosicionIDClase <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CInt(CurrentRowChecked.Cells(columnIDClase.Name).Value) = PosicionIDClase Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnIDClase.Name)
                    Exit For
                End If
            Next
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            If BusquedaAplicada Then
                listClases_FiltradaYOrdenada = (From c In listClases_Base
                                                Where c.Nombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim) And (comboboxActivo.SelectedIndex = 0 Or (comboboxActivo.SelectedIndex = 1 And c.EsActivo) Or (comboboxActivo.SelectedIndex = 2 And Not c.EsActivo))
                                                Select c).ToList
            Else
                listClases_FiltradaYOrdenada = (From c In listClases_Base
                                                Where comboboxActivo.SelectedIndex = 0 Or (comboboxActivo.SelectedIndex = 1 And c.EsActivo) Or (comboboxActivo.SelectedIndex = 2 And Not c.EsActivo)
                                                Select c).ToList
            End If

            Select Case listClases_FiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Clases para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Clase.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Clases.", listClases_FiltradaYOrdenada.Count)
            End Select

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case columnIDClase.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listClases_FiltradaYOrdenada = listClases_FiltradaYOrdenada.OrderBy(Function(col) col.IDClase).ToList
                Else
                    listClases_FiltradaYOrdenada = listClases_FiltradaYOrdenada.OrderByDescending(Function(col) col.IDClase).ToList
                End If
            Case columnNombre.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listClases_FiltradaYOrdenada = listClases_FiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ToList
                Else
                    listClases_FiltradaYOrdenada = listClases_FiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = listClases_FiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub textboxBuscar_GotFocus() Handles textboxBuscar.GotFocus
        textboxBuscar.SelectAll()
    End Sub

    Private Sub textboxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If textboxBuscar.Text.Trim.Length < 2 Then
                MsgBox("Se deben especificar al menos 2 letras para buscar.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxBuscar.Focus()
            Else
                BusquedaAplicada = True
                FilterData()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub buttonBuscarBorrar_Click() Handles buttonBuscarBorrar.Click
        If BusquedaAplicada Then
            textboxBuscar.Clear()
            BusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub comboboxActivo_SelectedIndexChanged() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn Is columnIDClase Or ClickedColumn Is columnNombre Then
            If ClickedColumn Is OrdenColumna Then
                ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
                If OrdenTipo = SortOrder.Ascending Then
                    OrdenTipo = SortOrder.Descending
                Else
                    OrdenTipo = SortOrder.Ascending
                End If
            Else
                ' La columna clickeada es diferencte a la que ya estaba ordenada.
                ' En primer lugar saco el ícono de orden de la columna vieja
                If Not OrdenColumna Is Nothing Then
                    OrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
                End If

                ' Ahora preparo todo para la nueva columna
                OrdenTipo = SortOrder.Ascending
                OrdenColumna = ClickedColumn
            End If
        End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        datagridviewMain.Enabled = False

        formClase.LoadAndShow(True, Me, 0)

        datagridviewMain.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Clase para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formClase.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Clase).IDClase)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub buttonEliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Clase para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim ClaseActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, Clase)

            If MsgBox("Se eliminará la Clase seleccionada." & vbCrLf & vbCrLf & ClaseActual.Nombre & vbCrLf & vbCrLf & "¿Confirma la eliminación definitiva?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    Using dbContext = New CSEstructuraContext(True)
                        dbContext.Clase.Attach(ClaseActual)
                        dbContext.Clase.Remove(ClaseActual)
                        dbContext.SaveChanges()
                    End Using

                Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                    Me.Cursor = Cursors.Default
                    Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                        Case Errors.RelatedEntity
                            MsgBox("No se puede eliminar la Clase porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    End Select
                    Exit Sub

                Catch ex As Exception
                    CS_Error.ProcessError(ex, "Error al eliminar la Clase.")
                End Try

                RefreshData()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Clase para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formClase.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Clase).IDClase)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class