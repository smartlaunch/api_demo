Imports System.Configuration

Namespace Classes

    Friend Class Settings

        Friend Shared ReadOnly Property ServerIP() As String
            Get
                Return ConfigurationSettings.AppSettings("Smartlaunch_ServerIP")
            End Get
        End Property

        Friend Shared ReadOnly Property ServerPort() As Integer
            Get
                Return Convert.ToInt32(ConfigurationSettings.AppSettings("Smartlaunch_ServerPort"))
            End Get
        End Property

        Friend Shared ReadOnly Property ServerUsername() As String
            Get
                Return ConfigurationSettings.AppSettings("Smartlaunch_ServerUsername")
            End Get
        End Property

        Friend Shared ReadOnly Property ServerPassword() As String
            Get
                Return ConfigurationSettings.AppSettings("Smartlaunch_ServerPassword")
            End Get
        End Property

		Friend Shared ReadOnly Property UpdateIntervalNews() As Integer
			Get
                Return Convert.ToInt32(ConfigurationSettings.AppSettings("Smartlaunch_UpdateIntervalNews"))
			End Get
		End Property

        Friend Shared ReadOnly Property UpdateIntervalComputers() As Integer
            Get
                Return Convert.ToInt32(ConfigurationSettings.AppSettings("Smartlaunch_UpdateIntervalComputers"))
            End Get
        End Property

        Friend Shared ReadOnly Property ComputerLayoutGroupName() As String
            Get
                Return ConfigurationSettings.AppSettings("Smartlaunch_ComputerLayoutGroupName")
            End Get
        End Property


    End Class
End Namespace