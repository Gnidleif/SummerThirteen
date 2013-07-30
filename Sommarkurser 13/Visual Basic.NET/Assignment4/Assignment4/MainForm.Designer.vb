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
        Me.lstReservations = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.RbtnCancel = New System.Windows.Forms.RadioButton()
        Me.RbtnReserve = New System.Windows.Forms.RadioButton()
        Me.OutputBox = New System.Windows.Forms.GroupBox()
        Me.lblVacant = New System.Windows.Forms.Label()
        Me.lblReserved = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.InputBox.SuspendLayout()
        Me.OutputBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstReservations
        '
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.Location = New System.Drawing.Point(286, 25)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.Size = New System.Drawing.Size(253, 225)
        Me.lstReservations.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price"
        '
        'InputBox
        '
        Me.InputBox.Controls.Add(Me.Label6)
        Me.InputBox.Controls.Add(Me.Label5)
        Me.InputBox.Controls.Add(Me.txtPrice)
        Me.InputBox.Controls.Add(Me.txtName)
        Me.InputBox.Controls.Add(Me.RbtnCancel)
        Me.InputBox.Controls.Add(Me.RbtnReserve)
        Me.InputBox.Location = New System.Drawing.Point(12, 25)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(268, 89)
        Me.InputBox.TabIndex = 5
        Me.InputBox.TabStop = False
        Me.InputBox.Text = "Input Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(162, 63)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'RbtnCancel
        '
        Me.RbtnCancel.AutoSize = True
        Me.RbtnCancel.Location = New System.Drawing.Point(172, 19)
        Me.RbtnCancel.Name = "RbtnCancel"
        Me.RbtnCancel.Size = New System.Drawing.Size(91, 17)
        Me.RbtnCancel.TabIndex = 1
        Me.RbtnCancel.TabStop = True
        Me.RbtnCancel.Text = "Cancel Ticket"
        Me.RbtnCancel.UseVisualStyleBackColor = True
        '
        'RbtnReserve
        '
        Me.RbtnReserve.AutoSize = True
        Me.RbtnReserve.Location = New System.Drawing.Point(6, 19)
        Me.RbtnReserve.Name = "RbtnReserve"
        Me.RbtnReserve.Size = New System.Drawing.Size(98, 17)
        Me.RbtnReserve.TabIndex = 0
        Me.RbtnReserve.TabStop = True
        Me.RbtnReserve.Text = "Reserve Ticket"
        Me.RbtnReserve.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        Me.OutputBox.Controls.Add(Me.lblVacant)
        Me.OutputBox.Controls.Add(Me.lblReserved)
        Me.OutputBox.Controls.Add(Me.lblTotal)
        Me.OutputBox.Location = New System.Drawing.Point(12, 149)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(268, 100)
        Me.OutputBox.TabIndex = 6
        Me.OutputBox.TabStop = False
        Me.OutputBox.Text = "Output Data"
        '
        'lblVacant
        '
        Me.lblVacant.AutoSize = True
        Me.lblVacant.Location = New System.Drawing.Point(6, 74)
        Me.lblVacant.Name = "lblVacant"
        Me.lblVacant.Size = New System.Drawing.Size(39, 13)
        Me.lblVacant.TabIndex = 8
        Me.lblVacant.Text = "Label9"
        '
        'lblReserved
        '
        Me.lblReserved.AutoSize = True
        Me.lblReserved.Location = New System.Drawing.Point(6, 49)
        Me.lblReserved.Name = "lblReserved"
        Me.lblReserved.Size = New System.Drawing.Size(39, 13)
        Me.lblReserved.TabIndex = 7
        Me.lblReserved.Text = "Label8"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(6, 26)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Label7"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(113, 120)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 261)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.InputBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReservations)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.InputBox.ResumeLayout(False)
        Me.InputBox.PerformLayout()
        Me.OutputBox.ResumeLayout(False)
        Me.OutputBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstReservations As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InputBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents RbtnCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnReserve As System.Windows.Forms.RadioButton
    Friend WithEvents OutputBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblVacant As System.Windows.Forms.Label
    Friend WithEvents lblReserved As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button

End Class
