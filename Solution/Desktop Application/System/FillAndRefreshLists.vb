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

    Friend Sub Propiedad_TipoDato(ByRef comboBoxControl As ComboBox)
        Dim datatableTiposDatos As New DataTable("TiposDatos")
        Dim datarowRow As DataRow

        comboBoxControl.ValueMember = "TipoDato"
        comboBoxControl.DisplayMember = "Nombre"

        With datatableTiposDatos
            .Columns.Add("TipoDato", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoTexto
            datarowRow("Nombre") = Constantes.TipoDatoTextoNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoNumeroEntero
            datarowRow("Nombre") = Constantes.TipoDatoNumeroEnteroNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoNumeroDecimal
            datarowRow("Nombre") = Constantes.TipoDatoNumeroDecimalNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoFechaHora
            datarowRow("Nombre") = Constantes.TipoDatoFechaHoraNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoFecha
            datarowRow("Nombre") = Constantes.TipoDatoFechaNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoHora
            datarowRow("Nombre") = Constantes.TipoDatoHoraNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoSiNo
            datarowRow("Nombre") = Constantes.TipoDatoSiNoNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoLista
            datarowRow("Nombre") = Constantes.TipoDatoListaNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoClase
            datarowRow("Nombre") = Constantes.TipoDatoClaseNombre
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("TipoDato") = Constantes.TipoDatoPlantillaEnlace
            datarowRow("Nombre") = Constantes.TipoDatoPlantillaEnlaceNombre
            .Rows.Add(datarowRow)
        End With

        comboBoxControl.DataSource = datatableTiposDatos
    End Sub

    Friend Sub Clase(ByRef comboBoxControl As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listClases As List(Of Clase)

        comboBoxControl.ValueMember = "IdClase"
        comboBoxControl.DisplayMember = "Nombre"

        listClases = dbContext.Clase.Where(Function(cl) cl.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

        If agregarItemTodos Then
            Dim Item_Todos As New Clase
            Item_Todos.IdClase = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listClases.Insert(0, Item_Todos)
        End If
        If agregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Clase
            Item_NoEspecifica.IdClase = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NON_SPECIFIED
            listClases.Insert(0, Item_NoEspecifica)
        End If

        comboBoxControl.DataSource = listClases
    End Sub

    Friend Sub Clase_Propiedad_Lista(ByRef comboBoxControl As ComboBox, ByVal idClase As Short, ByVal idPropiedad As Short)
        Dim listClase_Propiedad_Lista As List(Of ClasePropiedadLista)

        comboBoxControl.ValueMember = "IDLista"
        comboBoxControl.DisplayMember = "Nombre"

        listClase_Propiedad_Lista = (From cla_pro_lst In dbContext.ClasePropiedadLista
                                     Where cla_pro_lst.IdClase = idClase And cla_pro_lst.IdPropiedad = idPropiedad
                                     Select cla_pro_lst).ToList

        comboBoxControl.DataSource = listClase_Propiedad_Lista
    End Sub
End Class