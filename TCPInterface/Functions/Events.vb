Imports Smartlaunch.TCPInterface.Classes.Definitions

Namespace Events

    Public Module General
        Private _EventsLastUpdate As DateTime
        Private _EventsCollection As Events.EventCollection

        Public ReadOnly Property Items() As Events.EventCollection
            Get
                ' Update news. Put all news from data source into _newsCollection
                If _EventsLastUpdate = Nothing OrElse _EventsLastUpdate.AddSeconds(Classes.Settings.UpdateIntervalNews) < DateTime.Now Then
                    _EventsCollection = TCPInterface.Events.EventCollection.GetAll()
                    _EventsLastUpdate = DateTime.Now
                End If

                Return _EventsCollection
            End Get
        End Property

    End Module

    Public Class EventCollection
        Inherits CollectionBase

        Public ReadOnly Property Item(ByVal index As Integer) As EventItem
            Get
                Return CType(List.Item(index), EventItem)
            End Get
        End Property

        Public Sub Add(ByVal cafeEvent As EventItem)
            List.Add(cafeEvent)
        End Sub

        Public Function Remove(ByVal index As Integer) As Boolean
            If index > Count - 1 Or index < 0 Then
                Return False
            End If

            List.RemoveAt(index)
            Return True

        End Function


        Public Shared Function GetAll(Optional ByVal Top As Integer = 0) As EventCollection

            'Dim eventCol As New EventCollection
            '' Obtain all news IDs in the database
            'Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait("EventGetAll=")

            ''Dim ids As String() = Classes.Communication.SendAndWait("EventGetAll=").Split(DlM)

            ''For Each id As String In ids
            ''	eventCol.Add(New CafeEvent(Convert.ToInt32(id)))
            ''Next


            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("EventGetAll")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Top", Top)

            Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            Dim Events As New EventCollection
            For i As Integer = 0 To xmlDoc.GetElementsByTagName("Object").Count - 1
                Events.Add(New EventItem(xmlDoc.DocumentElement.GetElementsByTagName("Object")(i)))
            Next

            Return Events

        End Function


    End Class



    Public Class EventItem

        Private _EventID As Integer
        Private _Headline As String
        Private _Description As String
        Private _dtAdded As System.DateTime
        Private _dtBegin As System.DateTime
        Private _dtEnd As System.DateTime
        Private _JoinPrice As Double
        Private _MaxSeats As Integer
        Private _Participants As ArrayList  'ArrayList of EventParticipant structs
        Private _AllowedUserGroups As Integer()

        Public Structure EventParticipant

            Sub New(ByVal userName As String, ByVal hasPaid As Boolean)
                userName = userName
                hasPaid = hasPaid
            End Sub

            Public userName As String
            Public hasPaid As Boolean

        End Structure

#Region "Enums"
        Public Enum EventSaveResponse
            Success = 1
            EventIDInvalid = -1

        End Enum
#End Region

#Region "Properties"
        Public ReadOnly Property EventID() As Integer
            Get
                Return _EventID
            End Get
        End Property

        Public Property HeadLine() As String
            Get
                Return _Headline
            End Get
            Set(ByVal Value As String)
                _Headline = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property

        Public Property DateTimeAdded() As DateTime
            Get
                Return _dtAdded
            End Get
            Set(ByVal Value As DateTime)
                _dtAdded = Value
            End Set
        End Property

        Public Property DateTimeBegin() As DateTime
            Get
                Return _dtBegin
            End Get
            Set(ByVal Value As DateTime)
                _dtBegin = Value
            End Set
        End Property

        Public Property DateTimeEnd() As DateTime
            Get
                Return _dtEnd
            End Get
            Set(ByVal Value As DateTime)
                _dtEnd = Value
            End Set
        End Property

        Public Property JoinPrice() As Double
            Get
                Return _JoinPrice
            End Get
            Set(ByVal Value As Double)
                _JoinPrice = Value
            End Set
        End Property

        Public Property MaxSeats() As Integer
            Get
                Return _MaxSeats
            End Get
            Set(ByVal Value As Integer)
                _MaxSeats = Value
            End Set
        End Property

        Public ReadOnly Property Participants() As ArrayList
            Get
                Return _Participants
            End Get
        End Property

        Public Property AllowedUserGroups() As Integer()
            Get
                Return _AllowedUserGroups
            End Get
            Set(ByVal Value As Integer())
                _AllowedUserGroups = Value
            End Set
        End Property
