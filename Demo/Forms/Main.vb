Imports System.Xml
Imports System.Environment
Imports Smartlaunch.TCPInterface

Namespace Forms

    Public Class Main
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            Application.EnableVisualStyles()
            Application.DoEvents()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
        Friend WithEvents btnGetNews As System.Windows.Forms.Button
        Friend WithEvents txtOutput As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnClear As System.Windows.Forms.Button
        Friend WithEvents btnGetUserInfo As System.Windows.Forms.Button
        Friend WithEvents btnLoginUser As System.Windows.Forms.Button
        Friend WithEvents btnWithdrawMoney As System.Windows.Forms.Button
        Friend WithEvents btnDepositMoney As System.Windows.Forms.Button
        Friend WithEvents btnGetPrice As System.Windows.Forms.Button
        Friend WithEvents btnTestConnection As System.Windows.Forms.Button
        Friend WithEvents btnAsk As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents btnCreateUser As System.Windows.Forms.Button
        Friend WithEvents btnUserLogout As System.Windows.Forms.Button
        Friend WithEvents btnUpdateUserInfo As System.Windows.Forms.Button
        Friend WithEvents btnSetPasswd As System.Windows.Forms.Button
        Friend WithEvents btnLostPwSendMail As System.Windows.Forms.Button
        Friend WithEvents btnAskAccDetails As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEmployeesGetAll As System.Windows.Forms.Button
        Friend WithEvents btnAddOffer As System.Windows.Forms.Button
        Friend WithEvents btnAddProduct As System.Windows.Forms.Button
        Friend WithEvents btnUserRemoveOffer As System.Windows.Forms.Button
        Friend WithEvents btnUserLogHistory As System.Windows.Forms.Button
        Friend WithEvents btnUserGroupGetAll As System.Windows.Forms.Button
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEventGet As System.Windows.Forms.Button
        Friend WithEvents btnUserGroupGet As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents btnCafeStatusGet As System.Windows.Forms.Button
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents btnApplicationGetMostPopular As System.Windows.Forms.Button
        Friend WithEvents Button4 As System.Windows.Forms.Button
        Friend WithEvents btnTurnOff As System.Windows.Forms.Button
        Friend WithEvents btnTurnOn As System.Windows.Forms.Button
        Friend WithEvents btnDeleteBooking As System.Windows.Forms.Button
        Friend WithEvents btnAddBooking As System.Windows.Forms.Button
        Friend WithEvents btnEditBooking As System.Windows.Forms.Button
        Friend WithEvents btnGetAllBooking As System.Windows.Forms.Button
        Friend WithEvents ContextMenu As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnAll As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnBookingID As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnUserAddSpecialTime As System.Windows.Forms.Button
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents btnGetFinancialData As System.Windows.Forms.Button
        Friend WithEvents btnGetAllOffers As System.Windows.Forms.Button
        Friend WithEvents btnGetAllUserGroup As System.Windows.Forms.Button
        Friend WithEvents btnGetAllUsers As System.Windows.Forms.Button
        Friend WithEvents ContextLogin As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnUserAddTime As System.Windows.Forms.Button
        Friend WithEvents mNoParameter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mUsing2Parameters As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AllBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FilterByBookingIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGetAllProduct As System.Windows.Forms.Button
        Friend WithEvents GetAllProductGroups As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GetAllProduct As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnProduct As System.Windows.Forms.Button
        Friend WithEvents GetAllTaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents UsingColumnNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesGetAllUseColumnNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesGetAllUsing2ParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label6 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.btnGetNews = New System.Windows.Forms.Button()
            Me.StatusBar = New System.Windows.Forms.StatusBar()
            Me.txtOutput = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnGetUserInfo = New System.Windows.Forms.Button()
            Me.btnLoginUser = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnGetAllProduct = New System.Windows.Forms.Button()
            Me.btnUserAddTime = New System.Windows.Forms.Button()
            Me.btnGetAllUsers = New System.Windows.Forms.Button()
            Me.btnGetAllUserGroup = New System.Windows.Forms.Button()
            Me.btnGetAllOffers = New System.Windows.Forms.Button()
            Me.btnUserAddSpecialTime = New System.Windows.Forms.Button()
            Me.btnUserGroupGet = New System.Windows.Forms.Button()
            Me.btnUserGroupGetAll = New System.Windows.Forms.Button()
            Me.btnUserLogHistory = New System.Windows.Forms.Button()
            Me.btnUserRemoveOffer = New System.Windows.Forms.Button()
            Me.btnAddProduct = New System.Windows.Forms.Button()
            Me.btnAddOffer = New System.Windows.Forms.Button()
            Me.btnAskAccDetails = New System.Windows.Forms.Button()
            Me.btnLostPwSendMail = New System.Windows.Forms.Button()
            Me.btnSetPasswd = New System.Windows.Forms.Button()
            Me.btnUpdateUserInfo = New System.Windows.Forms.Button()
            Me.btnUserLogout = New System.Windows.Forms.Button()
            Me.btnCreateUser = New System.Windows.Forms.Button()
            Me.btnAsk = New System.Windows.Forms.Button()
            Me.btnGetPrice = New System.Windows.Forms.Button()
            Me.btnWithdrawMoney = New System.Windows.Forms.Button()
            Me.btnDepositMoney = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnCafeStatusGet = New System.Windows.Forms.Button()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnTestConnection = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnTurnOn = New System.Windows.Forms.Button()
            Me.btnTurnOff = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnGetAllBooking = New System.Windows.Forms.Button()
            Me.btnEditBooking = New System.Windows.Forms.Button()
            Me.btnDeleteBooking = New System.Windows.Forms.Button()
            Me.btnAddBooking = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.btnEmployeesGetAll = New System.Windows.Forms.Button()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.btnEventGet = New System.Windows.Forms.Button()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.btnApplicationGetMostPopular = New System.Windows.Forms.Button()
            Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mnAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnBookingID = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.btnGetFinancialData = New System.Windows.Forms.Button()
            Me.ContextLogin = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mNoParameter = New System.Windows.Forms.ToolStripMenuItem()
            Me.UsingColumnNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mUsing2Parameters = New System.Windows.Forms.ToolStripMenuItem()
            Me.AllBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FilterByBookingIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllProductGroups = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllProduct = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllTaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnProduct = New System.Windows.Forms.Button()
            Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.ContextMenu.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.ContextLogin.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnGetNews
            '
            Me.btnGetNews.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetNews.Location = New System.Drawing.Point(16, 123)
            Me.btnGetNews.Name = "btnGetNews"
            Me.btnGetNews.Size = New System.Drawing.Size(104, 24)
            Me.btnGetNews.TabIndex = 6
            Me.btnGetNews.Text = "Get All News"
            '
            'StatusBar
            '
            Me.StatusBar.Location = New System.Drawing.Point(0, 686)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Size = New System.Drawing.Size(856, 22)
            Me.StatusBar.TabIndex = 7
            '
            'txtOutput
            '
            Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOutput.Location = New System.Drawing.Point(8, 453)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtOutput.Size = New System.Drawing.Size(840, 225)
            Me.txtOutput.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(5, 434)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Messages:"
            '
            'btnGetUserInfo
            '
            Me.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetUserInfo.Location = New System.Drawing.Point(17, 82)
            Me.btnGetUserInfo.Name = "btnGetUserInfo"
            Me.btnGetUserInfo.Size = New System.Drawing.Size(104, 24)
            Me.btnGetUserInfo.TabIndex = 11
            Me.btnGetUserInfo.Text = "Get User Info"
            '
            'btnLoginUser
            '
            Me.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnLoginUser.Location = New System.Drawing.Point(17, 19)
            Me.btnLoginUser.Name = "btnLoginUser"
            Me.btnLoginUser.Size = New System.Drawing.Size(104, 26)
            Me.btnLoginUser.TabIndex = 12
            Me.btnLoginUser.Text = "Login User"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnGetAllProduct)
            Me.GroupBox1.Controls.Add(Me.btnUserAddTime)
            Me.GroupBox1.Controls.Add(Me.btnGetAllUsers)
            Me.GroupBox1.Controls.Add(Me.btnGetAllUserGroup)
            Me.GroupBox1.Controls.Add(Me.btnGetAllOffers)
            Me.GroupBox1.Controls.Add(Me.btnUserAddSpecialTime)
            Me.GroupBox1.Controls.Add(Me.btnUserGroupGet)
            Me.GroupBox1.Controls.Add(Me.btnUserGroupGetAll)
            Me.GroupBox1.Controls.Add(Me.btnUserLogHistory)
            Me.GroupBox1.Controls.Add(Me.btnUserRemoveOffer)
            Me.GroupBox1.Controls.Add(Me.btnAddProduct)
            Me.GroupBox1.Controls.Add(Me.btnAddOffer)
            Me.GroupBox1.Controls.Add(Me.btnAskAccDetails)
            Me.GroupBox1.Controls.Add(Me.btnLostPwSendMail)
            Me.GroupBox1.Controls.Add(Me.btnSetPasswd)
            Me.GroupBox1.Controls.Add(Me.btnUpdateUserInfo)
            Me.GroupBox1.Controls.Add(Me.btnUserLogout)
            Me.GroupBox1.Controls.Add(Me.btnCreateUser)
            Me.GroupBox1.Controls.Add(Me.btnAsk)
            Me.GroupBox1.Controls.Add(Me.btnGetPrice)
            Me.GroupBox1.Controls.Add(Me.btnWithdrawMoney)
            Me.GroupBox1.Controls.Add(Me.btnDepositMoney)
            Me.GroupBox1.Controls.Add(Me.btnGetUserInfo)
            Me.GroupBox1.Controls.Add(Me.btnLoginUser)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(148, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(696, 187)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "User handling"
            '
            'btnGetAllProduct
            '
            Me.btnGetAllProduct.Location = New System.Drawing.Point(536, 112)
            Me.btnGetAllProduct.Name = "btnGetAllProduct"
            Me.btnGetAllProduct.Size = New System.Drawing.Size(109, 26)
            Me.btnGetAllProduct.TabIndex = 47
            Me.btnGetAllProduct.Text = "GetAllProduct"
            Me.btnGetAllProduct.UseVisualStyleBackColor = True
            '
            'btnUserAddTime
            '
            Me.btnUserAddTime.Enabled = False
            Me.btnUserAddTime.Location = New System.Drawing.Point(536, 81)
            Me.btnUserAddTime.Name = "btnUserAddTime"
            Me.btnUserAddTime.Size = New System.Drawing.Size(109, 26)
            Me.btnUserAddTime.TabIndex = 46
            Me.btnUserAddTime.Text = "UserAddTime"
            Me.btnUserAddTime.UseVisualStyleBackColor = True
            '
            'btnGetAllUsers
            '
            Me.btnGetAllUsers.Enabled = False
            Me.btnGetAllUsers.Location = New System.Drawing.Point(536, 50)
            Me.btnGetAllUsers.Name = "btnGetAllUsers"
            Me.btnGetAllUsers.Size = New System.Drawing.Size(109, 26)
            Me.btnGetAllUsers.TabIndex = 45
            Me.btnGetAllUsers.Text = "GetAllUsers"
            Me.btnGetAllUsers.UseVisualStyleBackColor = True
            '
            'btnGetAllUserGroup
            '
            Me.btnGetAllUserGroup.Enabled = False
            Me.btnGetAllUserGroup.Location = New System.Drawing.Point(536, 19)
            Me.btnGetAllUserGroup.Name = "btnGetAllUserGroup"
            Me.btnGetAllUserGroup.Size = New System.Drawing.Size(109, 26)
            Me.btnGetAllUserGroup.TabIndex = 44
            Me.btnGetAllUserGroup.Text = "GetAllUserGroup"
            Me.btnGetAllUserGroup.UseVisualStyleBackColor = True
            '
            'btnGetAllOffers
            '
            Me.btnGetAllOffers.Enabled = False
            Me.btnGetAllOffers.Location = New System.Drawing.Point(421, 144)
            Me.btnGetAllOffers.Name = "btnGetAllOffers"
            Me.btnGetAllOffers.Size = New System.Drawing.Size(109, 26)
            Me.btnGetAllOffers.TabIndex = 43
            Me.btnGetAllOffers.Text = "GetAllOffers"
            Me.btnGetAllOffers.UseVisualStyleBackColor = True
            '
            'btnUserAddSpecialTime
            '
            Me.btnUserAddSpecialTime.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnUserAddSpecialTime.Location = New System.Drawing.Point(237, 81)
            Me.btnUserAddSpecialTime.Name = "btnUserAddSpecialTime"
            Me.btnUserAddSpecialTime.Size = New System.Drawing.Size(178, 26)
            Me.btnUserAddSpecialTime.TabIndex = 42
            Me.btnUserAddSpecialTime.Text = "User Add Special Time"
            '
            'btnUserGroupGet
            '
            Me.btnUserGroupGet.Enabled = False
            Me.btnUserGroupGet.Location = New System.Drawing.Point(421, 112)
            Me.btnUserGroupGet.Name = "btnUserGroupGet"
            Me.btnUserGroupGet.Size = New System.Drawing.Size(109, 26)
            Me.btnUserGroupGet.TabIndex = 41
            Me.btnUserGroupGet.Text = "UserGroupGet"
            Me.btnUserGroupGet.UseVisualStyleBackColor = True
            '
            'btnUserGroupGetAll
            '
            Me.btnUserGroupGetAll.Enabled = False
            Me.btnUserGroupGetAll.Location = New System.Drawing.Point(421, 81)
            Me.btnUserGroupGetAll.Name = "btnUserGroupGetAll"
            Me.btnUserGroupGetAll.Size = New System.Drawing.Size(109, 26)
            Me.btnUserGroupGetAll.TabIndex = 40
            Me.btnUserGroupGetAll.Text = "UserGroupGetAll"
            Me.btnUserGroupGetAll.UseVisualStyleBackColor = True
            '
            'btnUserLogHistory
            '
            Me.btnUserLogHistory.Enabled = False
            Me.btnUserLogHistory.Location = New System.Drawing.Point(421, 50)
            Me.btnUserLogHistory.Name = "btnUserLogHistory"
            Me.btnUserLogHistory.Size = New System.Drawing.Size(109, 26)
            Me.btnUserLogHistory.TabIndex = 39
            Me.btnUserLogHistory.Text = "UserLogHistory"
            Me.btnUserLogHistory.UseVisualStyleBackColor = True
            '
            'btnUserRemoveOffer
            '
            Me.btnUserRemoveOffer.Enabled = False
            Me.btnUserRemoveOffer.Location = New System.Drawing.Point(421, 19)
            Me.btnUserRemoveOffer.Name = "btnUserRemoveOffer"
            Me.btnUserRemoveOffer.Size = New System.Drawing.Size(109, 26)
            Me.btnUserRemoveOffer.TabIndex = 38
            Me.btnUserRemoveOffer.Text = "UserRemoveOffer"
            Me.btnUserRemoveOffer.UseVisualStyleBackColor = True
            '
            'btnAddProduct
            '
            Me.btnAddProduct.Enabled = False
            Me.btnAddProduct.Location = New System.Drawing.Point(237, 144)
            Me.btnAddProduct.Name = "btnAddProduct"
            Me.btnAddProduct.Size = New System.Drawing.Size(178, 26)
            Me.btnAddProduct.TabIndex = 37
            Me.btnAddProduct.Text = "User Add Product"
            Me.btnAddProduct.UseVisualStyleBackColor = True
            '
            'btnAddOffer
            '
            Me.btnAddOffer.Enabled = False
            Me.btnAddOffer.Location = New System.Drawing.Point(237, 112)
            Me.btnAddOffer.Name = "btnAddOffer"
            Me.btnAddOffer.Size = New System.Drawing.Size(178, 26)
            Me.btnAddOffer.TabIndex = 36
            Me.btnAddOffer.Text = "User Add Offer"
            Me.btnAddOffer.UseVisualStyleBackColor = True
            '
            'btnAskAccDetails
            '
            Me.btnAskAccDetails.Enabled = False
            Me.btnAskAccDetails.Location = New System.Drawing.Point(237, 19)
            Me.btnAskAccDetails.Name = "btnAskAccDetails"
            Me.btnAskAccDetails.Size = New System.Drawing.Size(178, 26)
            Me.btnAskAccDetails.TabIndex = 35
            Me.btnAskAccDetails.Text = "Ask Account Detail At Next Login"
            Me.btnAskAccDetails.UseVisualStyleBackColor = True
            '
            'btnLostPwSendMail
            '
            Me.btnLostPwSendMail.Enabled = False
            Me.btnLostPwSendMail.Location = New System.Drawing.Point(127, 112)
            Me.btnLostPwSendMail.Name = "btnLostPwSendMail"
            Me.btnLostPwSendMail.Size = New System.Drawing.Size(104, 26)
            Me.btnLostPwSendMail.TabIndex = 34
            Me.btnLostPwSendMail.Text = "LostPwSendMail"
            Me.btnLostPwSendMail.UseVisualStyleBackColor = True
            '
            'btnSetPasswd
            '
            Me.btnSetPasswd.Enabled = False
            Me.btnSetPasswd.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetPasswd.Location = New System.Drawing.Point(127, 81)
            Me.btnSetPasswd.Name = "btnSetPasswd"
            Me.btnSetPasswd.Size = New System.Drawing.Size(104, 26)
            Me.btnSetPasswd.TabIndex = 31
            Me.btnSetPasswd.Text = "Set Password"
            '
            'btnUpdateUserInfo
            '
            Me.btnUpdateUserInfo.Enabled = False
            Me.btnUpdateUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnUpdateUserInfo.Location = New System.Drawing.Point(127, 50)
            Me.btnUpdateUserInfo.Name = "btnUpdateUserInfo"
            Me.btnUpdateUserInfo.Size = New System.Drawing.Size(104, 26)
            Me.btnUpdateUserInfo.TabIndex = 30
            Me.btnUpdateUserInfo.Text = "UserSave"
            '
            'btnUserLogout
            '
            Me.btnUserLogout.Enabled = False
            Me.btnUserLogout.Location = New System.Drawing.Point(127, 144)
            Me.btnUserLogout.Name = "btnUserLogout"
            Me.btnUserLogout.Size = New System.Drawing.Size(104, 26)
            Me.btnUserLogout.TabIndex = 27
            Me.btnUserLogout.Text = "User Logout"
            Me.btnUserLogout.UseVisualStyleBackColor = True
            '
            'btnCreateUser
            '
            Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnCreateUser.Location = New System.Drawing.Point(17, 50)
            Me.btnCreateUser.Name = "btnCreateUser"
            Me.btnCreateUser.Size = New System.Drawing.Size(104, 26)
            Me.btnCreateUser.TabIndex = 24
            Me.btnCreateUser.Text = "Create user"
            '
            'btnAsk
            '
            Me.btnAsk.Enabled = False
            Me.btnAsk.Location = New System.Drawing.Point(237, 50)
            Me.btnAsk.Name = "btnAsk"
            Me.btnAsk.Size = New System.Drawing.Size(178, 26)
            Me.btnAsk.TabIndex = 20
            Me.btnAsk.Text = "Ask For Password At Next Login"
            Me.btnAsk.UseVisualStyleBackColor = True
            '
            'btnGetPrice
            '
            Me.btnGetPrice.Enabled = False
            Me.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetPrice.Location = New System.Drawing.Point(127, 19)
            Me.btnGetPrice.Name = "btnGetPrice"
            Me.btnGetPrice.Size = New System.Drawing.Size(104, 26)
            Me.btnGetPrice.TabIndex = 23
            Me.btnGetPrice.Text = "Get Price"
            '
            'btnWithdrawMoney
            '
            Me.btnWithdrawMoney.Enabled = False
            Me.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnWithdrawMoney.Location = New System.Drawing.Point(17, 144)
            Me.btnWithdrawMoney.Name = "btnWithdrawMoney"
            Me.btnWithdrawMoney.Size = New System.Drawing.Size(104, 26)
            Me.btnWithdrawMoney.TabIndex = 20
            Me.btnWithdrawMoney.Text = "Withdraw money"
            '
            'btnDepositMoney
            '
            Me.btnDepositMoney.Enabled = False
            Me.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDepositMoney.Location = New System.Drawing.Point(17, 112)
            Me.btnDepositMoney.Name = "btnDepositMoney"
            Me.btnDepositMoney.Size = New System.Drawing.Size(104, 26)
            Me.btnDepositMoney.TabIndex = 17
            Me.btnDepositMoney.Text = "Deposit money"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnCafeStatusGet)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.btnTestConnection)
            Me.GroupBox2.Controls.Add(Me.btnGetNews)
            Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(136, 187)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "General commands"
            '
            'btnCafeStatusGet
            '
            Me.btnCafeStatusGet.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnCafeStatusGet.Location = New System.Drawing.Point(16, 153)
            Me.btnCafeStatusGet.Name = "btnCafeStatusGet"
            Me.btnCafeStatusGet.Size = New System.Drawing.Size(104, 24)
            Me.btnCafeStatusGet.TabIndex = 13
            Me.btnCafeStatusGet.Text = "CafeStatusGet"
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(16, 64)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 56)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Modify connection details in the App.Config file."
            '
            'btnTestConnection
            '
            Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnTestConnection.Location = New System.Drawing.Point(16, 24)
            Me.btnTestConnection.Name = "btnTestConnection"
            Me.btnTestConnection.Size = New System.Drawing.Size(104, 24)
            Me.btnTestConnection.TabIndex = 11
            Me.btnTestConnection.Text = "Test Connection"
            '
            'btnClear
            '
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnClear.Location = New System.Drawing.Point(800, 423)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(48, 24)
            Me.btnClear.TabIndex = 19
            Me.btnClear.Text = "Clear"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btnTurnOn)
            Me.GroupBox3.Controls.Add(Me.btnTurnOff)
            Me.GroupBox3.Controls.Add(Me.Button1)
            Me.GroupBox3.Controls.Add(Me.Button2)
            Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox3.Location = New System.Drawing.Point(148, 211)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(134, 202)
            Me.GroupBox3.TabIndex = 20
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Computer commands"
            '
            'btnTurnOn
            '
            Me.btnTurnOn.Location = New System.Drawing.Point(23, 113)
            Me.btnTurnOn.Name = "btnTurnOn"
            Me.btnTurnOn.Size = New System.Drawing.Size(91, 23)
            Me.btnTurnOn.TabIndex = 25
            Me.btnTurnOn.Text = "Turn On Client"
            Me.btnTurnOn.UseVisualStyleBackColor = True
            '
            'btnTurnOff
            '
            Me.btnTurnOff.Location = New System.Drawing.Point(23, 84)
            Me.btnTurnOff.Name = "btnTurnOff"
            Me.btnTurnOff.Size = New System.Drawing.Size(91, 23)
            Me.btnTurnOff.TabIndex = 24
            Me.btnTurnOff.Text = "Turn Off Client"
            Me.btnTurnOff.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button1.Location = New System.Drawing.Point(16, 54)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(104, 24)
            Me.Button1.TabIndex = 18
            Me.Button1.Text = "Get Computer"
            '
            'Button2
            '
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button2.Location = New System.Drawing.Point(16, 24)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(104, 24)
            Me.Button2.TabIndex = 10
            Me.Button2.Text = "Get All Computers"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.btnGetAllBooking)
            Me.GroupBox4.Controls.Add(Me.btnEditBooking)
            Me.GroupBox4.Controls.Add(Me.btnDeleteBooking)
            Me.GroupBox4.Controls.Add(Me.btnAddBooking)
            Me.GroupBox4.Controls.Add(Me.Button4)
            Me.GroupBox4.Controls.Add(Me.btnEmployeesGetAll)
            Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox4.Location = New System.Drawing.Point(288, 211)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(275, 202)
            Me.GroupBox4.TabIndex = 21
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Employees commands"
            '
            'btnGetAllBooking
            '
            Me.btnGetAllBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllBooking.Location = New System.Drawing.Point(15, 167)
            Me.btnGetAllBooking.Name = "btnGetAllBooking"
            Me.btnGetAllBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnGetAllBooking.TabIndex = 15
            Me.btnGetAllBooking.Text = "Get Booking"
            '
            'btnEditBooking
            '
            Me.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEditBooking.Location = New System.Drawing.Point(15, 107)
            Me.btnEditBooking.Name = "btnEditBooking"
            Me.btnEditBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnEditBooking.TabIndex = 14
            Me.btnEditBooking.Text = "Edit Booking"
            '
            'btnDeleteBooking
            '
            Me.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDeleteBooking.Location = New System.Drawing.Point(15, 137)
            Me.btnDeleteBooking.Name = "btnDeleteBooking"
            Me.btnDeleteBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnDeleteBooking.TabIndex = 13
            Me.btnDeleteBooking.Text = "Delete Booking"
            '
            'btnAddBooking
            '
            Me.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnAddBooking.Location = New System.Drawing.Point(15, 77)
            Me.btnAddBooking.Name = "btnAddBooking"
            Me.btnAddBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnAddBooking.TabIndex = 12
            Me.btnAddBooking.Text = "Add Booking"
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(15, 48)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(104, 23)
            Me.Button4.TabIndex = 11
            Me.Button4.Text = "Get User Bill"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'btnEmployeesGetAll
            '
            Me.btnEmployeesGetAll.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEmployeesGetAll.Location = New System.Drawing.Point(15, 18)
            Me.btnEmployeesGetAll.Name = "btnEmployeesGetAll"
            Me.btnEmployeesGetAll.Size = New System.Drawing.Size(104, 24)
            Me.btnEmployeesGetAll.TabIndex = 10
            Me.btnEmployeesGetAll.Text = "EmployeesGetAll"
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.Button3)
            Me.GroupBox5.Controls.Add(Me.btnEventGet)
            Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox5.Location = New System.Drawing.Point(8, 211)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(134, 97)
            Me.GroupBox5.TabIndex = 22
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Event Commands"
            '
            'Button3
            '
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button3.Location = New System.Drawing.Point(15, 49)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(104, 40)
            Me.Button3.TabIndex = 11
            Me.Button3.Text = "EventGet Based on ID"
            '
            'btnEventGet
            '
            Me.btnEventGet.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEventGet.Location = New System.Drawing.Point(15, 19)
            Me.btnEventGet.Name = "btnEventGet"
            Me.btnEventGet.Size = New System.Drawing.Size(104, 24)
            Me.btnEventGet.TabIndex = 10
            Me.btnEventGet.Text = "EventGetAll"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.btnApplicationGetMostPopular)
            Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox6.Location = New System.Drawing.Point(8, 314)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(134, 99)
            Me.GroupBox6.TabIndex = 23
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Application Commands"
            '
            'btnApplicationGetMostPopular
            '
            Me.btnApplicationGetMostPopular.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnApplicationGetMostPopular.Location = New System.Drawing.Point(15, 19)
            Me.btnApplicationGetMostPopular.Name = "btnApplicationGetMostPopular"
            Me.btnApplicationGetMostPopular.Size = New System.Drawing.Size(104, 55)
            Me.btnApplicationGetMostPopular.TabIndex = 10
            Me.btnApplicationGetMostPopular.Text = "ApplicationGetMostPopular"
            '
            'ContextMenu
            '
            Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAll, Me.mnBookingID})
            Me.ContextMenu.Name = "ContextMenuStrip1"
            Me.ContextMenu.Size = New System.Drawing.Size(178, 48)
            '
            'mnAll
            '
            Me.mnAll.Name = "mnAll"
            Me.mnAll.Size = New System.Drawing.Size(177, 22)
            Me.mnAll.Text = "All"
            '
            'mnBookingID
            '
            Me.mnBookingID.Name = "mnBookingID"
            Me.mnBookingID.Size = New System.Drawing.Size(177, 22)
            Me.mnBookingID.Text = "Filter by Booking ID"
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.btnGetFinancialData)
            Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox7.Location = New System.Drawing.Point(569, 211)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(275, 202)
            Me.GroupBox7.TabIndex = 24
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Administrator command"
            '
            'btnGetFinancialData
            '
            Me.btnGetFinancialData.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetFinancialData.Location = New System.Drawing.Point(15, 18)
            Me.btnGetFinancialData.Name = "btnGetFinancialData"
            Me.btnGetFinancialData.Size = New System.Drawing.Size(104, 24)
            Me.btnGetFinancialData.TabIndex = 10
            Me.btnGetFinancialData.Text = "Get Financial Data"
            '
            'ContextLogin
            '
            Me.ContextLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.mNoParameter, Me.UsingColumnNamesToolStripMenuItem, Me.mUsing2Parameters, Me.AllBookingToolStripMenuItem, Me.FilterByBookingIDToolStripMenuItem, Me.GetAllProductGroups, Me.GetAllProduct, Me.GetAllTaxToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.EmployeesGetAllUseColumnNamesToolStripMenuItem, Me.EmployeesGetAllUsing2ParametersToolStripMenuItem})
            Me.ContextLogin.Name = "ContextMenuStrip1"
            Me.ContextLogin.Size = New System.Drawing.Size(283, 312)
            '
            'UserToolStripMenuItem
            '
            Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
            Me.UserToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.UserToolStripMenuItem.Tag = "Login"
            Me.UserToolStripMenuItem.Text = "User"
            '
            'EmployeeToolStripMenuItem
            '
            Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
            Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.EmployeeToolStripMenuItem.Tag = "Login"
            Me.EmployeeToolStripMenuItem.Text = "Employee"
            '
            'mNoParameter
            '
            Me.mNoParameter.Name = "mNoParameter"
            Me.mNoParameter.Size = New System.Drawing.Size(271, 22)
            Me.mNoParameter.Tag = "GetAllUsers"
            Me.mNoParameter.Text = "No Parameter"
            '
            'UsingColumnNamesToolStripMenuItem
            '
            Me.UsingColumnNamesToolStripMenuItem.Name = "UsingColumnNamesToolStripMenuItem"
            Me.UsingColumnNamesToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.UsingColumnNamesToolStripMenuItem.Tag = "GetAllUsers"
            Me.UsingColumnNamesToolStripMenuItem.Text = "Using Column Names"
            '
            'mUsing2Parameters
            '
            Me.mUsing2Parameters.Name = "mUsing2Parameters"
            Me.mUsing2Parameters.Size = New System.Drawing.Size(271, 22)
            Me.mUsing2Parameters.Tag = "GetAllUsers"
            Me.mUsing2Parameters.Text = "Using 2 Parameters"
            '
            'AllBookingToolStripMenuItem
            '
            Me.AllBookingToolStripMenuItem.Name = "AllBookingToolStripMenuItem"
            Me.AllBookingToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.AllBookingToolStripMenuItem.Tag = "GetBooking"
            Me.AllBookingToolStripMenuItem.Text = "All Booking"
            '
            'FilterByBookingIDToolStripMenuItem
            '
            Me.FilterByBookingIDToolStripMenuItem.Name = "FilterByBookingIDToolStripMenuItem"
            Me.FilterByBookingIDToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.FilterByBookingIDToolStripMenuItem.Tag = "GetBooking"
            Me.FilterByBookingIDToolStripMenuItem.Text = "Filter by Booking ID"
            '
            'GetAllProductGroups
            '
            Me.GetAllProductGroups.Name = "GetAllProductGroups"
            Me.GetAllProductGroups.Size = New System.Drawing.Size(271, 22)
            Me.GetAllProductGroups.Tag = "GetAllProduct"
            Me.GetAllProductGroups.Text = "GetAllProductGroups"
            '
            'GetAllProduct
            '
            Me.GetAllProduct.Name = "GetAllProduct"
            Me.GetAllProduct.Size = New System.Drawing.Size(271, 22)
            Me.GetAllProduct.Tag = "GetAllProduct"
            Me.GetAllProduct.Text = "GetAllProducts"
            '
            'GetAllTaxToolStripMenuItem
            '
            Me.GetAllTaxToolStripMenuItem.Name = "GetAllTaxToolStripMenuItem"
            Me.GetAllTaxToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.GetAllTaxToolStripMenuItem.Tag = "GetAllProduct"
            Me.GetAllTaxToolStripMenuItem.Text = "GetAllTax"
            '
            'btnProduct
            '
            Me.btnProduct.Location = New System.Drawing.Point(536, 112)
            Me.btnProduct.Name = "btnProduct"
            Me.btnProduct.Size = New System.Drawing.Size(109, 26)
            Me.btnProduct.TabIndex = 47
            Me.btnProduct.Text = "GetAllProduct"
            Me.btnProduct.UseVisualStyleBackColor = True
            '
            'EmployeesToolStripMenuItem
            '
            Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
            Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.EmployeesToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesToolStripMenuItem.Text = "EmployeesGetAll No Parameter"
            '
            'EmployeesGetAllUseColumnNamesToolStripMenuItem
            '
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Name = "EmployeesGetAllUseColumnNamesToolStripMenuItem"
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Text = "EmployeesGetAll Using Column Names"
            '
            'EmployeesGetAllUsing2ParametersToolStripMenuItem
            '
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Name = "EmployeesGetAllUsing2ParametersToolStripMenuItem"
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Text = "EmployeesGetAll Using 2 Parameters"
            '
            'Main
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(856, 708)
            Me.Controls.Add(Me.GroupBox7)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox6)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtOutput)
            Me.Controls.Add(Me.StatusBar)
            Me.Controls.Add(Me.Label1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Main"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Smartlaunch WebInterface Tester"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.ContextMenu.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.ContextLogin.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub ShowContextMenu(ByVal StrVisibleTrue As String)
            With ContextLogin
                For Each x As ToolStripMenuItem In .Items
                    x.Visible = x.Tag.ToString.ToLower = StrVisibleTrue.ToLower
                Next
            End With
            ContextLogin.Show(MousePosition)
        End Sub

        Private ActiveUser As Smartlaunch.TCPInterface.Users.User
        Private ActiveComputer As Smartlaunch.TCPInterface.Computers.Computer = New Smartlaunch.TCPInterface.Computers.Computer
        Private objGeneral As New General
        
        Private Sub btnGetNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNews.Click

            Try

                txtOutput.Text &= NewLine & NewLine & "News: " & NewLine
                For Each N As Smartlaunch.TCPInterface.News.NewsItem In Smartlaunch.TCPInterface.News.Items
                    txtOutput.Text &= N.DateTimeAdded.ToLongDateString & "     " & N.Headline & NewLine
                Next

                'txtOutput.Text &= NewLine & "Events: " & NewLine
                'For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items
                '    txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
                'Next

            Catch ex As SmartlaunchWebInterfaceException
                txtOutput.Text &= NewLine & NewLine & "Error ocurred: " & ex.Message
            End Try

        End Sub

        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            txtOutput.Text = ""
        End Sub

        Private Sub btnGetComputers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
            Next
        End Sub

        Private Sub btnGetUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetUserInfo.Click

            Dim username As String = InputBox("Please enter username", "Username", "test2")

            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "User loaded." & NewLine

                txtOutput.Text &= NewLine & "A few user details:" & NewLine
                With ActiveUser
                    txtOutput.Text &= "Username: " & .UserName & NewLine
                    txtOutput.Text &= "Firstname: " & .FirstName & NewLine
                    txtOutput.Text &= "Lastname: " & .LastName & NewLine
                    txtOutput.Text &= "Group ID: " & .UserGroupID & NewLine
                    txtOutput.Text &= "Email: " & .Email & NewLine
                    txtOutput.Text &= "Age: " & .Age & NewLine
                    txtOutput.Text &= "Time Status: " & .TimeStatus & NewLine
                    txtOutput.Text &= "Balance: " & .Balance & NewLine
                    txtOutput.Text &= "Deposit Amount: " & .DepositAmount & NewLine
                    txtOutput.Text &= "Deposit Date: " & .DepositDate & NewLine
                End With
            End If

            SetEnabledState()

        End Sub

        Private Sub btnLoginUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginUser.Click
            ShowContextMenu("Login")

        End Sub

        Private Sub SetEnabledState()
            Dim Enabled As Boolean = (Not ActiveUser Is Nothing)
            btnDepositMoney.Enabled = Enabled
            btnWithdrawMoney.Enabled = Enabled
            btnGetPrice.Enabled = Enabled
            btnUpdateUserInfo.Enabled = Enabled
            btnUserLogout.Enabled = Enabled
            btnAsk.Enabled = Enabled
            btnLostPwSendMail.Enabled = Enabled
            btnSetPasswd.Enabled = Enabled
            btnAddOffer.Enabled = Enabled
            btnAddProduct.Enabled = Enabled
            btnUserRemoveOffer.Enabled = Enabled
            btnUserLogHistory.Enabled = Enabled
            btnAskAccDetails.Enabled = Enabled
            btnUserGroupGetAll.Enabled = Enabled
            btnUserGroupGet.Enabled = Enabled
            btnUserAddSpecialTime.Enabled = Enabled
            btnGetAllOffers.Enabled = Enabled
            btnGetAllUserGroup.Enabled = Enabled
            btnGetAllUsers.Enabled = Enabled
            btnGetAllProduct.Enabled = Enabled
        End Sub

        Private Sub btnDepositMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositMoney.Click

            Dim amount As Double = InputBox("Please enter Amount (use 5 if you uncertain)", "Amount", 5)

            ActiveUser.DepositMoney(amount)

            txtOutput.Text &= NewLine & NewLine & "Money deposited." & NewLine
        End Sub

        Private Sub btnWithdrawMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdrawMoney.Click
            Dim amount As Double = InputBox("Please enter Amount (use 5 if you uncertain)", "Amount", 5)

            ActiveUser.WithdrawMoney(amount)

            txtOutput.Text &= NewLine & NewLine & "Money withdrawed." & NewLine
        End Sub

        Private Sub btnGetPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPrice.Click
            Dim minutes As Integer = InputBox("Please enter minutes (use 60 if you uncertain)", "Minutes", 60)

            Dim Price As Double = ActiveUser.GetPriceForTime(minutes)

            txtOutput.Text &= NewLine & NewLine & "Users price for " & minutes & " minutes is: " & FormatCurrency(Price) & NewLine
        End Sub

        Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConnection.Click
            Try
                If Smartlaunch.TCPInterface.Main.TestConnection() = True Then
                    txtOutput.Text &= NewLine & NewLine & "Connection test completed succesfully" & NewLine
                End If
            Catch ex As Exception
                txtOutput.Text &= NewLine & NewLine & "Could not connect. An error was returned:  " & ex.Message & NewLine
            End Try
        End Sub

        Private Sub btnAsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsk.Click

            'Dim username As String = InputBox("Please enter username", "Username", "test2")
            'Dim passwd As String = InputBox("Please enter password", "Password", "test")

            'ActiveUser = Smartlaunch.TCPInterface.Users.Login(username, passwd)

            If ActiveUser.SetAskPasswordAtNextLogin() Then
                txtOutput.Text &= NewLine & NewLine & "Ask password at next login." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Error@Ask password at next login." & NewLine
            End If



        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
            Next
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim pcNumber As String = InputBox("Please enter your PC number (use PC001 if you uncertain)", "ComputerID", "PC001")

            If pcNumber <> "" Then

                For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items

                    If pcNumber.ToUpper = C.Name.ToUpper Then
                        txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
                    End If
                Next

            Else
                MessageBox.Show("Please enter your PC number.")
            End If


        End Sub

        Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click

            Dim username As String = InputBox("Please enter username", "Username", "test2")
            Dim userGroup As String = InputBox("Please enter userGroup (use Members if you uncertain)", "userGroup", "Members")

            If userGroup <> "" Then
                ActiveUser = Smartlaunch.TCPInterface.Users.Create(username, userGroup)

                If ActiveUser Is Nothing Then
                    txtOutput.Text &= NewLine & NewLine & "Create user failed." & NewLine
                Else
                    txtOutput.Text &= NewLine & NewLine & "User created successfully." & NewLine
                End If
            Else
                MessageBox.Show("Please choose the UserGroup")
            End If



        End Sub

        Private Sub btnUserLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLogout.Click
            txtOutput.Text &= NewLine & NewLine & ActiveUser.LogoutUser.InnerXml
            'If ActiveUser.LogoutUser Then
            '    txtOutput.Text &= NewLine & NewLine & "User logout successfully." & NewLine
            'Else
            '    txtOutput.Text &= NewLine & NewLine & "User logout failed." & NewLine
            'End If

        End Sub

        Private Sub btnUpdateUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUserInfo.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")

            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                With ActiveUser

                    Dim FName As String = InputBox("Please enter first name", "First Name", .FirstName)
                    Dim LName As String = InputBox("Please enter last name", "Last  Name", .LastName)
                    Dim BirthDate As Integer = CInt(DateValue(InputBox("Please enter birth date", "Birth Date", .BirthDate) & " 00:00:00").ToOADate)
                    Dim Address As String = InputBox("Please enter address", "Address", .Address)
                    Dim City As String = InputBox("Please enter city", "City", .City)
                    Dim Zip As String = InputBox("Please enter zip", "Zip", .Zip)
                    Dim State As String = InputBox("Please enter State", "State", .State)
                    Dim Country As String = InputBox("Please enter email country", "Country", .Country)
                    Dim email As String = InputBox("Please enter email address", "Email Address", .Email)
                    Dim Phone As String = InputBox("Please enter phone", "Phone", .Phone)
                    Dim PhoneMobile As String = InputBox("Please enter mobile phone", "Mobile Phone", .PhoneMobile)
                    Dim Sex As String = InputBox("Please enter email sex", "Sex", .Sex)
                    Dim SocialNum As String = InputBox("Please enter personal number", "Personal Number", .SocialNum)

                    Dim XML As XmlDocument
                    XML = ActiveUser.UpdateUserInfo(FName, LName, BirthDate, Address, City, Zip, State, Country, email, _
                                                 Phone, PhoneMobile, SocialNum, Sex)
                    txtOutput.Text &= NewLine & NewLine & XML.InnerXml
                    'If ActiveUser.UpdateUserInfo(FName, LName, BirthDate, Address, City, Zip, State, Country, email, _
                    '                             Phone, PhoneMobile, SocialNum, Sex) Then
                    '    txtOutput.Text &= NewLine & NewLine & "User Info updated successfully." & NewLine
                    'Else
                    '    txtOutput.Text &= NewLine & NewLine & "Failed to update User Info." & NewLine
                    'End If
                End With

            End If

        End Sub

        Private Sub btnSetPasswd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPasswd.Click

            Dim passwd As String = InputBox("Please enter new passwd.", "Password", "test")

            Dim XML As XmlDocument
            XML = ActiveUser.UserSetNewPassword(passwd)
            txtOutput.Text &= NewLine & NewLine & XML.InnerXml
            'If ActiveUser.UserSetNewPassword(passwd) Then
            '    txtOutput.Text &= NewLine & NewLine & "New password set successfully." & NewLine
            'Else
            '    txtOutput.Text &= NewLine & NewLine & "Failed to set new password." & NewLine
            'End If

        End Sub

        Private Sub btnLostPwSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLostPwSendMail.Click
            Dim XML As XmlDocument
            XML = ActiveUser.LostPasswdEmail()
            txtOutput.Text &= NewLine & NewLine & XML.InnerXml
            'If ActiveUser.LostPasswdEmail() Then
            '    txtOutput.Text &= NewLine & NewLine & "Lost password email sent successfully." & NewLine
            'Else
            '    txtOutput.Text &= NewLine & NewLine & "Failed to sent lost password email." & NewLine
            'End If

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAskAccDetails.Click

            If ActiveUser.SetAskPasswordAtNextLogin() Then
                txtOutput.Text &= NewLine & NewLine & "Ask account detail at next login." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Error@Ask account detail at next login." & NewLine
            End If

        End Sub

        Private Sub btnEmployeesGetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeesGetAll.Click
            ShowContextMenu("EmployeesGetAll")
        End Sub

        Private Sub btnAddOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOffer.Click

            'This is just an example. Only for testing!!!
            Try
                Dim OfferID As Integer = InputBox("Please enter the OfferID (use 1 if you are uncertain)", "OfferID", 1)
                Dim Price As Double = InputBox("Please enter the Price (use 1 if you are uncertain)", "Price", 1)
                Dim PaymentType As String = InputBox("Please enter the PaymentType (use Cash if you are uncertain)", "PaymentType", "1")

                Dim FixedStart As Boolean = True
                Dim TheDate As Date = Date.Today
                Dim TaxPayable As Boolean = False

                ActiveUser.UserAddOffer(OfferID, Price, PaymentType, FixedStart, TheDate, TaxPayable)

                txtOutput.Text &= NewLine & NewLine & "Added offer successfully." & NewLine
            Catch ex As Exception

            End Try


        End Sub

        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProduct.Click

            'This is just an example. Only for testing!!!
            Dim ProductID As Integer = InputBox("Please enter the product ID (use 1 if you are uncertain)", "Product ID", 1)
            Dim Quantity As Integer = InputBox("Select quantity to add", "Quantity", "1")
            Dim TotalPrice As Double = InputBox("Select TotalPrice to add", "TotalPrice", 0)
            Dim PaymentType As String = InputBox("Select PaymentType to add", "PaymentType", "1")
            Dim TaxPayable As Boolean = False
            Dim Note As String = InputBox("Select Note to add", "Note", "Testing")

            ActiveUser.UserAddProduct(ProductID, Quantity, TotalPrice, PaymentType, TaxPayable, Note)

            txtOutput.Text &= NewLine & NewLine & "Added product successfully." & NewLine

        End Sub

        Private Sub btnUserRemoveOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserRemoveOffer.Click

            'This is just an example. Only for testing!!!
            Dim OfferStatID As Integer = InputBox("Please enter your OfferStatID (use 1 if you uncertain)", "OfferStatID", 1)

            ActiveUser.UserRemoveOffer(OfferStatID)

            txtOutput.Text &= NewLine & NewLine & "Removed offer successfully." & NewLine

        End Sub

        Private Sub btnUserLogHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLogHistory.Click

            'This is just an example. Only for testing!!!
            Dim TheDate As Date = Date.Today

            ActiveUser.UserLogHistory(TheDate)

            txtOutput.Text &= NewLine & NewLine & "successfully." & NewLine

        End Sub

        Private Sub btnUserGroupGetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserGroupGetAll.Click

            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.UserGroupGetAll()

            txtOutput.Text = xmlDoc.InnerXml

        End Sub

        Private Sub btnEventGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventGet.Click
            'Dim EventID As Integer = InputBox("Please enter event ID (use 1 if you uncertain)", "event ID", 1)

            txtOutput.Text &= NewLine & "Events: " & NewLine
            For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items
                txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
            Next

        End Sub

        Private Sub btnUserGroupGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserGroupGet.Click

            Dim UsergroupID As Integer = InputBox("Please enter UsergroupID (use 1 if you uncertain)", "UsergroupID", 1)

            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.UserGroupGet(UsergroupID)

            txtOutput.Text = xmlDoc.InnerXml
        End Sub

        Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Dim EventID As Integer = InputBox("Please enter EventID (use 1 if you uncertain)", "EventID", 1)

            For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items

                If EventID = Ev.EventID Then
                    txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
                End If


            Next

        End Sub

        'Private Sub btnCafeStatusGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCafeStatusGet.Click

        '    Dim employeeType As String = InputBox("Please enter Employee Type", "Employee Type", "Employee")

        '    Dim objGeneral As New General

        '    Dim xmlDoc As New XmlDocument
        '    'xmlDoc = objGeneral.GetAllEmployees(employeeType)

        '    txtOutput.Text = xmlDoc.InnerXml

        'End Sub

        Private Sub btnApplicationGetMostPopular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplicationGetMostPopular.Click

            Dim catName As String = InputBox("Please enter the Category Name (use Games if you uncertain)", "Category Name", "Games")
            Dim WithinDays As Integer = InputBox("Please enter the within days (use 1 if you unsure)", "WithinDays", 1)

            Dim objGen As New General

            Dim xmlDoc As New XmlDocument
            xmlDoc = objGen.ApplicationGetMostPopular(catName, WithinDays)

            txtOutput.Text = xmlDoc.InnerXml

        End Sub

        Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            SetEnabledState()
        End Sub

        Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Dim xmlDoc As New XmlDocument

            'GetUserLogHistory
            'xmlDoc = ActiveUser.GetUserLogHistory()

            '"UserGetBill"
            xmlDoc = ActiveUser.UserGetBill()

            txtOutput.Text = xmlDoc.InnerXml

        End Sub

        Private Sub btnTurnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurnOff.Click
            Dim ClientID As String = InputBox("Please enter Client ID", "Client ID", 1)

            ActiveComputer.ClientTurnOff(ClientID)

            txtOutput.Text &= NewLine & NewLine & "Client ID : """ & ClientID & " (Turn Off)." & NewLine

        End Sub

        Private Sub btnTurnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurnOn.Click
            Dim ClientID As String = InputBox("Please enter Client ID", "Client ID", 1)

            ActiveComputer.ClientTurnOff(ClientID)

            txtOutput.Text &= NewLine & NewLine & "Client ID : """ & ClientID & " (Turn On)." & NewLine
        End Sub

        Private Sub btnAddBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBooking.Click
            Dim CustomerName As String = InputBox("Please enter Customer Name", "Customer Name", "name")
            Dim CustomerPhone As String = InputBox("Please enter Customer Phone", "Customer Phone", "09763654")
            Dim Description As String = InputBox("Please enter Description", "Description", "description")
            Dim StartDate As String = InputBox("Please enter Start Date (MM/DD/YYYY hh:mm)", "Start Date", "MM/DD/YYYY hh:mm").Replace(" ", "/").Replace(":", "/")
            Dim EndDate As String = InputBox("Please enter End Date (MM/DD/YYYY hh:mm)", "End Date", "MM/DD/YYYY hh:mm").Replace(" ", "/").Replace(":", "/")
            Dim ComputerCount As String = InputBox("Please enter Count", "Count", 1)
            Dim SmokingArea As String = IIf(MsgBox("Are you want in Smoking Area?", vbYesNo, "Client ID") = vbYes, "1", "0")
            'Dim StartDate As Date = DateValue(_StartDate).Date.AddHours(_StartDate.Substring(11, 2)).AddMinutes(_StartDate.Substring(14, 2))
            'Dim StartDate As Date = DateValue(_StartDate).Date.AddHours(_StartDate.Substring(11, 2)).AddMinutes(_StartDate.Substring(14, 2))
            'Dim EndDate As Date = DateValue(_EndDate).Date.AddHours(_EndDate.Substring(11, 2)).AddMinutes(_EndDate.Substring(14, 2))
            Dim XmlDoc As New XmlDocument
            'Dim x As Date = DateForma
            'StartDate.GetHashCode()
            'MsgBox(StartDate)
            XmlDoc = ActiveUser.AddBooking(CustomerName, CustomerPhone, Description, StartDate, EndDate, ComputerCount, SmokingArea)
            txtOutput.Text &= NewLine & NewLine & XmlDoc.InnerXml
        End Sub

        Private Sub btnDeleteBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBooking.Click
            Dim BookingID As Integer = CInt(InputBox("Please enter Booking ID", "Booking ID", "12345"))
            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.DeleteBooking(BookingID)
            txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml
        End Sub

        Private Sub btnEditBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditBooking.Click
            Dim BookingID As Integer = CInt(InputBox("Please enter Booking ID", "Booking ID", "12345"))

            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.GetBookingByBookingID(BookingID)
            If xmlDoc.InnerXml.IndexOf("Response=""1""") > 0 Then
                ActiveUser.DeleteBooking(BookingID)
                Dim CustomerName As String = InputBox("Please enter Customer Name", "Customer Name", "name")
                Dim CustomerPhone As String = InputBox("Please enter Customer Phone", "Customer Phone", "09763654")
                Dim Description As String = InputBox("Please enter Description", "Description", "description")
                Dim StartDate As String = InputBox("Please enter Start Date (MM/DD/YYYY hh:mm)", "Start Date", "MM/DD/YYYY hh:mm").Replace(" ", "/").Replace(":", "/")
                Dim EndDate As String = InputBox("Please enter End Date (MM/DD/YYYY hh:mm)", "End Date", "MM/DD/YYYY hh:mm").Replace(" ", "/").Replace(":", "/")
                Dim ComputerCount As String = "1"
                Dim SmokingArea As String = IIf(MsgBox("Are you want in Smoking Area?", vbYesNo, "Client ID") = vbYes, "1", "0")
                xmlDoc = ActiveUser.AddBooking(BookingID, CustomerName, CustomerPhone, Description, StartDate, EndDate, ComputerCount, SmokingArea)
                txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml
            Else
                txtOutput.Text &= NewLine & NewLine & "Booking ID : " & BookingID & " (Doesn't exsist)"
            End If

        End Sub

        Private Sub btnGetAllBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllBooking.Click
            ShowContextMenu("GetBooking")
        End Sub

        Private Sub btnUserAddSpecialTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAddSpecialTime.Click
            Dim Username As String = InputBox("Please enter Username (User)", "Username (User)", "user")
            Dim Minutes As Integer = InputBox("Please enter Minutes", "Minutes", "60")
            Dim TotalPrice As String = InputBox("Please enter Total Price", "Total Price", "123")
            Dim TaxIncluded As Boolean = IIf(MsgBox("Tax Included?", vbYesNo, "Username (User)") = vbYes, True, False)
            Dim AdministratorID As Integer = InputBox("Please enter Administrator ID", "Administrator ID", "12345")

            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.UserAddSpecialTime(Username, Minutes, TotalPrice, TaxIncluded, AdministratorID)
            txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml
        End Sub

        Private Sub btnGetAllOffers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllOffers.Click
            txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllOffers.InnerXml & NewLine
        End Sub

        Private Sub btnGetAllUserGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllUserGroup.Click
            txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllUsergroup.InnerXml & NewLine
        End Sub

        Private Sub btnGetAllUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllUsers.Click
            ShowContextMenu("GetAllUsers")
        End Sub

        Private Sub btnUserAddTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAddTime.Click

        End Sub

        Private Sub ContextLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextLogin.ItemClicked
            'Dim StartID As String = InputBox("Please enter Start ID", "Start ID", "1")
            'Dim EndID As String = InputBox("Please enter Count", "Count", "10")
            'txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllUsers(StartID, EndID).InnerXml & NewLine
            Dim item As ToolStripItemClickedEventArgs = CType(e, ToolStripItemClickedEventArgs)

            Select Case item.ClickedItem.ToString
                Case "User"
                    Dim username As String = InputBox("Please enter username", "Username", "test2")
                    Dim passwd As String = InputBox("Please enter password", "Password", "test")
                    Dim Response As Int32 = Smartlaunch.TCPInterface.Users.Login(username, passwd)

                    Select Case Response
                        Case 1
                            ActiveUser = New Smartlaunch.TCPInterface.Users.User
                            ActiveUser = Smartlaunch.TCPInterface.Users.GetUserLogin(username, passwd)
                            txtOutput.Text &= NewLine & NewLine & "Login info correct... User loaded succesfully." & NewLine
                        Case 0
                            txtOutput.Text &= NewLine & NewLine & "Password was incorrect." & NewLine
                        Case Else
                            txtOutput.Text &= NewLine & NewLine & "Username or password was incorrect." & NewLine
                    End Select
                    SetEnabledState()

                Case "Employee"
                    Dim username As String = InputBox("Please enter username", "Username", "Admin")
                    Dim passwd As String = InputBox("Please enter password", "Password", "admin")

                    Dim xmlRes As XmlDocument = Smartlaunch.TCPInterface.Users.EmployeeLogin(username, passwd)
                    txtOutput.Text &= NewLine & NewLine & xmlRes.InnerXml & NewLine

                    If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                        MsgBox("Login Success" & vbCrLf & "Username : " & username & vbCrLf & "ID : " & xmlRes.DocumentElement.GetElementsByTagName("Object")(0).Attributes("ID").Value, MsgBoxStyle.Exclamation, "Warning")
                    Else
                        MsgBox("Username Or/And Password was incorrect", MsgBoxStyle.Exclamation, "Warning")
                    End If

                Case "All Booking"
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = ActiveUser.GetAllBooking()
                    txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml

                Case "Filter by Booking ID"
                    Dim BookingID As Integer = CInt(InputBox("Please enter Booking ID", "Booking ID", "12345"))
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = ActiveUser.GetBookingByBookingID(BookingID)
                    txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml

                Case "Using Column Names"
                    Dim ColumnName As String = InputBox("Please enter Column Name", "Columns", "Col1,Col2,Col3")
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllUsers(ColumnName) & NewLine

                Case "No Parameter"
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllUsers() & NewLine

                Case "Using 2 Parameters"
                    Dim IDStart As String = InputBox("Please enter Start ID", "Start ID", "123")
                    Dim TopCount As String = InputBox("Please enter Count", "Count", "10")
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllUsers(IDStart, TopCount) & NewLine

                Case "GetAllProductGroups"
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllProductGroups() & NewLine

                Case "GetAllProducts"
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllProducts() & NewLine

                Case "GetAllTax"
                    txtOutput.Text &= NewLine & NewLine & ActiveUser.GetAllTax() & NewLine

                Case "EmployeesGetAll No Parameter"
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = objGeneral.GetAllEmployees()
                    txtOutput.Text = xmlDoc.InnerXml

                Case "EmployeesGetAll Using Column Names"
                    Dim ColumnName As String = InputBox("Please enter Column Name", "Columns", "Col1,Col2,Col3")
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = objGeneral.GetAllEmployees(ColumnName)
                    txtOutput.Text = xmlDoc.InnerXml

                Case "EmployeesGetAll Using 2 Parameters"
                    Dim IDStart As String = InputBox("Please enter ID Start", "ID Start", "username")
                    Dim TopCount As String = InputBox("Please enter Count", "Count", "10")
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = objGeneral.GetAllEmployees(IDStart, TopCount)
                    txtOutput.Text = xmlDoc.InnerXml

                Case Else
                    MsgBox(item.ClickedItem.ToString)
            End Select
        End Sub

        Private Sub btnGetUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Dim ID As String = InputBox("Please enter ID", "ID", "0")
            Dim Username As String = InputBox("Please enter Username", "Username", "test")
            'Dim Firstname As String = InputBox("Please enter Firstname", "Firstname", "xxx")
            'Dim Lastname As String = InputBox("Please enter Lastname", "Lastname", "xxx")
            'Dim UsergroupID As String = InputBox("Please enter Group ID", "Group ID", "group")
            'Dim Email As String = InputBox("Please enter Email", "Email", "email@email.com")
            'Dim LastLogin As String = InputBox("Please enter LastLogin", "LastLogin", "12")
            'Dim Password As String = InputBox("Please enter Password", "Password", "password")
            'Dim Birthday As String = InputBox("Please enter Birthday", "Birthday", "12/31/1999")

            ActiveUser = New Smartlaunch.TCPInterface.Users.User(Username)

            'GetUser(ID,Username,PasswordHash,UsergroupID,LastLogin,InfoFirstname,InfoLastname,InfoBirthday)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "User loaded." & NewLine

                txtOutput.Text &= NewLine & "A few user details:" & NewLine
                With ActiveUser
                    txtOutput.Text &= "Username: " & .UserName & NewLine
                    txtOutput.Text &= "Firstname: " & .FirstName & NewLine
                    txtOutput.Text &= "Lastname: " & .LastName & NewLine
                    txtOutput.Text &= "Group ID: " & .UserGroupID & NewLine
                    txtOutput.Text &= "Email: " & .Email & NewLine
                    txtOutput.Text &= "Age: " & .Age & NewLine
                    txtOutput.Text &= "Time Status: " & .TimeStatus & NewLine
                    txtOutput.Text &= "Balance: " & .Balance & NewLine
                    txtOutput.Text &= "Deposit Amount: " & .DepositAmount & NewLine
                    txtOutput.Text &= "Deposit Date: " & .DepositDate & NewLine
                End With
            End If
        End Sub

        Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllProduct.Click, btnProduct.Click
            ShowContextMenu("GetAllProduct")
        End Sub
    End Class

End Namespace
