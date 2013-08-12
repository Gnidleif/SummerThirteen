Option Explicit On
Option Strict On

'ContactManager.vb
'Created by: Tim Fielding 12/08/2013
'Revised:

Public Class ContactManager
    Private mContacts As List(Of Contact)

    Public Sub New()
        mContacts = New List(Of Contact)
    End Sub
    ''' <summary>
    ''' Adds a contact using the parameters sent to the function
    ''' </summary>
    ''' <returns>
    ''' Checks all of the parameters before adding, if any fails it returns false, otherwise it returns true
    ''' </returns>
    Public Function AddContact(ByVal firstname As String, ByVal surname As String, ByVal address As Address) As Boolean
        Dim returner As Boolean = False

        'I like IsNot, way better than writing "Not address is Nothing", haha!
        If InputUtility.ValidateString(firstname) And InputUtility.ValidateString(surname) And address IsNot Nothing Then
            returner = True
            Dim contact As Contact = New Contact(firstname, surname, address)
            mContacts.Add(contact)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Also adds a contact, but takes a complete Contact-object as a parameter instead
    ''' </summary>
    Public Function AddContact(ByVal contact As Contact) As Boolean
        Dim returner As Boolean = False

        If contact IsNot Nothing Then
            returner = True
            mContacts.Add(contact)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Changes a contact, after checking that the variables sent to the method makes sense
    ''' </summary>
    ''' <returns>
    ''' True if the change was successful, false if it failed
    ''' </returns>
    Public Function ChangeContact(ByVal contact As Contact, ByVal index As Integer) As Boolean
        Dim returner As Boolean = False

        If contact IsNot Nothing And Me.CheckIndex(index) Then
            returner = True
            mContacts(index) = contact
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Deletes a contact after checking that the index sent is correct
    ''' </summary>
    ''' <returns>
    ''' False if the index sent isn't within the range of the List used within the class, true otherwise
    ''' </returns>
    Public Function DeleteContact(ByVal index As Integer) As Boolean
        Dim returner As Boolean = False

        If Me.CheckIndex(index) Then
            returner = True
            mContacts.RemoveAt(index)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Returns the contact at the given index if it's valid, otherwise returns null
    ''' </summary>
    Public Function GetContact(ByVal index As Integer) As Contact
        Dim returner As Contact = Nothing

        If Me.CheckIndex(index) Then
            returner = mContacts(index)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Turns all the objects stored in the List into a string array
    ''' </summary>
    ''' <returns>
    ''' The string array is then returned
    ''' </returns>
    Public Function GetContactsInfo() As String()
        Dim infoStrings As String() = New String(Me.Count - 1) {}

        Dim i As Integer = 0
        For Each obj As Contact In mContacts 'For Each is great!
            infoStrings(i) = obj.ToString()
            i += 1
        Next

        Return infoStrings
    End Function
    ''' <summary>
    ''' Used by other methods of the class to check if a valid sent as a parameter is within range of the List or not
    ''' </summary>
    ''' <returns>
    ''' True if it is within range of the List, false if not
    ''' </returns>
    Private Function CheckIndex(ByVal index As Integer) As Boolean
        Return index >= 0 And index < Me.Count
    End Function
    ''' <summary>
    ''' A ReadOnly property which can be used from the outside to see the size of the list
    ''' </summary>
    ''' <returns>
    ''' The current size of the list
    ''' </returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return mContacts.Count
        End Get
    End Property

End Class
