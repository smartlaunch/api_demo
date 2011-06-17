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
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnClear As System.Windows.Forms.Button
        Friend WithEvents btnGetComputers As System.Windows.Forms.Button
        Friend WithEvents btnGetUserInfo As System.Windows.Forms.Button
        Friend WithEvents btnLoginUser As System.Windows.Forms.Button
        Friend WithEvents btnWithdrawMoney As System.Windows.Forms.Button
        Friend WithEvents btnDepositMoney As System.Windows.Forms.Button
        Friend WithEvents txtAmount As System.Windows.Forms.TextBox
        Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnGetPrice As System.Windows.Forms.Button
        Friend WithEvents btnTestConnection As System.Windows.Forms.Button
        Friend WithEvents Label6 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.btnGetNews = New System.Windows.Forms.Button
            Me.StatusBar = New System.Windows.Forms.StatusBar
            Me.txtOutput = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.btnGetComputers = New System.Windows.Forms.Button
            Me.btnGetUserInfo = New System.Windows.Forms.Button
            Me.btnLoginUser = New System.Windows.Forms.Button
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtUsername = New System.Windows.Forms.TextBox
            Me.txtPassword = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.btnGetPrice = New System.Windows.Forms.Button
            Me.txtMinutes = New System.Windows.Forms.TextBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.btnWithdrawMoney = New System.Windows.Forms.Button
            Me.txtAmount = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnDepositMoney = New System.Windows.Forms.Button
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.btnTestConnection = New System.Windows.Forms.Button
            Me.btnClear = New System.Windows.Forms.Button
            Me.Label6 = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnGetNews
            '
            Me.btnGetNews.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetNews.Location = New System.Drawing.Point(16, 144)
            Me.btnGetNews.Name = "btnGetNews"
            Me.btnGetNews.Size = New System.Drawing.Size(104, 24)
            Me.btnGetNews.TabIndex = 6
            Me.btnGetNews.Text = "Get News"
            '
            'StatusBar
            '
            Me.StatusBar.Location = New System.Drawing.Point(0, 544)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Size = New System.Drawing.Size(520, 22)
            Me.StatusBar.TabIndex = 7
            '
            'txtOutput
            '
            Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOutput.Location = New System.Drawing.Point(8, 272)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtOutput.Size = New System.Drawing.Size(504, 264)
            Me.txtOutput.TabIndex = 8
            Me.txtOutput.Text = ""
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(8, 248)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(144, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Messages:"
            '
            'btnGetComputers
            '
            Me.btnGetComputers.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetComputers.Location = New System.Drawing.Point(16, 176)
            Me.btnGetComputers.Name = "btnGetComputers"
            Me.btnGetComputers.Size = New System.Drawing.Size(104, 24)
            Me.btnGetComputers.TabIndex = 10
            Me.btnGetComputers.Text = "Get Computers"
            '
            'btnGetUserInfo
            '
            Me.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetUserInfo.Location = New System.Drawing.Point(232, 56)
            Me.btnGetUserInfo.Name = "btnGetUserInfo"
            Me.btnGetUserInfo.Size = New System.Drawing.Size(104, 24)
            Me.btnGetUserInfo.TabIndex = 11
            Me.btnGetUserInfo.Text = "Get User Info"
            '
            'btnLoginUser
            '
            Me.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnLoginUser.Location = New System.Drawing.Point(232, 24)
            Me.btnLoginUser.Name = "btnLoginUser"
            Me.btnLoginUser.Size = New System.Drawing.Size(104, 24)
            Me.btnLoginUser.TabIndex = 12
            Me.btnLoginUser.Text = "Login User"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(16, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 16)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Username:"
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(16, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 16)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Password:"
            '
            'txtUsername
            '
            Me.txtUsername.Location = New System.Drawing.Point(120, 24)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(104, 20)
            Me.txtUsername.TabIndex = 15
            Me.txtUsername.Text = "test"
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(120, 48)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(104, 20)
            Me.txtPassword.TabIndex = 16
            Me.txtPassword.Text = "test"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnGetPrice)
            Me.GroupBox1.Controls.Add(Me.txtMinutes)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.btnWithdrawMoney)
            Me.GroupBox1.Controls.Add(Me.txtAmount)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.btnDepositMoney)
            Me.GroupBox1.Controls.Add(Me.txtPassword)
            Me.GroupBox1.Controls.Add(Me.txtUsername)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.btnGetUserInfo)
            Me.GroupBox1.Controls.Add(Me.btnLoginUser)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(160, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(352, 216)
            Me.GroupBox1.TabIndex = 17
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "User handling"
            '
            'btnGetPrice
            '
            Me.btnGetPrice.Enabled = False
            Me.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnGetPrice.Location = New System.Drawing.Point(232, 176)
            Me.btnGetPrice.Name = "btnGetPrice"
            Me.btnGetPrice.Size = New System.Drawing.Size(104, 24)
            Me.btnGetPrice.TabIndex = 23
            Me.btnGetPrice.Text = "Get Price"
            '
            'txtMinutes
            '
            Me.txtMinutes.Location = New System.Drawing.Point(120, 176)
            Me.txtMinutes.Name = "txtMinutes"
            Me.txtMinutes.Size = New System.Drawing.Size(104, 20)
            Me.txtMinutes.TabIndex = 22
            Me.txtMinutes.Text = "60"
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(16, 176)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(96, 16)
            Me.Label5.TabIndex = 21
            Me.Label5.Text = "Minutes:"
            '
            'btnWithdrawMoney
            '
            Me.btnWithdrawMoney.Enabled = False
            Me.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnWithdrawMoney.Location = New System.Drawing.Point(232, 136)
            Me.btnWithdrawMoney.Name = "btnWithdrawMoney"
            Me.btnWithdrawMoney.Size = New System.Drawing.Size(104, 24)
            Me.btnWithdrawMoney.TabIndex = 20
            Me.btnWithdrawMoney.Text = "Withdraw money"
            '
            'txtAmount
            '
            Me.txtAmount.Location = New System.Drawing.Point(120, 104)
            Me.txtAmount.Name = "txtAmount"
            Me.txtAmount.Size = New System.Drawing.Size(104, 20)
            Me.txtAmount.TabIndex = 19
            Me.txtAmount.Text = "5"
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(16, 104)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 16)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "Amount:"
            '
            'btnDepositMoney
            '
            Me.btnDepositMoney.Enabled = False
            Me.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnDepositMoney.Location = New System.Drawing.Point(232, 104)
            Me.btnDepositMoney.Name = "btnDepositMoney"
            Me.btnDepositMoney.Size = New System.Drawing.Size(104, 24)
            Me.btnDepositMoney.TabIndex = 17
            Me.btnDepositMoney.Text = "Deposit money"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.btnTestConnection)
            Me.GroupBox2.Controls.Add(Me.btnGetComputers)
            Me.GroupBox2.Controls.Add(Me.btnGetNews)
            Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(136, 216)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "General commands"
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
            Me.btnClear.Location = New System.Drawing.Point(464, 240)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(48, 24)
            Me.btnClear.TabIndex = 19
            Me.btnClear.Text = "Clear"
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(16, 64)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 56)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Modify connection details in the App.Config file."
            '
            'Main
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(520, 566)
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
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private ActiveUser As Smartlaunch.TCPInterface.Users.User

        Private Sub btnGetNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNews.Click

            Try

                txtOutput.Text &= NewLine & NewLine & "News: " & NewLine
                For Each N As Smartlaunch.TCPInterface.News.NewsItem In Smartlaunch.TCPInterface.News.Items
                    txtOutput.Text &= N.DateTimeAdded.ToLongDateString & "     " & N.Headline & NewLine
                Next

                txtOutput.Text &= NewLine & "Events: " & NewLine
                For Each Ev As Smartlaunch.TCPInterface.Events.EventItem In Smartlaunch.TCPInterface.Events.Items
                    txtOutput.Text &= Ev.EventID & "   " & Ev.HeadLine & "   " & Ev.DateTimeAdded & "  " & NewLine
                Next

            Catch ex As SmartlaunchWebInterfaceException
                txtOutput.Text &= NewLine & NewLine & "Error ocurred: " & ex.Message
            End Try

        End Sub

        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            txtOutput.Text = ""
        End Sub


        Private Sub btnGetComputers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetComputers.Click
            txtOutput.Text &= NewLine & NewLine & "Computers: " & NewLine
            For Each C As Smartlaunch.TCPInterface.Computers.Computer In Smartlaunch.TCPInterface.Computers.Items
                txtOutput.Text &= C.ComputerID & "    " & C.Name & "          Console Type: " & C.Type.ToString & "        Group ID: " & C.GroupID & "         X: " & C.PositionX & "  Y: " & C.PositionY & NewLine
            Next
        End Sub

        Private Sub btnGetUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetUserInfo.Click
            ActiveUser = New Smartlaunch.TCPInterface.Users.User(txtUsername.Text)


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
            ActiveUser = Smartlaunch.TCPInterface.Users.Login(txtUsername.Text, txtPassword.Text)

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

        End Sub


        Private Sub btnDepositMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositMoney.Click
            ActiveUser.DepositMoney(CDbl(txtAmount.Text))

            txtOutput.Text &= NewLine & NewLine & "Money deposited." & NewLine
        End Sub

        Private Sub btnWithdrawMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdrawMoney.Click
            ActiveUser.WithdrawMoney(CDbl(txtAmount.Text))

            txtOutput.Text &= NewLine & NewLine & "Money withdrawed." & NewLine
        End Sub


        Private Sub btnGetPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPrice.Click
            Dim Price As Double = ActiveUser.GetPriceForTime(CInt(txtMinutes.Text))

            txtOutput.Text &= NewLine & NewLine & "Users price for " & txtMinutes.Text & " minutes is: " & FormatCurrency(Price) & NewLine
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
    End Class

End Namespace
