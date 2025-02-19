﻿Imports System.Data.Entity

Namespace Models

    Public Class ProductContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("WingtipToys")
        End Sub

        Public Property Categories() As DbSet(Of Category)

        Public Property Products() As DbSet(Of Product)

        Public Property ShoppingCartItems() As DbSet(Of CartItem)

    End Class

End Namespace
