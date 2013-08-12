Option Strict On
Option Explicit On

Public MustInherit Class BakeryItem
    Private mName As String = String.Empty
    Private mPrice As Double = 0D

    Public Sub New(ByVal name As String, ByVal price As Double)
        mName = name
        mPrice = price
    End Sub

    Public MustOverride Function CalcTotal() As Double

    Public Overrides Function ToString() As String
        Return String.Format("{0, -20} {1, -10} {2, -10}", Me.Name, Me.Price, Me.CalcTotal().ToString())
    End Function

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mName = value
            End If
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return mPrice
        End Get
        Set(value As Double)
            If InputUtility.ValidateDouble(value) Then
                mPrice = value
            End If
        End Set
    End Property

End Class
