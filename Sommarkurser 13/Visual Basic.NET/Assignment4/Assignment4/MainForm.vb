Option Explicit On
Option Strict On

'MainForm.vb
'Created by: Tim Fielding 15/07/2013
'Revised: 05/08/2013

''' <summary>
''' The class handling the input/output of the program
''' </summary>
''' <remarks></remarks>
Public Class MainForm
    Private Const mNumSeats As Integer = 60
    Private mSeatManager As SeatManager
    ''' <summary>
    ''' Constructor of the MainForm class,
    ''' Initializes the seatmanager and GUI and also handles the first update of the gui
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mSeatManager = New SeatManager(mNumSeats)
        InitializeGUI()
        UpdateGUI()
    End Sub
    ''' <summary>
    ''' Maybe more should be here, but this is the only thing in the program that only needs to be set once,
    ''' maybe should've been put in the constructor instead
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeGUI()
        lblTotal.Text = "Total number of seats: " + mSeatManager.GetNumSeats().ToString()
        RbtnReserve.Checked = True
    End Sub
    ''' <summary>
    ''' Check if the index selected in the lstReservations window is valid (not -1)
    ''' </summary>
    ''' <returns>
    ''' Returns true if the index selected isn't -1
    ''' </returns>
    ''' <remarks></remarks>
    Private Function CheckSelectedIndex() As Boolean
        Return lstReservations.SelectedIndex <> -1
    End Function
    ''' <summary>
    ''' Uses the inpututility class to check if a string is valid
    ''' </summary>
    ''' <param name="name">
    ''' The string to be checked
    ''' </param>
    ''' <returns>
    ''' True if the string is valid, false if it isn't
    ''' </returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateName(ByVal name As String) As Boolean
        Return InputUtility.ValidateString(name)
    End Function
    ''' <summary>
    ''' Same as the above, only with a double instead
    ''' </summary>
    Private Function ReadAndValidatePrice(ByVal price As Double) As Boolean
        Return InputUtility.ValidateDouble(price)
    End Function
    ''' <summary>
    ''' A function used to check both of the above functions
    ''' </summary>
    ''' <returns>
    ''' True if both returns true, false if either of them return false
    ''' </returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateInput(ByVal name As String, ByVal price As Double) As Boolean
        Return ReadAndValidateName(name) And ReadAndValidatePrice(price)
    End Function
    ''' <summary>
    ''' Function handling reservation/cancellation of seats
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReserveOrCancelSeat()
        If CheckSelectedIndex() Then 'Important to check this first

            Dim index As Integer = lstReservations.SelectedIndex 'Sets the index to the selected index
            Dim price As Double = 0D 'Local variable for storing the price put in the txtPrice.Text
            Dim name As String = txtName.Text 'Same here, but with the txtName.Text instead

            InputUtility.GetDouble(txtPrice.Text, price)

            If RbtnReserve.Checked And ReadAndValidateInput(name, price) Then 'Checks if RbtnReserve is checked, then validates name/price

                If mSeatManager.IsReservedAt(index) Then
                    Dim box As DialogResult = MessageBox.Show("Are you sure you want to overwrite the previous reservation?",
                                            "Previous reservation error.",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If box = Windows.Forms.DialogResult.OK Then
                        mSeatManager.ReserveSeat(index, name, price) 'If it all checks out, reserve a seat
                        UpdateGUI() 'Then update the GUI accordingly
                    End If

                Else
                    mSeatManager.ReserveSeat(index, name, price) 'If it all checks out, reserve a seat
                    UpdateGUI() 'Then update the GUI accordingly
                End If

            ElseIf RbtnCancel.Checked Then 'If RbtnCancel is checked, it goes on to cancel the selected seat
                mSeatManager.CancelSeat(index)
                UpdateGUI()

            Else 'This can really only occur if ReadAndValidateInput fails, since either of the boxes has to be chosen at all times
                MessageBox.Show("No correct input made.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else 'If a bad index is selected, this happens
            MessageBox.Show("No correct selection made.", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' Handles updating of the GUI whenever a change is made
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        txtName.Text = String.Empty 'Clears all the inputboxes
        txtPrice.Text = String.Empty

        lstReservations.Items.Clear() 'Removes everything from the itemslist 
        lstReservations.Items.AddRange(mSeatManager.GetAllSeatInfo())

        lblReserved.Text = "Reserved seats: " + mSeatManager.GetNumReserved.ToString() 'Changes the labelText accordingly
        lblVacant.Text = "Vacant seats: " + mSeatManager.GetNumVacant.ToString()
    End Sub
    ''' <summary>
    ''' Calls the ReserveOrCancelSeat() function whenever the OK-button is clicked
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ReserveOrCancelSeat()
    End Sub

End Class
