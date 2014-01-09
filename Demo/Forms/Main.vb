Imports System.Xml
Imports System.Environment
Imports System.Collections.Generic
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
        Friend WithEvents btnGetAllComputers As System.Windows.Forms.Button
        Friend WithEvents btnGetComputer As System.Windows.Forms.Button
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
        Friend WithEvents btnGetAllTax As System.Windows.Forms.Button
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
        Friend WithEvents btnGetAllOffers As System.Windows.Forms.Button
        Friend WithEvents btnGetAllUserGroup As System.Windows.Forms.Button
        Friend WithEvents btnGetAllUsers As System.Windows.Forms.Button
        Friend WithEvents ContextLogin As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
        Friend WithEvents btnGetAllComputerGroups As System.Windows.Forms.Button
        Friend WithEvents btnOpenAccount As System.Windows.Forms.Button
        Friend WithEvents btnLockAccount As System.Windows.Forms.Button
        Friend WithEvents btnLoginEmployee As System.Windows.Forms.Button
        Friend WithEvents btnGetLayoutGroup As System.Windows.Forms.Button
        Friend WithEvents btnGetComputerGroup As System.Windows.Forms.Button
        Friend WithEvents btnGetAllLayoutGroups As System.Windows.Forms.Button
        Friend WithEvents btnGetSmartlaunchVersion As System.Windows.Forms.Button
        Friend WithEvents btnGetAllFinancialTransactions As System.Windows.Forms.Button
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
            Me.btnOpenAccount = New System.Windows.Forms.Button()
            Me.btnUserAddTime = New System.Windows.Forms.Button()
            Me.btnGetAllUsers = New System.Windows.Forms.Button()
            Me.btnGetAllUserGroup = New System.Windows.Forms.Button()
            Me.btnLockAccount = New System.Windows.Forms.Button()
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
            Me.btnGetAllTax = New System.Windows.Forms.Button()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnTestConnection = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnGetAllLayoutGroups = New System.Windows.Forms.Button()
            Me.btnGetLayoutGroup = New System.Windows.Forms.Button()
            Me.btnGetComputerGroup = New System.Windows.Forms.Button()
            Me.btnGetAllComputerGroups = New System.Windows.Forms.Button()
            Me.btnTurnOn = New System.Windows.Forms.Button()
            Me.btnTurnOff = New System.Windows.Forms.Button()
            Me.btnGetComputer = New System.Windows.Forms.Button()
            Me.btnGetAllComputers = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnLoginEmployee = New System.Windows.Forms.Button()
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
            Me.btnGetAllFinancialTransactions = New System.Windows.Forms.Button()
            Me.btnGetSmartlaunchVersion = New System.Windows.Forms.Button()
            Me.ContextLogin = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mNoParameter = New System.Windows.Forms.ToolStripMenuItem()
            Me.UsingColumnNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mUsing2Parameters = New System.Windows.Forms.ToolStripMenuItem()
            Me.AllBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FilterByBookingIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllProductGroups = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllProduct = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllTaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnProduct = New System.Windows.Forms.Button()
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
            Me.btnGetNews.Location = New System.Drawing.Point(6, 111)
            Me.btnGetNews.Name = "btnGetNews"
            Me.btnGetNews.Size = New System.Drawing.Size(122, 24)
            Me.btnGetNews.TabIndex = 6
            Me.btnGetNews.Text = "2. GetAllNews"
            Me.btnGetNews.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            Me.txtOutput.Location = New System.Drawing.Point(8, 475)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtOutput.Size = New System.Drawing.Size(840, 203)
            Me.txtOutput.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(5, 453)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Messages:"
            '
            'btnGetUserInfo
            '
            Me.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetUserInfo.Location = New System.Drawing.Point(136, 138)
            Me.btnGetUserInfo.Name = "btnGetUserInfo"
            Me.btnGetUserInfo.Size = New System.Drawing.Size(122, 24)
            Me.btnGetUserInfo.TabIndex = 11
            Me.btnGetUserInfo.Text = "11. GetUserInfo"
            Me.btnGetUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetUserInfo.UseVisualStyleBackColor = True
            '
            'btnLoginUser
            '
            Me.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnLoginUser.Location = New System.Drawing.Point(8, 23)
            Me.btnLoginUser.Name = "btnLoginUser"
            Me.btnLoginUser.Size = New System.Drawing.Size(122, 24)
            Me.btnLoginUser.TabIndex = 12
            Me.btnLoginUser.Text = "1. LoginUser"
            Me.btnLoginUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLoginUser.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnGetAllProduct)
            Me.GroupBox1.Controls.Add(Me.btnOpenAccount)
            Me.GroupBox1.Controls.Add(Me.btnUserAddTime)
            Me.GroupBox1.Controls.Add(Me.btnLockAccount)
            Me.GroupBox1.Controls.Add(Me.btnGetAllOffers)
            Me.GroupBox1.Controls.Add(Me.btnUserAddSpecialTime)
            Me.GroupBox1.Controls.Add(Me.btnUserGroupGet)
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
            Me.GroupBox1.Size = New System.Drawing.Size(696, 211)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "User handling"
            '
            'btnGetAllProduct
            '
            Me.btnGetAllProduct.Location = New System.Drawing.Point(392, 53)
            Me.btnGetAllProduct.Name = "btnGetAllProduct"
            Me.btnGetAllProduct.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllProduct.TabIndex = 47
            Me.btnGetAllProduct.Text = "20. GetAllProduct"
            Me.btnGetAllProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetAllProduct.UseVisualStyleBackColor = True
            '
            'btnOpenAccount
            '
            Me.btnOpenAccount.Location = New System.Drawing.Point(8, 138)
            Me.btnOpenAccount.Name = "btnOpenAccount"
            Me.btnOpenAccount.Size = New System.Drawing.Size(122, 24)
            Me.btnOpenAccount.TabIndex = 49
            Me.btnOpenAccount.Text = "5. OpenUserAccount"
            Me.btnOpenAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOpenAccount.UseVisualStyleBackColor = True
            '
            'btnUserAddTime
            '
            Me.btnUserAddTime.Enabled = False
            Me.btnUserAddTime.Location = New System.Drawing.Point(392, 23)
            Me.btnUserAddTime.Name = "btnUserAddTime"
            Me.btnUserAddTime.Size = New System.Drawing.Size(122, 24)
            Me.btnUserAddTime.TabIndex = 46
            Me.btnUserAddTime.Text = "19. AddTime"
            Me.btnUserAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserAddTime.UseVisualStyleBackColor = True
            '
            'btnGetAllUsers
            '
            Me.btnGetAllUsers.Enabled = False
            Me.btnGetAllUsers.Location = New System.Drawing.Point(125, 106)
            Me.btnGetAllUsers.Name = "btnGetAllUsers"
            Me.btnGetAllUsers.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllUsers.TabIndex = 45
            Me.btnGetAllUsers.Text = "10. GetAllUsers"
            Me.btnGetAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetAllUsers.UseVisualStyleBackColor = True
            '
            'btnGetAllUserGroup
            '
            Me.btnGetAllUserGroup.Enabled = False
            Me.btnGetAllUserGroup.Location = New System.Drawing.Point(125, 79)
            Me.btnGetAllUserGroup.Name = "btnGetAllUserGroup"
            Me.btnGetAllUserGroup.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllUserGroup.TabIndex = 44
            Me.btnGetAllUserGroup.Text = "9. GetAllUserGroup"
            Me.btnGetAllUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetAllUserGroup.UseVisualStyleBackColor = True
            '
            'btnLockAccount
            '
            Me.btnLockAccount.Location = New System.Drawing.Point(8, 108)
            Me.btnLockAccount.Name = "btnLockAccount"
            Me.btnLockAccount.Size = New System.Drawing.Size(122, 24)
            Me.btnLockAccount.TabIndex = 48
            Me.btnLockAccount.Text = "4. LockUserAccount"
            Me.btnLockAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLockAccount.UseVisualStyleBackColor = True
            '
            'btnGetAllOffers
            '
            Me.btnGetAllOffers.Enabled = False
            Me.btnGetAllOffers.Location = New System.Drawing.Point(264, 138)
            Me.btnGetAllOffers.Name = "btnGetAllOffers"
            Me.btnGetAllOffers.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllOffers.TabIndex = 43
            Me.btnGetAllOffers.Text = "17. GetAllOffers"
            Me.btnGetAllOffers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetAllOffers.UseVisualStyleBackColor = True
            '
            'btnUserAddSpecialTime
            '
            Me.btnUserAddSpecialTime.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnUserAddSpecialTime.Location = New System.Drawing.Point(136, 168)
            Me.btnUserAddSpecialTime.Name = "btnUserAddSpecialTime"
            Me.btnUserAddSpecialTime.Size = New System.Drawing.Size(122, 24)
            Me.btnUserAddSpecialTime.TabIndex = 42
            Me.btnUserAddSpecialTime.Text = "12. AddSpecialTime"
            Me.btnUserAddSpecialTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserAddSpecialTime.UseVisualStyleBackColor = True
            '
            'btnUserGroupGet
            '
            Me.btnUserGroupGet.Enabled = False
            Me.btnUserGroupGet.Location = New System.Drawing.Point(392, 80)
            Me.btnUserGroupGet.Name = "btnUserGroupGet"
            Me.btnUserGroupGet.Size = New System.Drawing.Size(193, 24)
            Me.btnUserGroupGet.TabIndex = 41
            Me.btnUserGroupGet.Text = "21. GetUsergroupOfUser"
            Me.btnUserGroupGet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserGroupGet.UseVisualStyleBackColor = True
            '
            'btnUserGroupGetAll
            '
            Me.btnUserGroupGetAll.Enabled = False
            Me.btnUserGroupGetAll.Location = New System.Drawing.Point(125, 49)
            Me.btnUserGroupGetAll.Name = "btnUserGroupGetAll"
            Me.btnUserGroupGetAll.Size = New System.Drawing.Size(122, 24)
            Me.btnUserGroupGetAll.TabIndex = 40
            Me.btnUserGroupGetAll.Text = "8. GetAllUsergroup"
            Me.btnUserGroupGetAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserGroupGetAll.UseVisualStyleBackColor = True
            '
            'btnUserLogHistory
            '
            Me.btnUserLogHistory.Enabled = False
            Me.btnUserLogHistory.Location = New System.Drawing.Point(264, 108)
            Me.btnUserLogHistory.Name = "btnUserLogHistory"
            Me.btnUserLogHistory.Size = New System.Drawing.Size(122, 24)
            Me.btnUserLogHistory.TabIndex = 39
            Me.btnUserLogHistory.Text = "16. UserLogHistory"
            Me.btnUserLogHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserLogHistory.UseVisualStyleBackColor = True
            '
            'btnUserRemoveOffer
            '
            Me.btnUserRemoveOffer.Enabled = False
            Me.btnUserRemoveOffer.Location = New System.Drawing.Point(264, 50)
            Me.btnUserRemoveOffer.Name = "btnUserRemoveOffer"
            Me.btnUserRemoveOffer.Size = New System.Drawing.Size(122, 24)
            Me.btnUserRemoveOffer.TabIndex = 38
            Me.btnUserRemoveOffer.Text = "14. RemoveOffer"
            Me.btnUserRemoveOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserRemoveOffer.UseVisualStyleBackColor = True
            '
            'btnAddProduct
            '
            Me.btnAddProduct.Enabled = False
            Me.btnAddProduct.Location = New System.Drawing.Point(264, 78)
            Me.btnAddProduct.Name = "btnAddProduct"
            Me.btnAddProduct.Size = New System.Drawing.Size(122, 24)
            Me.btnAddProduct.TabIndex = 37
            Me.btnAddProduct.Text = "15. AddProduct"
            Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAddProduct.UseVisualStyleBackColor = True
            '
            'btnAddOffer
            '
            Me.btnAddOffer.Enabled = False
            Me.btnAddOffer.Location = New System.Drawing.Point(264, 23)
            Me.btnAddOffer.Name = "btnAddOffer"
            Me.btnAddOffer.Size = New System.Drawing.Size(122, 24)
            Me.btnAddOffer.TabIndex = 36
            Me.btnAddOffer.Text = "13. AddOffer"
            Me.btnAddOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAddOffer.UseVisualStyleBackColor = True
            '
            'btnAskAccDetails
            '
            Me.btnAskAccDetails.Enabled = False
            Me.btnAskAccDetails.Location = New System.Drawing.Point(392, 108)
            Me.btnAskAccDetails.Name = "btnAskAccDetails"
            Me.btnAskAccDetails.Size = New System.Drawing.Size(193, 24)
            Me.btnAskAccDetails.TabIndex = 35
            Me.btnAskAccDetails.Text = "22. AskAccountDetailAtNextLogin"
            Me.btnAskAccDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAskAccDetails.UseVisualStyleBackColor = True
            '
            'btnLostPwSendMail
            '
            Me.btnLostPwSendMail.Enabled = False
            Me.btnLostPwSendMail.Location = New System.Drawing.Point(136, 23)
            Me.btnLostPwSendMail.Name = "btnLostPwSendMail"
            Me.btnLostPwSendMail.Size = New System.Drawing.Size(122, 24)
            Me.btnLostPwSendMail.TabIndex = 34
            Me.btnLostPwSendMail.Text = "7. LostPwSendMail"
            Me.btnLostPwSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLostPwSendMail.UseVisualStyleBackColor = True
            '
            'btnSetPasswd
            '
            Me.btnSetPasswd.Enabled = False
            Me.btnSetPasswd.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetPasswd.Location = New System.Drawing.Point(8, 168)
            Me.btnSetPasswd.Name = "btnSetPasswd"
            Me.btnSetPasswd.Size = New System.Drawing.Size(122, 24)
            Me.btnSetPasswd.TabIndex = 31
            Me.btnSetPasswd.Text = "6. SetUserPassword"
            Me.btnSetPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSetPasswd.UseVisualStyleBackColor = True
            '
            'btnUpdateUserInfo
            '
            Me.btnUpdateUserInfo.Enabled = False
            Me.btnUpdateUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnUpdateUserInfo.Location = New System.Drawing.Point(136, 108)
            Me.btnUpdateUserInfo.Name = "btnUpdateUserInfo"
            Me.btnUpdateUserInfo.Size = New System.Drawing.Size(122, 24)
            Me.btnUpdateUserInfo.TabIndex = 30
            Me.btnUpdateUserInfo.Text = "10. SaveUser"
            Me.btnUpdateUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUpdateUserInfo.UseVisualStyleBackColor = True
            '
            'btnUserLogout
            '
            Me.btnUserLogout.Enabled = False
            Me.btnUserLogout.Location = New System.Drawing.Point(8, 50)
            Me.btnUserLogout.Name = "btnUserLogout"
            Me.btnUserLogout.Size = New System.Drawing.Size(122, 24)
            Me.btnUserLogout.TabIndex = 27
            Me.btnUserLogout.Text = "2. LogoutUser"
            Me.btnUserLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserLogout.UseVisualStyleBackColor = True
            '
            'btnCreateUser
            '
            Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnCreateUser.Location = New System.Drawing.Point(8, 80)
            Me.btnCreateUser.Name = "btnCreateUser"
            Me.btnCreateUser.Size = New System.Drawing.Size(122, 24)
            Me.btnCreateUser.TabIndex = 24
            Me.btnCreateUser.Text = "3. CreateUser"
            Me.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCreateUser.UseVisualStyleBackColor = True
            '
            'btnAsk
            '
            Me.btnAsk.Enabled = False
            Me.btnAsk.Location = New System.Drawing.Point(392, 138)
            Me.btnAsk.Name = "btnAsk"
            Me.btnAsk.Size = New System.Drawing.Size(193, 24)
            Me.btnAsk.TabIndex = 20
            Me.btnAsk.Text = "23. AskForPasswordAtNextLogin"
            Me.btnAsk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAsk.UseVisualStyleBackColor = True
            '
            'btnGetPrice
            '
            Me.btnGetPrice.Enabled = False
            Me.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetPrice.Location = New System.Drawing.Point(264, 168)
            Me.btnGetPrice.Name = "btnGetPrice"
            Me.btnGetPrice.Size = New System.Drawing.Size(122, 24)
            Me.btnGetPrice.TabIndex = 23
            Me.btnGetPrice.Text = "18. GetPrice"
            Me.btnGetPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetPrice.UseVisualStyleBackColor = True
            '
            'btnWithdrawMoney
            '
            Me.btnWithdrawMoney.Enabled = False
            Me.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnWithdrawMoney.Location = New System.Drawing.Point(136, 50)
            Me.btnWithdrawMoney.Name = "btnWithdrawMoney"
            Me.btnWithdrawMoney.Size = New System.Drawing.Size(122, 24)
            Me.btnWithdrawMoney.TabIndex = 20
            Me.btnWithdrawMoney.Text = "8. WithdrawMoney"
            Me.btnWithdrawMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnWithdrawMoney.UseVisualStyleBackColor = True
            '
            'btnDepositMoney
            '
            Me.btnDepositMoney.Enabled = False
            Me.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDepositMoney.Location = New System.Drawing.Point(136, 80)
            Me.btnDepositMoney.Name = "btnDepositMoney"
            Me.btnDepositMoney.Size = New System.Drawing.Size(122, 24)
            Me.btnDepositMoney.TabIndex = 17
            Me.btnDepositMoney.Text = "9. DepositMoney"
            Me.btnDepositMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDepositMoney.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnGetAllTax)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.btnTestConnection)
            Me.GroupBox2.Controls.Add(Me.btnGetNews)
            Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(136, 211)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "General commands"
            '
            'btnGetAllTax
            '
            Me.btnGetAllTax.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllTax.Location = New System.Drawing.Point(6, 141)
            Me.btnGetAllTax.Name = "btnGetAllTax"
            Me.btnGetAllTax.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllTax.TabIndex = 13
            Me.btnGetAllTax.Text = "3. GetAllTax"
            Me.btnGetAllTax.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.btnGetAllTax.Visible = False
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(6, 50)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 56)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Modify connection details in the App.Config file."
            '
            'btnTestConnection
            '
            Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnTestConnection.Location = New System.Drawing.Point(6, 23)
            Me.btnTestConnection.Name = "btnTestConnection"
            Me.btnTestConnection.Size = New System.Drawing.Size(122, 24)
            Me.btnTestConnection.TabIndex = 11
            Me.btnTestConnection.Text = "1. Test Connection"
            Me.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.TopLeft
            '
            'btnClear
            '
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnClear.Location = New System.Drawing.Point(800, 442)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(48, 24)
            Me.btnClear.TabIndex = 19
            Me.btnClear.Text = "Clear"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btnGetAllLayoutGroups)
            Me.GroupBox3.Controls.Add(Me.btnGetLayoutGroup)
            Me.GroupBox3.Controls.Add(Me.btnGetComputerGroup)
            Me.GroupBox3.Controls.Add(Me.btnGetAllComputerGroups)
            Me.GroupBox3.Controls.Add(Me.btnTurnOn)
            Me.GroupBox3.Controls.Add(Me.btnTurnOff)
            Me.GroupBox3.Controls.Add(Me.btnGetComputer)
            Me.GroupBox3.Controls.Add(Me.btnGetAllComputers)
            Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox3.Location = New System.Drawing.Point(148, 233)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(263, 202)
            Me.GroupBox3.TabIndex = 20
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Computer commands"
            '
            'btnGetAllLayoutGroups
            '
            Me.btnGetAllLayoutGroups.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllLayoutGroups.Location = New System.Drawing.Point(7, 106)
            Me.btnGetAllLayoutGroups.Name = "btnGetAllLayoutGroups"
            Me.btnGetAllLayoutGroups.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllLayoutGroups.TabIndex = 29
            Me.btnGetAllLayoutGroups.Text = "4. GetAllLayoutGroups"
            Me.btnGetAllLayoutGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGetLayoutGroup
            '
            Me.btnGetLayoutGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetLayoutGroup.Location = New System.Drawing.Point(135, 107)
            Me.btnGetLayoutGroup.Name = "btnGetLayoutGroup"
            Me.btnGetLayoutGroup.Size = New System.Drawing.Size(122, 24)
            Me.btnGetLayoutGroup.TabIndex = 28
            Me.btnGetLayoutGroup.Text = "8. GetLayoutGroup"
            Me.btnGetLayoutGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGetComputerGroup
            '
            Me.btnGetComputerGroup.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetComputerGroup.Location = New System.Drawing.Point(135, 49)
            Me.btnGetComputerGroup.Name = "btnGetComputerGroup"
            Me.btnGetComputerGroup.Size = New System.Drawing.Size(122, 24)
            Me.btnGetComputerGroup.TabIndex = 27
            Me.btnGetComputerGroup.Text = "6. GetCompGroup"
            Me.btnGetComputerGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGetAllComputerGroups
            '
            Me.btnGetAllComputerGroups.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllComputerGroups.Location = New System.Drawing.Point(8, 47)
            Me.btnGetAllComputerGroups.Name = "btnGetAllComputerGroups"
            Me.btnGetAllComputerGroups.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllComputerGroups.TabIndex = 26
            Me.btnGetAllComputerGroups.Text = "2. GetAllCompGroups"
            Me.btnGetAllComputerGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnTurnOn
            '
            Me.btnTurnOn.Location = New System.Drawing.Point(135, 77)
            Me.btnTurnOn.Name = "btnTurnOn"
            Me.btnTurnOn.Size = New System.Drawing.Size(122, 23)
            Me.btnTurnOn.TabIndex = 25
            Me.btnTurnOn.Text = "7. TurnOnClient"
            Me.btnTurnOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTurnOn.UseVisualStyleBackColor = True
            '
            'btnTurnOff
            '
            Me.btnTurnOff.Location = New System.Drawing.Point(8, 79)
            Me.btnTurnOff.Name = "btnTurnOff"
            Me.btnTurnOff.Size = New System.Drawing.Size(122, 23)
            Me.btnTurnOff.TabIndex = 24
            Me.btnTurnOff.Text = "3. TurnOffClient"
            Me.btnTurnOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTurnOff.UseVisualStyleBackColor = True
            '
            'btnGetComputer
            '
            Me.btnGetComputer.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetComputer.Location = New System.Drawing.Point(135, 19)
            Me.btnGetComputer.Name = "btnGetComputer"
            Me.btnGetComputer.Size = New System.Drawing.Size(122, 24)
            Me.btnGetComputer.TabIndex = 18
            Me.btnGetComputer.Text = "5. GetComputer"
            Me.btnGetComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGetAllComputers
            '
            Me.btnGetAllComputers.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllComputers.Location = New System.Drawing.Point(8, 18)
            Me.btnGetAllComputers.Name = "btnGetAllComputers"
            Me.btnGetAllComputers.Size = New System.Drawing.Size(122, 24)
            Me.btnGetAllComputers.TabIndex = 10
            Me.btnGetAllComputers.Text = "1. GetAllComputers"
            Me.btnGetAllComputers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.btnLoginEmployee)
            Me.GroupBox4.Controls.Add(Me.btnGetAllBooking)
            Me.GroupBox4.Controls.Add(Me.btnEditBooking)
            Me.GroupBox4.Controls.Add(Me.btnGetAllUsers)
            Me.GroupBox4.Controls.Add(Me.btnDeleteBooking)
            Me.GroupBox4.Controls.Add(Me.btnGetAllUserGroup)
            Me.GroupBox4.Controls.Add(Me.btnAddBooking)
            Me.GroupBox4.Controls.Add(Me.Button4)
            Me.GroupBox4.Controls.Add(Me.btnEmployeesGetAll)
            Me.GroupBox4.Controls.Add(Me.btnUserGroupGetAll)
            Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox4.Location = New System.Drawing.Point(417, 233)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(261, 202)
            Me.GroupBox4.TabIndex = 21
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Employees commands"
            '
            'btnLoginEmployee
            '
            Me.btnLoginEmployee.Location = New System.Drawing.Point(125, 18)
            Me.btnLoginEmployee.Name = "btnLoginEmployee"
            Me.btnLoginEmployee.Size = New System.Drawing.Size(104, 23)
            Me.btnLoginEmployee.TabIndex = 50
            Me.btnLoginEmployee.Text = "7. LoginEmployee"
            Me.btnLoginEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLoginEmployee.UseVisualStyleBackColor = True
            '
            'btnGetAllBooking
            '
            Me.btnGetAllBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllBooking.Location = New System.Drawing.Point(15, 165)
            Me.btnGetAllBooking.Name = "btnGetAllBooking"
            Me.btnGetAllBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnGetAllBooking.TabIndex = 15
            Me.btnGetAllBooking.Text = "6. GetBooking"
            Me.btnGetAllBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditBooking
            '
            Me.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEditBooking.Location = New System.Drawing.Point(15, 106)
            Me.btnEditBooking.Name = "btnEditBooking"
            Me.btnEditBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnEditBooking.TabIndex = 14
            Me.btnEditBooking.Text = "4. EditBooking"
            Me.btnEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnDeleteBooking
            '
            Me.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDeleteBooking.Location = New System.Drawing.Point(15, 135)
            Me.btnDeleteBooking.Name = "btnDeleteBooking"
            Me.btnDeleteBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnDeleteBooking.TabIndex = 13
            Me.btnDeleteBooking.Text = "5. DeleteBooking"
            Me.btnDeleteBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnAddBooking
            '
            Me.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnAddBooking.Location = New System.Drawing.Point(15, 77)
            Me.btnAddBooking.Name = "btnAddBooking"
            Me.btnAddBooking.Size = New System.Drawing.Size(104, 24)
            Me.btnAddBooking.TabIndex = 12
            Me.btnAddBooking.Text = "3. AddBooking"
            Me.btnAddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(15, 49)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(104, 23)
            Me.Button4.TabIndex = 11
            Me.Button4.Text = "2. GetUserBill"
            Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button4.UseVisualStyleBackColor = True
            '
            'btnEmployeesGetAll
            '
            Me.btnEmployeesGetAll.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEmployeesGetAll.Location = New System.Drawing.Point(15, 18)
            Me.btnEmployeesGetAll.Name = "btnEmployeesGetAll"
            Me.btnEmployeesGetAll.Size = New System.Drawing.Size(104, 24)
            Me.btnEmployeesGetAll.TabIndex = 10
            Me.btnEmployeesGetAll.Text = "1. GetAllEmployees"
            Me.btnEmployeesGetAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.Button3)
            Me.GroupBox5.Controls.Add(Me.btnEventGet)
            Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox5.Location = New System.Drawing.Point(8, 233)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(134, 97)
            Me.GroupBox5.TabIndex = 22
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Event Commands"
            '
            'Button3
            '
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button3.Location = New System.Drawing.Point(6, 47)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(104, 24)
            Me.Button3.TabIndex = 11
            Me.Button3.Text = "2. GetEvent"
            Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEventGet
            '
            Me.btnEventGet.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEventGet.Location = New System.Drawing.Point(6, 17)
            Me.btnEventGet.Name = "btnEventGet"
            Me.btnEventGet.Size = New System.Drawing.Size(104, 24)
            Me.btnEventGet.TabIndex = 10
            Me.btnEventGet.Text = "1. GetAllEvents"
            Me.btnEventGet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.btnApplicationGetMostPopular)
            Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox6.Location = New System.Drawing.Point(8, 336)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(134, 99)
            Me.GroupBox6.TabIndex = 23
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Application Commands"
            '
            'btnApplicationGetMostPopular
            '
            Me.btnApplicationGetMostPopular.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnApplicationGetMostPopular.Location = New System.Drawing.Point(6, 19)
            Me.btnApplicationGetMostPopular.Name = "btnApplicationGetMostPopular"
            Me.btnApplicationGetMostPopular.Size = New System.Drawing.Size(122, 28)
            Me.btnApplicationGetMostPopular.TabIndex = 10
            Me.btnApplicationGetMostPopular.Text = "1. GetMostPopularApps"
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
            Me.GroupBox7.Controls.Add(Me.btnGetAllFinancialTransactions)
            Me.GroupBox7.Controls.Add(Me.btnGetSmartlaunchVersion)
            Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox7.Location = New System.Drawing.Point(684, 233)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(160, 202)
            Me.GroupBox7.TabIndex = 24
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Administrator command"
            '
            'btnGetAllFinancialTransactions
            '
            Me.btnGetAllFinancialTransactions.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetAllFinancialTransactions.Location = New System.Drawing.Point(6, 47)
            Me.btnGetAllFinancialTransactions.Name = "btnGetAllFinancialTransactions"
            Me.btnGetAllFinancialTransactions.Size = New System.Drawing.Size(148, 24)
            Me.btnGetAllFinancialTransactions.TabIndex = 12
            Me.btnGetAllFinancialTransactions.Text = "2. GetFinancialTransactions"
            Me.btnGetAllFinancialTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGetSmartlaunchVersion
            '
            Me.btnGetSmartlaunchVersion.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetSmartlaunchVersion.Location = New System.Drawing.Point(6, 19)
            Me.btnGetSmartlaunchVersion.Name = "btnGetSmartlaunchVersion"
            Me.btnGetSmartlaunchVersion.Size = New System.Drawing.Size(148, 24)
            Me.btnGetSmartlaunchVersion.TabIndex = 11
            Me.btnGetSmartlaunchVersion.Text = "1. GetServerVersion"
            Me.btnGetSmartlaunchVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ContextLogin
            '
            Me.ContextLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.mNoParameter, Me.UsingColumnNamesToolStripMenuItem, Me.mUsing2Parameters, Me.AllBookingToolStripMenuItem, Me.FilterByBookingIDToolStripMenuItem, Me.GetAllProductGroups, Me.GetAllProduct, Me.GetAllTaxToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.EmployeesGetAllUseColumnNamesToolStripMenuItem, Me.EmployeesGetAllUsing2ParametersToolStripMenuItem})
            Me.ContextLogin.Name = "ContextMenuStrip1"
            Me.ContextLogin.Size = New System.Drawing.Size(283, 268)
            '
            'UserToolStripMenuItem
            '
            Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
            Me.UserToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.UserToolStripMenuItem.Tag = "Login"
            Me.UserToolStripMenuItem.Text = "User"
            '
            'mNoParameter
            '
            Me.mNoParameter.Name = "mNoParameter"
            Me.mNoParameter.Size = New System.Drawing.Size(282, 22)
            Me.mNoParameter.Tag = "GetAllUsers"
            Me.mNoParameter.Text = "No Parameter"
            '
            'UsingColumnNamesToolStripMenuItem
            '
            Me.UsingColumnNamesToolStripMenuItem.Name = "UsingColumnNamesToolStripMenuItem"
            Me.UsingColumnNamesToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.UsingColumnNamesToolStripMenuItem.Tag = "GetAllUsers"
            Me.UsingColumnNamesToolStripMenuItem.Text = "Using Column Names"
            '
            'mUsing2Parameters
            '
            Me.mUsing2Parameters.Name = "mUsing2Parameters"
            Me.mUsing2Parameters.Size = New System.Drawing.Size(282, 22)
            Me.mUsing2Parameters.Tag = "GetAllUsers"
            Me.mUsing2Parameters.Text = "Using 2 Parameters"
            '
            'AllBookingToolStripMenuItem
            '
            Me.AllBookingToolStripMenuItem.Name = "AllBookingToolStripMenuItem"
            Me.AllBookingToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.AllBookingToolStripMenuItem.Tag = "GetBooking"
            Me.AllBookingToolStripMenuItem.Text = "All Booking"
            '
            'FilterByBookingIDToolStripMenuItem
            '
            Me.FilterByBookingIDToolStripMenuItem.Name = "FilterByBookingIDToolStripMenuItem"
            Me.FilterByBookingIDToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.FilterByBookingIDToolStripMenuItem.Tag = "GetBooking"
            Me.FilterByBookingIDToolStripMenuItem.Text = "Filter by Booking ID"
            '
            'GetAllProductGroups
            '
            Me.GetAllProductGroups.Name = "GetAllProductGroups"
            Me.GetAllProductGroups.Size = New System.Drawing.Size(282, 22)
            Me.GetAllProductGroups.Tag = "GetAllProduct"
            Me.GetAllProductGroups.Text = "GetAllProductGroups"
            '
            'GetAllProduct
            '
            Me.GetAllProduct.Name = "GetAllProduct"
            Me.GetAllProduct.Size = New System.Drawing.Size(282, 22)
            Me.GetAllProduct.Tag = "GetAllProduct"
            Me.GetAllProduct.Text = "GetAllProducts"
            '
            'GetAllTaxToolStripMenuItem
            '
            Me.GetAllTaxToolStripMenuItem.Name = "GetAllTaxToolStripMenuItem"
            Me.GetAllTaxToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.GetAllTaxToolStripMenuItem.Tag = "GetAllProduct"
            Me.GetAllTaxToolStripMenuItem.Text = "GetAllTax"
            '
            'EmployeesToolStripMenuItem
            '
            Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
            Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
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
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Text = "EmployeesGetAll Using 2 Parameters"
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
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtOutput)
            Me.Controls.Add(Me.GroupBox4)
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

        Public ComputerGroups As New List(Of Computers.ComputerGroups)

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
        Private objGeneral As New Smartlaunch.TCPInterface.General

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
                    txtOutput.Text &= "============================" & NewLine
                    txtOutput.Text &= "Username: " & .UserName & NewLine
                    txtOutput.Text &= "Firstname: " & .FirstName & NewLine
                    txtOutput.Text &= "Lastname: " & .LastName & NewLine
                    txtOutput.Text &= "Group ID: " & .UserGroupID & NewLine
                    txtOutput.Text &= "Email: " & .Email & NewLine
                    txtOutput.Text &= "Age: " & .Age & NewLine
                    txtOutput.Text &= "Time Status: " & .TimeStatus & NewLine
                    txtOutput.Text &= "Balance: " & .Balance & NewLine
                    txtOutput.Text &= "============================" & NewLine
                    txtOutput.Text &= "Deposit Amount: " & .DepositAmount & NewLine
                    txtOutput.Text &= "Deposit Date: " & .DepositDate & NewLine
                    txtOutput.Text &= "============================" & NewLine
                    txtOutput.Text &= "Withdraw Amount: " & .WithdrawAmount & NewLine
                    txtOutput.Text &= "Withdraw Date: " & .WithdrawDate & NewLine
                    txtOutput.Text &= "============================" & NewLine
                    txtOutput.Text &= "Add Offer: " & .AddOffer & NewLine
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

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllComputers.Click
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
            Next
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetComputer.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim pcNumber As String = InputBox("Please enter your PC number (use PC001 if you uncertain)", "ComputerID", "PC001")

            If pcNumber <> "" Then
                For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                    If Not C Is Nothing AndAlso Not C.Name Is Nothing Then
                        If pcNumber.ToUpper = C.Name.ToUpper Then
                            txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
                        End If
                    End If
                Next

            Else
                MessageBox.Show("Please enter your PC number.")
            End If


        End Sub

        Private Sub btnGetAllComputerGroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllComputerGroups.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetAllComputerGroups()

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
                Dim OfferID As Integer = InputBox("Please enter the OfferID (use 1 if you are uncertain, and make sure that you have a offer item on your server)", "OfferID", 1)
                Dim Price As Double = InputBox("Please enter the Price (use 1 if you are uncertain)", "Price", 1)
                Dim PaymentType As String = InputBox("Please enter the PaymentType (use 1 for Cash payment type if you are uncertain)", "PaymentType", "1")

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

            Dim objGen As New Smartlaunch.TCPInterface.General

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
                    txtOutput.Text &= "Withdraw Amount: " & .WithdrawAmount & NewLine
                    txtOutput.Text &= "Withdraw Date: " & .WithdrawDate & NewLine

                End With
            End If
        End Sub

        Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllProduct.Click, btnProduct.Click
            ShowContextMenu("GetAllProduct")
        End Sub

        Private Sub btnLockAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockAccount.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")
            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                ActiveUser.LockUserAccount(username)
                txtOutput.Text &= NewLine & NewLine & "User locked." & NewLine
            End If
        End Sub

        Private Sub btnOpenAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAccount.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")
            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                ActiveUser.OpenUserAccount(username)
                txtOutput.Text &= NewLine & NewLine & "User opened." & NewLine
            End If
        End Sub

        Private Sub btnLoginEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginEmployee.Click

            Dim username As String = InputBox("Please enter username", "Username", "Admin")
            Dim passwd As String = InputBox("Please enter password", "Password", "admin")

            Dim xmlRes As XmlDocument = Smartlaunch.TCPInterface.Users.EmployeeLogin(username, passwd)
            txtOutput.Text &= NewLine & NewLine & xmlRes.InnerXml & NewLine

            If xmlRes.GetElementsByTagName("Response")(0).Attributes("Response").Value = "1" Then
                MsgBox("Login Success" & vbCrLf & "Username : " & username & vbCrLf & "ID : " & xmlRes.DocumentElement.GetElementsByTagName("Object")(0).Attributes("ID").Value, MsgBoxStyle.Exclamation, "Warning")
            Else
                MsgBox("Username Or/And Password was incorrect", MsgBoxStyle.Exclamation, "Warning")
            End If

        End Sub


        Private Sub btnGetComputerGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetComputerGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim pcNumber As String = InputBox("Please enter your PC number (use PC001 if you uncertain)", "ComputerID", "PC001")

            If pcNumber <> "" Then

                For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                    If Not C Is Nothing AndAlso Not C.Name Is Nothing Then

                        If pcNumber.ToUpper = C.Name.ToUpper Then
                            'Get group name based on group ID
                            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetComputerGroupNameBasedOnGroupID(C.GroupID)
                        End If
                    End If
                Next

            Else
                MessageBox.Show("Please enter your PC number.")
            End If
        End Sub

        Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetLayoutGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim strComputerGroupID As String = InputBox("Please enter your computer group ID", "Computer Group ID", "1")
            Dim computerGroupID As Integer

            If Integer.TryParse(strComputerGroupID, computerGroupID) Then

                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetLayoutNameBasedOnLayoutID(computerGroupID)

            Else
                MessageBox.Show("Please enter your computer group ID.")
            End If
        End Sub

        Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllLayoutGroups.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetAllComputerLayoutGroups()
        End Sub


        Private Sub btnGetSmartlaunchVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetSmartlaunchVersion.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.General.GetSmartlaunchServerVersion()
        End Sub

        Private Sub btnGetAllFinancialTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllFinancialTransactions.Click
            Dim StartDate As Date = InputBox("Please enter start date", "Startdate", Date.Today)
            Dim EndDate As Date = InputBox("Please enter end date", "Enddate", Date.Today)
            Dim FilterAdministratorID As Integer = InputBox("Please enter AdministratorID", "AdministratorID", 1)
            Dim FilterEmployeeID As Integer = InputBox("Please enter EmployeeID", "EmployeeID", 1)
            Dim OnlyPrintReport As Boolean = True
            Dim EmployeeName As String = InputBox("Please enter EmployeeName", "EmployeeName", "admin")

            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.General.GetAllFinancialTransactions(StartDate, EndDate, FilterAdministratorID, FilterEmployeeID, OnlyPrintReport, EmployeeName)

        End Sub

        Private Sub btnGetFinancialData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub btnCafeStatusGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllTax.Click

        End Sub
    End Class

End Namespace
