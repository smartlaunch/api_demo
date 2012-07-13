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
        Friend WithEvents Label6 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.btnGetNews = New System.Windows.Forms.Button()
            Me.StatusBar = New System.Windows.Forms.StatusBar()
            Me.txtOutput = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnGetUserInfo = New System.Windows.Forms.Button()
            Me.btnLoginUser = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnEmployeesGetAll = New System.Windows.Forms.Button()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.btnEventGet = New System.Windows.Forms.Button()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.btnApplicationGetMostPopular = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
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
            Me.StatusBar.Location = New System.Drawing.Point(0, 541)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Size = New System.Drawing.Size(612, 22)
            Me.StatusBar.TabIndex = 7
            '
            'txtOutput
            '
            Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOutput.Location = New System.Drawing.Point(8, 358)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtOutput.Size = New System.Drawing.Size(596, 175)
            Me.txtOutput.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(5, 328)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Messages:"
            '
            'btnGetUserInfo
            '
            Me.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetUserInfo.Location = New System.Drawing.Point(17, 50)
            Me.btnGetUserInfo.Name = "btnGetUserInfo"
            Me.btnGetUserInfo.Size = New System.Drawing.Size(104, 24)
            Me.btnGetUserInfo.TabIndex = 11
            Me.btnGetUserInfo.Text = "Get User Info"
            '
            'btnLoginUser
            '
            Me.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnLoginUser.Location = New System.Drawing.Point(17, 24)
            Me.btnLoginUser.Name = "btnLoginUser"
            Me.btnLoginUser.Size = New System.Drawing.Size(104, 24)
            Me.btnLoginUser.TabIndex = 12
            Me.btnLoginUser.Text = "Login User"
            '
            'GroupBox1
            '
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
            Me.GroupBox1.Size = New System.Drawing.Size(317, 309)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "User handling"
            '
            'btnUserGroupGet
            '
            Me.btnUserGroupGet.Enabled = False
            Me.btnUserGroupGet.Location = New System.Drawing.Point(127, 274)
            Me.btnUserGroupGet.Name = "btnUserGroupGet"
            Me.btnUserGroupGet.Size = New System.Drawing.Size(142, 26)
            Me.btnUserGroupGet.TabIndex = 41
            Me.btnUserGroupGet.Text = "UserGroupGet"
            Me.btnUserGroupGet.UseVisualStyleBackColor = True
            '
            'btnUserGroupGetAll
            '
            Me.btnUserGroupGetAll.Enabled = False
            Me.btnUserGroupGetAll.Location = New System.Drawing.Point(127, 242)
            Me.btnUserGroupGetAll.Name = "btnUserGroupGetAll"
            Me.btnUserGroupGetAll.Size = New System.Drawing.Size(142, 26)
            Me.btnUserGroupGetAll.TabIndex = 40
            Me.btnUserGroupGetAll.Text = "UserGroupGetAll"
            Me.btnUserGroupGetAll.UseVisualStyleBackColor = True
            '
            'btnUserLogHistory
            '
            Me.btnUserLogHistory.Enabled = False
            Me.btnUserLogHistory.Location = New System.Drawing.Point(127, 210)
            Me.btnUserLogHistory.Name = "btnUserLogHistory"
            Me.btnUserLogHistory.Size = New System.Drawing.Size(142, 26)
            Me.btnUserLogHistory.TabIndex = 39
            Me.btnUserLogHistory.Text = "UserLogHistory"
            Me.btnUserLogHistory.UseVisualStyleBackColor = True
            '
            'btnUserRemoveOffer
            '
            Me.btnUserRemoveOffer.Enabled = False
            Me.btnUserRemoveOffer.Location = New System.Drawing.Point(127, 178)
            Me.btnUserRemoveOffer.Name = "btnUserRemoveOffer"
            Me.btnUserRemoveOffer.Size = New System.Drawing.Size(142, 26)
            Me.btnUserRemoveOffer.TabIndex = 38
            Me.btnUserRemoveOffer.Text = "UserRemoveOffer"
            Me.btnUserRemoveOffer.UseVisualStyleBackColor = True
            '
            'btnAddProduct
            '
            Me.btnAddProduct.Enabled = False
            Me.btnAddProduct.Location = New System.Drawing.Point(127, 146)
            Me.btnAddProduct.Name = "btnAddProduct"
            Me.btnAddProduct.Size = New System.Drawing.Size(142, 26)
            Me.btnAddProduct.TabIndex = 37
            Me.btnAddProduct.Text = "User Add Product"
            Me.btnAddProduct.UseVisualStyleBackColor = True
            '
            'btnAddOffer
            '
            Me.btnAddOffer.Enabled = False
            Me.btnAddOffer.Location = New System.Drawing.Point(127, 114)
            Me.btnAddOffer.Name = "btnAddOffer"
            Me.btnAddOffer.Size = New System.Drawing.Size(142, 26)
            Me.btnAddOffer.TabIndex = 36
            Me.btnAddOffer.Text = "User Add Offer"
            Me.btnAddOffer.UseVisualStyleBackColor = True
            '
            'btnAskAccDetails
            '
            Me.btnAskAccDetails.Enabled = False
            Me.btnAskAccDetails.Location = New System.Drawing.Point(127, 22)
            Me.btnAskAccDetails.Name = "btnAskAccDetails"
            Me.btnAskAccDetails.Size = New System.Drawing.Size(178, 26)
            Me.btnAskAccDetails.TabIndex = 35
            Me.btnAskAccDetails.Text = "Ask Account Detail At Next Login"
            Me.btnAskAccDetails.UseVisualStyleBackColor = True
            '
            'btnLostPwSendMail
            '
            Me.btnLostPwSendMail.Enabled = False
            Me.btnLostPwSendMail.Location = New System.Drawing.Point(127, 82)
            Me.btnLostPwSendMail.Name = "btnLostPwSendMail"
            Me.btnLostPwSendMail.Size = New System.Drawing.Size(142, 26)
            Me.btnLostPwSendMail.TabIndex = 34
            Me.btnLostPwSendMail.Text = "LostPwSendMail"
            Me.btnLostPwSendMail.UseVisualStyleBackColor = True
            '
            'btnSetPasswd
            '
            Me.btnSetPasswd.Enabled = False
            Me.btnSetPasswd.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetPasswd.Location = New System.Drawing.Point(17, 246)
            Me.btnSetPasswd.Name = "btnSetPasswd"
            Me.btnSetPasswd.Size = New System.Drawing.Size(104, 24)
            Me.btnSetPasswd.TabIndex = 31
            Me.btnSetPasswd.Text = "Set Password"
            '
            'btnUpdateUserInfo
            '
            Me.btnUpdateUserInfo.Enabled = False
            Me.btnUpdateUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnUpdateUserInfo.Location = New System.Drawing.Point(17, 216)
            Me.btnUpdateUserInfo.Name = "btnUpdateUserInfo"
            Me.btnUpdateUserInfo.Size = New System.Drawing.Size(104, 24)
            Me.btnUpdateUserInfo.TabIndex = 30
            Me.btnUpdateUserInfo.Text = "Update User Info"
            '
            'btnUserLogout
            '
            Me.btnUserLogout.Enabled = False
            Me.btnUserLogout.Location = New System.Drawing.Point(17, 277)
            Me.btnUserLogout.Name = "btnUserLogout"
            Me.btnUserLogout.Size = New System.Drawing.Size(104, 26)
            Me.btnUserLogout.TabIndex = 27
            Me.btnUserLogout.Text = "User Logout"
            Me.btnUserLogout.UseVisualStyleBackColor = True
            '
            'btnCreateUser
            '
            Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnCreateUser.Location = New System.Drawing.Point(17, 74)
            Me.btnCreateUser.Name = "btnCreateUser"
            Me.btnCreateUser.Size = New System.Drawing.Size(104, 24)
            Me.btnCreateUser.TabIndex = 24
            Me.btnCreateUser.Text = "Create user"
            '
            'btnAsk
            '
            Me.btnAsk.Enabled = False
            Me.btnAsk.Location = New System.Drawing.Point(127, 49)
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
            Me.btnGetPrice.Location = New System.Drawing.Point(17, 186)
            Me.btnGetPrice.Name = "btnGetPrice"
            Me.btnGetPrice.Size = New System.Drawing.Size(104, 24)
            Me.btnGetPrice.TabIndex = 23
            Me.btnGetPrice.Text = "Get Price"
            '
            'btnWithdrawMoney
            '
            Me.btnWithdrawMoney.Enabled = False
            Me.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnWithdrawMoney.Location = New System.Drawing.Point(17, 146)
            Me.btnWithdrawMoney.Name = "btnWithdrawMoney"
            Me.btnWithdrawMoney.Size = New System.Drawing.Size(104, 24)
            Me.btnWithdrawMoney.TabIndex = 20
            Me.btnWithdrawMoney.Text = "Withdraw money"
            '
            'btnDepositMoney
            '
            Me.btnDepositMoney.Enabled = False
            Me.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDepositMoney.Location = New System.Drawing.Point(17, 114)
            Me.btnDepositMoney.Name = "btnDepositMoney"
            Me.btnDepositMoney.Size = New System.Drawing.Size(104, 24)
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
            Me.GroupBox2.Size = New System.Drawing.Size(136, 195)
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
            Me.btnClear.Location = New System.Drawing.Point(556, 328)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(48, 24)
            Me.btnClear.TabIndex = 19
            Me.btnClear.Text = "Clear"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Button1)
            Me.GroupBox3.Controls.Add(Me.Button2)
            Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox3.Location = New System.Drawing.Point(8, 222)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(134, 103)
            Me.GroupBox3.TabIndex = 20
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Computer commands"
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
            Me.GroupBox4.Controls.Add(Me.Button4)
            Me.GroupBox4.Controls.Add(Me.btnEmployeesGetAll)
            Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox4.Location = New System.Drawing.Point(471, 16)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(134, 75)
            Me.GroupBox4.TabIndex = 21
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Employees commands"
            '
            'btnEmployeesGetAll
            '
            Me.btnEmployeesGetAll.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEmployeesGetAll.Location = New System.Drawing.Point(24, 18)
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
            Me.GroupBox5.Location = New System.Drawing.Point(471, 97)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(134, 114)
            Me.GroupBox5.TabIndex = 22
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Event Commands"
            '
            'Button3
            '
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button3.Location = New System.Drawing.Point(24, 49)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(104, 40)
            Me.Button3.TabIndex = 11
            Me.Button3.Text = "EventGet Based on ID"
            '
            'btnEventGet
            '
            Me.btnEventGet.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnEventGet.Location = New System.Drawing.Point(24, 18)
            Me.btnEventGet.Name = "btnEventGet"
            Me.btnEventGet.Size = New System.Drawing.Size(104, 24)
            Me.btnEventGet.TabIndex = 10
            Me.btnEventGet.Text = "EventGetAll"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.btnApplicationGetMostPopular)
            Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox6.Location = New System.Drawing.Point(471, 211)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(134, 114)
            Me.GroupBox6.TabIndex = 23
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Application Commands"
            '
            'btnApplicationGetMostPopular
            '
            Me.btnApplicationGetMostPopular.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnApplicationGetMostPopular.Location = New System.Drawing.Point(24, 18)
            Me.btnApplicationGetMostPopular.Name = "btnApplicationGetMostPopular"
            Me.btnApplicationGetMostPopular.Size = New System.Drawing.Size(104, 55)
            Me.btnApplicationGetMostPopular.TabIndex = 10
            Me.btnApplicationGetMostPopular.Text = "ApplicationGetMostPopular"
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(24, 46)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(75, 23)
            Me.Button4.TabIndex = 11
            Me.Button4.Text = "New"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Main
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(612, 563)
            Me.Controls.Add(Me.GroupBox6)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtOutput)
            Me.Controls.Add(Me.StatusBar)
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private ActiveUser As Smartlaunch.TCPInterface.Users.User

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
                    txtOutput.Text &= "Email: " & .Email & NewLine
                    txtOutput.Text &= "Age: " & .Age & NewLine
                    txtOutput.Text &= "Time Status: " & .TimeStatus & NewLine
                    txtOutput.Text &= "Balance: " & .Balance & NewLine
                End With
            End If

            SetEnabledState()

        End Sub

        Private Sub btnLoginUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginUser.Click

            Dim username As String = InputBox("Please enter username", "Username", "test2")
            Dim passwd As String = InputBox("Please enter password", "Password", "test")

            ActiveUser = Smartlaunch.TCPInterface.Users.Login(username, passwd)

            If ActiveUser Is Nothing Then
                txtOutput.Text &= NewLine & NewLine & "Username or password was incorrect." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Login info correct... User loaded succesfully." & NewLine
            End If

            SetEnabledState()
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
            If ActiveUser.LogoutUser Then
                txtOutput.Text &= NewLine & NewLine & "User logout successfully." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "User logout failed." & NewLine
            End If

        End Sub

        Private Sub btnUpdateUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUserInfo.Click

            Dim fName As String = InputBox("Please enter first name", "First Name", "My first name")
            Dim lName As String = InputBox("Please enter last name", "Last  Name", "My last name")
            Dim address As String = InputBox("Please enter address name", "address", "My address")
            Dim city As String = InputBox("Please enter city", "city", "My city")
            Dim country As String = InputBox("Please enter country", "country", "My country")
            Dim email As String = InputBox("Please enter email address", "Email", "aaa@yahoo.com")

            If ActiveUser.UpdateUserInfo(email) Then
                txtOutput.Text &= NewLine & NewLine & "User Info updated successfully." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Failed to update User Info." & NewLine
            End If

        End Sub

        Private Sub btnSetPasswd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPasswd.Click

            Dim passwd As String = InputBox("Please enter new passwd.", "Password", "test")

            If ActiveUser.UserSetNewPassword(passwd) Then
                txtOutput.Text &= NewLine & NewLine & "New password set successfully." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Failed to set new password." & NewLine
            End If

        End Sub

        Private Sub btnLostPwSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLostPwSendMail.Click

            If ActiveUser.LostPasswdEmail() Then
                txtOutput.Text &= NewLine & NewLine & "Lost password email sent successfully." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Failed to sent lost password email." & NewLine
            End If

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAskAccDetails.Click

            If ActiveUser.SetAskPasswordAtNextLogin() Then
                txtOutput.Text &= NewLine & NewLine & "Ask account detail at next login." & NewLine
            Else
                txtOutput.Text &= NewLine & NewLine & "Error@Ask account detail at next login." & NewLine
            End If

        End Sub

        Private Sub btnEmployeesGetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeesGetAll.Click

            Dim employeeType As String = InputBox("Please enter Employee Type (use Admin if you are uncertain)", "Employee Type", "Admin")

            If employeeType <> "" Then
                Dim objGeneral As New General
                Dim xmlDoc As New XmlDocument

                xmlDoc = objGeneral.GetAllEmployees(employeeType)

                txtOutput.Text = xmlDoc.InnerXml

            Else
                MessageBox.Show("Please enter Employee Type.")
            End If

        End Sub

        Private Sub btnAddOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOffer.Click

            'This is just an example. Only for testing!!!
            Dim OfferID As Integer = InputBox("Please enter the OfferID (use 1 if you are uncertain)", "OfferID", 1)
            Dim Price As Double = InputBox("Please enter the Price (use 1 if you are uncertain)", "Price", 1)
            Dim PaymentType As String = InputBox("Please enter the PaymentType (use Cash if you are uncertain)", "PaymentType", "1")

            Dim FixedStart As Boolean = True
            Dim TheDate As Date = Date.Today
            Dim TaxPayable As Boolean = False

            ActiveUser.UserAddOffer(OfferID, Price, PaymentType, FixedStart, TheDate, TaxPayable)

            txtOutput.Text &= NewLine & NewLine & "Added offer successfully." & NewLine

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

        Private Sub btnCafeStatusGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCafeStatusGet.Click

            Dim employeeType As String = InputBox("Please enter Employee Type", "Employee Type", "Employee")

            Dim objGeneral As New General

            Dim xmlDoc As New XmlDocument
            xmlDoc = objGeneral.GetAllEmployees(employeeType)

            txtOutput.Text = xmlDoc.InnerXml

        End Sub

        Private Sub btnApplicationGetMostPopular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplicationGetMostPopular.Click

            Dim catName As String = InputBox("Please enter the Category Name (use Games if you uncertain)", "Category Name", "Games")
            Dim WithinDays As Integer = InputBox("Please enter the within days (use 1 if you unsure)", "WithinDays", 1)

            Dim objGen As New General

            Dim xmlDoc As New XmlDocument
            xmlDoc = objGen.ApplicationGetMostPopular(catName, WithinDays)

            txtOutput.Text = xmlDoc.InnerXml

        End Sub

        Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Dim xmlDoc As New XmlDocument

            'GetUserLogHistory
            'xmlDoc = ActiveUser.GetUserLogHistory()

            '"UserGetBill"
            xmlDoc = ActiveUser.UserGetBill()

            txtOutput.Text = xmlDoc.InnerXml

        End Sub
    End Class

End Namespace
