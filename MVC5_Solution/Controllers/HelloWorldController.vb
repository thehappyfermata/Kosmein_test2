Imports System.Web.Mvc

Public Class HelloWorldController
    Inherits Controller

    ' GET: /HelloWorld
    Function Index() As ActionResult
        Return View()
    End Function

    'GET: /HelloWorld/Welcome/
    Function Welcome(name As String, Optional numTimes As Integer = 4) As ActionResult
        ViewBag.Message = "Hello " & name
        ViewBag.NumTimes = numTimes
        Return View() 'HttpUtility.HtmlEncode("Hello " & name & ", ID: " & ID)
    End Function
End Class