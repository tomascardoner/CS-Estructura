﻿Module Parametros
    'SISTEMA
    Friend Const INTERNET_PROXY As String = "INTERNET_PROXY"

    ' APLICACIÓN
    Friend Const APPLICATION_DATABASE_GUID As String = "APPLICATION_DATABASE_GUID"
    Friend Const LICENSE_COMPANY_NAME As String = "LICENSE_COMPANY_NAME"
    Friend Const USER_PASSWORD_MINIMUM_LENGHT As String = "USER_PASSWORD_MINIMUM_LENGHT"
    Friend Const USER_PASSWORD_SECURE_REQUIRED As String = "USER_PASSWORD_SECURE_REQUIRED"
    Friend Const EMAIL_VALIDATION_REGULAREXPRESSION As String = "EMAIL_VALIDATION_REGULAREXPRESSION"

    ' EMPRESA
    Friend Const EMPRESA_CUIT As String = "EMPRESA_CUIT"
    Friend Const EMPRESA_RAZONSOCIAL As String = "EMPRESA_RAZONSOCIAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_DIRECCION As String = "EMPRESA_DOMICILIOFISCAL_DIRECCION"
    Friend Const EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL As String = "EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID As String = "EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID"
    Friend Const EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID As String = "EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID"
    Friend Const EMPRESA_CATEGORIAIVA_ID As String = "EMPRESA_CATEGORIAIVA_ID"
    Friend Const EMPRESA_IIBB_NUMERO As String = "EMPRESA_IIBB_NUMERO"
    Friend Const EMPRESA_INICIO_ACTIVIDAD As String = "EMPRESA_INICIO_ACTIVIDAD"

    Friend Function SaveParameter(ByRef parametro As Parametro) As Boolean
        Return True
    End Function
End Module
