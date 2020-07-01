Module Constantes
    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const ApplicationDatabaseGuid As String = "{DEBD3DD3-D81E-4548-B26A-0E9071536579}"
    Friend Const FilterActivoListIndex As Long = 1

    '//////////////////
    '    BÁSICAS
    '//////////////////
    Friend Const KeyStringer As String = "@"
    Friend Const KeyDelimiter As String = "|@|"

    Friend Const StringListSeparator As String = "|"
    Friend Const StringListDelimiter As String = "¬"

    Friend Const DateTimeFieldNullValue As Date = #12:00:00 AM#


    '//////////////////////
    '    TIPOS DE DATOS
    '//////////////////////
    Friend Const TipoDatoTexto As String = "TX"
    Friend Const TipoDatoTextoNombre As String = "Texto"
    Friend Const TipoDatoNumeroEntero As String = "NE"
    Friend Const TipoDatoNumeroEnteroNombre As String = "Número entero"
    Friend Const TipoDatoNumeroDecimal As String = "ND"
    Friend Const TipoDatoNumeroDecimalNombre As String = "Número decimal"
    Friend Const TipoDatoFechaHora As String = "FH"
    Friend Const TipoDatoFechaHoraNombre As String = "Fecha y Hora"
    Friend Const TipoDatoFecha As String = "FE"
    Friend Const TipoDatoFechaNombre As String = "Fecha"
    Friend Const TipoDatoHora As String = "HO"
    Friend Const TipoDatoHoraNombre As String = "Hora"
    Friend Const TipoDatoSiNo As String = "SN"
    Friend Const TipoDatoSiNoNombre As String = "Sí/No"
    Friend Const TipoDatoLista As String = "LS"
    Friend Const TipoDatoListaNombre As String = "Lista"
    Friend Const TipoDatoClase As String = "CL"
    Friend Const TipoDatoClaseNombre As String = "Clase"
    Friend Const TipoDatoPlantillaEnlace As String = "PL"
    Friend Const TipoDatoPlantillaEnlaceNombre As String = "Enlace a plantilla"

    Friend Const ObjetoIdPlantilla As Integer = -1


    '///////////////////////////////////
    '    PARÁMETROS DE LOS REPORTES
    '///////////////////////////////////
    'Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    'Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    'Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    'Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    'Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    'Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    'Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    'Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    'Friend Const REPORTE_PARAMETRO_TIPO_SINO As String = "SINO"
End Module
