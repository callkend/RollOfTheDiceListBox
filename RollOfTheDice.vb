'Kendall Callister
'RCET0265
'Spring 2021
'Roll of the Dice-List Box
'https://github.com/callkend/RollOfTheDiceListBox.git

Public Class RollOfTheDice

    'Adds tool tips
    Private Sub RollOfTheDice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip.SetToolTip(RollButton, "Rolls Dice")
        ToolTip.SetToolTip(ClearButton, "Clears Results")
        ToolTip.SetToolTip(ExitButton, "Exits Program")
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim outcome(10) As Integer
        Dim number As Integer
        Randomize()

        'Checks to see if the list box has been filled already
        If RollListBox.Items.Count < 1 Then
            'Looks for two random numbers between 1 & 6 and than adds them together, and stores the
            'outcome in a array 1000 times.
            For i = 0 To 999
                number = CInt(6 * Rnd()) + 1 + CInt(6 * Rnd()) + 1
                Select Case number
                    Case = 2
                        outcome(0) += 1
                    Case = 3
                        outcome(1) += 1
                    Case = 4
                        outcome(2) += 1
                    Case = 5
                        outcome(3) += 1
                    Case = 6
                        outcome(4) += 1
                    Case = 7
                        outcome(5) += 1
                    Case = 8
                        outcome(6) += 1
                    Case = 9
                        outcome(7) += 1
                    Case = 10
                        outcome(8) += 1
                    Case = 11
                        outcome(9) += 1
                    Case = 12
                        outcome(10) += 1
                End Select
            Next


            'Formats table and pulls info from array.
            Console.WriteLine("Roll of the Dice" + vbNewLine)
            For j = 0 To 10
                RollListBox.ColumnWidth = 52
                If j + 2 = 7 Then
                    RollListBox.Items.Add("Results")
                Else
                    RollListBox.Items.Add("")
                End If
                RollListBox.Items.Add("- - - - - - - - -")
                RollListBox.Items.Add((CStr(j + 2).PadLeft(5) + " |"))
                RollListBox.Items.Add("- - - - - - - - -")
                RollListBox.Items.Add((CStr(outcome(j)).PadLeft(5) + " |"))

            Next
        End If
    End Sub

    'Clears Table
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollListBox.Items.Clear()
    End Sub

    'Exits Program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
