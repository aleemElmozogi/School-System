Imports System.Data.SqlClient
Public Class frmCources
    Dim dt As New DataTable

    Sub fillDGV()
        Dim rd As String = "select id,label  from courses "

        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dt)
        DGV.DataSource = dt
        DGV.Columns(0).Visible = False
        Me.DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).HeaderText = "العنوان"
    End Sub
    Private Sub frmCources_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDGV()
    End Sub

    Private Sub sCancelBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = New SqlCommandBuilder(adapter)
            adapter.Update(dt)
            MsgBox("تمت عملية الاضافة بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class