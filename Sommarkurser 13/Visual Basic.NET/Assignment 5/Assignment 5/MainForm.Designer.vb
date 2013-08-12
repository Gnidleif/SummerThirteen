<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoRecords = New System.Windows.Forms.Label()
        Me.grpName.SuspendLayout()
        Me.grpAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.txtSurname)
        Me.grpName.Controls.Add(Me.txtFirstname)
        Me.grpName.Controls.Add(Me.Label4)
        Me.grpName.Controls.Add(Me.Label3)
        Me.grpName.Location = New System.Drawing.Point(12, 12)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(200, 79)
        Me.grpName.TabIndex = 0
        Me.grpName.TabStop = False
        Me.grpName.Text = "Name info"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(94, 45)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 15
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(94, 12)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "First name:"
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.cmbCountry)
        Me.grpAddress.Controls.Add(Me.txtZip)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.txtStreet)
        Me.grpAddress.Controls.Add(Me.Label8)
        Me.grpAddress.Controls.Add(Me.Label7)
        Me.grpAddress.Controls.Add(Me.Label6)
        Me.grpAddress.Controls.Add(Me.Label5)
        Me.grpAddress.Location = New System.Drawing.Point(12, 97)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(200, 115)
        Me.grpAddress.TabIndex = 1
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address Info"
        '
        'cmbCountry
        '
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(73, 91)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(121, 21)
        Me.cmbCountry.TabIndex = 17
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(94, 68)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 16
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(94, 44)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 15
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(94, 18)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Country:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Zip code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Street:"
        '
        'lstRecords
        '
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.Location = New System.Drawing.Point(12, 218)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(387, 95)
        Me.lstRecords.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(218, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 42)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(218, 60)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(99, 42)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(218, 108)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 42)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. of registered records:"
        '
        'lblNoRecords
        '
        Me.lblNoRecords.AutoSize = True
        Me.lblNoRecords.Location = New System.Drawing.Point(350, 199)
        Me.lblNoRecords.Name = "lblNoRecords"
        Me.lblNoRecords.Size = New System.Drawing.Size(13, 13)
        Me.lblNoRecords.TabIndex = 7
        Me.lblNoRecords.Text = "0"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 325)
        Me.Controls.Add(Me.lblNoRecords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.grpName)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpName As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstRecords As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNoRecords As System.Windows.Forms.Label

End Class
