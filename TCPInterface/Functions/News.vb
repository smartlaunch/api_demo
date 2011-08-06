Imports Smartlaunch.TCPInterface.Classes.Definitions

Namespace News


    Public Module General
        Private _NewsCollection As News.NewsCollection
        Private _NewsLastUpdate As DateTime


        Public ReadOnly Property Items() As News.NewsCollection
            Get
                ' Update news. Put all news from data source into _newsCollection
                If _NewsLastUpdate = Nothing OrElse _NewsLastUpdate.AddSeconds(Classes.Settings.UpdateIntervalNews) < DateTime.Now Then
                    _NewsCollection = TCPInterface.News.NewsCollection.GetAll()
                    _NewsLastUpdate = DateTime.Now
                End If

                Return _NewsCollection
            End Get
        End Property


    End Module


    Public Class NewsCollection
        Inherits CollectionBase

        Public ReadOnly Property Item(ByVal index As Integer) As NewsItem
            Get
                Return CType(List.Item(index), NewsItem)
            End Get
        End Property

        Public Sub Add(ByVal news As NewsItem)
            List.Add(news)
        End Sub

        Public Function Remove(ByVal index As Integer) As Boolean
            If index > Count - 1 Or index < 0 Then
                Return False
            End If

            List.RemoveAt(index)
            Return True

        End Function

        Friend Shared Function GetAll() As NewsCollection

            Dim newsCol As New NewsCollection

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("NewsGetAll")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Top", "0")

            Dim xmlDoc As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            For i As Integer = 0 To xmlDoc.GetElementsByTagName("Object").Count - 1
                newsCol.Add(LoadNewsItemFromXml(xmlDoc, i))
            Next

            Return newsCol

        End Function

        Public Shared Function LoadNewsItemFromXml(ByVal xmlDoc As Xml.XmlDocument, ByVal index As Integer) As NewsItem

            Dim news As New TCPInterface.News.NewsItem

            With xmlDoc.DocumentElement.GetElementsByTagName("Object")(index)
                news.NewsID = Convert.ToInt32(.Attributes("NewsID").Value)
                news.DateTimeAdded = Date.FromOADate(CDbl(.Attributes("DateTimeAdded").Value))
                news.DateTimeLastUpdated = Date.FromOADate(CDbl(.Attributes("DateTimeLastUpdated").Value))
                news.Author = Convert.ToString(.Attributes("Author").Value)
                news.Headline = Convert.ToString(.Attributes("Headline").Value)
                news.Content = Convert.ToString(.Attributes("Content").Value)
            End With

            Return news

        End Function

    End Class


    Public Class NewsItem

        Private _NewsID As Integer
        Private _dtAdded As DateTime
        Private _dtLastUpdated As DateTime
        Private _Author As String
        Private _Headline As String
        Private _Content As String

#Region "Properties"
        Public Property NewsID() As Integer
            Get
                Return _NewsID
            End Get
            Set(ByVal Value As Integer)
                _NewsID = Value
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

        Public Property DateTimeLastUpdated() As DateTime
            Get
                Return _dtLastUpdated
            End Get
            Set(ByVal Value As DateTime)
                _dtLastUpdated = Value
            End Set
        End Property

        Public Property Author() As String
            Get
                Return _Author
            End Get
            Set(ByVal Value As String)
                _Author = Value
            End Set
        End Property

        Public Property Headline() As String
            Get
                Return _Headline
            End Get
            Set(ByVal Value As String)
                _Headline = Value
            End Set
        End Property

        Public Property Content() As String
            Get
                Return _Content
            End Get
            Set(ByVal Value As String)
                _Content = Value
            End Set
        End Property
#End Region

#Region "Enums"
        Public Enum NewsSaveResponse
            Success = 1
            InvalidNewsID = -1
        End Enum
#End Region

        Sub New()

        End Sub

        Sub New(ByVal newsID As Integer)
            _NewsID = newsID
            Load(newsID)
        End Sub


        Private Sub Load(ByVal newsID As Integer)

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("NewsGet")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("NewsID", newsID)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait("NewsGet=" & newsID)

            Main.XmlDocContainsSingle("news items", xmlRes)

            With xmlRes.DocumentElement.GetElementsByTagName("Object")(0)
                _dtAdded = Convert.ToDateTime(.Attributes("DateTimeAdded").Value)
                _dtLastUpdated = Convert.ToDateTime(.Attributes("DateTimeLastUpdated").Value)
                _Author = Convert.ToString(.Attributes("Author").Value)
                _Headline = Convert.ToString(.Attributes("Headline").Value)
                _Content = Convert.ToString(.Attributes("Content").Value)
            End With

        End Sub


        Public Function Save() As NewsSaveResponse

            Dim res As New Classes.XMLCommand
            res.AppendCommand("NewsSave")

            res.AppendParameterSection()
            res.AppendParameter("NewsID", _NewsID)
            res.AppendParameter("DateTimeAdded", _dtAdded)
            res.AppendParameter("DateTimeLastUpdated", _dtLastUpdated)
            res.AppendParameter("Author", _Author)
            res.AppendParameter("Headline", _Headline)
            res.AppendParameter("Content", _Content)

            Dim ret As String = Classes.Communication.SendAndWait(res.InnerXML).GetElementsByTagName("Response")(0).Attributes("Response").Value
            Return CType(ret, NewsSaveResponse)

        End Function




    End Class

End Namespace
