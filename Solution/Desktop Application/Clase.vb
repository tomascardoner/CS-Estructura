'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Clase
    Public Property IDClase As Short
    Public Property Nombre As String
    Public Property EsActivo As Boolean

    Public Overridable Property Objeto As ICollection(Of Objeto) = New HashSet(Of Objeto)
    Public Overridable Property Clase_Propiedad As ICollection(Of Clase_Propiedad) = New HashSet(Of Clase_Propiedad)

End Class