#End Region


        ' Load existing event
        Sub New(ByVal EventID As Integer)
            _EventID = EventID
            Load(EventID)
        End Sub

        Sub New(ByVal Node As Xml.XmlNode)
            Load(EventID)
        End Sub

        Public Function AddParticipant(ByVal userName As String, ByVal hasPaid As Boolean) As Integer

            If _Participants.Count < _MaxSeats Then
                _Participants.Add(New EventParticipant(userName, hasPaid))
                Return 1
            Else
                Return -1
            End If

        End Function

        Public Function RemoveParticipant(ByVal userName As String) As Boolean

            ' Easier way to removed specified user from arraylist?
            For i As Integer = 0 To _Participants.Count
                If DirectCast(_Participants(i), EventParticipant).userName = userName Then
                    _Participants.RemoveAt(i)
                    Exit For
                End If
            Next

        End Function


        Private Sub Load(ByVal eventID As Integer)

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("EventGet")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("EventID", eventID)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            Main.XmlDocContainsSingle("events", xmlRes)

            LoadDataFromNode(xmlRes.DocumentElement.GetElementsByTagName("Object")(0))

        End Sub

        Private Sub LoadDataFromNode(ByVal Node As Xml.XmlNode)
            With Node
                _EventID = Convert.ToInt32(.Attributes("EventID").Value)
                _Headline = Convert.ToString(.Attributes("Healine").Value)
                _Description = Convert.ToString(.Attributes("Description").Value)
                _dtAdded = Convert.ToDateTime(.Attributes("DateTimeAdded").Value)
                _dtBegin = Convert.ToDateTime(.Attributes("DateTimeBegin").Value)
                _dtEnd = Convert.ToDateTime(.Attributes("DateTimeEnd").Value)
                _JoinPrice = Convert.ToInt32(.Attributes("Joinprice").Value)
                _MaxSeats = Convert.ToInt32(.Attributes("Maxseats").Value)

                For Each xNode As Xml.XmlNode In .SelectSingleNode("Participant")
                    Dim userName As String = xNode.Attributes("Username").Value
                    Dim hasPaid As Boolean = Convert.ToBoolean(xNode.Attributes("Paid").Value)
                    _Participants.Add(New EventParticipant(userName, hasPaid))
                Next

                For Each xNode As Xml.XmlNode In .SelectSingleNode("Participant")
                    Dim userName As String = xNode.Attributes("Username").Value
                    Dim hasPaid As Boolean = Convert.ToBoolean(xNode.Attributes("Paid").Value)
                    _Participants.Add(New EventParticipant(userName, hasPaid))
                Next

                ReDim _AllowedUserGroups(.SelectSingleNode("AllowedUserGroup").ChildNodes.Count)

                For i As Integer = 0 To .SelectSingleNode("AllowedUserGroup").ChildNodes.Count - 1
                    Dim xNode As Xml.XmlNode = .SelectSingleNode("AllowedUserGroup").ChildNodes(i)
                    _AllowedUserGroups(i) = Convert.ToInt32(xnode.Attributes("ID"))
                Next
            End With
        End Sub


        Public Function Save() As EventSaveResponse

            Dim cmd As String = "EventSave="

            cmd &= _EventID.ToString() & DlM
            cmd &= _Headline & DlM
            cmd &= _Description & DlM
            cmd &= _dtAdded.ToString() & DlM
            cmd &= _dtBegin.ToString() & DlM
            cmd &= _dtEnd.ToString() & DlM
            cmd &= _JoinPrice.ToString() & DlM
            cmd &= _MaxSeats.ToString() & DlM

            For Each part As EventParticipant In _Participants
                cmd &= part.userName & DlMSep2 & Convert.ToInt32(part.hasPaid).ToString() & DlMSep
            Next

            ' Remove last delimiter
            cmd = cmd.Substring(0, cmd.Length - 1)

            cmd &= DlM

            For Each i As Integer In _AllowedUserGroups
                cmd &= i.ToString() & DlMSep
            Next

            ' Remove last delimiter
            cmd = cmd.Substring(0, cmd.Length - 1)

            Return DirectCast(Convert.ToInt32(Classes.Communication.SendAndWait(cmd)), EventSaveResponse)

        End Function



    End Class

End Namespace
