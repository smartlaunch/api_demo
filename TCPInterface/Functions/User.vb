Imports Smartlaunch.TCPInterface.Classes.Definitions

Namespace Users

    Public Module General

        Public Function Create(ByVal Username As String, ByVal UserGroupName As String) As User

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("UserCreate")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Username", Username)
            xmlCmd.AppendParameter("UserGroupName", UserGroupName)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return New User(Username)
            Else
                Return Nothing
            End If

        End Function

        Public Function Login(ByVal Username As String, ByVal Password As String) As User

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("UserLogin")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Username", Username)
            xmlCmd.AppendParameter("Password", Password)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return New User(Username)
            Else
                Return Nothing
            End If

        End Function

    End Module


    Public Class User

        Private _UserName As String
        Private _UserGroupID As Integer
        Private _PasswordHash As String
        Private _FirstName As String
        Private _LastName As String
        Private _BirthDate As System.DateTime
        Private _Address As String
        Private _City As String
        Private _Zip As String
        Private _State As String
        Private _Country As String
        Private _Email As String
        Private _Phone As String
        Private _PhoneMobile As String
        Private _Sex As EnumSex
        Private _Age As Integer
        Private _SocialNum As String
        Private _TimeStatus As Integer
        Private _Balance As Double


#Region "Properties"
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal Value As String)
                _UserName = Value
            End Set
        End Property

        Public Property UserGroupID() As Integer
            Get
                Return _UserGroupID
            End Get
            Set(ByVal Value As Integer)
                _UserGroupID = Value
            End Set
        End Property

        Public Property PasswordHash() As String
            Get
                Return _PasswordHash
            End Get
            Set(ByVal Value As String)
                _PasswordHash = Value
            End Set
        End Property

        Public Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(ByVal Value As String)
                _FirstName = Value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(ByVal Value As String)
                _LastName = Value
            End Set
        End Property

        Public Property BirthDate() As System.DateTime
            Get
                Return _BirthDate
            End Get
            Set(ByVal Value As System.DateTime)
                _BirthDate = Value
            End Set
        End Property

        Public Property Address() As String
            Get
                Return _Address
            End Get
            Set(ByVal Value As String)
                _Address = Value
            End Set
        End Property

        Public Property City() As String
            Get
                Return _City
            End Get
            Set(ByVal Value As String)
                _City = Value
            End Set
        End Property

        Public Property Zip() As String
            Get
                Return _Zip
            End Get
            Set(ByVal Value As String)
                _Zip = Value
            End Set
        End Property

        Public Property State() As String
            Get
                Return _State
            End Get
            Set(ByVal Value As String)
                _State = Value
            End Set
        End Property

        Public Property Country() As String
            Get
                Return _Country
            End Get
            Set(ByVal Value As String)
                _Country = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal Value As String)
                _Email = Value
            End Set
        End Property

        Public Property Phone() As String
            Get
                Return _Phone
            End Get
            Set(ByVal Value As String)
                _Phone = Value
            End Set
        End Property

        Public Property PhoneMobile() As String
            Get
                Return _PhoneMobile
            End Get
            Set(ByVal Value As String)
                _PhoneMobile = Value
            End Set
        End Property

        Public Property Sex() As EnumSex
            Get
                Return _Sex
            End Get
            Set(ByVal Value As EnumSex)
                _Sex = Value
            End Set
        End Property

        Public Property Age() As Integer
            Get
                Return _Age
            End Get
            Set(ByVal Value As Integer)
                _Age = Value
            End Set
        End Property

        Public Property SocialNum() As String
            Get
                Return _SocialNum
            End Get
            Set(ByVal Value As String)
                _SocialNum = Value
            End Set
        End Property

        Public Property TimeStatus() As Integer
            Get
                Return _TimeStatus
            End Get
            Set(ByVal Value As Integer)
                _TimeStatus = Value
            End Set
        End Property

        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region

