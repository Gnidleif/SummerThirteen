Option Explicit On
Option Strict On

Public Class BakeryManager
    Private mItem As BakeryItem

    Public Sub New()
        ResetItem()
    End Sub

    Public Sub ResetItem()
        mItem = Nothing
    End Sub

    Public Sub CreateCake(ByVal name As String, ByVal price As Double, ByVal pieces As Integer)
        mItem = New Cake(name, price, pieces)
    End Sub

    Public Sub CreateCookie(ByVal name As String, ByVal price As Double, ByVal weight As Double)
        mItem = New Cookie(name, price, weight)
    End Sub

    Public ReadOnly Property Item() As BakeryItem
        Get
            Return mItem
        End Get
    End Property

End Class
