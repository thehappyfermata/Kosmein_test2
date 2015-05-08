Imports System.Data.Entity

Namespace Models

    Public Class Product
        Public Property ID As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property Remaining As Integer
        Public Property Price As Decimal
    End Class

    Public Class ProductDbContext
        Inherits DbContext

        Public Property Product As DbSet(Of Product)
    End Class
End Namespace
