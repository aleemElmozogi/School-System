<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCources
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        sCancelBtn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sCancelBtn
        '
        sCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        sCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        sCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        sCancelBtn.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        sCancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        sCancelBtn.Location = New System.Drawing.Point(194, 355)
        sCancelBtn.Name = "sCancelBtn"
        sCancelBtn.Size = New System.Drawing.Size(105, 37)
        sCancelBtn.TabIndex = 11
        sCancelBtn.Text = "الغاء"
        sCancelBtn.UseMnemonic = False
        sCancelBtn.UseVisualStyleBackColor = False
        AddHandler sCancelBtn.Click, AddressOf Me.sCancelBtn_Click
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cairo Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(135, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "المواد الدراسية"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.UseWaitCursor = True
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(32, 59)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 25
        Me.DGV.Size = New System.Drawing.Size(311, 272)
        Me.DGV.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(83, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCources
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 428)
        Me.Controls.Add(sCancelBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCources"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button1 As Button
End Class
