Imports Smartlaunch.TCPInterface.Classes.Definitions

Public Class SmartlaunchWebInterfaceException
    Inherits System.Exception

    Public Sub New(ByVal Message As String)
        MyBase.New(Message)
    End Sub

End Class

Namespace Main


    Public Module General

        ' We'll make it friend, should not be used outside this project
        Friend Sub XmlDocContainsSingle(ByVal type As String, ByVal xmlDoc As Xml.XmlDocument)

            If xmlDoc.DocumentElement.GetElementsByTagName("Object").Count <> 1 Then
                Throw New Exception("Error: Zero or more than one " & type & " items found")
            End If

        End Sub

        Public Function TestConnection() As Boolean
            Return Classes.Communication.TestConnection
        End Function




    End Module

End Namespace
