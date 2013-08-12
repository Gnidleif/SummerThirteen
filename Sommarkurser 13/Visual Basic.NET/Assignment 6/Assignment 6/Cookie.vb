Option Explicit On
Option Strict On

Public Class Cookie : Inherits BakeryItem
    Private mWeight As Double = 0D

    Public Sub New(ByVal name As String, ByVal price As Double, ByVal weight As Double)
        MyBase.New(name, price)
        mWeight = weight
    End Sub

    Public Overrides Function CalcTotal() As Double
        Return mWeight * MyBase.Price
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() + String.Format("{0, -20}", mWeight.ToString())
    End Function

    Public Property Weight() As Double
        Get
            Return mWeight
        End Get
        Set(value As Double)
            If InputUtility.ValidateDouble(value) Then
                mWeight = value
            End If
        End Set
    End Property

End Class
