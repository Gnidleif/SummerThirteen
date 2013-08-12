Option Explicit On
Option Strict On

'Address.vb
'Created by: Tim Fielding 12/08/2013
'Revised:

Public Class Address

    Private mStreet As String = Nothing
    Private mCity As String = Nothing
    Private mZip As String = Nothing
    Private mCountry As Countries
    ''' <summary>
    ''' The default constructor
    ''' </summary>
    Public Sub New()
        Me.New(String.Empty, String.Empty, "Karlskrona")
    End Sub
    ''' <summary>
    ''' The second constructor, takes three parameters
    ''' </summary>
    Public Sub New(ByVal street As String, ByVal city As String, ByVal zip As String)
        Me.New(street, city, zip, Countries.Sverige)
    End Sub
    ''' <summary>
    ''' The third constructor, takes all parameters
    ''' </summary>
    Public Sub New(ByVal street As String, ByVal city As String, ByVal zip As String, ByVal country As Countries)
        mStreet = street
        mCity = city
        mZip = zip
        mCountry = country
    End Sub
    ''' <summary>
    ''' Copy constructor, takes an object of the same type as parameter 
    ''' and uses the properties of that object to create a copy of it
    ''' </summary>
    Public Sub New(ByVal data As Address)
        mStreet = data.Street
        mCity = data.City
        mZip = data.Zip
        mCountry = data.Country
    End Sub
    ''' <summary>
    ''' Used to create a string of the country stored in the object, 
    ''' also removes the underscores that exists in the enum version of the country
    ''' </summary>
    Public Function GetCountryString() As String
        Dim strCountry As String = Me.Country.ToString()
        strCountry.Replace("_", " ")
        Return strCountry
    End Function
    ''' <summary>
    ''' Overrides the ToString() function to get a formatted version of it with the applicable variables
    ''' </summary>
    Public Overrides Function ToString() As String
        Return String.Format("{0, -20} {1, -10} {2, -10} {3, -10}", Me.City, Me.Zip, Me.Street, Me.GetCountryString())
    End Function
    ''' <summary>
    ''' Below we have properties, used to get/set the various variables stored in the object
    ''' The set-part also uses the InputUtility-class to validate the input
    ''' </summary>
    Public Property Street() As String
        Get
            Return mStreet
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mStreet = value
            End If
        End Set
    End Property

    Public Property City() As String
        Get
            Return mCity
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mCity = value
            End If
        End Set
    End Property

    Public Property Zip() As String
        Get
            Return mZip
        End Get
        Set(value As String)
            If InputUtility.ValidateString(value) Then
                mZip = value
            End If
        End Set
    End Property

    Public Property Country() As Countries
        Get
            Return mCountry
        End Get
        Set(value As Countries)
            mCountry = value
        End Set
    End Property

End Class
