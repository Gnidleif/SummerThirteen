Option Explicit On
Option Strict On

'Contact.vb
'Created by: Tim Fielding 12/08/2013
'Revised:

Public Class Contact
    Private mFirstname As String = Nothing
    Private mSurname As String = Nothing
    Private mAddress As Address = Nothing
    ''' <summary>
    ''' Default constructor calling the second constructor
    ''' </summary>
    Public Sub New()
        'Since this calls new on the default constructor of the Address class, the address values will also be default
        Me.New(String.Empty, String.Empty, New Address())
    End Sub
    ''' <summary>
    ''' The second constructor where everything is sent in
    ''' </summary>
    Public Sub New(ByVal firstname As String, ByVal surname As String, ByVal address As Address)
        mFirstname = firstname
        mSurname = surname
        mAddress = address
    End Sub
    ''' <summary>
    ''' Copy constructor
    ''' </summary>
    Public Sub New(ByVal data As Contact)
        mFirstname = data.Firstname
        mSurname = data.Surname
        mAddress = data.AddressData
    End Sub
    ''' <summary>
    ''' Overriden ToString() method, uses the overridden ToString() method in the Address-class 
    ''' as well as adding the Fullname property in the Contact-class
    ''' </summary>
    Public Overrides Function ToString() As String
        Return String.Format("{0, -20} {1, -20}", Me.Fullname, Me.AddressData.ToString())
    End Function
    ''' <summary>
    ''' Properties, more description can be found in the Address-class
    ''' </summary>
    Public Property Firstname() As String
        Get
            Return mFirstname
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mFirstname = value
            End If
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return mSurname
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mSurname = value
            End If
        End Set
    End Property

    Public Property AddressData() As Address
        Get
            Return mAddress
        End Get
        Set(value As Address)
            mAddress = value
        End Set
    End Property
    ''' <summary>
    ''' Puts together the mFirstname and mSurname into a single string, used in the ToString() method of this class
    ''' since these values doesn't need to be separated when presented to the user
    ''' </summary>
    Public ReadOnly Property Fullname() As String
        Get
            Return mFirstname + " " + mSurname
        End Get
    End Property

End Class
