Friend Class FillAndRefreshLists

#Region "Declarations"
    Friend dbContext As CSEstructuraContext
#End Region

#Region "Class events"
    Public Sub New()
        dbContext = New CSEstructuraContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        dbContext.Dispose()
        MyBase.Finalize()
    End Sub
#End Region

    Friend Sub Propiedad_TipoDato(ByRef ComboBoxControl As ComboBox)
        Dim datatableTiposDatos As New DataTable("TiposDatos")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "TipoDato"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableTiposDatos
            .Columns.Add("TipoDato", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_TEXTO
            datarowRow("Nombre") = Constantes.TIPODATO_TEXTO_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_NUMEROENTERO
            datarowRow("Nombre") = Constantes.TIPODATO_NUMEROENTERO_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_NUMERODECIMAL
            datarowRow("Nombre") = Constantes.TIPODATO_NUMERODECIMAL_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_FECHAHORA
            datarowRow("Nombre") = Constantes.TIPODATO_FECHAHORA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_FECHA
            datarowRow("Nombre") = Constantes.TIPODATO_FECHA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_HORA
            datarowRow("Nombre") = Constantes.TIPODATO_HORA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_SINO
            datarowRow("Nombre") = Constantes.TIPODATO_SINO_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_LISTA
            datarowRow("Nombre") = Constantes.TIPODATO_LISTA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_CLASE
            datarowRow("Nombre") = Constantes.TIPODATO_CLASE_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TIPODATO_PLANTILLAENLACE
            datarowRow("Nombre") = Constantes.TIPODATO_PLANTILLAENLACE_NOMBRE
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableTiposDatos
    End Sub

    Friend Sub Clase(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listClases As List(Of Clase)

        ComboBoxControl.ValueMember = "IDClase"
        ComboBoxControl.DisplayMember = "Nombre"

        listClases = dbContext.Clase.Where(Function(cl) cl.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Clase
            Item_Todos.IDClase = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listClases.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Clase
            Item_NoEspecifica.IDClase = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NON_SPECIFIED
            listClases.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listClases
    End Sub

    Friend Sub Clase_Propiedad_Lista(ByRef ComboBoxControl As ComboBox, ByVal IDClase As Short, ByVal IDPropiedad As Short)
        Dim listClase_Propiedad_Lista As List(Of Clase_Propiedad_Lista)

        ComboBoxControl.ValueMember = "IDLista"
        ComboBoxControl.DisplayMember = "Nombre"

        listClase_Propiedad_Lista = (From cla_pro_lst In dbContext.Clase_Propiedad_Lista
                                     Where cla_pro_lst.IDClase = IDClase And cla_pro_lst.IDPropiedad = IDPropiedad
                                     Select cla_pro_lst).ToList

        ComboBoxControl.DataSource = listClase_Propiedad_Lista
    End Sub
End Class