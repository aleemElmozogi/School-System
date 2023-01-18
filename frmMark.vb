Imports System.Data.SqlClient

Public Class frmMark

    Dim dt, dtStudent, dtCourses As New DataTable

    Sub fillDGV()
        dt.Rows.Clear()

        Dim rd As String = "select *  from marks "
        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dt)
        DGV.DataSource = dt
        DGV.Columns(0).HeaderText = "اسم الطالب"
        DGV.Columns(1).HeaderText = "اسم المادة"
        DGV.Columns(2).HeaderText = "الدرجة"
    End Sub
    Sub cmbCourses()
        Dim rd As String = "select * from courses "

        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dtCourses)
        coComboBox.DataSource = dtCourses
        coComboBox.DisplayMember = "label"
        coComboBox.ValueMember = "id"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dt.Rows.Clear()

        Dim rd As String = "select *  from marks "
        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dt)
        DGV.DataSource = dt

        Dim row As DataRow = dt.NewRow
        row(0) = stComboBox.Text
        row(1) = coComboBox.Text
        row(2) = mrTextBox.Text
        dt.Rows.Add(row)
        cmd = New SqlCommandBuilder(adapter)
        adapter.Update(dt)
        MsgBox("تمت عملية الاضافة بنجاح")
    End Sub

    Sub cmbStudent()
        Dim rd As String = "select * from student "
        adapter = New SqlDataAdapter(rd, con)
        adapter.Fill(dtStudent)
        stComboBox.DataSource = dtStudent
        stComboBox.DisplayMember = "Sname"
        stComboBox.ValueMember = "id"
    End Sub

    Private Sub frmMark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDGV()
        cmbStudent()
        cmbCourses()
    End Sub
End Class