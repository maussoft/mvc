﻿Imports System.Reflection

Public Class Application
	Public Shared Sub Main()
		Dim w as New WebServer(Of Session)("appsettings.json")
		w.Run()
	End Sub
End Class
