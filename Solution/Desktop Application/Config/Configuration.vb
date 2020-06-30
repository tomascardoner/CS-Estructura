Module Configuration
    Private Const ConfigSubFolder As String = "Config"

    Private Const AppearanceFileName As String = "Appearance.config"
    Private Const ComprobanteFileName As String = "Comprobante.config"
    Private Const DatabaseFileName As String = "Database.config"
    Private Const EmailFileName As String = "Email.config"
    Private Const GeneralFileName As String = "General.config"

    Friend Function LoadFiles() As Boolean
        Dim ConfigFolder As String

        ConfigFolder = My.Application.Info.DirectoryPath & IIf(My.Application.Info.DirectoryPath.EndsWith("\"), "", "\").ToString() & ConfigSubFolder & "\"

        ' Appearance
        If Not CardonerSistemas.Configuration.LoadFile(ConfigFolder, AppearanceFileName, pAppearanceConfig) Then
            Return False
        End If

        If Not CardonerSistemas.Configuration.LoadFile(ConfigFolder, DatabaseFileName, pDatabaseConfig) Then
            Return False
        End If
        If Not CardonerSistemas.Configuration.LoadFile(ConfigFolder, EmailFileName, pEmailConfig) Then
            Return False
        End If
        If Not CardonerSistemas.Configuration.LoadFile(ConfigFolder, GeneralFileName, pGeneralConfig) Then
            Return False
        End If

        Return True
    End Function

End Module
