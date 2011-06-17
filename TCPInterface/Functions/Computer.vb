Imports Smartlaunch.TCPInterface.Classes.Definitions

Namespace Computers

    Public Module General
        Private _ComputerLastUpdate As DateTime
        Private _ComputerCollection As Computers.ComputerCollection

        Public ReadOnly Property Items() As Computers.ComputerCollection
            Get
                ' Update news. Put all news from data source into _newsCollection
                If _ComputerLastUpdate = Nothing OrElse _ComputerLastUpdate.AddSeconds(Classes.Settings.UpdateIntervalNews) < DateTime.Now Then
                    _ComputerCollection = TCPInterface.Computers.ComputerCollection.GetAll()
                    _ComputerLastUpdate = DateTime.Now
                End If

                Return _ComputerCollection
            End Get
        End Property

    End Module

    Public Class ComputerCollection
        Inherits CollectionBase

        Public ReadOnly Property Item(ByVal index As Integer) As Computer
            Get
                Return CType(List.Item(index), Computer)
            End Get
        End Property

        Public Sub Add(ByVal computer As Computer)
            List.Add(computer)
        End Sub

        Public Function Remove(ByVal index As Integer) As Boolean
            If index > Count - 1 Or index < 0 Then
                Return False
            End If

            List.RemoveAt(index)
            Return True

        End Function


        Friend Shared Function GetAll() As ComputerCollection

            'Dim compCol As New ComputerCollection
            '' Obtain all news IDs in the database
            'Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait("ComputerGetAll=")

            ''For Each id As String In ids
            ''	compCol.Add(New Computer(Convert.ToInt32(id)))
            ''Next

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("ComputerGetAll")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("LayoutGroupName", Classes.Settings.ComputerLayoutGroupName)

            Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            Dim Computers As New ComputerCollection
            For i As Integer = 0 To xmlDoc.GetElementsByTagName("Object").Count - 1
                Computers.Add(LoadComputerItemFromXml(xmlDoc, i))
            Next

            Return Computers
        End Function


        Public Shared Function LoadComputerItemFromXml(ByVal xmlDoc As Xml.XmlDocument, ByVal index As Integer) As Computer

            Dim Computer As New TCPInterface.Computers.Computer

            With xmlDoc.DocumentElement.GetElementsByTagName("Object")(index)
                Computer.Type = CType(Convert.ToInt32(.Attributes("ConsoleType").Value), Computer.ComputerTypes)
                Computer.ComputerID = CInt(.Attributes("ComputerID").Value)
                Computer.GroupID = CInt(.Attributes("GroupID").Value)
                Computer.Name = .Attributes("Name").Value
                Computer.ActiveUserID = CInt(.Attributes("ActiveUserID").Value)
                Computer.ActiveApplications = Convert.ToString(.Attributes("ActiveApplications").Value)
                Computer.PositionX = CInt(.Attributes("PositionX").Value)
                Computer.PositionY = CInt(.Attributes("PositionY").Value)
            End With

            Return Computer
        End Function

    End Class


    Public Class Computer

        Private _ComputerID As Integer
        Private _GroupID As Integer
        Private _Name As String
        Private _Type As ComputerTypes
        Private _ActiveUserID As Integer
        Private _ActiveApplications As String
        Private _PositionX As Integer  ' position of computer in cafe "grid", if used
        Private _PositionY As Integer

#Region "Properties"
        Public Property ComputerID() As Integer
            Get
                Return _ComputerID
            End Get
            Set(ByVal Value As Integer)
                _ComputerID = Value
            End Set
        End Property

        Public Property GroupID() As Integer
            Get
                Return _GroupID
            End Get
            Set(ByVal Value As Integer)
                _GroupID = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property

        Public Property Type() As ComputerTypes
            Get
                Return _Type
            End Get
            Set(ByVal Value As ComputerTypes)
                _Type = Value
            End Set
        End Property

        Public Property ActiveUserID() As Integer
            Get
                Return _ActiveUserID
            End Get
            Set(ByVal Value As Integer)
                _ActiveUserID = Value
            End Set
        End Property


        Public Property ActiveApplications() As String
            Get
                Return _ActiveApplications
            End Get
            Set(ByVal Value As String)
                _ActiveApplications = Value
            End Set
        End Property

        Public Property PositionX() As Integer
            Get
                Return _PositionX
            End Get
            Set(ByVal Value As Integer)
                _PositionX = Value
            End Set
        End Property

        Public Property PositionY() As Integer
            Get
                Return _PositionY
            End Get
            Set(ByVal Value As Integer)
                _PositionY = Value
            End Set
        End Property
#End Region

#Region "Enums"
        Public Enum ComputerTypes
            Disabled = 0
            XBox
            PS2
            GameCube
            Laptop
            VirtualPC
        End Enum

        Public Enum ComputerSaveResponse
            Success = 1
            '...
        End Enum
#End Region

        Sub New()

        End Sub

        Sub New(ByVal computerID As Integer)
            _ComputerID = computerID
            Load(computerID)
        End Sub

        Private Sub Load(ByVal computerID As Integer)
            Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait("ComputerGet=" & computerID)

            _GroupID = Convert.ToInt32(Str(0))
            _Name = Str(1)
            _Type = DirectCast(2, ComputerTypes)
            _ActiveUserID = Convert.ToInt32(Str(3))
            _ActiveApplications = Str(4)
            _PositionX = Convert.ToInt32(Str(5))
            _PositionY = Convert.ToInt32(Str(6))

        End Sub

        Public Function Save() As ComputerSaveResponse
            Dim cmd As String = "ComputerSave="

            cmd &= _ComputerID.ToString() & DlM
            cmd &= _GroupID.ToString() & DlM
            cmd &= _Name & DlM
            cmd &= Convert.ToInt32(_Type).ToString() & DlM
            cmd &= _ActiveUserID.ToString() & DlM
            cmd &= _ActiveApplications & DlM
            cmd &= _PositionX.ToString() & DlM
            cmd &= _PositionY.ToString()

            Return DirectCast(Convert.ToInt32(Classes.Communication.SendAndWait(cmd)), ComputerSaveResponse)

        End Function



    End Class



End Namespace

