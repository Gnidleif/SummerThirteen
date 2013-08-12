Option Explicit On
Option Strict On

Public Class MainWindow
    Private mBakeryManager As BakeryManager

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        mBakeryManager = New BakeryManager()
        InitializeGUI()
    End Sub

    Private Sub InitializeGUI()
        txtAmount.Text = "0"
        txtPrice.Text = "0.0"
        lblReceipt.Text = "Nothing bought yet!"

        For Each obj As BakeryTypes In System.Enum.GetValues(GetType(BakeryTypes))
            cmbTypes.Items.Add(obj)
        Next
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If ReadInput() = False Then
            MessageBox.Show("Please select a valid type.", "Type error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ReadInput() As Boolean
        Dim returner As Boolean = False
        If Me.CheckTypeIndex() Then
            Me.CreateItem()

            If mBakeryManager.Item IsNot Nothing Then
                lblReceipt.Text = mBakeryManager.Item.ToString()
                mBakeryManager.ResetItem()
                returner = True
            Else
                MessageBox.Show("Please input all values correctly!", "Input error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return returner
    End Function

    Private Function CheckTypeIndex() As Boolean
        Return cmbTypes.SelectedIndex >= 0 And cmbTypes.SelectedIndex < cmbTypes.Items.Count - 1
    End Function

    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        Select Case Me.GetBakeryType()
            Case BakeryTypes.Cake
                lblAmount.Text = "Pieces:"
                lblPrice.Text = "Price/piece:"
            Case BakeryTypes.Cookie
                lblAmount.Text = "Weight:"
                lblPrice.Text = "Price/kg:"
        End Select
    End Sub

    Private Sub CreateItem()
        Dim name As String = cmbTypes.Items(cmbTypes.SelectedIndex).ToString()
        Dim price As Double = 0D
        InputUtility.GetDouble(txtPrice.Text, price)

        Select Case Me.GetBakeryType()
            Case BakeryTypes.Cake
                Dim pieces As Integer = 0
                InputUtility.GetInt(txtAmount.Text, pieces)
                If InputUtility.ValidateDouble(price) And InputUtility.ValidateInt(pieces) Then
                    mBakeryManager.CreateCake(name, price, pieces)
                End If
            Case BakeryTypes.Cookie
                Dim weight As Double = 0D
                InputUtility.GetDouble(txtAmount.Text, weight)
                If InputUtility.ValidateDouble(price) And InputUtility.ValidateDouble(weight) Then
                    mBakeryManager.CreateCookie(name, price, weight)
                End If
        End Select
    End Sub

    Private Function GetBakeryType() As BakeryTypes
        Dim returner As BakeryTypes = BakeryTypes.Cake
        Dim checker As String = cmbTypes.Items(cmbTypes.SelectedIndex).ToString()

        For Each obj As BakeryTypes In System.Enum.GetValues(GetType(BakeryTypes))
            If obj.ToString() = checker Then
                returner = obj
            End If
        Next

        Return returner
    End Function

End Class
