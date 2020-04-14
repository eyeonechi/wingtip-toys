Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Diagnostics
Imports WingtipToys.Logic

Partial Public Class AddToCart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rawId As String = Request.QueryString("ProductID")
        Dim productId As Integer
        If Not String.IsNullOrEmpty(rawId) And Integer.TryParse(rawId, productId) Then
            Using usersShoppingCart As ShoppingCartActions = New ShoppingCartActions()
                usersShoppingCart.AddToCart(Convert.ToInt16(rawId))
            End Using
        Else
            Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ProductId")
            Throw New Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId")
        End If
        Response.Redirect("ShoppingCart.aspx")
    End Sub

End Class
