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
