Imports System.Data.SqlClient

Module connctionModule

    Public con As New SqlConnection("server=DESKTOP-2DHSDHI\SQLEXPRESS;database=students;integrated security=true")
    Public adapter As SqlDataAdapter
    Public dt As New DataTable
    Public cmd As New SqlCommandBuilder
End Module
