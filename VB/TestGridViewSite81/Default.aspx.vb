Imports System
Imports System.Data
Imports DevExpress.Web
Imports DevExpress.Data


Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub ASPxGridView1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            DirectCast(sender, ASPxGridView).FocusedRowIndex = -1
        End If
    End Sub
End Class
