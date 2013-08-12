Option Strict On
Option Explicit On

Public Class Cake : Inherits BakeryItem
    Private mPieces As Integer = 0

    Public Sub New(ByVal name As String, ByVal price As Double, ByVal pieces As Integer)
        MyBase.New(name, price)
        mPieces = pieces
    End Sub

    Public Overrides Function CalcTotal() As Double
        Return mPieces * MyBase.Price
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() + String.Format("{0, -20}", mPieces)
    End Function

    Public Property Pieces() As Integer
        Get
            Return mPieces
        End Get
        Set(value As Integer)
            If InputUtility.ValidateInt(value) Then
                mPieces = value
            End If
        End Set
    End Property

End Class
