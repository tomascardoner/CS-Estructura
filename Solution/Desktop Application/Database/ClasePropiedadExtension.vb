Partial Public Class ClasePropiedad
    Public ReadOnly Property TipoDatoNombre As String
        Get
            Select Case TipoDato
                Case Constantes.TipoDatoTexto
                    Return Constantes.TipoDatoTextoNombre
                Case Constantes.TipoDatoNumeroEntero
                    Return Constantes.TipoDatoNumeroEnteroNombre
                Case Constantes.TipoDatoNumeroDecimal
                    Return Constantes.TipoDatoNumeroDecimalNombre
                Case Constantes.TipoDatoFechaHora
                    Return Constantes.TipoDatoFechaHoraNombre
                Case Constantes.TipoDatoFecha
                    Return Constantes.TipoDatoFechaNombre
                Case Constantes.TipoDatoHora
                    Return Constantes.TipoDatoHoraNombre
                Case Constantes.TipoDatoSiNo
                    Return Constantes.TipoDatoSiNoNombre
                Case Constantes.TipoDatoLista
                    Return Constantes.TipoDatoListaNombre
                Case Constantes.TipoDatoClase
                    Return Constantes.TipoDatoClaseNombre
                Case Else
                    Return String.Empty
            End Select
        End Get
    End Property
End Class
