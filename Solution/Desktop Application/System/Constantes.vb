Module Constantes
    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const APPLICATION_DATABASE_GUID As String = "{DEBD3DD3-D81E-4548-B26A-0E9071536579}"
    Friend Const FILTER_ACTIVO_LIST_INDEX As Long = 1

    '//////////////////
    '    BÁSICAS
    '//////////////////
    Friend Const KEY_STRINGER As String = "@"
    Friend Const KEY_DELIMITER As String = "|@|"

    Friend Const STRING_LIST_SEPARATOR As String = "|"
    Friend Const STRING_LIST_DELIMITER As String = "¬"

    Friend Const DATE_TIME_FIELD_NULL_VALUE As Date = #12:00:00 AM#


    '//////////////////////
    '    TIPOS DE DATOS
    '//////////////////////
    Friend Const TIPODATO_TEXTO As String = "TX"
    Friend Const TIPODATO_TEXTO_NOMBRE As String = "Texto"
    Friend Const TIPODATO_NUMEROENTERO As String = "NE"
    Friend Const TIPODATO_NUMEROENTERO_NOMBRE As String = "Número entero"
    Friend Const TIPODATO_NUMERODECIMAL As String = "ND"
    Friend Const TIPODATO_NUMERODECIMAL_NOMBRE As String = "Número decimal"
    Friend Const TIPODATO_FECHAHORA As String = "FH"
    Friend Const TIPODATO_FECHAHORA_NOMBRE As String = "Fecha y Hora"
    Friend Const TIPODATO_FECHA As String = "FE"
    Friend Const TIPODATO_FECHA_NOMBRE As String = "Fecha"
    Friend Const TIPODATO_HORA As String = "HO"
    Friend Const TIPODATO_HORA_NOMBRE As String = "Hora"
    Friend Const TIPODATO_SINO As String = "SN"
    Friend Const TIPODATO_SINO_NOMBRE As String = "Sí/No"
    Friend Const TIPODATO_LISTA As String = "LS"
    Friend Const TIPODATO_LISTA_NOMBRE As String = "Lista"
    Friend Const TIPODATO_CLASE As String = "CL"
    Friend Const TIPODATO_CLASE_NOMBRE As String = "Clase"
    Friend Const TIPODATO_PLANTILLAENLACE As String = "PL"
    Friend Const TIPODATO_PLANTILLAENLACE_NOMBRE As String = "Enlace a plantilla"

    Friend Const OBJETO_PLANTILLA_ID As Integer = -1


    '///////////////////////////////////
    '    PARÁMETROS DE LOS REPORTES
    '///////////////////////////////////
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    Friend Const REPORTE_PARAMETRO_TIPO_SINO As String = "SINO"
End Module
