﻿Imports System.Xml

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

    Public Function GetAllEmployees(ByVal employeeType As String) As XmlDocument

        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("EmployeesGetAll")

        Command.AppendParameterSection()
        Command.AppendParameter("EmployeeType", employeeType)

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

    Public Class Cafe

    End Class


End Class