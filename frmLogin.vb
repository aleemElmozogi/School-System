Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dt.Clear()
        adapter = New SqlDataAdapter("select * from users where id ='" & TextBox1.Text & "'and password =  '" & TextBox2.Text & "' ", con)
        adapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            frmMain.userName = TextBox1.Text
            frmMain.Show()
            Me.Close()

        Else
            MsgBox("اسم المستخذم او كلمة المرور غير صحيحة", MsgBoxStyle.Information, "فشل")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MsgBox("هل تريد الاغلاق", MsgBoxStyle.YesNo, "تأكيد الاغلاق") = DialogResult.Yes Then
            Me.Close()

            If DialogResult.No Then

            End If


        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class
