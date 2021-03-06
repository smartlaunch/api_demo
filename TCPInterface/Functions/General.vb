﻿Imports System.Xml
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

    Public Function GetAllEmployees() As XmlDocument

        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("EmployeeAll")

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return xmlRes
    End Function

    Public Function EmployeeByName(ByVal employeename As String) As XmlDocument

        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("EmployeeAll")
        Command.AppendParameterSection()
        Command.AppendParameter("employeename", employeename)
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
        Command.AppendCommand("SmartlaunchVersion")

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        Return Command.InnerXML & NewLine & xmlRes.InnerXml
    End Function


    Public Shared Function GetAllFinancialTransactions(StartDate As Date, EndDate As Date, FilterAdministratorID As Integer, FilterEmployeeID As Integer, OnlyPrintReport As Boolean, EmployeeName As String) As String
        Dim Command As New Classes.XMLCommand
        Command.AppendCommand("GetAllFinancialTransactions")

        Command.AppendParameterSection()
        Command.AppendParameter("StartDate", StartDate)
        Command.AppendParameter("EndDate", EndDate)
        Command.AppendParameter("FilterAdministratorID", FilterAdministratorID)
        Command.AppendParameter("FilterEmployeeID", FilterEmployeeID)
        Command.AppendParameter("OnlyPrintReport", OnlyPrintReport)
        Command.AppendParameter("EmployeeName", EmployeeName)

        Classes.Communication.SendAndWait(Command.InnerXML)

        Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
        Debug.WriteLine(xmlRes.InnerXml)

        'Return Command.InnerXML & NewLine & xmlRes.InnerXml

        For i As Integer = 0 To xmlRes.GetElementsByTagName("Object").Count - 1
            'With xmlRes.DocumentElement.GetElementsByTagName("Object")(i)
            '    Computers.Add(New ComputerGroup(CInt(.Attributes("ID").Value), .Attributes("Name").Value))
            'End With
        Next
        Return Command.InnerXML & NewLine & xmlRes.InnerXml


    End Function

    Private Shared Function SmartlaunchVersion(p1 As Integer, p2 As String) As String
        Throw New NotImplementedException
    End Function


End Class
