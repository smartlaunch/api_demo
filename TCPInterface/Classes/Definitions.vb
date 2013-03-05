
Namespace Classes

	Friend Class Definitions

		Friend Const DlM As Char = "^"c
		Friend Const DlMSep As Char = "|"c
        Friend Const DlMSep2 As Char = ";"c

	End Class

    Friend Class Variable
        Public Enum Paymode
            Later = 0
            Cash = 1
            Payment1 = 2
            Payment2 = 3
            Withdraw = 4
            Save = 5
            NA = -1
        End Enum
    End Class
End Namespace