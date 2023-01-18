<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMark
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
        Dim Button2 As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.mrTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stComboBox = New System.Windows.Forms.ComboBox()
        Me.coComboBox = New System.Windows.Forms.ComboBox()
        Button2 = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button2.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Button2.Location = New System.Drawing.Point(142, 240)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(105, 37)
        Button2.TabIndex = 20
        Button2.Text = "إلغاء"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = False
        AddHandler Button2.Click, AddressOf Me.Button2_Click
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Button1.Location = New System.Drawing.Point(31, 240)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(105, 37)
        Button1.TabIndex = 19
        Button1.Text = "إضافة"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(279, 22)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 25
        Me.DGV.Size = New System.Drawing.Size(291, 255)
        Me.DGV.TabIndex = 0
        '
        'mrTextBox
        '
        Me.mrTextBox.Location = New System.Drawing.Point(56, 193)
        Me.mrTextBox.Name = "mrTextBox"
        Me.mrTextBox.Size = New System.Drawing.Size(173, 23)
        Me.mrTextBox.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(56, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "الدرجة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(56, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "اسم الطالب"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cairo Black", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(56, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "إضافة درجات الطلبة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(56, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "اسم المادة"
        '
        'stComboBox
        '
        Me.stComboBox.FormattingEnabled = True
        Me.stComboBox.Location = New System.Drawing.Point(56, 89)
        Me.stComboBox.Name = "stComboBox"
        Me.stComboBox.Size = New System.Drawing.Size(173, 23)
        Me.stComboBox.TabIndex = 21
        '
        'coComboBox
        '
        Me.coComboBox.FormattingEnabled = True
        Me.coComboBox.Location = New System.Drawing.Point(56, 141)
        Me.coComboBox.Name = "coComboBox"
        Me.coComboBox.Size = New System.Drawing.Size(173, 23)
        Me.coComboBox.TabIndex = 21
        '
        'frmMark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 302)
        Me.Controls.Add(Me.coComboBox)
        Me.Controls.Add(Me.stComboBox)
        Me.Controls.Add(Button2)
        Me.Controls.Add(Button1)
        Me.Controls.Add(Me.mrTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMark"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents mrTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents stComboBox As ComboBox
    Friend WithEvents coComboBox As ComboBox
End Class
