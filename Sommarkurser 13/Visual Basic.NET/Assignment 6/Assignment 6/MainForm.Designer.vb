<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmbTypes = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.grpOrder.SuspendLayout
        Me.grpReceipt.SuspendLayout
        Me.SuspendLayout
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.txtPrice)
        Me.grpOrder.Controls.Add(Me.txtAmount)
        Me.grpOrder.Controls.Add(Me.cmbTypes)
        Me.grpOrder.Controls.Add(Me.lblPrice)
        Me.grpOrder.Controls.Add(Me.lblAmount)
        Me.grpOrder.Controls.Add(Me.lblItem)
        Me.grpOrder.Location = New System.Drawing.Point(12, 12)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(260, 104)
        Me.grpOrder.TabIndex = 0
        Me.grpOrder.TabStop = false
        Me.grpOrder.Text = "Order"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(154, 73)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(154, 43)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 4
        '
        'cmbTypes
        '
        Me.cmbTypes.FormattingEnabled = true
        Me.cmbTypes.Location = New System.Drawing.Point(122, 16)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.Size = New System.Drawing.Size(132, 21)
        Me.cmbTypes.TabIndex = 3
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = true
        Me.lblPrice.Location = New System.Drawing.Point(6, 80)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = true
        Me.lblAmount.Location = New System.Drawing.Point(6, 50)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount:"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = true
        Me.lblItem.Location = New System.Drawing.Point(6, 16)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "Item:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(95, 122)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 42)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = true
        '
        'grpReceipt
        '
        Me.grpReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.grpReceipt.Controls.Add(Me.lblReceipt)
        Me.grpReceipt.Location = New System.Drawing.Point(12, 169)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(260, 100)
        Me.grpReceipt.TabIndex = 1
        Me.grpReceipt.TabStop = false
        Me.grpReceipt.Text = "Receipt"
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = true
        Me.lblReceipt.Location = New System.Drawing.Point(6, 44)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(100, 13)
        Me.lblReceipt.TabIndex = 0
        Me.lblReceipt.Text = "Nothing bought yet!"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 281)
        Me.Controls.Add(Me.grpReceipt)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpOrder)
        Me.Name = "MainWindow"
        Me.Text = "Cakeshop!"
        Me.grpOrder.ResumeLayout(false)
        Me.grpOrder.PerformLayout
        Me.grpReceipt.ResumeLayout(false)
        Me.grpReceipt.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents grpOrder As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbTypes As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents grpReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents lblReceipt As System.Windows.Forms.Label

End Class
