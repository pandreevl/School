'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Department
    Public Property DepartmentID As Integer
    Public Property Name As String
    Public Property Budget As Decimal
    Public Property StartDate As Date
    Public Property Administrator As Nullable(Of Integer)

    Public Overridable Property Course As ICollection(Of Course) = New HashSet(Of Course)

End Class
