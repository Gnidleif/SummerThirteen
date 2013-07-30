Option Explicit On
Option Strict On

'SeatManager.vb
'Created by: Tim Fielding 15/07/2013
'Revised: 30/07/2013

''' <summary>
''' Class to handle the output shown in the list of reservations
''' </summary>
''' <remarks></remarks>
Public Class SeatManager
    Private ReadOnly mTotalSeats As Integer
    Private mNameList As String() = Nothing
    Private mPriceList As Double() = Nothing
    ''' <summary>
    ''' Constructor to the seatmanager class
    ''' </summary>
    ''' <param name="totalSeats">
    ''' Sets the mTotalSeats variable
    ''' </param>
    ''' <remarks></remarks>
    Public Sub New(ByVal totalSeats As Integer)
        mTotalSeats = totalSeats
        mNameList = New String(mTotalSeats) {}
        mPriceList = New Double(mTotalSeats) {}
    End Sub
    ''' <summary>
    ''' Checks if a number is less than mTotalSeats but still more than or equal to 0
    ''' </summary>
    ''' <param name="index">
    ''' The number to be checked
    ''' </param>
    ''' <returns>
    ''' Returns true if the number is within the valid scope, returns false otherwise
    ''' </returns>
    ''' <remarks></remarks>
    Private Function CheckIndex(ByVal index As Integer) As Boolean
        Return index >= 0 And index < mTotalSeats
    End Function
    ''' <summary>
    ''' Calculates the amount of reserved seats
    ''' </summary>
    ''' <returns>
    ''' Returns the amount of seats reserved after going through the mNameList with a for-loop
    ''' </returns>
    ''' <remarks></remarks>
    Public Function GetNumReserved() As Integer
        Dim amount As Integer = 0
        For i As Integer = 0 To mTotalSeats - 1 Step 1
            If InputUtility.ValidateString(mNameList(i)) Then
                amount += 1 'Amount += 1 every time the mNameList isn't empty, IE: the spot is reserved
            End If
        Next
        Return amount
    End Function
    ''' <summary>
    ''' Does the same as the above, only with vacant seats instead
    ''' </summary>
    Public Function GetNumVacant() As Integer
        Dim amount As Integer = 0
        For i As Integer = 0 To mTotalSeats - 1 Step 1
            If Not InputUtility.ValidateString(mNameList(i)) Then
                amount += 1
            End If
        Next
        Return amount
    End Function
    ''' <summary>
    ''' Utility function to check how many total seats there are
    ''' </summary>
    Public Function GetNumSeats() As Integer
        Return mTotalSeats
    End Function
    ''' <summary>
    ''' Enables cancelling a seat
    ''' </summary>
    ''' <param name="index">
    ''' The index of the seat to be cancelled
    ''' </param>
    ''' <returns>
    ''' Returns true if the cancellation succeeded, fails if not
    ''' </returns>
    ''' <remarks></remarks>
    Public Function CancelSeat(ByVal index As Integer) As Boolean
        If CheckIndex(index) Then 'First checks if the index sent is valid
            mNameList(index) = String.Empty 'Then empties the arrays at the specified index
            mPriceList(index) = 0D
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Pretty much the same as the above, only reserves a seat instead
    ''' It also checks if the user really wants to overwrite a reservation before overwriting it
    ''' </summary>
    ''' <param name="index">
    ''' The index of the seat to be reserved
    ''' </param>
    ''' <param name="name">
    ''' The new name of the reservation
    ''' </param>
    ''' <param name="price">
    ''' The new price of the reservation
    ''' </param>
    ''' <returns>
    ''' False if the index doesn't exist in the array, or if the user decides to not overwrite an existing reservation
    ''' </returns>
    Public Function ReserveSeat(ByVal index As Integer, ByVal name As String, ByVal price As Double) As Boolean
        If CheckIndex(index) Then
            If (InputUtility.ValidateString(mNameList(index))) Then '' Using a simple messagebox to ask the user about overwriting
                Dim box As DialogResult = MessageBox.Show("Are you sure you want to overwrite the previous reservation?",
                                "Previous reservation error.",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If box = DialogResult.Cancel Then '' If the user presses the cancel button in the messagebox the reservation is cancelled
                    Return False '' That is, the method returns false
                End If
            End If
            mNameList(index) = name 'Sets the mNameList at the specified index to the string sent as a parameter
            mPriceList(index) = price 'Same here, only with the price
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Handles the actual string to be put in the textBox
    ''' </summary>
    ''' <param name="index">
    ''' The current index in the list of the string being created
    ''' </param>
    ''' <returns>
    ''' Returns a formatted string with all the needed information or an empty string if the CheckIndex() call failed
    ''' </returns>
    ''' <remarks></remarks>
    Private Function GetSeatInfoAt(ByVal index As Integer) As String
        If CheckIndex(index) Then 'Important to check this
            Dim status As String = String.Empty 'Initializing status here
            If InputUtility.ValidateString(mNameList(index)) Then 'If the string is valid, we know that the seat is reserved
                status = "Reserved"
            Else 'Otherwise it's vacant
                status = "Vacant"
            End If
            Return String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, status, mNameList(index), mPriceList(index))
        End If
        Return String.Empty
    End Function
    ''' <summary>
    ''' Builds a string-array to be returned back to the textBox
    ''' </summary>
    ''' <returns>
    ''' The string put together by calling the GetSeatInfoAt method for each existing seat
    ''' </returns>
    Public Function GetAllSeatInfo() As String()
        Dim allSeats As String() = New String(mTotalSeats - 1) {}
        For i As Integer = 0 To mTotalSeats - 1 Step 1
            allSeats(i) = GetSeatInfoAt(i)
        Next
        Return allSeats
    End Function

End Class
