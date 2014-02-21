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
        Friend WithEvents btn02User As System.Windows.Forms.Button
        Friend WithEvents btn06UserLogin As System.Windows.Forms.Button
        Friend WithEvents btnWithdrawMoney As System.Windows.Forms.Button
        Friend WithEvents btnDepositMoney As System.Windows.Forms.Button
        Friend WithEvents btnGetPrice As System.Windows.Forms.Button
        Friend WithEvents btn01TestConnection As System.Windows.Forms.Button
        Friend WithEvents btnAsk As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents btn01ComputerAll As System.Windows.Forms.Button
        Friend WithEvents btn02Computer As System.Windows.Forms.Button
        Friend WithEvents btn03UserCreate As System.Windows.Forms.Button
        Friend WithEvents btn07UserLogout As System.Windows.Forms.Button
        Friend WithEvents btn04UserUpdate As System.Windows.Forms.Button
        Friend WithEvents btnSetPasswd As System.Windows.Forms.Button
        Friend WithEvents btnLostPwSendMail As System.Windows.Forms.Button
        Friend WithEvents btnAskAccDetails As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEmployeesGetAll As System.Windows.Forms.Button
        Friend WithEvents btnAddOffer As System.Windows.Forms.Button
        Friend WithEvents btnAddProduct As System.Windows.Forms.Button
        Friend WithEvents btnUserRemoveOffer As System.Windows.Forms.Button
        Friend WithEvents btnUserLogHistory As System.Windows.Forms.Button
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEventGet As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents btnApplicationGetMostPopular As System.Windows.Forms.Button
        Friend WithEvents btn11UserGetBill As System.Windows.Forms.Button
        Friend WithEvents btnTurnOff As System.Windows.Forms.Button
        Friend WithEvents btnTurnOn As System.Windows.Forms.Button
        Friend WithEvents btnDeleteBooking As System.Windows.Forms.Button
        Friend WithEvents btnAddBooking As System.Windows.Forms.Button
        Friend WithEvents btnEditBooking As System.Windows.Forms.Button
        Friend WithEvents btnGetAllBooking As System.Windows.Forms.Button
        Friend WithEvents ContextMenu As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents mnAll As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnBookingID As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btn10UserAddTime As System.Windows.Forms.Button
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents btn05OfferAll As System.Windows.Forms.Button
        Friend WithEvents btn13UserGroupAll As System.Windows.Forms.Button
        Friend WithEvents btn01UserAll As System.Windows.Forms.Button
        Friend WithEvents ContextLogin As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents btnUserAddTime As System.Windows.Forms.Button
        Friend WithEvents mNoParameter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mUsing2Parameters As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AllBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FilterByBookingIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btn03ProductAll As System.Windows.Forms.Button
        Friend WithEvents GetAllTaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents UsingColumnNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesGetAllUseColumnNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmployeesGetAllUsing2ParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btn03ComputerGroupAll As System.Windows.Forms.Button
        Friend WithEvents btn08UserOpen As System.Windows.Forms.Button
        Friend WithEvents btn09UserLock As System.Windows.Forms.Button
        Friend WithEvents btnLoginEmployee As System.Windows.Forms.Button
        Friend WithEvents btn09LayoutGroupByComputerName As System.Windows.Forms.Button
        Friend WithEvents btn05ComputerGroupByComputerName As System.Windows.Forms.Button
        Friend WithEvents btn06LayoutGroupAll As System.Windows.Forms.Button
        Friend WithEvents btn02SmartlaunchVersion As System.Windows.Forms.Button
        Friend WithEvents btnGetAllFinancialTransactions As System.Windows.Forms.Button
        Friend WithEvents btn04ComputerGroup As System.Windows.Forms.Button
        Friend WithEvents btn08LayoutGroupByComputerGroupName As System.Windows.Forms.Button
        Friend WithEvents btn14UserGroup As System.Windows.Forms.Button
        Friend WithEvents btn07LayoutGroup As System.Windows.Forms.Button
        Friend WithEvents btn05UserMoveUserGroup As System.Windows.Forms.Button
        Friend WithEvents btn01ProductGroupAll As System.Windows.Forms.Button
        Friend WithEvents btn02ProductGroup As System.Windows.Forms.Button
        Friend WithEvents btn04Product As System.Windows.Forms.Button
        Friend WithEvents btn06Offer As System.Windows.Forms.Button
        Friend WithEvents Label6 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.btnGetNews = New System.Windows.Forms.Button()
            Me.StatusBar = New System.Windows.Forms.StatusBar()
            Me.txtOutput = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btn02User = New System.Windows.Forms.Button()
            Me.btn06UserLogin = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnGetAllFinancialTransactions = New System.Windows.Forms.Button()
            Me.btn05UserMoveUserGroup = New System.Windows.Forms.Button()
            Me.btn14UserGroup = New System.Windows.Forms.Button()
            Me.btn08UserOpen = New System.Windows.Forms.Button()
            Me.btnUserAddTime = New System.Windows.Forms.Button()
            Me.btn01UserAll = New System.Windows.Forms.Button()
            Me.btn09UserLock = New System.Windows.Forms.Button()
            Me.btn13UserGroupAll = New System.Windows.Forms.Button()
            Me.btn10UserAddTime = New System.Windows.Forms.Button()
            Me.btn11UserGetBill = New System.Windows.Forms.Button()
            Me.btnUserLogHistory = New System.Windows.Forms.Button()
            Me.btnUserRemoveOffer = New System.Windows.Forms.Button()
            Me.btnAddProduct = New System.Windows.Forms.Button()
            Me.btnAddOffer = New System.Windows.Forms.Button()
            Me.btnAskAccDetails = New System.Windows.Forms.Button()
            Me.btnLostPwSendMail = New System.Windows.Forms.Button()
            Me.btnSetPasswd = New System.Windows.Forms.Button()
            Me.btn04UserUpdate = New System.Windows.Forms.Button()
            Me.btn07UserLogout = New System.Windows.Forms.Button()
            Me.btn03UserCreate = New System.Windows.Forms.Button()
            Me.btnAsk = New System.Windows.Forms.Button()
            Me.btnGetPrice = New System.Windows.Forms.Button()
            Me.btnWithdrawMoney = New System.Windows.Forms.Button()
            Me.btnDepositMoney = New System.Windows.Forms.Button()
            Me.btn03ProductAll = New System.Windows.Forms.Button()
            Me.btn05OfferAll = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btn02SmartlaunchVersion = New System.Windows.Forms.Button()
            Me.btn01TestConnection = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btn07LayoutGroup = New System.Windows.Forms.Button()
            Me.btn08LayoutGroupByComputerGroupName = New System.Windows.Forms.Button()
            Me.btn04ComputerGroup = New System.Windows.Forms.Button()
            Me.btn06LayoutGroupAll = New System.Windows.Forms.Button()
            Me.btnTurnOn = New System.Windows.Forms.Button()
            Me.btnTurnOff = New System.Windows.Forms.Button()
            Me.btn09LayoutGroupByComputerName = New System.Windows.Forms.Button()
            Me.btn05ComputerGroupByComputerName = New System.Windows.Forms.Button()
            Me.btn03ComputerGroupAll = New System.Windows.Forms.Button()
            Me.btn02Computer = New System.Windows.Forms.Button()
            Me.btn01ComputerAll = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnLoginEmployee = New System.Windows.Forms.Button()
            Me.btnGetAllBooking = New System.Windows.Forms.Button()
            Me.btnEditBooking = New System.Windows.Forms.Button()
            Me.btnDeleteBooking = New System.Windows.Forms.Button()
            Me.btnAddBooking = New System.Windows.Forms.Button()
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
            Me.btn06Offer = New System.Windows.Forms.Button()
            Me.btn01ProductGroupAll = New System.Windows.Forms.Button()
            Me.btn02ProductGroup = New System.Windows.Forms.Button()
            Me.btn04Product = New System.Windows.Forms.Button()
            Me.ContextLogin = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.mNoParameter = New System.Windows.Forms.ToolStripMenuItem()
            Me.UsingColumnNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mUsing2Parameters = New System.Windows.Forms.ToolStripMenuItem()
            Me.AllBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FilterByBookingIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GetAllTaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
            Me.btnGetNews.Location = New System.Drawing.Point(6, 19)
            Me.btnGetNews.Name = "btnGetNews"
            Me.btnGetNews.Size = New System.Drawing.Size(150, 24)
            Me.btnGetNews.TabIndex = 6
            Me.btnGetNews.Text = "2. GetAllNews"
            Me.btnGetNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'StatusBar
            '
            Me.StatusBar.Location = New System.Drawing.Point(0, 686)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Size = New System.Drawing.Size(978, 22)
            Me.StatusBar.TabIndex = 7
            '
            'txtOutput
            '
            Me.txtOutput.Location = New System.Drawing.Point(12, 467)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtOutput.Size = New System.Drawing.Size(954, 229)
            Me.txtOutput.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(12, 443)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Messages:"
            '
            'btn02User
            '
            Me.btn02User.BackColor = System.Drawing.Color.Azure
            Me.btn02User.Location = New System.Drawing.Point(6, 49)
            Me.btn02User.Name = "btn02User"
            Me.btn02User.Size = New System.Drawing.Size(150, 24)
            Me.btn02User.TabIndex = 11
            Me.btn02User.Text = "2. User"
            Me.btn02User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn02User.UseVisualStyleBackColor = False
            '
            'btn06UserLogin
            '
            Me.btn06UserLogin.BackColor = System.Drawing.Color.Azure
            Me.btn06UserLogin.Location = New System.Drawing.Point(162, 19)
            Me.btn06UserLogin.Name = "btn06UserLogin"
            Me.btn06UserLogin.Size = New System.Drawing.Size(150, 24)
            Me.btn06UserLogin.TabIndex = 12
            Me.btn06UserLogin.Text = "6. UserLogin"
            Me.btn06UserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn06UserLogin.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnGetAllFinancialTransactions)
            Me.GroupBox1.Controls.Add(Me.btn05UserMoveUserGroup)
            Me.GroupBox1.Controls.Add(Me.btn14UserGroup)
            Me.GroupBox1.Controls.Add(Me.btn08UserOpen)
            Me.GroupBox1.Controls.Add(Me.btnUserAddTime)
            Me.GroupBox1.Controls.Add(Me.btn01UserAll)
            Me.GroupBox1.Controls.Add(Me.btn09UserLock)
            Me.GroupBox1.Controls.Add(Me.btn13UserGroupAll)
            Me.GroupBox1.Controls.Add(Me.btn10UserAddTime)
            Me.GroupBox1.Controls.Add(Me.btn11UserGetBill)
            Me.GroupBox1.Controls.Add(Me.btnUserLogHistory)
            Me.GroupBox1.Controls.Add(Me.btnUserRemoveOffer)
            Me.GroupBox1.Controls.Add(Me.btnAddProduct)
            Me.GroupBox1.Controls.Add(Me.btnAddOffer)
            Me.GroupBox1.Controls.Add(Me.btnAskAccDetails)
            Me.GroupBox1.Controls.Add(Me.btnLostPwSendMail)
            Me.GroupBox1.Controls.Add(Me.btnSetPasswd)
            Me.GroupBox1.Controls.Add(Me.btn04UserUpdate)
            Me.GroupBox1.Controls.Add(Me.btn07UserLogout)
            Me.GroupBox1.Controls.Add(Me.btn03UserCreate)
            Me.GroupBox1.Controls.Add(Me.btnAsk)
            Me.GroupBox1.Controls.Add(Me.btnGetPrice)
            Me.GroupBox1.Controls.Add(Me.btnWithdrawMoney)
            Me.GroupBox1.Controls.Add(Me.btnDepositMoney)
            Me.GroupBox1.Controls.Add(Me.btn02User)
            Me.GroupBox1.Controls.Add(Me.btn06UserLogin)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(180, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(786, 211)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Users"
            '
            'btnGetAllFinancialTransactions
            '
            Me.btnGetAllFinancialTransactions.Location = New System.Drawing.Point(630, 79)
            Me.btnGetAllFinancialTransactions.Name = "btnGetAllFinancialTransactions"
            Me.btnGetAllFinancialTransactions.Size = New System.Drawing.Size(150, 24)
            Me.btnGetAllFinancialTransactions.TabIndex = 12
            Me.btnGetAllFinancialTransactions.Text = "2. GetFinancialTransactions"
            Me.btnGetAllFinancialTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btn05UserMoveUserGroup
            '
            Me.btn05UserMoveUserGroup.BackColor = System.Drawing.Color.Azure
            Me.btn05UserMoveUserGroup.Enabled = False
            Me.btn05UserMoveUserGroup.Location = New System.Drawing.Point(6, 139)
            Me.btn05UserMoveUserGroup.Name = "btn05UserMoveUserGroup"
            Me.btn05UserMoveUserGroup.Size = New System.Drawing.Size(150, 24)
            Me.btn05UserMoveUserGroup.TabIndex = 51
            Me.btn05UserMoveUserGroup.Text = "5. UserMoveUserGroup"
            Me.btn05UserMoveUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn05UserMoveUserGroup.UseVisualStyleBackColor = False
            '
            'btn14UserGroup
            '
            Me.btn14UserGroup.BackColor = System.Drawing.Color.Azure
            Me.btn14UserGroup.Location = New System.Drawing.Point(318, 49)
            Me.btn14UserGroup.Name = "btn14UserGroup"
            Me.btn14UserGroup.Size = New System.Drawing.Size(150, 24)
            Me.btn14UserGroup.TabIndex = 50
            Me.btn14UserGroup.Text = "14. UserGroup"
            Me.btn14UserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn14UserGroup.UseVisualStyleBackColor = False
            '
            'btn08UserOpen
            '
            Me.btn08UserOpen.BackColor = System.Drawing.Color.Azure
            Me.btn08UserOpen.Enabled = False
            Me.btn08UserOpen.Location = New System.Drawing.Point(162, 79)
            Me.btn08UserOpen.Name = "btn08UserOpen"
            Me.btn08UserOpen.Size = New System.Drawing.Size(150, 24)
            Me.btn08UserOpen.TabIndex = 49
            Me.btn08UserOpen.Text = "8. UserOpen"
            Me.btn08UserOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn08UserOpen.UseVisualStyleBackColor = False
            '
            'btnUserAddTime
            '
            Me.btnUserAddTime.Location = New System.Drawing.Point(474, 19)
            Me.btnUserAddTime.Name = "btnUserAddTime"
            Me.btnUserAddTime.Size = New System.Drawing.Size(150, 24)
            Me.btnUserAddTime.TabIndex = 46
            Me.btnUserAddTime.Text = "19. AddTime"
            Me.btnUserAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserAddTime.UseVisualStyleBackColor = True
            '
            'btn01UserAll
            '
            Me.btn01UserAll.BackColor = System.Drawing.Color.Azure
            Me.btn01UserAll.Location = New System.Drawing.Point(6, 19)
            Me.btn01UserAll.Name = "btn01UserAll"
            Me.btn01UserAll.Size = New System.Drawing.Size(150, 24)
            Me.btn01UserAll.TabIndex = 45
            Me.btn01UserAll.Text = "1. UserAll"
            Me.btn01UserAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn01UserAll.UseVisualStyleBackColor = False
            '
            'btn09UserLock
            '
            Me.btn09UserLock.BackColor = System.Drawing.Color.Azure
            Me.btn09UserLock.Enabled = False
            Me.btn09UserLock.Location = New System.Drawing.Point(162, 109)
            Me.btn09UserLock.Name = "btn09UserLock"
            Me.btn09UserLock.Size = New System.Drawing.Size(150, 24)
            Me.btn09UserLock.TabIndex = 48
            Me.btn09UserLock.Text = "9. UserLock"
            Me.btn09UserLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn09UserLock.UseVisualStyleBackColor = False
            '
            'btn13UserGroupAll
            '
            Me.btn13UserGroupAll.BackColor = System.Drawing.Color.Azure
            Me.btn13UserGroupAll.Location = New System.Drawing.Point(318, 19)
            Me.btn13UserGroupAll.Name = "btn13UserGroupAll"
            Me.btn13UserGroupAll.Size = New System.Drawing.Size(150, 24)
            Me.btn13UserGroupAll.TabIndex = 44
            Me.btn13UserGroupAll.Text = "13. UserGroupAll"
            Me.btn13UserGroupAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn13UserGroupAll.UseVisualStyleBackColor = False
            '
            'btn10UserAddTime
            '
            Me.btn10UserAddTime.BackColor = System.Drawing.Color.Azure
            Me.btn10UserAddTime.Enabled = False
            Me.btn10UserAddTime.Location = New System.Drawing.Point(162, 139)
            Me.btn10UserAddTime.Name = "btn10UserAddTime"
            Me.btn10UserAddTime.Size = New System.Drawing.Size(150, 24)
            Me.btn10UserAddTime.TabIndex = 42
            Me.btn10UserAddTime.Text = "10. UserAddTime"
            Me.btn10UserAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn10UserAddTime.UseVisualStyleBackColor = False
            '
            'btn11UserGetBill
            '
            Me.btn11UserGetBill.BackColor = System.Drawing.Color.Azure
            Me.btn11UserGetBill.Enabled = False
            Me.btn11UserGetBill.Location = New System.Drawing.Point(162, 169)
            Me.btn11UserGetBill.Name = "btn11UserGetBill"
            Me.btn11UserGetBill.Size = New System.Drawing.Size(150, 24)
            Me.btn11UserGetBill.TabIndex = 11
            Me.btn11UserGetBill.Text = "11. UserGetBill"
            Me.btn11UserGetBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn11UserGetBill.UseVisualStyleBackColor = False
            '
            'btnUserLogHistory
            '
            Me.btnUserLogHistory.Location = New System.Drawing.Point(318, 109)
            Me.btnUserLogHistory.Name = "btnUserLogHistory"
            Me.btnUserLogHistory.Size = New System.Drawing.Size(150, 24)
            Me.btnUserLogHistory.TabIndex = 39
            Me.btnUserLogHistory.Text = "16. UserLogHistory"
            Me.btnUserLogHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserLogHistory.UseVisualStyleBackColor = True
            '
            'btnUserRemoveOffer
            '
            Me.btnUserRemoveOffer.Location = New System.Drawing.Point(318, 169)
            Me.btnUserRemoveOffer.Name = "btnUserRemoveOffer"
            Me.btnUserRemoveOffer.Size = New System.Drawing.Size(150, 24)
            Me.btnUserRemoveOffer.TabIndex = 38
            Me.btnUserRemoveOffer.Text = "14. RemoveOffer"
            Me.btnUserRemoveOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUserRemoveOffer.UseVisualStyleBackColor = True
            '
            'btnAddProduct
            '
            Me.btnAddProduct.Location = New System.Drawing.Point(318, 79)
            Me.btnAddProduct.Name = "btnAddProduct"
            Me.btnAddProduct.Size = New System.Drawing.Size(150, 24)
            Me.btnAddProduct.TabIndex = 37
            Me.btnAddProduct.Text = "15. AddProduct"
            Me.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAddProduct.UseVisualStyleBackColor = True
            '
            'btnAddOffer
            '
            Me.btnAddOffer.Location = New System.Drawing.Point(474, 49)
            Me.btnAddOffer.Name = "btnAddOffer"
            Me.btnAddOffer.Size = New System.Drawing.Size(150, 24)
            Me.btnAddOffer.TabIndex = 36
            Me.btnAddOffer.Text = "13. AddOffer"
            Me.btnAddOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAddOffer.UseVisualStyleBackColor = True
            '
            'btnAskAccDetails
            '
            Me.btnAskAccDetails.Location = New System.Drawing.Point(474, 109)
            Me.btnAskAccDetails.Name = "btnAskAccDetails"
            Me.btnAskAccDetails.Size = New System.Drawing.Size(150, 24)
            Me.btnAskAccDetails.TabIndex = 35
            Me.btnAskAccDetails.Text = "22. AskAccountDetailAtNextLogin"
            Me.btnAskAccDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAskAccDetails.UseVisualStyleBackColor = True
            '
            'btnLostPwSendMail
            '
            Me.btnLostPwSendMail.Location = New System.Drawing.Point(630, 49)
            Me.btnLostPwSendMail.Name = "btnLostPwSendMail"
            Me.btnLostPwSendMail.Size = New System.Drawing.Size(150, 24)
            Me.btnLostPwSendMail.TabIndex = 34
            Me.btnLostPwSendMail.Text = "7. LostPwSendMail"
            Me.btnLostPwSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLostPwSendMail.UseVisualStyleBackColor = True
            '
            'btnSetPasswd
            '
            Me.btnSetPasswd.Location = New System.Drawing.Point(474, 169)
            Me.btnSetPasswd.Name = "btnSetPasswd"
            Me.btnSetPasswd.Size = New System.Drawing.Size(150, 24)
            Me.btnSetPasswd.TabIndex = 31
            Me.btnSetPasswd.Text = "6. SetUserPassword"
            Me.btnSetPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSetPasswd.UseVisualStyleBackColor = True
            '
            'btn04UserUpdate
            '
            Me.btn04UserUpdate.BackColor = System.Drawing.Color.Azure
            Me.btn04UserUpdate.Enabled = False
            Me.btn04UserUpdate.Location = New System.Drawing.Point(6, 109)
            Me.btn04UserUpdate.Name = "btn04UserUpdate"
            Me.btn04UserUpdate.Size = New System.Drawing.Size(150, 24)
            Me.btn04UserUpdate.TabIndex = 30
            Me.btn04UserUpdate.Text = "4. UserUpdate"
            Me.btn04UserUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn04UserUpdate.UseVisualStyleBackColor = False
            '
            'btn07UserLogout
            '
            Me.btn07UserLogout.BackColor = System.Drawing.Color.Azure
            Me.btn07UserLogout.Enabled = False
            Me.btn07UserLogout.Location = New System.Drawing.Point(162, 49)
            Me.btn07UserLogout.Name = "btn07UserLogout"
            Me.btn07UserLogout.Size = New System.Drawing.Size(150, 24)
            Me.btn07UserLogout.TabIndex = 27
            Me.btn07UserLogout.Text = "7. UserLogout"
            Me.btn07UserLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn07UserLogout.UseVisualStyleBackColor = False
            '
            'btn03UserCreate
            '
            Me.btn03UserCreate.BackColor = System.Drawing.Color.Azure
            Me.btn03UserCreate.Enabled = False
            Me.btn03UserCreate.Location = New System.Drawing.Point(6, 79)
            Me.btn03UserCreate.Name = "btn03UserCreate"
            Me.btn03UserCreate.Size = New System.Drawing.Size(150, 24)
            Me.btn03UserCreate.TabIndex = 24
            Me.btn03UserCreate.Text = "3. UserCreate"
            Me.btn03UserCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn03UserCreate.UseVisualStyleBackColor = False
            '
            'btnAsk
            '
            Me.btnAsk.Location = New System.Drawing.Point(474, 139)
            Me.btnAsk.Name = "btnAsk"
            Me.btnAsk.Size = New System.Drawing.Size(150, 24)
            Me.btnAsk.TabIndex = 20
            Me.btnAsk.Text = "23. AskForPasswordAtNextLogin"
            Me.btnAsk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAsk.UseVisualStyleBackColor = True
            '
            'btnGetPrice
            '
            Me.btnGetPrice.Location = New System.Drawing.Point(318, 139)
            Me.btnGetPrice.Name = "btnGetPrice"
            Me.btnGetPrice.Size = New System.Drawing.Size(150, 24)
            Me.btnGetPrice.TabIndex = 23
            Me.btnGetPrice.Text = "18. GetPrice"
            Me.btnGetPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGetPrice.UseVisualStyleBackColor = True
            '
            'btnWithdrawMoney
            '
            Me.btnWithdrawMoney.Location = New System.Drawing.Point(474, 79)
            Me.btnWithdrawMoney.Name = "btnWithdrawMoney"
            Me.btnWithdrawMoney.Size = New System.Drawing.Size(150, 24)
            Me.btnWithdrawMoney.TabIndex = 20
            Me.btnWithdrawMoney.Text = "8. WithdrawMoney"
            Me.btnWithdrawMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnWithdrawMoney.UseVisualStyleBackColor = True
            '
            'btnDepositMoney
            '
            Me.btnDepositMoney.Location = New System.Drawing.Point(630, 19)
            Me.btnDepositMoney.Name = "btnDepositMoney"
            Me.btnDepositMoney.Size = New System.Drawing.Size(150, 24)
            Me.btnDepositMoney.TabIndex = 17
            Me.btnDepositMoney.Text = "9. DepositMoney"
            Me.btnDepositMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDepositMoney.UseVisualStyleBackColor = True
            '
            'btn03ProductAll
            '
            Me.btn03ProductAll.BackColor = System.Drawing.Color.Azure
            Me.btn03ProductAll.Location = New System.Drawing.Point(6, 79)
            Me.btn03ProductAll.Name = "btn03ProductAll"
            Me.btn03ProductAll.Size = New System.Drawing.Size(150, 24)
            Me.btn03ProductAll.TabIndex = 47
            Me.btn03ProductAll.Text = "3. ProductAll"
            Me.btn03ProductAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn03ProductAll.UseVisualStyleBackColor = False
            '
            'btn05OfferAll
            '
            Me.btn05OfferAll.BackColor = System.Drawing.Color.Azure
            Me.btn05OfferAll.Location = New System.Drawing.Point(6, 139)
            Me.btn05OfferAll.Name = "btn05OfferAll"
            Me.btn05OfferAll.Size = New System.Drawing.Size(150, 24)
            Me.btn05OfferAll.TabIndex = 43
            Me.btn05OfferAll.Text = "5. OfferAll"
            Me.btn05OfferAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn05OfferAll.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.btn02SmartlaunchVersion)
            Me.GroupBox2.Controls.Add(Me.btn01TestConnection)
            Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(162, 136)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "General"
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(6, 46)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 49)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Modify connection details in the App.Config file."
            '
            'btn02SmartlaunchVersion
            '
            Me.btn02SmartlaunchVersion.BackColor = System.Drawing.Color.Azure
            Me.btn02SmartlaunchVersion.Location = New System.Drawing.Point(6, 98)
            Me.btn02SmartlaunchVersion.Name = "btn02SmartlaunchVersion"
            Me.btn02SmartlaunchVersion.Size = New System.Drawing.Size(150, 24)
            Me.btn02SmartlaunchVersion.TabIndex = 11
            Me.btn02SmartlaunchVersion.Text = "2. SmartlaunchVersion"
            Me.btn02SmartlaunchVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn02SmartlaunchVersion.UseVisualStyleBackColor = False
            '
            'btn01TestConnection
            '
            Me.btn01TestConnection.BackColor = System.Drawing.Color.Azure
            Me.btn01TestConnection.Location = New System.Drawing.Point(6, 19)
            Me.btn01TestConnection.Name = "btn01TestConnection"
            Me.btn01TestConnection.Size = New System.Drawing.Size(150, 24)
            Me.btn01TestConnection.TabIndex = 11
            Me.btn01TestConnection.Text = "1. TestConnection"
            Me.btn01TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn01TestConnection.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnClear.Location = New System.Drawing.Point(816, 437)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(150, 24)
            Me.btnClear.TabIndex = 19
            Me.btnClear.Text = "Clear"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btn07LayoutGroup)
            Me.GroupBox3.Controls.Add(Me.btn08LayoutGroupByComputerGroupName)
            Me.GroupBox3.Controls.Add(Me.btn04ComputerGroup)
            Me.GroupBox3.Controls.Add(Me.btn06LayoutGroupAll)
            Me.GroupBox3.Controls.Add(Me.btnTurnOn)
            Me.GroupBox3.Controls.Add(Me.btnTurnOff)
            Me.GroupBox3.Controls.Add(Me.btn09LayoutGroupByComputerName)
            Me.GroupBox3.Controls.Add(Me.btn05ComputerGroupByComputerName)
            Me.GroupBox3.Controls.Add(Me.btn03ComputerGroupAll)
            Me.GroupBox3.Controls.Add(Me.btn02Computer)
            Me.GroupBox3.Controls.Add(Me.btn01ComputerAll)
            Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox3.Location = New System.Drawing.Point(180, 229)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(318, 202)
            Me.GroupBox3.TabIndex = 20
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Computers"
            '
            'btn07LayoutGroup
            '
            Me.btn07LayoutGroup.BackColor = System.Drawing.Color.Azure
            Me.btn07LayoutGroup.Location = New System.Drawing.Point(162, 49)
            Me.btn07LayoutGroup.Name = "btn07LayoutGroup"
            Me.btn07LayoutGroup.Size = New System.Drawing.Size(150, 24)
            Me.btn07LayoutGroup.TabIndex = 32
            Me.btn07LayoutGroup.Text = "7. LayoutGroup"
            Me.btn07LayoutGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn07LayoutGroup.UseVisualStyleBackColor = False
            '
            'btn08LayoutGroupByComputerGroupName
            '
            Me.btn08LayoutGroupByComputerGroupName.BackColor = System.Drawing.Color.Azure
            Me.btn08LayoutGroupByComputerGroupName.Location = New System.Drawing.Point(162, 79)
            Me.btn08LayoutGroupByComputerGroupName.Name = "btn08LayoutGroupByComputerGroupName"
            Me.btn08LayoutGroupByComputerGroupName.Size = New System.Drawing.Size(150, 24)
            Me.btn08LayoutGroupByComputerGroupName.TabIndex = 31
            Me.btn08LayoutGroupByComputerGroupName.Text = "8. LayoutGroupByComputerGroupName"
            Me.btn08LayoutGroupByComputerGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn08LayoutGroupByComputerGroupName.UseVisualStyleBackColor = False
            '
            'btn04ComputerGroup
            '
            Me.btn04ComputerGroup.BackColor = System.Drawing.Color.Azure
            Me.btn04ComputerGroup.Location = New System.Drawing.Point(6, 109)
            Me.btn04ComputerGroup.Name = "btn04ComputerGroup"
            Me.btn04ComputerGroup.Size = New System.Drawing.Size(150, 24)
            Me.btn04ComputerGroup.TabIndex = 30
            Me.btn04ComputerGroup.Text = "4. ComputerGroup"
            Me.btn04ComputerGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn04ComputerGroup.UseVisualStyleBackColor = False
            '
            'btn06LayoutGroupAll
            '
            Me.btn06LayoutGroupAll.BackColor = System.Drawing.Color.Azure
            Me.btn06LayoutGroupAll.Location = New System.Drawing.Point(162, 19)
            Me.btn06LayoutGroupAll.Name = "btn06LayoutGroupAll"
            Me.btn06LayoutGroupAll.Size = New System.Drawing.Size(150, 24)
            Me.btn06LayoutGroupAll.TabIndex = 29
            Me.btn06LayoutGroupAll.Text = "6. LayoutGroupAll"
            Me.btn06LayoutGroupAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn06LayoutGroupAll.UseVisualStyleBackColor = False
            '
            'btnTurnOn
            '
            Me.btnTurnOn.Location = New System.Drawing.Point(162, 139)
            Me.btnTurnOn.Name = "btnTurnOn"
            Me.btnTurnOn.Size = New System.Drawing.Size(150, 24)
            Me.btnTurnOn.TabIndex = 25
            Me.btnTurnOn.Text = "7. TurnOnClient"
            Me.btnTurnOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTurnOn.UseVisualStyleBackColor = True
            '
            'btnTurnOff
            '
            Me.btnTurnOff.Location = New System.Drawing.Point(162, 169)
            Me.btnTurnOff.Name = "btnTurnOff"
            Me.btnTurnOff.Size = New System.Drawing.Size(150, 24)
            Me.btnTurnOff.TabIndex = 24
            Me.btnTurnOff.Text = "3. TurnOffClient"
            Me.btnTurnOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTurnOff.UseVisualStyleBackColor = True
            '
            'btn09LayoutGroupByComputerName
            '
            Me.btn09LayoutGroupByComputerName.BackColor = System.Drawing.Color.Azure
            Me.btn09LayoutGroupByComputerName.Location = New System.Drawing.Point(162, 109)
            Me.btn09LayoutGroupByComputerName.Name = "btn09LayoutGroupByComputerName"
            Me.btn09LayoutGroupByComputerName.Size = New System.Drawing.Size(150, 24)
            Me.btn09LayoutGroupByComputerName.TabIndex = 28
            Me.btn09LayoutGroupByComputerName.Text = "9. LayoutGroupByComputerName"
            Me.btn09LayoutGroupByComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn09LayoutGroupByComputerName.UseVisualStyleBackColor = False
            '
            'btn05ComputerGroupByComputerName
            '
            Me.btn05ComputerGroupByComputerName.BackColor = System.Drawing.Color.Azure
            Me.btn05ComputerGroupByComputerName.Location = New System.Drawing.Point(6, 139)
            Me.btn05ComputerGroupByComputerName.Name = "btn05ComputerGroupByComputerName"
            Me.btn05ComputerGroupByComputerName.Size = New System.Drawing.Size(150, 24)
            Me.btn05ComputerGroupByComputerName.TabIndex = 27
            Me.btn05ComputerGroupByComputerName.Text = "5. ComputerGroupByComputerName"
            Me.btn05ComputerGroupByComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn05ComputerGroupByComputerName.UseVisualStyleBackColor = False
            '
            'btn03ComputerGroupAll
            '
            Me.btn03ComputerGroupAll.BackColor = System.Drawing.Color.Azure
            Me.btn03ComputerGroupAll.Location = New System.Drawing.Point(6, 79)
            Me.btn03ComputerGroupAll.Name = "btn03ComputerGroupAll"
            Me.btn03ComputerGroupAll.Size = New System.Drawing.Size(150, 24)
            Me.btn03ComputerGroupAll.TabIndex = 26
            Me.btn03ComputerGroupAll.Text = "3. ComputerGroupAll"
            Me.btn03ComputerGroupAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn03ComputerGroupAll.UseVisualStyleBackColor = False
            '
            'btn02Computer
            '
            Me.btn02Computer.BackColor = System.Drawing.Color.Azure
            Me.btn02Computer.Location = New System.Drawing.Point(6, 49)
            Me.btn02Computer.Name = "btn02Computer"
            Me.btn02Computer.Size = New System.Drawing.Size(150, 24)
            Me.btn02Computer.TabIndex = 18
            Me.btn02Computer.Text = "2. Computer"
            Me.btn02Computer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn02Computer.UseVisualStyleBackColor = False
            '
            'btn01ComputerAll
            '
            Me.btn01ComputerAll.BackColor = System.Drawing.Color.Azure
            Me.btn01ComputerAll.Location = New System.Drawing.Point(6, 19)
            Me.btn01ComputerAll.Name = "btn01ComputerAll"
            Me.btn01ComputerAll.Size = New System.Drawing.Size(150, 24)
            Me.btn01ComputerAll.TabIndex = 10
            Me.btn01ComputerAll.Text = "1. ComputerAll"
            Me.btn01ComputerAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn01ComputerAll.UseVisualStyleBackColor = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.btnLoginEmployee)
            Me.GroupBox4.Controls.Add(Me.btnGetAllBooking)
            Me.GroupBox4.Controls.Add(Me.btnEditBooking)
            Me.GroupBox4.Controls.Add(Me.btnDeleteBooking)
            Me.GroupBox4.Controls.Add(Me.btnAddBooking)
            Me.GroupBox4.Controls.Add(Me.btnEmployeesGetAll)
            Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox4.Location = New System.Drawing.Point(504, 229)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(162, 202)
            Me.GroupBox4.TabIndex = 21
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Employees"
            '
            'btnLoginEmployee
            '
            Me.btnLoginEmployee.Location = New System.Drawing.Point(6, 49)
            Me.btnLoginEmployee.Name = "btnLoginEmployee"
            Me.btnLoginEmployee.Size = New System.Drawing.Size(150, 24)
            Me.btnLoginEmployee.TabIndex = 50
            Me.btnLoginEmployee.Text = "7. LoginEmployee"
            Me.btnLoginEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLoginEmployee.UseVisualStyleBackColor = True
            '
            'btnGetAllBooking
            '
            Me.btnGetAllBooking.Location = New System.Drawing.Point(6, 169)
            Me.btnGetAllBooking.Name = "btnGetAllBooking"
            Me.btnGetAllBooking.Size = New System.Drawing.Size(150, 24)
            Me.btnGetAllBooking.TabIndex = 15
            Me.btnGetAllBooking.Text = "6. GetBooking"
            Me.btnGetAllBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditBooking
            '
            Me.btnEditBooking.Location = New System.Drawing.Point(6, 109)
            Me.btnEditBooking.Name = "btnEditBooking"
            Me.btnEditBooking.Size = New System.Drawing.Size(150, 24)
            Me.btnEditBooking.TabIndex = 14
            Me.btnEditBooking.Text = "4. EditBooking"
            Me.btnEditBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnDeleteBooking
            '
            Me.btnDeleteBooking.Location = New System.Drawing.Point(6, 139)
            Me.btnDeleteBooking.Name = "btnDeleteBooking"
            Me.btnDeleteBooking.Size = New System.Drawing.Size(150, 24)
            Me.btnDeleteBooking.TabIndex = 13
            Me.btnDeleteBooking.Text = "5. DeleteBooking"
            Me.btnDeleteBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnAddBooking
            '
            Me.btnAddBooking.Location = New System.Drawing.Point(6, 79)
            Me.btnAddBooking.Name = "btnAddBooking"
            Me.btnAddBooking.Size = New System.Drawing.Size(150, 24)
            Me.btnAddBooking.TabIndex = 12
            Me.btnAddBooking.Text = "3. AddBooking"
            Me.btnAddBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEmployeesGetAll
            '
            Me.btnEmployeesGetAll.Location = New System.Drawing.Point(6, 19)
            Me.btnEmployeesGetAll.Name = "btnEmployeesGetAll"
            Me.btnEmployeesGetAll.Size = New System.Drawing.Size(150, 24)
            Me.btnEmployeesGetAll.TabIndex = 10
            Me.btnEmployeesGetAll.Text = "1. GetAllEmployees"
            Me.btnEmployeesGetAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.btnGetNews)
            Me.GroupBox5.Controls.Add(Me.Button3)
            Me.GroupBox5.Controls.Add(Me.btnEventGet)
            Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox5.Location = New System.Drawing.Point(12, 154)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(162, 113)
            Me.GroupBox5.TabIndex = 22
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "News and Events"
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(6, 79)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(150, 24)
            Me.Button3.TabIndex = 11
            Me.Button3.Text = "2. GetEvent"
            Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEventGet
            '
            Me.btnEventGet.Location = New System.Drawing.Point(6, 49)
            Me.btnEventGet.Name = "btnEventGet"
            Me.btnEventGet.Size = New System.Drawing.Size(150, 24)
            Me.btnEventGet.TabIndex = 10
            Me.btnEventGet.Text = "1. GetAllEvents"
            Me.btnEventGet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.btnApplicationGetMostPopular)
            Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox6.Location = New System.Drawing.Point(12, 273)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(162, 53)
            Me.GroupBox6.TabIndex = 23
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Applications"
            '
            'btnApplicationGetMostPopular
            '
            Me.btnApplicationGetMostPopular.Location = New System.Drawing.Point(6, 19)
            Me.btnApplicationGetMostPopular.Name = "btnApplicationGetMostPopular"
            Me.btnApplicationGetMostPopular.Size = New System.Drawing.Size(150, 24)
            Me.btnApplicationGetMostPopular.TabIndex = 10
            Me.btnApplicationGetMostPopular.Text = "1. GetMostPopularApps"
            Me.btnApplicationGetMostPopular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ContextMenu
            '
            Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAll, Me.mnBookingID})
            Me.ContextMenu.Name = "ContextMenuStrip1"
            Me.ContextMenu.Size = New System.Drawing.Size(168, 48)
            '
            'mnAll
            '
            Me.mnAll.Name = "mnAll"
            Me.mnAll.Size = New System.Drawing.Size(167, 22)
            Me.mnAll.Text = "All"
            '
            'mnBookingID
            '
            Me.mnBookingID.Name = "mnBookingID"
            Me.mnBookingID.Size = New System.Drawing.Size(167, 22)
            Me.mnBookingID.Text = "Filter by Booking ID"
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.btn06Offer)
            Me.GroupBox7.Controls.Add(Me.btn01ProductGroupAll)
            Me.GroupBox7.Controls.Add(Me.btn02ProductGroup)
            Me.GroupBox7.Controls.Add(Me.btn04Product)
            Me.GroupBox7.Controls.Add(Me.btn03ProductAll)
            Me.GroupBox7.Controls.Add(Me.btn05OfferAll)
            Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox7.Location = New System.Drawing.Point(672, 229)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(162, 202)
            Me.GroupBox7.TabIndex = 24
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Products and Offers"
            '
            'btn06Offer
            '
            Me.btn06Offer.BackColor = System.Drawing.Color.Azure
            Me.btn06Offer.Location = New System.Drawing.Point(6, 169)
            Me.btn06Offer.Name = "btn06Offer"
            Me.btn06Offer.Size = New System.Drawing.Size(150, 24)
            Me.btn06Offer.TabIndex = 51
            Me.btn06Offer.Text = "6. Offer"
            Me.btn06Offer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn06Offer.UseVisualStyleBackColor = False
            '
            'btn01ProductGroupAll
            '
            Me.btn01ProductGroupAll.BackColor = System.Drawing.Color.Azure
            Me.btn01ProductGroupAll.Location = New System.Drawing.Point(6, 19)
            Me.btn01ProductGroupAll.Name = "btn01ProductGroupAll"
            Me.btn01ProductGroupAll.Size = New System.Drawing.Size(150, 24)
            Me.btn01ProductGroupAll.TabIndex = 50
            Me.btn01ProductGroupAll.Text = "1. ProductGroupAll"
            Me.btn01ProductGroupAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn01ProductGroupAll.UseVisualStyleBackColor = False
            '
            'btn02ProductGroup
            '
            Me.btn02ProductGroup.BackColor = System.Drawing.Color.Azure
            Me.btn02ProductGroup.Location = New System.Drawing.Point(6, 49)
            Me.btn02ProductGroup.Name = "btn02ProductGroup"
            Me.btn02ProductGroup.Size = New System.Drawing.Size(150, 24)
            Me.btn02ProductGroup.TabIndex = 49
            Me.btn02ProductGroup.Text = "2. ProductGroup"
            Me.btn02ProductGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn02ProductGroup.UseVisualStyleBackColor = False
            '
            'btn04Product
            '
            Me.btn04Product.BackColor = System.Drawing.Color.Azure
            Me.btn04Product.Location = New System.Drawing.Point(6, 109)
            Me.btn04Product.Name = "btn04Product"
            Me.btn04Product.Size = New System.Drawing.Size(150, 24)
            Me.btn04Product.TabIndex = 48
            Me.btn04Product.Text = "4. Product"
            Me.btn04Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btn04Product.UseVisualStyleBackColor = False
            '
            'ContextLogin
            '
            Me.ContextLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mNoParameter, Me.UsingColumnNamesToolStripMenuItem, Me.mUsing2Parameters, Me.AllBookingToolStripMenuItem, Me.FilterByBookingIDToolStripMenuItem, Me.GetAllTaxToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.EmployeesGetAllUseColumnNamesToolStripMenuItem, Me.EmployeesGetAllUsing2ParametersToolStripMenuItem})
            Me.ContextLogin.Name = "ContextMenuStrip1"
            Me.ContextLogin.Size = New System.Drawing.Size(256, 202)
            '
            'mNoParameter
            '
            Me.mNoParameter.Name = "mNoParameter"
            Me.mNoParameter.Size = New System.Drawing.Size(255, 22)
            Me.mNoParameter.Tag = "GetAllUsers"
            Me.mNoParameter.Text = "No Parameter"
            '
            'UsingColumnNamesToolStripMenuItem
            '
            Me.UsingColumnNamesToolStripMenuItem.Name = "UsingColumnNamesToolStripMenuItem"
            Me.UsingColumnNamesToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.UsingColumnNamesToolStripMenuItem.Tag = "GetAllUsers"
            Me.UsingColumnNamesToolStripMenuItem.Text = "Using Column Names"
            '
            'mUsing2Parameters
            '
            Me.mUsing2Parameters.Name = "mUsing2Parameters"
            Me.mUsing2Parameters.Size = New System.Drawing.Size(255, 22)
            Me.mUsing2Parameters.Tag = "GetAllUsers"
            Me.mUsing2Parameters.Text = "Using 2 Parameters"
            '
            'AllBookingToolStripMenuItem
            '
            Me.AllBookingToolStripMenuItem.Name = "AllBookingToolStripMenuItem"
            Me.AllBookingToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.AllBookingToolStripMenuItem.Tag = "GetBooking"
            Me.AllBookingToolStripMenuItem.Text = "All Booking"
            '
            'FilterByBookingIDToolStripMenuItem
            '
            Me.FilterByBookingIDToolStripMenuItem.Name = "FilterByBookingIDToolStripMenuItem"
            Me.FilterByBookingIDToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.FilterByBookingIDToolStripMenuItem.Tag = "GetBooking"
            Me.FilterByBookingIDToolStripMenuItem.Text = "Filter by Booking ID"
            '
            'GetAllTaxToolStripMenuItem
            '
            Me.GetAllTaxToolStripMenuItem.Name = "GetAllTaxToolStripMenuItem"
            Me.GetAllTaxToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.GetAllTaxToolStripMenuItem.Tag = "GetAllProduct"
            Me.GetAllTaxToolStripMenuItem.Text = "GetAllTax"
            '
            'EmployeesToolStripMenuItem
            '
            Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
            Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.EmployeesToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesToolStripMenuItem.Text = "EmployeesGetAll No Parameter"
            '
            'EmployeesGetAllUseColumnNamesToolStripMenuItem
            '
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Name = "EmployeesGetAllUseColumnNamesToolStripMenuItem"
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesGetAllUseColumnNamesToolStripMenuItem.Text = "EmployeesGetAll Using Column Names"
            '
            'EmployeesGetAllUsing2ParametersToolStripMenuItem
            '
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Name = "EmployeesGetAllUsing2ParametersToolStripMenuItem"
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Tag = "EmployeesGetAll"
            Me.EmployeesGetAllUsing2ParametersToolStripMenuItem.Text = "EmployeesGetAll Using 2 Parameters"
            '
            'Main
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(978, 708)
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
        Private ActiveUser As Smartlaunch.TCPInterface.Users.User
        Private ActiveComputer As Smartlaunch.TCPInterface.Computers.Computer = New Smartlaunch.TCPInterface.Computers.Computer
        Private objGeneral As New Smartlaunch.TCPInterface.General

        Private Sub ShowContextMenu(ByVal StrVisibleTrue As String)
            With ContextLogin
                For Each x As ToolStripMenuItem In .Items
                    x.Visible = x.Tag.ToString.ToLower = StrVisibleTrue.ToLower
                Next
            End With
            ContextLogin.Show(MousePosition)
        End Sub

        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            txtOutput.Text = ""
        End Sub

        Private Sub ContextLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextLogin.ItemClicked
            Dim item As ToolStripItemClickedEventArgs = CType(e, ToolStripItemClickedEventArgs)

            Select Case item.ClickedItem.ToString
                Case "All Booking"
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = ActiveUser.GetAllBooking()
                    txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml

                Case "Filter by Booking ID"
                    Dim BookingID As Integer = CInt(InputBox("Please enter Booking ID", "Booking ID", "12345"))
                    Dim xmlDoc As New XmlDocument
                    xmlDoc = ActiveUser.GetBookingByBookingID(BookingID)
                    txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml

                    ''' GetAllUsers
                Case "No Parameter"
                    txtOutput.Text &= NewLine & NewLine & Users.User.GetAllUsers() & NewLine

                    ''' GetAllUsers
                Case "Using Column Names"
                    Dim ColumnName As String = InputBox("Please enter Column Name", "Columns", "Col1,Col2,Col3")
                    txtOutput.Text &= NewLine & NewLine & Users.User.GetAllUsers(ColumnName) & NewLine

                    ''' GetAllUsers
                Case "Using 2 Parameters"
                    Dim IDStart As String = InputBox("Please enter Start ID", "Start ID", "123")
                    Dim TopCount As String = InputBox("Please enter Count", "Count", "10")
                    txtOutput.Text &= NewLine & NewLine & Users.User.GetAllUsers(IDStart, TopCount) & NewLine

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

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' General 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn01TestConnection.Click
            Try
                If Smartlaunch.TCPInterface.Main.TestConnection() = True Then
                    txtOutput.Text &= NewLine & NewLine & "Connection test completed succesfully" & NewLine
                End If
            Catch ex As Exception
                txtOutput.Text &= NewLine & NewLine & "Could not connect. An error was returned:  " & ex.Message & NewLine
            End Try
        End Sub

        Private Sub btnGetSmartlaunchVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn02SmartlaunchVersion.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.General.GetSmartlaunchServerVersion()
        End Sub

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Users 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Private Sub btn01UserAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn01UserAll.Click
            ShowContextMenu("GetAllUsers")
        End Sub

        Private Sub btn02User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn02User.Click
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
                End With
            End If

            SetEnableState()
        End Sub

        Private Sub btn03UserCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn03UserCreate.Click
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

        Private Sub btn04UserUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn04UserUpdate.Click
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
                End With

            End If
        End Sub

        Private Sub btn05UserMoveUserGroup_Click(sender As System.Object, e As System.EventArgs) Handles btn05UserMoveUserGroup.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")

            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                Dim newusergroupid As String = InputBox("Please enter new usergroup id", "New UserGroup ID", "1")

                Dim XML As XmlDocument
                XML = ActiveUser.MoveUserGroup(newusergroupid)
                txtOutput.Text &= NewLine & NewLine & XML.InnerXml
            End If
        End Sub

        Private Sub btn06UserLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn06UserLogin.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")
            Dim passwd As String = InputBox("Please enter password", "Password", "test")
            Dim computername As String = InputBox("Please enter computer name", "Computer Name", "PC001")
            Dim Response As Int32 = Smartlaunch.TCPInterface.Users.Login(username, computername, passwd)

            Select Case Response
                Case 1
                    ActiveUser = New Smartlaunch.TCPInterface.Users.User
                    ActiveUser = Smartlaunch.TCPInterface.Users.GetUserLogin(username, passwd)
                    txtOutput.Text &= NewLine & NewLine & "Login info correct... User logged in succesfully." & NewLine
                Case Else
                    txtOutput.Text &= NewLine & NewLine & "Username or password was incorrect." & NewLine
            End Select
            SetEnableState()
        End Sub

        Private Sub btn07UserLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn07UserLogout.Click
            txtOutput.Text &= NewLine & NewLine & ActiveUser.LogoutUser.InnerXml
        End Sub

        Private Sub btn08UserOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn08UserOpen.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")
            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                ActiveUser.OpenUserAccount(username)
                txtOutput.Text &= NewLine & NewLine & "User opened." & NewLine
            End If
        End Sub

        Private Sub btn09UserLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn09UserLock.Click
            Dim username As String = InputBox("Please enter username", "Username", "test2")
            ActiveUser = New Smartlaunch.TCPInterface.Users.User(username)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username did not exist." & NewLine
            Else
                ActiveUser.LockUserAccount(username)
                txtOutput.Text &= NewLine & NewLine & "User locked." & NewLine
            End If
        End Sub

        Private Sub btn10UserAddTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10UserAddTime.Click
            Dim Username As String = InputBox("Please enter Username (User)", "Username (User)", "user")
            Dim Minutes As Integer = InputBox("Please enter Minutes", "Minutes", "60")
            Dim TotalPrice As String = InputBox("Please enter Total Price", "Total Price", "123")
            Dim TaxIncluded As Boolean = IIf(MsgBox("Tax Included?", vbYesNo, "Username (User)") = vbYes, True, False)

            Dim xmlDoc As New XmlDocument
            xmlDoc = ActiveUser.UserAddSpecialTime(Minutes, TotalPrice, TaxIncluded)
            txtOutput.Text &= NewLine & NewLine & xmlDoc.InnerXml
        End Sub

        Private Sub btn11UserGetBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11UserGetBill.Click
            Dim xmlDoc As New XmlDocument

            xmlDoc = ActiveUser.UserGetBill()

            txtOutput.Text = xmlDoc.InnerXml
        End Sub

        Private Sub btn13UserGroupAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13UserGroupAll.Click
            txtOutput.Text &= NewLine & NewLine & Users.User.GetAllUsergroup.InnerXml & NewLine
        End Sub

        Private Sub btn14UserGroup_Click(sender As System.Object, e As System.EventArgs) Handles btn14UserGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim usergroupname As String = InputBox("Please enter your user group name", "User Group Name", "Members")

            If usergroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Users.User.UserGroupGet(usergroupname).InnerXml & NewLine
            Else
                MessageBox.Show("Please enter your user group name.")
            End If
        End Sub

        Private Sub SetEnableState()
            Dim enablestate As Boolean = (Not ActiveUser Is Nothing)

            btn03UserCreate.Enabled = enablestate
            btn04UserUpdate.Enabled = enablestate
            btn07UserLogout.Enabled = enablestate
            btn08UserOpen.Enabled = enablestate
            btn09UserLock.Enabled = enablestate
            btn10UserAddTime.Enabled = enablestate
            btn11UserGetBill.Enabled = enablestate

            'btnDepositMoney.Enabled = enablestate
            'btnWithdrawMoney.Enabled = enablestate
            'btnGetPrice.Enabled = enablestate
            'btnAsk.Enabled = enablestate
            'btnLostPwSendMail.Enabled = enablestate
            'btnSetPasswd.Enabled = enablestate
            'btnAddOffer.Enabled = enablestate
            'btnAddProduct.Enabled = enablestate
            'btnUserRemoveOffer.Enabled = enablestate
            'btnUserLogHistory.Enabled = enablestate
            'btnAskAccDetails.Enabled = enablestate
            'btnUserGroupGet.Enabled = enablestate
            'btnGetAllOffers.Enabled = enablestate
            'btnGetAllProduct.Enabled = enablestate
        End Sub

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Computers 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Private Sub btn01ComputerAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn01ComputerAll.Click
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & NewLine
            Next
        End Sub

        Private Sub btn02Computer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn02Computer.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim pcNumber As String = InputBox("Please enter your computer name (use PC001 if you uncertain)", "Computer Name", "PC001")

            If pcNumber <> "" Then
                For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                    If Not C Is Nothing AndAlso Not C.Name Is Nothing Then
                        If pcNumber.ToUpper = C.Name.ToUpper Then
                            txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & NewLine
                        End If
                    End If
                Next

            Else
                MessageBox.Show("Please enter your PC number.")
            End If
        End Sub

        Private Sub btn03ComputerGroupAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn03ComputerGroupAll.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetAllComputerGroups()
        End Sub

        Private Sub btn04ComputerGroup_Click(sender As System.Object, e As System.EventArgs) Handles btn04ComputerGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim computerGroupName As String = InputBox("Please enter your computer group name", "Computer Group Name", "Default")

            If computerGroupName <> "" Then
                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetComputerGroupNameBasedOnGroupName(computerGroupName)
            Else
                MessageBox.Show("Please enter your Computer Group ID.")
            End If
        End Sub

        Private Sub btn05ComputerGroupByComputerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn05ComputerGroupByComputerName.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim computername As String = InputBox("Please enter your computer name", "Computer Name", "PC001")

            If computername <> "" Then
                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetComputerGroupByComputerName(computername)
            Else
                MessageBox.Show("Please enter your Computer Group ID.")
            End If
        End Sub

        Private Sub btn06LayoutGroupAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn06LayoutGroupAll.Click
            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetAllComputerLayoutGroups()
        End Sub

        Private Sub btn07LayoutGroup_Click(sender As System.Object, e As System.EventArgs) Handles btn07LayoutGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim layoutgroupname As String = InputBox("Please enter your layout group name", "Layout Group Name", "All Computers")

            If layoutgroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetLayoutGroup(layoutgroupname)
            Else
                MessageBox.Show("Please enter your Layout Group name.")
            End If
        End Sub

        Private Sub btn08LayoutGroupByComputerGroupName_Click(sender As System.Object, e As System.EventArgs) Handles btn08LayoutGroupByComputerGroupName.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim computergroupname As String = InputBox("Please enter your computer group name", "Computer Group Name", "Default")

            If computergroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetLayoutGroupByComputerGroupName(computergroupname)
            Else
                MessageBox.Show("Please enter your Computer Group name.")
            End If
        End Sub

        Private Sub btn09LayoutGroupByComputerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn09LayoutGroupByComputerName.Click
            txtOutput.Text &= NewLine & NewLine & "Computer: " & NewLine

            Dim computername As String = InputBox("Please enter your computer name", "Computer Name", "PC001")

            If computername <> "" Then
                txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.Computers.ComputerGroups.GetLayoutGroupByComputerName(computername)
            Else
                MessageBox.Show("Please enter your Computer name.")
            End If
        End Sub
        
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Products 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Private Sub btn01ProductGroupAll_Click(sender As System.Object, e As System.EventArgs) Handles btn01ProductGroupAll.Click
            txtOutput.Text &= NewLine & NewLine & Users.User.ProductGroupAll.InnerXml & NewLine
        End Sub

        Private Sub btn02ProductGroup_Click(sender As System.Object, e As System.EventArgs) Handles btn02ProductGroup.Click
            txtOutput.Text &= NewLine & NewLine & "Product Group: " & NewLine

            Dim productgroupname As String = InputBox("Please enter your product group name", "Product Group Name", "Chocolates")

            If productgroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Users.User.ProductGroup(productgroupname)
            Else
                MessageBox.Show("Please enter your Product Group name.")
            End If
        End Sub

        Private Sub btn03ProductAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn03ProductAll.Click
            txtOutput.Text &= NewLine & NewLine & Users.User.ProductAll.InnerXml & NewLine
        End Sub

        Private Sub btn04Product_Click(sender As System.Object, e As System.EventArgs) Handles btn04Product.Click
            txtOutput.Text &= NewLine & NewLine & "Product: " & NewLine

            Dim productgroupname As String = InputBox("Please enter your product name", "Product Name", "Chocolate")

            If productgroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Users.User.Product(productgroupname)
            Else
                MessageBox.Show("Please enter your Product name.")
            End If
        End Sub

        Private Sub btn05OfferAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn05OfferAll.Click
            txtOutput.Text &= NewLine & NewLine & Users.User.GetAllOffers.InnerXml & NewLine
        End Sub

        Private Sub btn06Offer_Click(sender As System.Object, e As System.EventArgs) Handles btn06Offer.Click
            txtOutput.Text &= NewLine & NewLine & "Offer: " & NewLine

            Dim productgroupname As String = InputBox("Please enter your offer name", "Offer Name", "Offers")

            If productgroupname <> "" Then
                txtOutput.Text &= NewLine & NewLine & Users.User.Offer(productgroupname)
            Else
                MessageBox.Show("Please enter your Offer name.")
            End If
        End Sub



        Private Sub btnGetNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNews.Click
            Try
                txtOutput.Text &= NewLine & NewLine & "News: " & NewLine
                For Each N As Smartlaunch.TCPInterface.News.NewsItem In Smartlaunch.TCPInterface.News.Items
                    txtOutput.Text &= N.DateTimeAdded.ToLongDateString & "     " & N.Headline & NewLine
                Next
            Catch ex As SmartlaunchWebInterfaceException
                txtOutput.Text &= NewLine & NewLine & "Error ocurred: " & ex.Message
            End Try
        End Sub

        Private Sub btnGetComputers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
            Next
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



        Private Sub btnAsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsk.Click
            If ActiveUser.SetAskPasswordAtNextLogin() Then
                txtOutput.Text &= NewLine & NewLine & "Ask password at next login." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Error@Ask password at next login." & NewLine
            End If
        End Sub

        Private Sub btnSetPasswd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPasswd.Click

            Dim passwd As String = InputBox("Please enter new passwd.", "Password", "test")

            Dim XML As XmlDocument
            XML = ActiveUser.UserSetNewPassword(passwd)
            txtOutput.Text &= NewLine & NewLine & XML.InnerXml
        End Sub

        Private Sub btnLostPwSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLostPwSendMail.Click
            Dim XML As XmlDocument
            XML = ActiveUser.LostPasswdEmail()
            txtOutput.Text &= NewLine & NewLine & XML.InnerXml
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

        Private Sub btnEventGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventGet.Click
            'Dim EventID As Integer = InputBox("Please enter event ID (use 1 if you uncertain)", "event ID", 1)

            txtOutput.Text &= NewLine & "Events: " & NewLine
            For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items
                txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
            Next
        End Sub

        Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Dim EventID As Integer = InputBox("Please enter EventID (use 1 if you uncertain)", "EventID", 1)

            For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items

                If EventID = Ev.EventID Then
                    txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
                End If
            Next
        End Sub

        Private Sub btnApplicationGetMostPopular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplicationGetMostPopular.Click

            Dim catName As String = InputBox("Please enter the Category Name (use Games if you uncertain)", "Category Name", "Games")
            Dim WithinDays As Integer = InputBox("Please enter the within days (use 1 if you unsure)", "WithinDays", 1)

            Dim objGen As New Smartlaunch.TCPInterface.General

            Dim xmlDoc As New XmlDocument
            xmlDoc = objGen.ApplicationGetMostPopular(catName, WithinDays)

            txtOutput.Text = xmlDoc.InnerXml
        End Sub

        Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            SetEnableState()
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
            MsgBox("We were sorry for this inconvenience. This feature is temporary unavailable", MsgBoxStyle.Information, "Unavailable Features")
            Exit Sub
            'ShowContextMenu("GetBooking")
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

        

        Private Sub btnUserAddTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAddTime.Click

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








        Private Sub btnGetAllFinancialTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllFinancialTransactions.Click
            Dim StartDate As Date = InputBox("Please enter start date", "Startdate", Date.Today)
            Dim EndDate As Date = InputBox("Please enter end date", "Enddate", Date.Today)
            Dim FilterAdministratorID As Integer = InputBox("Please enter AdministratorID", "AdministratorID", 1)
            Dim FilterEmployeeID As Integer = InputBox("Please enter EmployeeID", "EmployeeID", 1)
            Dim OnlyPrintReport As Boolean = True
            Dim EmployeeName As String = InputBox("Please enter EmployeeName", "EmployeeName", "admin")

            txtOutput.Text &= NewLine & NewLine & Smartlaunch.TCPInterface.General.GetAllFinancialTransactions(StartDate, EndDate, FilterAdministratorID, FilterEmployeeID, OnlyPrintReport, EmployeeName)

        End Sub

        
    End Class

End Namespace
