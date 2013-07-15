Option Explicit On
Option Strict On

'MainForm.vb
'Created by: Tim Fielding 08/07/2013
'Revised:

''' <summary>
''' Class to handle input/output from user
''' </summary>
''' <remarks></remarks>
Public Class MainForm
    Private mName As String = String.Empty
    Private mPrice As Double = 0D
    Private mReserved As Integer = 0
    Private Const mTotalSeats As Integer = 250
    Private mVacant As Integer = mTotalSeats

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub

    ''' <summary>
    ''' Initializes the parts of the GUI that only needs to be set once, the rest is set in UpdateGUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeGUI()
        rbtnReserve.Checked = True
        lstReservations.Items.Clear()
        For i As Integer = 0 To mTotalSeats - 1 Step 1
            Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", i + 1, "Vacant", mName, mPrice)
            lstReservations.Items.Add(strOut)
        Next
        lstReservations.SelectedIndex = -1
        lblTotSeats.Text = "Total number of seats: " + mTotalSeats.ToString()

        UpdateGUI() 'Called once during startup as well
    End Sub

    ''' <summary>
    ''' These things needs to be done every time the GUI is updated,
    ''' mostly clears variables before the next iteration of the program is run
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        txtName.Text = String.Empty
        txtPrice.Text = String.Empty
        mName = String.Empty
        mPrice = 0D

        lblVacSeats.Text = "Number of vacant seats: " + mVacant.ToString()
        lblResSeats.Text = "Number of reserved seats: " + mReserved.ToString()
    End Sub

    ''' <summary>
    ''' Buttons is clicked -> Check which of the buttons are checked and calls the correct method, then updates the GUI
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If rbtnReserve.Checked Then
            HandleReservation()
        ElseIf rbtnCancel.Checked Then
            HandleCancellation()
        End If
        UpdateGUI()
    End Sub
    ''' <summary>
    ''' Quite a big if in the beginning to see if the strings checks out,
    ''' if the amount of reserved seats are more than the total seats and if anything is selected in the reservationlist
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub HandleReservation()
        If InputUtility.ValidateString(txtName.Text) And
            InputUtility.ValidateString(txtPrice.Text) And
            mReserved <> mTotalSeats And
            lstReservations.SelectedIndex <> -1 Then

            InputUtility.GetDouble(txtPrice.Text, mPrice) 'Puts the txtPrice.Text in the mPrice variable
            mReserved += 1
            mVacant -= 1
            mName = txtName.Text 'Sets the name here, to be used in the UpdateReservations method
            UpdateReservations(lstReservations.SelectedIndex, "Reserved") 'Updates reservations accordingly
        Else 'Messagebox that pops up if anything goes wrong
            MessageBox.Show("Error while handling reservation, did you input name/price?", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' This one only needs to check if amount reserved is more than 0 and if anything is selected
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub HandleCancellation()
        If lstReservations.SelectedIndex <> -1 And mReserved > 0 Then
            mReserved -= 1
            mVacant += 1
            UpdateReservations(lstReservations.SelectedIndex, "Vacant")
        Else
            MessageBox.Show("Error while handling cancellation, did you select a reservation?", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' Takes the index of the item in the list to be changed and the updated status as parameters,
    ''' removes the old item and puts the new item there instead
    ''' </summary>
    ''' <param name="index"></param>
    ''' <param name="status"></param>
    ''' <remarks></remarks>
    Private Sub UpdateReservations(ByVal index As Integer, ByVal status As String)
        Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, status, mName, mPrice)
        lstReservations.Items.RemoveAt(index)
        lstReservations.Items.Insert(index, strOut)
    End Sub
End Class
