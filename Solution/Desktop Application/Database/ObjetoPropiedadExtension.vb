Partial Public Class ObjetoPropiedad
    Public Function Valor(ByVal IdClase As Short, ByVal TipoDato As String, Optional dbContext As CSEstructuraContext = Nothing) As String
        Select Case TipoDato
            Case Constantes.TipoDatoTexto
                If ValorTexto Is Nothing Then
                    Return String.Empty
                Else
                    Return ValorTexto
                End If
            Case Constantes.TipoDatoNumeroEntero
                If ValorNumeroEntero Is Nothing Then
                    Return String.Empty
                Else
                    Return FormatNumber(ValorNumeroEntero, 0)
                End If
            Case Constantes.TipoDatoNumeroDecimal
                If ValorNumeroDecimal Is Nothing Then
                    Return String.Empty
                Else
                    Return FormatNumber(ValorNumeroDecimal, 0)
                End If
            Case Constantes.TipoDatoFechaHora
                If ValorFechaHora.HasValue Then
                    Return FormatDateTime(ValorFechaHora.Value, DateFormat.ShortDate) & " " & FormatDateTime(ValorFechaHora.Value, DateFormat.ShortTime)
                Else
                    Return String.Empty
                End If
            Case Constantes.TipoDatoFecha
                If ValorFechaHora.HasValue Then
                    Return FormatDateTime(ValorFechaHora.Value, DateFormat.ShortDate)
                Else
                    Return String.Empty
                End If
            Case Constantes.TipoDatoHora
                If ValorFechaHora.HasValue Then
                    Return FormatDateTime(ValorFechaHora.Value, DateFormat.ShortTime)
                Else
                    Return String.Empty
                End If
            Case Constantes.TipoDatoSiNo
                If ValorSiNo.HasValue Then
                    Return Convert.ToString(IIf(ValorSiNo.Value, My.Resources.STRING_YES, My.Resources.STRING_NO))
                Else
                    Return String.Empty
                End If
            Case Constantes.TipoDatoLista
                If ValorLista Is Nothing Then
                    Return String.Empty
                Else
                    Dim ClasePropiedadListaActual As ClasePropiedadLista

                    If dbContext Is Nothing Then
                        Using dbContextLocal As New CSEstructuraContext(True)
                            ClasePropiedadListaActual = dbContextLocal.ClasePropiedadLista.Find(IdClase, IdPropiedad, ValorLista)
                        End Using
                    Else
                        ClasePropiedadListaActual = dbContext.ClasePropiedadLista.Find(IdClase, IdPropiedad, ValorLista)
                    End If
                    If ClasePropiedadListaActual Is Nothing Then
                        Return String.Empty
                    Else
                        Return ClasePropiedadListaActual.Nombre
                    End If
                End If
            Case Constantes.TipoDatoClase
                Return String.Empty
            Case Else
                Return String.Empty
        End Select
    End Function
End Class
