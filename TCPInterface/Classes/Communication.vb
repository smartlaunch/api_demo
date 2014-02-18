Imports Smartlaunch.TCPInterface.Classes.Definitions
Imports System.Net.Sockets
Imports System.Text

Namespace Classes

    Friend Class Communication

        Private WithEvents client As TcpClient
        Private EOLs As String = "{end}"
        Private EOL As Byte() = System.Text.Encoding.Default.GetBytes(EOLs)
        Private receiveData(1024) As Byte
        Friend ResponseReceived As Boolean = False
        Friend LastResponse As String

        Friend Sub New()
            Try
                client = New TcpClient
            Catch e As Exception
                Log.AddError(e.ToString)
            End Try
        End Sub

        Friend Function Connect() As Boolean
            Try
                client.Connect(Settings.ServerIP, Settings.ServerPort)
            Catch e As Exception
                Return False
            End Try

            If client.Connected Then
                client.GetStream().BeginRead(receiveData, 0, receiveData.Length, AddressOf ReceiveDataCallback, client)

                Return True
            Else
                Return False
            End If

        End Function

        Private Sub ReceiveDataCallback(ByVal iar As IAsyncResult)

            If (client.Connected) Then
                Dim bytesReceived As Int32 = (client.GetStream().EndRead(iar))
                Dim NewData As String = Encoding.UTF8.GetString(receiveData, 0, bytesReceived) 'Encoding.ASCII.GetString(receiveData, 0, bytesReceived)

                If NewData.EndsWith(EOLs) Then
                    LastResponse &= NewData.Substring(0, NewData.Length - EOLs.Length)
                    ResponseReceived = True
                Else
                    ' The whole message haven't been received, lets store the temporary data
                    LastResponse &= NewData
                End If

                Try
                    client.GetStream().BeginRead(receiveData, 0, receiveData.Length, AddressOf ReceiveDataCallback, client)
                Catch ex As Exception

                End Try

            End If

        End Sub

        Friend Sub Send(ByVal Command As String, ByVal Argument As String)
            Send(Command & "=" & Argument)
        End Sub

        Friend Sub Send(ByVal Data As String, Optional ByVal IncludeEOL As Boolean = True)
            If IncludeEOL AndAlso Not Data.EndsWith(EOLs) Then Data &= EOLs
            Send(System.Text.Encoding.UTF8.GetBytes(Data))
        End Sub

        Friend Sub Send(ByVal Data As Byte())
            Try
                ResponseReceived = False
                LastResponse = ""
                client.GetStream().Write(Data, 0, Data.Length)
            Catch e As Exception
                Log.Add("Error sending data: " & e.ToString & NewLine & System.Text.Encoding.UTF8.GetString(Data))
                Disconnect()
            End Try
        End Sub

        Friend Shared Function SendAndWait(ByVal Data As XMLCommand) As Xml.XmlDocument
            Return SendAndWait(Data.InnerXML)
        End Function

        Friend Shared Function TestConnection() As Boolean
            ' Just trying to send some random command
            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("UserLogin")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("username", "test")
            xmlCmd.AppendParameter("password", "test")

            Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            ' No errors have been thrown if we reach this point.
            Return True

        End Function

        Friend Shared Function SendAndWait(ByVal Data As String) As Xml.XmlDocument

            ' Connect
            Dim Connection As New Classes.Communication
            Connection.Connect()
            If Not Connection.Connected Then
                Log.AddError("Could not connect to Smartlaunch Server")
            Else
                ' Authorize
                Connection.Send("ExternalAuthorization=" & Settings.ServerUsername & DlM & Settings.ServerPassword)
                Do Until Not Connection.Connected OrElse Connection.ResponseReceived
                    Threading.Thread.Sleep(10)
                Loop

                ' Send data
                If Not Connection.Connected Then
                    Log.AddError("Could not authorize with Smartlaunch Server")
                Else
                    Connection.Send("XMLCommand=" & Data)

                    Do Until Not Connection.Connected OrElse Connection.ResponseReceived
                        Threading.Thread.Sleep(10)
                    Loop

                    If Connection.Connected Then
                        If Connection.LastResponse.StartsWith("Error=") Then
                            Throw New Exception(Connection.LastResponse.Substring(6))
                        Else
                            Dim Xml As New Xml.XmlDocument
                            Xml.LoadXml(Connection.LastResponse)
                            SendAndWait = Xml
                        End If
                        Connection.Disconnect()
                    End If
                End If
            End If
        End Function

        Friend Sub Disconnect()
            If client.Connected Then
                Send("CloseConnection")
                client.Close()
            End If
        End Sub

        Friend ReadOnly Property Connected() As Boolean
            Get
                If client Is Nothing Then Return False
                Return client.Connected
            End Get
        End Property

    End Class

End Namespace
