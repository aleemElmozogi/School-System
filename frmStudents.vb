Imports System.Data.SqlClient

Public Class frmStudents


    Dim dt As New DataTable
    Sub DGVFILL()
        dt.Clear()
        Dim rd As String = "select *  from student "
        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dt)
        DGT.DataSource = dt

        DGT.Columns(0).HeaderText = "الرقم"
        DGT.Columns(1).HeaderText = "الاسم"
        DGT.Columns(2).HeaderText = "العنوان"
        DGT.Columns(3).HeaderText = "التاريخ"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub sAddBtn_Click(sender As Object, e As EventArgs)
        frmAdd.opperation = "add"
        frmAdd.Label3.Text = "اضافة بيانات طالب"
        frmAdd.Button1.Text = "اضافة"
        frmAdd.ShowDialog()
        DGVFILL()
    End Sub


    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVFILL()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " Sname + address + address + birthday like '%" & txtSearch.Text & "%'"
            DGT.DataSource = dv
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmAdd.opperation = "edith"
        frmAdd.id = DGT.CurrentRow.Cells(0).Value
        frmAdd.Label3.Text = "تعديل بيانات الطالب: " & DGT.CurrentRow.Cells(1).Value
        frmAdd.Button1.Text = "تعديل"
        frmAdd.name = DGT.CurrentRow.Cells(1).Value
        frmAdd.address = DGT.CurrentRow.Cells(2).Value
        frmAdd.sDate = DGT.CurrentRow.Cells(3).Value

        frmAdd.ShowDialog()
        DGVFILL()
    End Sub

    Private Sub sCancelBtn_Click(sender As Object, e As EventArgs)
        If dt.Constraints.Contains("primary") Then

        Else
            dt.Constraints.Add("primary", dt.Columns(0), True)

        End If

        Dim row As DataRow = dt.Rows.Find(DGT.CurrentRow.Cells(0).Value)
        If row Is Nothing Then
        Else
            If MsgBox(" :هل تريد حذف الطالب" & DGT.CurrentRow.Cells(1).Value, MsgBoxStyle.YesNo, "تأكيد الحذف") = DialogResult.Yes Then
                row.Delete()
                cmd = New SqlCommandBuilder(adapter)
                adapter.Update(dt)
                MsgBox("تمت عملية الحذف بنجاح")
            End If
        End If

    End Sub
End Class