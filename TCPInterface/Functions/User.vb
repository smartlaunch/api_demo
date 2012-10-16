Imports System.Xml
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
            xmlCmd.AppendParameter("PasswordHash", Password)

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
        Private _StartDate As Date
        Private _EndDate As Date
        Private _Description As String
        Private _ComputerCount As Integer


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

        Public Property StartDate() As Date
            Get
                Return _StartDate
            End Get
            Set(ByVal value As Date)
                _StartDate = value
            End Set
        End Property

        Public Property EndDate() As Date
            Get
                Return _EndDate
            End Get
            Set(ByVal value As Date)
                _EndDate = value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)
                _Description = value
            End Set
        End Property

        Public Property ComputerCount() As Integer
            Get
                Return _ComputerCount
            End Get
            Set(ByVal value As Integer)
                _ComputerCount = value
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
                    '_BirthDate = Convert.ToDateTime(.Attributes("Birthday").Value)
                    'Dim BirthDate As Date
                    _BirthDate = Date.FromOADate(CDbl(.Attributes("Birthday").Value))
                    _Age = CInt(DateDiff(DateInterval.Year, _BirthDate, Now))
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

        Public Function SetAskPasswordAtNextLogin() As Boolean
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserAskForPasswordAtNextLogin")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If


        End Function

        Public Function SetAskAccountDeatilAtNextLogin() As Boolean
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserAskForAccountDetailsAtNextLogin")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If

        End Function

        
        Public Function UpdateUserInfo(ByVal FirstName As String, ByVal LastName As String, ByVal BirthDate As Integer, ByVal Address As String, _
                                       ByVal City As String, ByVal Zip As String, ByVal State As String, ByVal Country As String, _
                                       ByVal Email As String, ByVal Phone As String, ByVal PhoneMobile As String, ByVal PersonalNumber As String, _
                                       ByVal Sex As String) As Boolean
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserSave")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Firstname", FirstName)
            Command.AppendParameter("Lastname", LastName)
            Command.AppendParameter("Birthday", BirthDate)
            Command.AppendParameter("Address", Address)
            Command.AppendParameter("City", City)
            Command.AppendParameter("Zip", Zip)
            Command.AppendParameter("Email", Email)
            Command.AppendParameter("State", State)
            Command.AppendParameter("Country", Country)
            Command.AppendParameter("Telephone", Phone)
            Command.AppendParameter("Sex", Sex)
            Command.AppendParameter("Mobilephone", PhoneMobile)
            Command.AppendParameter("Personalnumber", SocialNum)


            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function UserSetNewPassword(ByVal newPass As String) As Boolean
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserSetPassword")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Password", newPass)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function LostPasswdEmail() As Boolean
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("LostPwSendMail")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Email", Email)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function LogoutUser() As Boolean
            Dim xmlCmd As New Classes.XMLCommand
            xmlCmd.AppendCommand("UserLogout")
            xmlCmd.AppendParameterSection()
            xmlCmd.AppendParameter("Username", UserName)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(xmlCmd.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                Return True
            Else
                Return False
            End If

        End Function


        Public Sub UserAddOffer(ByVal OfferID As Integer, ByVal Price As Double, ByVal PaymentType As String, ByVal FixedStart As Boolean, ByVal theDate As Date, ByVal TaxPayable As Boolean)

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserAddOffer")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("OfferID", OfferID)
            Command.AppendParameter("Price", Price)
            Command.AppendParameter("PaymentType", PaymentType)
            Command.AppendParameter("FixedStart", FixedStart)
            Command.AppendParameter("Date", theDate)
            Command.AppendParameter("TaxPayable", TaxPayable)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)


        End Sub

        Public Sub UserAddProduct(ByVal ProductID As Integer, ByVal Quantity As Integer, ByVal TotalPrice As Double, ByVal PaymentType As String, ByVal TaxPayable As Boolean, ByVal Note As String)

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserAddOffer")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("ProductID", ProductID)
            Command.AppendParameter("Quantity", Quantity)
            Command.AppendParameter("TotalPrice", TotalPrice)
            Command.AppendParameter("PaymentType", PaymentType)
            Command.AppendParameter("TaxPayable", TaxPayable)
            Command.AppendParameter("Note", Note)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)


        End Sub

        Public Sub UserRemoveOffer(ByVal OfferStatID As Integer)

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserRemoveOffer")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("OfferStatID", OfferStatID)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)


        End Sub

        Public Sub UserLogHistory(ByVal theDate As Date)

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserLogHistory")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)
            Command.AppendParameter("Date", theDate)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)


        End Sub

        Public Sub GetEmployeeByType(ByVal empType As String)

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("EmployeesGetAll")

            Command.AppendParameterSection()
            Command.AppendParameter("EmployeeType", empType)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)


        End Sub

        Public Function UserGroupGetAll() As XmlDocument

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserGroupGetAll")

            Command.AppendParameterSection()

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes

        End Function

        Public Function UserGroupGet(ByVal UsergroupID As Integer) As XmlDocument

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserGroupGet")

            Command.AppendParameterSection()
            Command.AppendParameter("UsergroupID", UsergroupID)

            Classes.Communication.SendAndWait(Command.InnerXML)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes

        End Function

        Public Function UserGetBill() As XmlDocument

            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("UserGetBill")

            Command.AppendParameterSection()
            Command.AppendParameter("Username", _UserName)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes

        End Function

        Public Function AddBooking(ByVal BookingID As String, ByVal CustomerName As String, ByVal CustomerPhone As String, ByVal Description As String, ByVal StartDate As String, _
                                   ByVal EndDate As String, ByVal ComputerCount As Integer, ByVal SmokingArea As Integer) As XmlDocument
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("AddBooking")

            Command.AppendParameterSection()
            Command.AppendParameter("BookingID", BookingID)
            Command.AppendParameter("CustomerName", CustomerName)
            Command.AppendParameter("CustomerPhone", CustomerPhone)
            Command.AppendParameter("Description", Description)
            Command.AppendParameter("StartDate", StartDate)
            Command.AppendParameter("EndDate", EndDate)
            Command.AppendParameter("ComputerCount", ComputerCount)
            Command.AppendParameter("SmokingArea", SmokingArea)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes
        End Function

        Public Function AddBooking(ByVal CustomerName As String, ByVal CustomerPhone As String, ByVal Description As String, ByVal StartDate As String, _
                                   ByVal EndDate As String, ByVal ComputerCount As Integer, ByVal SmokingArea As Integer) As XmlDocument
            
            Dim xmlRes As Xml.XmlDocument
            xmlRes = AddBooking("", CustomerName, CustomerPhone, Description, StartDate, EndDate, ComputerCount, SmokingArea)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes
        End Function

        Public Function DeleteBooking(ByVal BookingID As Integer) As XmlDocument
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("DeleteBooking")

            Command.AppendParameterSection()
            Command.AppendParameter("BookingID", BookingID)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes
        End Function

        Public Function GetAllBooking() As XmlDocument
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("GetAllBooking")

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes
        End Function

        Public Function GetBookingByBookingID(ByVal BookingID As String) As XmlDocument
            Dim Command As New Classes.XMLCommand
            Command.AppendCommand("GetBookingByBookingID")

            Command.AppendParameterSection()
            Command.AppendParameter("BookingID", BookingID)

            Dim xmlRes As Xml.XmlDocument = Classes.Communication.SendAndWait(Command.InnerXML)
            Debug.WriteLine(xmlRes.InnerXml)

            Return xmlRes
        End Function

    End Class

End Namespace



