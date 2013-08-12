Option Explicit On
Option Strict On

'InputUtility.vb
'Created by: Tim Fielding 15/07/2013
'Revised:

''' <summary>
''' Class with public shared functions made to assist the rest of the program 
''' with parsing and validity checking of variables
''' </summary>
''' <remarks></remarks>
Public Class InputUtility
    ''' <summary>
    ''' Parses a string to an int
    ''' </summary>
    ''' <param name="toConvert">
    ''' The string about to be converted
    ''' </param>
    ''' <param name="intRef">
    ''' The parameter sent as a reference in order to change it to the parsed value, if parsing is possible
    ''' </param>
    ''' <returns>
    ''' True or false depending on if the parsing failed or succeeded
    ''' </returns>
    ''' <remarks></remarks>
    Public Shared Function GetInt(ByVal toConvert As String, ByRef intRef As Integer) As Boolean
        Return Integer.TryParse(toConvert, intRef)
    End Function
    ''' <summary>
    ''' Same as the above, only with a double
    ''' </summary>
    Public Shared Function GetDouble(ByVal toConvert As String, ByRef doubleRef As Double) As Boolean
        Return Double.TryParse(toConvert, doubleRef)
    End Function
    ''' <summary>
    ''' Checks the validity of an integer
    ''' </summary>
    ''' <param name="toCheck">
    ''' The integer to be checked
    ''' </param>
    ''' <returns>
    ''' True if the integer is above 0, false if not
    ''' </returns>
    ''' <remarks></remarks>
    Public Shared Function ValidateInt(ByVal toCheck As Integer) As Boolean
        Return toCheck > 0
    End Function
    ''' <summary>
    ''' Same as the above, only with a double
    ''' </summary>
    Public Shared Function ValidateDouble(ByVal toCheck As Double) As Boolean
        Return toCheck > 0D
    End Function
    ''' <summary>
    ''' Same as the above, only with a string
    ''' </summary>
    Public Shared Function ValidateString(ByVal toCheck As String) As Boolean
        Return Not String.IsNullOrEmpty(toCheck)
    End Function

End Class
