Imports System.Data.SqlClient

Public Class frmAdd
    Public opperation As String = "add"
    Public id As Integer
    Public name As String
    Public address As String
    Public sDate As Date


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If opperation = "edith" Then
            sName.Text = name
            sAddress.Text = address
            sBirthDay.Value = sDate
        Else
            sName.Clear()
            sAddress.Clear()
            sBirthDay.ResetText()
        End If

    End Sub

    Private Sub sCancelBtn_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If opperation = "add" Then
                adapter = New SqlDataAdapter("select * from student", con)
                adapter.Fill(dt)
                Dim row As DataRow = dt.NewRow

                row(2) = sName.Text
                row(3) = sAddress.Text
                row(4) = sBirthDay.Value.ToString("yyyy - MM - dd")
                dt.Rows.Add(row)
                cmd = New SqlCommandBuilder(adapter)
                adapter.Update(dt)
                MsgBox("تمت عملية الاضافة بنجاح ", MsgBoxStyle.Information, "نجاح")
                sName.Clear()
                sAddress.Clear()
                sBirthDay.ResetText()
            Else
                dt.Clear()
                adapter = New SqlDataAdapter("select * from student", con)
                adapter.Fill(dt)
                If dt.Constraints.Contains("primary") Then

                Else
                    dt.Constraints.Add("primary", dt.Columns(0), True)

                End If

                Dim row As DataRow = dt.Rows.Find(id)

                row(1) = id
                row(2) = sName.Text
                row(3) = sAddress.Text
                row(4) = sBirthDay.Value.ToString("yyyy-MM-dd")
                cmd = New SqlCommandBuilder(adapter)
                adapter.Update(dt)
                MsgBox("تمت عملية التحديث بنجاح")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "فشل")

        End Try
    End Sub
End Class