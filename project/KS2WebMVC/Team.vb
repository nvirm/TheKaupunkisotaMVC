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

Partial Public Class Team
    Public Property id As Integer
    Public Property CityName As String
    Public Property TeamName As String
    Public Property CaptainUser_id As Nullable(Of Integer)
    Public Property Division As Nullable(Of Integer)
    Public Property Eliminated As Nullable(Of Integer)

    Public Overridable Property MatchTeams As ICollection(Of MatchTeams) = New HashSet(Of MatchTeams)
    Public Overridable Property User As ICollection(Of User) = New HashSet(Of User)
    Public Overridable Property User1 As ICollection(Of User) = New HashSet(Of User)

End Class
