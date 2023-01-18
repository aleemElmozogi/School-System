<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sBirthDay = New System.Windows.Forms.DateTimePicker()
        Me.sAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        sCancelBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sCancelBtn
        '
        sCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        sCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        sCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        sCancelBtn.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        sCancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        sCancelBtn.Location = New System.Drawing.Point(205, 294)
        sCancelBtn.Name = "sCancelBtn"
        sCancelBtn.Size = New System.Drawing.Size(105, 37)
        sCancelBtn.TabIndex = 10
        sCancelBtn.Text = "الغاء"
        sCancelBtn.UseMnemonic = False
        sCancelBtn.UseVisualStyleBackColor = False
        AddHandler sCancelBtn.Click, AddressOf Me.sCancelBtn_Click
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.sBirthDay)
        Me.Panel1.Controls.Add(Me.sAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.sName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(40, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 189)
        Me.Panel1.TabIndex = 0
        '
        'sBirthDay
        '
        Me.sBirthDay.Location = New System.Drawing.Point(46, 145)
        Me.sBirthDay.Name = "sBirthDay"
        Me.sBirthDay.Size = New System.Drawing.Size(173, 23)
        Me.sBirthDay.TabIndex = 9
        '
        'sAddress
        '
        Me.sAddress.Location = New System.Drawing.Point(46, 93)
        Me.sAddress.Name = "sAddress"
        Me.sAddress.Size = New System.Drawing.Size(173, 23)
        Me.sAddress.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(150, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "تاريخ الميلاد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'sName
        '
        Me.sName.Location = New System.Drawing.Point(46, 39)
        Me.sName.Name = "sName"
        Me.sName.Size = New System.Drawing.Size(173, 23)
        Me.sName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(173, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "العنوان"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cairo SemiBold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(180, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "الاسم"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cairo Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(130, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "إضافة طالب"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cairo Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(94, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "إضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(375, 370)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(sCancelBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.name = "frmAdd"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents sAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sBirthDay As DateTimePicker
    Friend WithEvents sCancelBtn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
End Class
