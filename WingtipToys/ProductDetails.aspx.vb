Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.ModelBinding
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports WingtipToys.Models

Partial Public Class ProductDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function GetProduct(<QueryString("productID")> productId As Integer?) As IQueryable(Of Product)
        Dim _db = New ProductContext()
        Dim query As IQueryable(Of Product) = _db.Products
        If (productId.HasValue And productId > 0) Then
            query = query.Where(Function(p) p.ProductID = productId)
        Else
            query = Nothing
        End If
        Return query
    End Function

End Class
