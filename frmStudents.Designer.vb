<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim sCancelBtn As System.Windows.Forms.Button
        Dim sAddBtn As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button2 As System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGT = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        sCancelBtn = New System.Windows.Forms.Button()
        sAddBtn = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sCancelBtn
        '
        sCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        sCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        sCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        sCancelBtn.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        sCancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        sCancelBtn.Location = New System.Drawing.Point(171, 412)
        sCancelBtn.Name = "sCancelBtn"
        sCancelBtn.Size = New System.Drawing.Size(105, 37)
        sCancelBtn.TabIndex = 12
        sCancelBtn.Text = "حذف"
        sCancelBtn.UseMnemonic = False
        sCancelBtn.UseVisualStyleBackColor = False
        AddHandler sCancelBtn.Click, AddressOf Me.sCancelBtn_Click
        '
        'sAddBtn
        '
        sAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        sAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        sAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        sAddBtn.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        sAddBtn.ForeColor = System.Drawing.SystemColors.ControlText
        sAddBtn.Location = New System.Drawing.Point(31, 412)
        sAddBtn.Name = "sAddBtn"
        sAddBtn.Size = New System.Drawing.Size(105, 37)
        sAddBtn.TabIndex = 11
        sAddBtn.Text = "إضافة"
        sAddBtn.UseMnemonic = False
        sAddBtn.UseVisualStyleBackColor = False
        AddHandler sAddBtn.Click, AddressOf Me.sAddBtn_Click
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Button1.Location = New System.Drawing.Point(314, 412)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(105, 37)
        Button1.TabIndex = 11
        Button1.Text = "تعديل"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button2.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Button2.Location = New System.Drawing.Point(457, 412)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(105, 37)
        Button2.TabIndex = 12
        Button2.Text = "الغاء"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = False
        AddHandler Button2.Click, AddressOf Me.Button2_Click
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGT)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الطلبة المسجلين"
        '
        'DGT
        '
        Me.DGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGT.Location = New System.Drawing.Point(21, 92)
        Me.DGT.Name = "DGT"
        Me.DGT.ReadOnly = True
        Me.DGT.RowTemplate.Height = 25
        Me.DGT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGT.Size = New System.Drawing.Size(531, 254)
        Me.DGT.TabIndex = 9
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(21, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(486, 29)
        Me.txtSearch.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cairo SemiBold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(513, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "البحث"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 479)
        Me.Controls.Add(Button2)
        Me.Controls.Add(Button1)
        Me.Controls.Add(sCancelBtn)
        Me.Controls.Add(sAddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudents"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DGT As DataGridView
End Class
