
Imports System.ComponentModel

Public Class frmMain
    Public userName As String
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click



        If MsgBox("هل تريد الاغلاق", MsgBoxStyle.YesNo, "تأكيد الاغلاق") = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()


        End If

    End Sub



    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmAdd.Show()
    End Sub

    Private Sub btnstudents_Click(sender As Object, e As EventArgs) Handles btnstudents.Click
        frmStudents.Show()
    End Sub

    Private Sub btncources_Click(sender As Object, e As EventArgs) Handles btncources.Click
        frmCources.Show()

    End Sub

    Private Sub btnmarks_Click(sender As Object, e As EventArgs) Handles btnmarks.Click
        frmMark.ShowDialog()
    End Sub

    Private Sub tsstudents_Click(sender As Object, e As EventArgs) Handles tsstudents.Click
        btnstudents_Click(sender, e)
    End Sub

    Private Sub tscources_Click(sender As Object, e As EventArgs) Handles tscources.Click
        btncources_Click(Nothing, Nothing)
    End Sub

    Private Sub tsmarks_Click(sender As Object, e As EventArgs) Handles tsmarks.Click
        btnmarks_Click(Nothing, Nothing)
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        MsgBox("هذا البرنامج تدريبي لمادة البرمجة المرئية لسنة 2022")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ssname.Text = userName
        sstime.Text = Date.Now.ToString("HH,mm,ss")
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        If MsgBox("هل تريد الاغلاق", MsgBoxStyle.YesNo, "تأكيد الاغلاق") = DialogResult.Yes Then
            frmCources.Close()
            frmAdd.Close()
            frmStudents.Close()
            frmStudents.Close()
            frmLogin.Show()

        Else
            e.Cancel = True

        End If


    End Sub

    Private Sub sstime_Click(sender As Object, e As EventArgs) Handles sstime.Click

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
End Class