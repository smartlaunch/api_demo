Imports System.Xml
Imports System.Collections.Generic

Public Class General

    Public Class Employee
        Private _Username As String
        Private _PasswordHash As String
        Private _PrivilegesServer As String
        Private _PrivilegesAdministrator As String
        Private _PrivilegesClient As String
        Private _InfoName As String
        Private _InfoAddress As String
        Private _InfoZip As String
        Private _InfoCity As String
        Private _InfoState As String
        Private _InfoEmail As String
        Private _InfoTelephone As String
        Private _InfoMobilephone As String
        Private _HideAds As String

    End Class


    Sub New()
    End Sub

    Public Function GetAllEmployees(Optional ByVal ColumnName As String = Nothing) As XmlDocument

        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("EmployeesGetAll")

        If Not ColumnName Is Nothing Then
            Command.AppendParameterSection()
            Command.AppendParameter("Columns", ColumnName)
        End If

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return xmlRes

    End Function

    Public Function GetAllEmployees(ByVal IDStart As String, ByVal TopCount As Integer) As XmlDocument

        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("EmployeesGetAll")

        Command.AppendParameterSection()
        Command.AppendParameter("IDStart", IDStart)
        Command.AppendParameter("TopCount", TopCount)

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return xmlRes

    End Function

    Public Class Application
        Private Name As String
        Private CategoryID As String
        Private SubCategoryID As String
        Private DirectApplicationID As String
    End Class

    Public Function ApplicationGetMostPopular(ByVal catName As String, ByVal withinDays As Integer) As XmlDocument
        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("ApplicationGetMostPopular")

        Command.AppendParameterSection()
        Command.AppendParameter("Top", "0")
        Command.AppendParameter("CategoryName", catName)
        Command.AppendParameter("WithinDays", withinDays)

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return xmlRes
    End Function

    Public Shared Function GetSmartlaunchServerVersion() As String
        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("GetSmartlaunchServerVersion")

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return Command.InnerXML & NewLine & xmlRes.InnerXml

    End Function


    Public Class Cafe

    End Class

    Private Shared Function SmartlaunchVersion(p1 As Integer, p2 As String) As String
        Throw New NotImplementedException
    End Function


End Class
