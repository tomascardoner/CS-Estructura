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
