<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRegNum = New System.Windows.Forms.TextBox()
        Me.lblSports = New System.Windows.Forms.Label()
        Me.lblSpecialisation = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRegNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(346, 239)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox3.TabIndex = 31
        Me.CheckBox3.Text = "Rugby"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(275, 242)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "Tennis"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(198, 243)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Football"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(346, 196)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton3.TabIndex = 28
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Software"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(275, 196)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 27
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Network"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(198, 196)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hardware"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Certificate", "Diploma", "Degree"})
        Me.ComboBox1.Location = New System.Drawing.Point(198, 149)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 20)
        Me.TextBox1.TabIndex = 24
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(198, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(205, 20)
        Me.txtName.TabIndex = 23
        '
        'txtRegNum
        '
        Me.txtRegNum.Location = New System.Drawing.Point(198, 7)
        Me.txtRegNum.Name = "txtRegNum"
        Me.txtRegNum.Size = New System.Drawing.Size(205, 20)
        Me.txtRegNum.TabIndex = 22
        '
        'lblSports
        '
        Me.lblSports.AutoSize = True
        Me.lblSports.Location = New System.Drawing.Point(7, 243)
        Me.lblSports.Name = "lblSports"
        Me.lblSports.Size = New System.Drawing.Size(43, 13)
        Me.lblSports.TabIndex = 21
        Me.lblSports.Text = "Sports: "
        '
        'lblSpecialisation
        '
        Me.lblSpecialisation.AutoSize = True
        Me.lblSpecialisation.Location = New System.Drawing.Point(7, 200)
        Me.lblSpecialisation.Name = "lblSpecialisation"
        Me.lblSpecialisation.Size = New System.Drawing.Size(75, 13)
        Me.lblSpecialisation.TabIndex = 20
        Me.lblSpecialisation.Text = "Specialisation:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(7, 157)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(39, 13)
        Me.lblLevel.TabIndex = 19
        Me.lblLevel.Text = "Level: "
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(7, 105)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(72, 13)
        Me.lblDOB.TabIndex = 18
        Me.lblDOB.Text = "Date of Birth: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 59)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name: "
        '
        'lblRegNum
        '
        Me.lblRegNum.AutoSize = True
        Me.lblRegNum.Location = New System.Drawing.Point(7, 14)
        Me.lblRegNum.Name = "lblRegNum"
        Me.lblRegNum.Size = New System.Drawing.Size(106, 13)
        Me.lblRegNum.TabIndex = 16
        Me.lblRegNum.Text = "Registration Number:"
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 273)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRegNum)
        Me.Controls.Add(Me.lblSports)
        Me.Controls.Add(Me.lblSpecialisation)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRegNum)
        Me.Name = "frmRegistration"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents lblSports As Label
    Friend WithEvents lblSpecialisation As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRegNum As Label
End Class
