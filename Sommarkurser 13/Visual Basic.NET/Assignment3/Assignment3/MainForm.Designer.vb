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
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.rbtnReserve = New System.Windows.Forms.RadioButton()
        Me.rbtnCancel = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotSeats = New System.Windows.Forms.Label()
        Me.lblResSeats = New System.Windows.Forms.Label()
        Me.lblVacSeats = New System.Windows.Forms.Label()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstReservations
        '
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.Location = New System.Drawing.Point(292, 25)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.Size = New System.Drawing.Size(244, 225)
        Me.lstReservations.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblVacSeats)
        Me.grpOutput.Controls.Add(Me.lblResSeats)
        Me.grpOutput.Controls.Add(Me.lblTotSeats)
        Me.grpOutput.Location = New System.Drawing.Point(12, 149)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(274, 100)
        Me.grpOutput.TabIndex = 5
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Data"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.Label6)
        Me.grpInput.Controls.Add(Me.Label5)
        Me.grpInput.Controls.Add(Me.txtPrice)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Controls.Add(Me.rbtnCancel)
        Me.grpInput.Controls.Add(Me.rbtnReserve)
        Me.grpInput.Location = New System.Drawing.Point(12, 9)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(274, 100)
        Me.grpInput.TabIndex = 6
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input Data"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(109, 115)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'rbtnReserve
        '
        Me.rbtnReserve.AutoSize = True
        Me.rbtnReserve.Location = New System.Drawing.Point(6, 19)
        Me.rbtnReserve.Name = "rbtnReserve"
        Me.rbtnReserve.Size = New System.Drawing.Size(94, 17)
        Me.rbtnReserve.TabIndex = 7
        Me.rbtnReserve.TabStop = True
        Me.rbtnReserve.Text = "Reserve ticket"
        Me.rbtnReserve.UseVisualStyleBackColor = True
        '
        'rbtnCancel
        '
        Me.rbtnCancel.AutoSize = True
        Me.rbtnCancel.Location = New System.Drawing.Point(138, 19)
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.Size = New System.Drawing.Size(91, 17)
        Me.rbtnCancel.TabIndex = 8
        Me.rbtnCancel.TabStop = True
        Me.rbtnCancel.Text = "Cancel Ticket"
        Me.rbtnCancel.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(138, 74)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Price"
        '
        'lblTotSeats
        '
        Me.lblTotSeats.AutoSize = True
        Me.lblTotSeats.Location = New System.Drawing.Point(6, 26)
        Me.lblTotSeats.Name = "lblTotSeats"
        Me.lblTotSeats.Size = New System.Drawing.Size(39, 13)
        Me.lblTotSeats.TabIndex = 0
        Me.lblTotSeats.Text = "Label7"
        '
        'lblResSeats
        '
        Me.lblResSeats.AutoSize = True
        Me.lblResSeats.Location = New System.Drawing.Point(6, 48)
        Me.lblResSeats.Name = "lblResSeats"
        Me.lblResSeats.Size = New System.Drawing.Size(39, 13)
        Me.lblResSeats.TabIndex = 1
        Me.lblResSeats.Text = "Label8"
        '
        'lblVacSeats
        '
        Me.lblVacSeats.AutoSize = True
        Me.lblVacSeats.Location = New System.Drawing.Point(6, 71)
        Me.lblVacSeats.Name = "lblVacSeats"
        Me.lblVacSeats.Size = New System.Drawing.Size(39, 13)
        Me.lblVacSeats.TabIndex = 2
        Me.lblVacSeats.Text = "Label9"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 261)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReservations)
        Me.Name = "MainForm"
        Me.Text = "Cinema Booking System"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstReservations As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents lblVacSeats As System.Windows.Forms.Label
    Friend WithEvents lblResSeats As System.Windows.Forms.Label
    Friend WithEvents lblTotSeats As System.Windows.Forms.Label
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents rbtnCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReserve As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button

End Class
