Public Class Form1
    Private Sub txtDatatype_Click(sender As Object, e As EventArgs) Handles txtDatatype.Click
        Dim number1 As String
        number1 = txtNum.Text
        If IsNumeric(number1) Then
            MsgBox("You have entered " & number1 & " which is a number")
        Else
            MsgBox("Please enter a number, " & number1 & " is not a number  or an integer")
        End If
    End Sub
End Class
