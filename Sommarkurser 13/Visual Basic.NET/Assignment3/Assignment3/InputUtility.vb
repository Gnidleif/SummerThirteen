Option Explicit On
Option Strict On

'InputUtility.vb
'Created by: Tim Fielding 08/07/2013
'Revised:

''' <summary>
''' Class used to check if inputs from the user checks out and to check/"convert" some types to others
''' </summary>
''' <remarks></remarks>
Public Class InputUtility
    ''' <summary>
    ''' Takes a string and a double as parameters, checks with the tryparse function if it works to parse the double,
    ''' if it does the double is set to the double-value of the string
    ''' </summary>
    ''' <param name="toConvert"></param>
    ''' <param name="doubleOut"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal toConvert As String, ByRef doubleOut As Double) As Boolean
        Return Double.TryParse(toConvert, doubleOut)
    End Function
    ''' <summary>
    ''' Returns false if a string is empty, true if it's not
    ''' </summary>
    ''' <param name="toCheck"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ValidateString(ByVal toCheck As String) As Boolean
        Return Not String.IsNullOrEmpty(toCheck)
    End Function
    ''' <summary>
    ''' Returns true if a double is more than 0, returns false otherwise
    ''' </summary>
    ''' <param name="toCheck"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ValidateDouble(ByVal toCheck As Double) As Boolean
        Return Not (toCheck > 0D)
    End Function

End Class