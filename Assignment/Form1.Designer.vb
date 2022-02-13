<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblOtherName = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblHomeAddr = New System.Windows.Forms.Label()
        Me.lblNOK = New System.Windows.Forms.Label()
        Me.lblRelationshipNOK = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.txtRelationshipNOK = New System.Windows.Forms.TextBox()
        Me.txtNOK = New System.Windows.Forms.TextBox()
        Me.txtHomeAddr = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(23, 24)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 19)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(23, 50)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(71, 19)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname"
        '
        'lblOtherName
        '
        Me.lblOtherName.AutoSize = True
        Me.lblOtherName.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherName.Location = New System.Drawing.Point(23, 76)
        Me.lblOtherName.Name = "lblOtherName"
        Me.lblOtherName.Size = New System.Drawing.Size(95, 19)
        Me.lblOtherName.TabIndex = 2
        Me.lblOtherName.Text = "Other Name"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(23, 134)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(94, 19)
        Me.lblDepartment.TabIndex = 3
        Me.lblDepartment.Text = "Department"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(23, 160)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 19)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(23, 186)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(60, 19)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(23, 212)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(105, 19)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(23, 238)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(112, 19)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone number"
        '
        'lblHomeAddr
        '
        Me.lblHomeAddr.AutoSize = True
        Me.lblHomeAddr.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAddr.Location = New System.Drawing.Point(23, 264)
        Me.lblHomeAddr.Name = "lblHomeAddr"
        Me.lblHomeAddr.Size = New System.Drawing.Size(109, 19)
        Me.lblHomeAddr.TabIndex = 8
        Me.lblHomeAddr.Text = "Home address"
        '
        'lblNOK
        '
        Me.lblNOK.AutoSize = True
        Me.lblNOK.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOK.Location = New System.Drawing.Point(23, 290)
        Me.lblNOK.Name = "lblNOK"
        Me.lblNOK.Size = New System.Drawing.Size(89, 19)
        Me.lblNOK.TabIndex = 9
        Me.lblNOK.Text = "Next of Kin"
        '
        'lblRelationshipNOK
        '
        Me.lblRelationshipNOK.AutoSize = True
        Me.lblRelationshipNOK.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelationshipNOK.Location = New System.Drawing.Point(23, 316)
        Me.lblRelationshipNOK.Name = "lblRelationshipNOK"
        Me.lblRelationshipNOK.Size = New System.Drawing.Size(215, 19)
        Me.lblRelationshipNOK.TabIndex = 10
        Me.lblRelationshipNOK.Text = "Relationship with Next of Kin"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(244, 24)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(244, 50)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 20)
        Me.txtSurname.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(244, 212)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtOtherName
        '
        Me.txtOtherName.Location = New System.Drawing.Point(244, 76)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(200, 20)
        Me.txtOtherName.TabIndex = 19
        '
        'txtRelationshipNOK
        '
        Me.txtRelationshipNOK.Location = New System.Drawing.Point(244, 316)
        Me.txtRelationshipNOK.Name = "txtRelationshipNOK"
        Me.txtRelationshipNOK.Size = New System.Drawing.Size(200, 20)
        Me.txtRelationshipNOK.TabIndex = 20
        '
        'txtNOK
        '
        Me.txtNOK.Location = New System.Drawing.Point(244, 290)
        Me.txtNOK.Name = "txtNOK"
        Me.txtNOK.Size = New System.Drawing.Size(200, 20)
        Me.txtNOK.TabIndex = 21
        '
        'txtHomeAddr
        '
        Me.txtHomeAddr.Location = New System.Drawing.Point(244, 264)
        Me.txtHomeAddr.Name = "txtHomeAddr"
        Me.txtHomeAddr.Size = New System.Drawing.Size(200, 20)
        Me.txtHomeAddr.TabIndex = 22
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(244, 238)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 20)
        Me.txtPhone.TabIndex = 23
        '
        'cmbDepartment
        '
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Human Resources", "Research", "Administration", "Development", "Testing"})
        Me.cmbDepartment.Location = New System.Drawing.Point(244, 133)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(200, 21)
        Me.cmbDepartment.TabIndex = 24
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(244, 160)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbStatus.TabIndex = 25
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(244, 187)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 21)
        Me.cmbGender.TabIndex = 26
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(27, 351)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(417, 40)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(23, 103)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(99, 19)
        Me.lblDOB.TabIndex = 28
        Me.lblDOB.Text = "Date of birth"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = ""
        Me.dtpDOB.Location = New System.Drawing.Point(244, 107)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 30
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(72, 409)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(118, 20)
        Me.txtAge.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Age"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 454)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtHomeAddr)
        Me.Controls.Add(Me.txtNOK)
        Me.Controls.Add(Me.txtRelationshipNOK)
        Me.Controls.Add(Me.txtOtherName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblRelationshipNOK)
        Me.Controls.Add(Me.lblNOK)
        Me.Controls.Add(Me.lblHomeAddr)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblOtherName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblOtherName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblHomeAddr As Label
    Friend WithEvents lblNOK As Label
    Friend WithEvents lblRelationshipNOK As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtOtherName As TextBox
    Friend WithEvents txtRelationshipNOK As TextBox
    Friend WithEvents txtNOK As TextBox
    Friend WithEvents txtHomeAddr As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblDOB As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
End Class
