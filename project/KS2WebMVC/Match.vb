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

Partial Public Class Match
    Public Property id As Integer
    Public Property Matchcode As String
    Public Property Team1_id As Nullable(Of Integer)
    Public Property Team2_id As Nullable(Of Integer)
    Public Property ObsDraftURL As String
    Public Property ManageDraftURL As String
    Public Property WinnerTeam_id As Nullable(Of Integer)
    Public Property closed As Nullable(Of Boolean)
    Public Property added As Nullable(Of Date)
    Public Property started As Nullable(Of Boolean)
    Public Property modified As Nullable(Of Date)
    Public Property projectedstarttime As Nullable(Of Date)
    Public Property Team1_division As Nullable(Of Integer)
    Public Property Team2_division As Nullable(Of Integer)

    Public Overridable Property MatchTeams As ICollection(Of MatchTeams) = New HashSet(Of MatchTeams)
    Public Overridable Property User As ICollection(Of User) = New HashSet(Of User)

End Class
