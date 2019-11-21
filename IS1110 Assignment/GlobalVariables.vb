Module GlobalVariables
    Public gErrorCount As Integer = 0

    Public Sub ErrorCount()
        'Public sub procedure named ErrorCount
        If gErrorCount = 0 Or (gErrorCount < 4 And gErrorCount > 0) Then
            'Increase the value of the error count by 1
            gErrorCount += 1

            MessageBox.Show("You have made " & gErrorCount & " error(s).")
        Else
            MessageBox.Show("You have exceeded your error limit.")
            'The error count is reset
            gErrorCount = 0

            frmLogIn.Show()
            frmMain.Close()
        End If
    End Sub
End Module
