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

Partial Public Class ClasePropiedad
    Public Property IdClase As Short
    Public Property IdPropiedad As Short
    Public Property Nombre As String
    Public Property TipoDato As String
    Public Property TipoDatoIdClase As Nullable(Of Short)

    Public Overridable Property Clase As Clase
    Public Overridable Property ClasePropiedadesLista As ICollection(Of ClasePropiedadLista) = New HashSet(Of ClasePropiedadLista)

End Class