#Region "Enums"
        Public Enum EnumSex
            Male = 1
            Female = 2
        End Enum

        Public Enum UserSaveResponse
            Success = 1
            InvalidUserName = -1
            UserNameInUse = -2
            UserGroupInvalid = -3
            ErrorOther = -4
        End Enum
#End Region

        Sub New()

        End Sub


        ' Load an existing user
        Sub New(ByVal userName As String)
            _UserName = userName
            Load(userName)
        End Sub


        Private Sub Load(ByVal userName As String)

            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("UserGet")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Username", userName)

            Debug.WriteLine(xmlCmd.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)

            ' Handling of response field here
            Debug.WriteLine(xmlRes.InnerXml)
            Debug.WriteLine(xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value)

            Main.XmlDocContainsSingle("users", xmlRes)

            With xmlRes.DocumentElement.GetElementsByTagName("Object")(0)
                _UserGroupID = Convert.ToInt32(.Attributes("UsergroupID").Value)
                _PasswordHash = .Attributes("PasswordHash").Value
                _FirstName = Convert.ToString(.Attributes("Firstname").Value)
                _LastName = Convert.ToString(.Attributes("Lastname").Value)

                Try
                    _BirthDate = Convert.ToDateTime(.Attributes("Birthday").Value)
                Catch ex As Exception
                    _BirthDate = New DateTime
                End Try

                _Address = Convert.ToString(.Attributes("Address").Value)
                _City = Convert.ToString(.Attributes("City").Value)
                _Zip = Convert.ToString(.Attributes("Zip").Value)
                _State = Convert.ToString(.Attributes("State").Value)
                _Country = Convert.ToString(.Attributes("Country").Value)
                _Email = Convert.ToString(.Attributes("Email").Value)
                _Phone = Convert.ToString(.Attributes("Telephone").Value)
                _PhoneMobile = Convert.ToString(.Attributes("Mobilephone").Value)
                _Sex = CType(Convert.ToInt32(.Attributes("Sex").Value), EnumSex)
                _SocialNum = Convert.ToString(.Attributes("Personalnumber").Value)
                _TimeStatus = Convert.ToInt32(.Attributes("Time").Value)
                _Balance = Convert.ToDouble(.Attributes("Balance").Value)

            End With

        End Sub

        Public Sub DepositMoney(ByVal Amount As Double)
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserDepositWithdrawMoney")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Amount", Amount)

            Classes.Communication.SendAndWait(Command.InnerXML)
        End Sub

        Public Sub WithdrawMoney(ByVal Amount As Double)
            DepositMoney(-Amount)
        End Sub

        Public Function GetPriceForTime(ByVal Minutes As Integer) As Double
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserGetPriceForMinutes")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Minutes", Minutes)

            Return CDbl(Classes.Communication.SendAndWait(Command.InnerXML).GetElementsByTagName("Response")(0).Attributes("Price").Value)

        End Function

        Public Function Save() As UserSaveResponse

            Dim res As New Classes.XMLCommand
            res.AppendCommand("UserSave")

            res.AppendParameterSection()
            res.AppendParameter("Username", _UserName)
            res.AppendParameter("UsergroupID", _UserGroupID)
            res.AppendParameter("PasswordHash", _PasswordHash)
            res.AppendParameter("Firstname", _FirstName)
            res.AppendParameter("Lastname", _LastName)
            res.AppendParameter("Birthday", _BirthDate)
            res.AppendParameter("Address", _Address)
            res.AppendParameter("City", _City)
            res.AppendParameter("Zip", _Zip)
            res.AppendParameter("State", _State)
            res.AppendParameter("Country", _Country)
            res.AppendParameter("Email", _Email)
            res.AppendParameter("Telephone", _Phone)
            res.AppendParameter("Mobilephone", _PhoneMobile)
            res.AppendParameter("Sex", Convert.ToInt32(_Sex))
            res.AppendParameter("PersonalNumber", _SocialNum)

            Dim ret As String = Classes.Communication.SendAndWait(res.InnerXML).GetElementsByTagName("Response")(0).Attributes("Response").Value
            Return CType(ret, UserSaveResponse)

        End Function

    End Class

End Namespace



