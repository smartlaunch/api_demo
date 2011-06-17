
Namespace Classes

    Friend Class Log

        Public Shared Event LogEntry(ByVal Message As String)

        Friend Shared Sub Add(ByVal Message As String)
            RaiseEvent LogEntry(Message)
        End Sub

        Friend Shared Sub AddError(ByVal Message As String)
            Throw (New SmartlaunchWebInterfaceException(Message))
        End Sub

    End Class

End Namespace