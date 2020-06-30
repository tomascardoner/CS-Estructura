Module MiscFunctions
    Friend Function LoadParameters() As Boolean
        Try
            Using dbcontext As New CSEstructuraContext(True)
                pParametros = dbcontext.Parametro.ToList
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al cargar los Parámetros desde la base de datos.")
            Return False
        End Try
    End Function
End Module
