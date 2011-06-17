Namespace Classes

	Public Class XMLCommand

		Private X As New Xml.XmlDocument
		'Private MainNode As Xml.XmlNode
		Private ActiveNode As Xml.XmlNode
		Private ActiveParameter As Xml.XmlNode

		Public Sub New()
			X.AppendChild(X.CreateElement("SL", "root", "Smartlaunch"))
		End Sub

		Public Sub AppendCommand(ByVal cmd As String)
			ActiveNode = X.DocumentElement.AppendChild(X.CreateElement("Command"))
			ActiveNode.Attributes.Append(X.CreateAttribute("Name")).Value = cmd
		End Sub

		Public Sub AppendParameterSection()
			ActiveParameter = ActiveNode.AppendChild(X.CreateElement("Parameter"))
		End Sub

		Public Sub AppendParameter(ByVal Name As String, ByVal Value As Object)
			ActiveParameter.Attributes.Append(X.CreateAttribute(Name)).Value = Value.ToString()
		End Sub

		Public ReadOnly Property InnerXML() As String
			Get
				Return X.InnerXml
			End Get
		End Property

	End Class

End Namespace
