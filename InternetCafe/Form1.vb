'Project Name: Internet Cafe
'Project purpose: performs customer billing for the Internet Cafe'
'Created by: Will Wells


Public Class MainForm

    Const HOURLY_RATE = 12.0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim hours As Double
        Dim amount As Double
        Dim isConverted As Boolean

        isConverted = Double.TryParse(hoursTextBox.Text, hours)
        If isConverted Then
            amount = hours * HOURLY_RATE

        End If

        amountDueLabel.Text = Format(amount, "Currency")

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(amountDueLabel)

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'clears screen for next user

        lastNameTextBox.Text = String.Empty
        firstNameTextBox.Text = String.Empty
        hoursTextBox.Text = String.Empty
        amountDueLabel.Text = String.Empty

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

End Class
