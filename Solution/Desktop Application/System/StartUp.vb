Module StartUp
    ' Config files
    Friend pAppearanceConfig As New AppearanceConfig
    Friend pDatabaseConfig As DatabaseConfig
    Friend pEmailConfig As EmailConfig
    Friend pGeneralConfig As GeneralConfig

    ' Database stuff
    Friend pDatabase As CardonerSistemas.Database.ADO.SQLServer
    Friend pFillAndRefreshLists As FillAndRefreshLists

    Friend pParametros As List(Of Parametro)

    Friend Sub Main()
        Dim StartupTime As Date

        System.Windows.Forms.Cursor.Current = Cursors.AppStarting

        My.Application.Log.WriteEntry("La Aplicación se está iniciando.", TraceEventType.Information)

        ' Cargo los archivos de configuración de la aplicación
        If Not Configuration.LoadFiles() Then
            TerminateApplication()
            Exit Sub
        End If

        ' Verifico si ya hay una instancia ejecutandose, si permite iniciar otra, o de lo contrario, muestro la instancia original
        If pGeneralConfig.SingleInstanceApplication Then

        End If

        ' Realizo la inicialización de la Aplicación
        If pAppearanceConfig.EnableVisualStyles Then
            Application.EnableVisualStyles()
        End If

        ' Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
        formSplashScreen.Show()
        formSplashScreen.Cursor = Cursors.AppStarting
        formSplashScreen.labelStatus.Text = "Obteniendo los parámetros de conexión a la Base de datos..."
        Application.DoEvents()

        ' Obtengo el Connection String para las conexiones de ADO .NET
        pDatabase = New CardonerSistemas.Database.ADO.SQLServer
        pDatabase.ApplicationName = My.Application.Info.Title
        pDatabase.Datasource = pDatabaseConfig.Datasource
        pDatabase.AttachDBFilename = pDatabaseConfig.AttachDBFilename
        pDatabase.InitialCatalog = pDatabaseConfig.Database
        pDatabase.UserId = pDatabaseConfig.UserId

        ' Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
        Dim Decrypter As New CS_Encrypt_TripleDES(CardonerSistemas.Constants.PUBLIC_ENCRYPTION_PASSWORD)
        Dim DecryptedText As String = ""
        If Decrypter.Decrypt(pDatabaseConfig.Password, DecryptedText) Then
            pDatabase.Password = DecryptedText
        Else
            pDatabase.Password = ""
        End If
        Decrypter = Nothing

        pDatabase.MultipleActiveResultsets = True
        pDatabase.WorkstationID = My.Computer.Name
        pDatabase.CreateConnectionString()

        ' Obtengo el Connection String para las conexiones de Entity Framework
        CSEstructuraContext.ConnectionString = CardonerSistemas.Database.EntityFramework.CreateConnectionString(pDatabaseConfig.Provider, pDatabase.ConnectionString, "CSEstructura")

        ' Cargos los Parámetros desde la Base de datos
        formSplashScreen.labelStatus.Text = "Cargando los parámetros desde la Base de datos..."
        Application.DoEvents()
        If Not MiscFunctions.LoadParameters() Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Exit Sub
        End If

        ' Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
        If CS_Parameter_System.GetString(Parametros.APPLICATION_DATABASE_GUID) <> Constantes.ApplicationDatabaseGuid Then
            MsgBox("La Base de Datos especificada no corresponde a esta aplicación.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Exit Sub
        End If

        ' Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
        formSplashScreen.labelLicensedTo.Text = CS_Parameter_System.GetString(Parametros.LICENSE_COMPANY_NAME, "")
        Application.DoEvents()

        ' Preparo instancia de clase para llenar los ComboBox
        pFillAndRefreshLists = New FillAndRefreshLists

        ' Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
        StartupTime = Now

        ' Muestro el form MDI principal
        formMDIMain.Cursor = Cursors.AppStarting
        formMDIMain.Enabled = False
        formMDIMain.Show()

        formSplashScreen.labelStatus.Text = "Todo completado."
        Application.DoEvents()

        ' Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
        If Not CS_Instance.IsRunningUnderIDE Then
            Do While Now.Subtract(StartupTime).Seconds < pAppearanceConfig.MinimumSplashScreenDisplaySeconds
                Application.DoEvents()
            Loop
        End If
        formSplashScreen.Close()
        formSplashScreen.Dispose()

        ' Está todo listo. Cambio el puntero del mouse a modo normal y habilito el form MDI principal
        formMDIMain.Cursor = Cursors.Default
        formMDIMain.Enabled = True

        System.Windows.Forms.Cursor.Current = Cursors.Default

        ' Inicio el loop sobre el form MDI principal
        My.Application.Log.WriteEntry("La Aplicación se ha iniciado correctamente.", TraceEventType.Information)
        Application.Run(formMDIMain)
    End Sub

    Friend Sub TerminateApplication()
        pAppearanceConfig = Nothing
        pDatabaseConfig = Nothing
        pEmailConfig = Nothing
        pGeneralConfig = Nothing

        pDatabase = Nothing
        pFillAndRefreshLists = Nothing
    End Sub
End Module
