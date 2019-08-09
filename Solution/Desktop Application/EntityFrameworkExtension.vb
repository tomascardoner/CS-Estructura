Imports System.Data.Entity
Imports System.Data.Entity.Core.EntityClient

Partial Public Class CSEstructuraContext
    Inherits DbContext

    Public Shared Property ConnectionString As String

    Public Sub New(ByVal UseCustomConnectionString As Boolean)
        MyBase.New(ConnectionString)
    End Sub

    Public Shared Sub CreateConnectionString(ByVal Provider As String, ByVal ProviderConnectionString As String)
        Dim ecb As EntityConnectionStringBuilder = New EntityConnectionStringBuilder()

        ecb.Metadata = String.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", "CSEstructura")
        ecb.Provider = Provider
        ecb.ProviderConnectionString = ProviderConnectionString

        ConnectionString = ecb.ConnectionString
    End Sub

    Public Sub RefreshAll()
        For Each dbentity In MyBase.ChangeTracker.Entries
            Select Case dbentity.State
                Case EntityState.Added
                Case EntityState.Deleted
                Case EntityState.Modified Or EntityState.Unchanged
                    dbentity.Reload()
            End Select
        Next
    End Sub
End Class

Partial Public Class Clase_Propiedad
    Public ReadOnly Property TipoDatoNombre As String
        Get
            Select Case TipoDato
                Case Constantes.TIPODATO_TEXTO
                    Return Constantes.TIPODATO_TEXTO_NOMBRE
                Case Constantes.TIPODATO_NUMEROENTERO
                    Return Constantes.TIPODATO_NUMEROENTERO_NOMBRE
                Case Constantes.TIPODATO_NUMERODECIMAL
                    Return Constantes.TIPODATO_NUMERODECIMAL_NOMBRE
                Case Constantes.TIPODATO_FECHAHORA
                    Return Constantes.TIPODATO_FECHAHORA_NOMBRE
                Case Constantes.TIPODATO_FECHA
                    Return Constantes.TIPODATO_FECHA_NOMBRE
                Case Constantes.TIPODATO_HORA
                    Return Constantes.TIPODATO_HORA_NOMBRE
                Case Constantes.TIPODATO_SINO
                    Return Constantes.TIPODATO_SINO_NOMBRE
                Case Constantes.TIPODATO_LISTA
                    Return Constantes.TIPODATO_LISTA_NOMBRE
                Case Constantes.TIPODATO_CLASE
                    Return Constantes.TIPODATO_CLASE_NOMBRE
                Case Else
                    Return String.Empty
            End Select
        End Get
    End Property
End Class

Partial Public Class Objeto_Propiedad
    Public Function Valor(ByVal IDClase As Short, ByVal TipoDato As String, Optional dbContext As CSEstructuraContext = Nothing) As String
        Select Case TipoDato
            Case Constantes.TIPODATO_TEXTO
                If Valor_Texto Is Nothing Then
                    Return String.Empty
                Else
                    Return Valor_Texto
                End If
            Case Constantes.TIPODATO_NUMEROENTERO
                If Valor_NumeroEntero Is Nothing Then
                    Return String.Empty
                Else
                    Return FormatNumber(Valor_NumeroEntero, 0)
                End If
            Case Constantes.TIPODATO_NUMERODECIMAL
                If Valor_NumeroDecimal Is Nothing Then
                    Return String.Empty
                Else
                    Return FormatNumber(Valor_NumeroDecimal, 0)
                End If
            Case Constantes.TIPODATO_FECHAHORA
                If Valor_FechaHora.HasValue Then
                    Return FormatDateTime(Valor_FechaHora.Value, DateFormat.ShortDate) & " " & FormatDateTime(Valor_FechaHora.Value, DateFormat.ShortTime)
                Else
                    Return String.Empty
                End If
            Case Constantes.TIPODATO_FECHA
                If Valor_FechaHora.HasValue Then
                    Return FormatDateTime(Valor_FechaHora.Value, DateFormat.ShortDate)
                Else
                    Return String.Empty
                End If
            Case Constantes.TIPODATO_HORA
                If Valor_FechaHora.HasValue Then
                    Return FormatDateTime(Valor_FechaHora.Value, DateFormat.ShortTime)
                Else
                    Return String.Empty
                End If
            Case Constantes.TIPODATO_SINO
                If Valor_SiNo.HasValue Then
                    Return Convert.ToString(IIf(Valor_SiNo.Value, My.Resources.STRING_YES, My.Resources.STRING_NO))
                Else
                    Return String.Empty
                End If
            Case Constantes.TIPODATO_LISTA
                If Valor_Lista Is Nothing Then
                    Return String.Empty
                Else
                    Dim Clase_Propiedad_ListaActual As Clase_Propiedad_Lista

                    If dbContext Is Nothing Then
                        Using dbContextLocal As New CSEstructuraContext(True)
                            Clase_Propiedad_ListaActual = dbContextLocal.Clase_Propiedad_Lista.Find(IDClase, IDPropiedad, Valor_Lista)
                        End Using
                    Else
                        Clase_Propiedad_ListaActual = dbContext.Clase_Propiedad_Lista.Find(IDClase, IDPropiedad, Valor_Lista)
                    End If
                    If Clase_Propiedad_ListaActual Is Nothing Then
                        Return String.Empty
                    Else
                        Return Clase_Propiedad_ListaActual.Nombre
                    End If
                End If
            Case Constantes.TIPODATO_CLASE
                Return String.Empty
            Case Else
                Return String.Empty
        End Select
    End Function
End Class