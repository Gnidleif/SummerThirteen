Option Explicit On
Option Strict On

'MainForm.vb
'Created by: Tim Fielding 12/08/2013
'Revised:

Public Class MainForm
    Private mContactManager As ContactManager

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mContactManager = New ContactManager()
        Me.InitializeGUI()
    End Sub
    ''' <summary>
    ''' Initializes the GUI, all it really does is iterate over the required Enums and adding each to the combobox
    ''' </summary>
    Private Sub InitializeGUI()
        For Each obj As Countries In System.Enum.GetValues(GetType(Countries))
            cmbCountry.Items.Add(obj)
        Next
    End Sub
    ''' <summary>
    ''' Updates the GUI by adding the result of the strings returned by the mContactManager
    ''' </summary>
    Private Sub UpdateGUI()
        Dim strContacts() As String = mContactManager.GetContactsInfo()

        If strContacts IsNot Nothing Then 'Checks for null, just in case
            lstRecords.Items.Clear()
            lstRecords.Items.AddRange(strContacts)
            lblNoRecords.Text = mContactManager.Count.ToString()
        End If
    End Sub
    ''' <summary>
    ''' Switches the values of the different input-boxes to the values of the currently selected contact in the listbox
    ''' </summary>
    Private Sub UpdateContactInfo()
        Dim contact As Contact = mContactManager.GetContact(lstRecords.SelectedIndex)

        cmbCountry.SelectedIndex = DirectCast(contact.AddressData.Country, Integer)
        txtFirstname.Text = contact.Firstname
        txtSurname.Text = contact.Surname
        txtStreet.Text = contact.AddressData.Street
        txtCity.Text = contact.AddressData.City
        txtZip.Text = contact.AddressData.Zip
    End Sub
    ''' <summary>
    ''' Checks if the selected index is within the range of the total size of the listbox
    ''' </summary>
    ''' <returns>
    ''' True if inside the range, false if not
    ''' </returns>
    Private Function CheckRecordIndex() As Boolean
        Return lstRecords.SelectedIndex >= 0 And lstRecords.SelectedIndex < mContactManager.Count
    End Function
    ''' <summary>
    ''' Same as the above, only on the combobox instead
    ''' </summary>
    Private Function CheckCountryIndex() As Boolean
        Return cmbCountry.SelectedIndex >= 0 And cmbCountry.SelectedIndex < cmbCountry.Items.Count
    End Function
    ''' <summary>
    ''' Used to call the ReadFirstname- and ReadSurname functions
    ''' </summary>
    ''' <returns>
    ''' If they both check out fine it returns true, otherwise not
    ''' </returns>
    Private Function ReadNameInfo(ByRef firstname As String, ByRef surname As String) As Boolean
        Return ReadFirstname(firstname) And ReadSurname(surname)
    End Function
    ''' <summary>
    ''' Reads the txtFirstname.Text and checks it's validity, then sets the parameter sent as a reference to the value if it's valid
    ''' </summary>
    ''' <param name="data">
    ''' Parameter sent as a reference
    ''' </param>
    ''' <returns>
    ''' True if the txtFirstname.Text was valid and by extension if the referenced data was changed
    ''' </returns>
    Private Function ReadFirstname(ByRef data As String) As Boolean
        Dim returner As Boolean = False

        If InputUtility.ValidateString(txtFirstname.Text) Then
            returner = True
            data = txtFirstname.Text
        Else
            MessageBox.Show("Invalid first name input.", "First name error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Same as above, only with the surname instead
    ''' </summary>
    Private Function ReadSurname(ByRef data As String) As Boolean
        Dim returner As Boolean = False

        If (InputUtility.ValidateString(txtSurname.Text)) Then
            returner = True
            data = txtSurname.Text

        Else
            MessageBox.Show("Please input a correct surname in the surname box.", "Surname error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Used to build a new Address-object and return it depending on how much information has been set by the user
    ''' </summary>
    ''' <returns>
    ''' The new address-object
    ''' </returns>
    Private Function ReadAddressInfo() As Address
        Dim returner As Address = New Address() 'First just creates a default-object

        If CheckAddressStrings() Then 'If anything was input into the textboxes the various property-functions are used to set them to the correct values
            returner.Street = txtStreet.Text
            returner.City = txtCity.Text
            returner.Zip = txtZip.Text
        End If

        If CheckCountryIndex() Then 'If a country was selected, the corresponding property is called 
            Dim country As Countries = Countries.Sverige
            'Checker is a locally stored string used to handle the string-version of the currently selected country
            Dim checker As String = cmbCountry.Items(cmbCountry.SelectedIndex).ToString()

            For Each obj As Countries In System.Enum.GetValues(GetType(Countries)) 'Iterates over the entire enum
                If obj.ToString() = checker Then 'If the currently iterated objects string-version is the same as checker
                    country = obj 'The local variable country stores the value of that object
                End If
            Next

            returner.Country = country 'Calls the Country-property of the returning object
        End If

        Return returner
    End Function
    ''' <summary>
    ''' Makes sure any of the textboxes of the addressdata groupbox are filled in
    ''' </summary>
    Private Function CheckAddressStrings() As Boolean
        Return CheckStreet() Or CheckCity() Or CheckZip()
    End Function
    ''' <summary>
    ''' Validates the string currently typed in the textbox of their corresponding values
    ''' </summary>
    Private Function CheckStreet() As Boolean
        Return InputUtility.ValidateString(txtStreet.Text)
    End Function

    Private Function CheckCity() As Boolean
        Return InputUtility.ValidateString(txtCity.Text)
    End Function

    Private Function CheckZip() As Boolean
        Return InputUtility.ValidateString(txtZip.Text)
    End Function
    ''' <summary>
    ''' If the Add button is clicked, this happens
    ''' </summary>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstname As String = String.Empty
        Dim surname As String = String.Empty

        If Me.ReadNameInfo(firstname, surname) Then 'Makes sure the info input into the Name groupbox is valid
            Dim address As Address = Me.ReadAddressInfo()
            Dim contact As Contact = New Contact(firstname, surname, address) 'The new object! (third constructor)
            mContactManager.AddContact(contact)
            Me.UpdateGUI()

        Else 'If the names weren't valid, this pops up
            MessageBox.Show("Problem when trying add a contact.", "Addition problem!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' Same as above, only it calls the ChangeContact method in the ContactManager class instead
    ''' </summary>
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim firstname As String = String.Empty
        Dim surname As String = String.Empty

        If Me.ReadNameInfo(firstname, surname) And Me.CheckRecordIndex() Then 'Besides names also need to check if the selected index is valid
            Dim index As Integer = lstRecords.SelectedIndex
            Dim address As Address = Me.ReadAddressInfo()
            Dim contact As Contact = New Contact(firstname, surname, address)
            mContactManager.ChangeContact(contact, index)
            UpdateGUI()

        Else
            MessageBox.Show("Failed when trying to change the contact.", "Change error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' Deletes an object from the mContactManager
    ''' </summary>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Me.CheckRecordIndex() Then 'Only needs to check the index before doing anything
            Dim index As Integer = lstRecords.SelectedIndex
            mContactManager.DeleteContact(index)
            UpdateGUI()

        Else
            MessageBox.Show("Couldn't delete the contact.", "Deletion-error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ''' <summary>
    ''' If an object in the listbox is clicked, the UpdateContactInfo method is called
    ''' </summary>
    Private Sub lstRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecords.SelectedIndexChanged
        Me.UpdateContactInfo()
    End Sub
End Class
