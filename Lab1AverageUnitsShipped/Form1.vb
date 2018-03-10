'Name: Connor Simmonds-Parke
'Student ID: 100344939
'Course: NETD - 2202
'Project: Lab1AverageUnitsShipped
'Date: Feb 7, 2018
'Description: A program to calculate the average amount of units shipped over a week using
'             user inputted data and storing it in an array. This is an assignment that
'             is designed to introduce us to the differences between c# and Visual Basic.

Public Class frmAverageUnitsShipped
    'DECLARATIONS

    'GLOBAL VARIABLES
    Dim dayCounter As Integer = 0 'Holds the number of days/amount of times user inputted data.
    Dim unitsPerDayArray(7) As Integer 'Array to hold the user inputted amount of units shipped for 7 days.


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtUnitsList.Clear() 'Clears the textbox that lists the user's input.
        txtUserInputUnits.Clear() 'Clears the textbox for the user input.
        txtUserInputUnits.Focus() 'Sets the focus to the textbox for user input.
        lblDaysCounter.Text = "Day 1".ToString 'Sets the days label back to day 1.
        btnEnter.Enabled = True 'Makes sure the accept button is enabled.
        txtUserInputUnits.ReadOnly = False 'Makes sure the input textbox is not on read only.
        dayCounter = 0 'Resets the counter that counts the days/amount of user inputs.
        lblAverageUnitsShipped.ResetText() 'Clears the label that calculates the average.

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close() 'Closes this form and therefore exits the program.

    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'DECLARATIONS

        'LOCAL VARIABLES
        Dim userInput As Integer = 0 'Holds the user's input for units sold (For input).
        Dim averageCounter As Integer = 0 'Counter to count the for loop to sum up the array's values (For processing).
        Dim averageUnits As Double = 0.0 'Holds the average of all the values in the units array (for processing/output).


        'INPUT

        If (Integer.TryParse(txtUserInputUnits.Text, userInput) = True) Then 'Checks to see if the value entered is a whole number.

            If (userInput < 0 Or userInput > 1000) Then 'Checks to see if the value enetered is not between 0 and 1000.

                MessageBox.Show("Please enter a whole number between 0 and 1000 inclusive.") 'Displays a message box detailing the reason for the invalid input.
                txtUserInputUnits.Focus() 'Sets the focus to the input textbox.
                txtUserInputUnits.SelectAll() 'Selects/highlights everything in the textbox.


            Else

                unitsPerDayArray(dayCounter) = userInput 'Sets the array's value to the user's input in this event.
                txtUnitsList.Multiline = True 'Sets the textbox to allow for multiple lines.
                txtUnitsList.AppendText("Day " & (dayCounter + 1) & ":" & vbTab & unitsPerDayArray(dayCounter) & Environment.NewLine) 'Displays and adds the user's input for units to the textbox.
                dayCounter += 1 'Adds one to the day counter.
                lblDaysCounter.Text = "Day " & (dayCounter + 1).ToString 'Changes the day label to match the array index.
                txtUserInputUnits.Focus() 'Sets the focus back to the input text box.
                txtUserInputUnits.Clear() 'Clears the input text box.

                'PROCESSING

                If (dayCounter = 7) Then 'Checks to see if the user has entered seven values.

                    txtUserInputUnits.ReadOnly = True 'Stops the user from entering more data in the text box.
                    btnEnter.Enabled = False 'Disables the enter button so the user can't attempt to enter more data.

                    For averageCounter = 0 To 7 Step 1 'loop to calculate the sum of the array.
                        averageUnits += unitsPerDayArray(averageCounter)

                    Next

                    averageUnits = Math.Round((averageUnits / 7), 2) 'Calculates the average of the array and rounds the value to two decimal places.

                    'OUTPUT

                    lblAverageUnitsShipped.Text = "The average units shipped: " & averageUnits.ToString 'Outputs the average for the user.

                End If

            End If

        Else

            MessageBox.Show("Please enter a whole number for units shipped.") 'Displays a message box detailing the reason for the invalid input.
            txtUserInputUnits.Focus() 'Sets the focus to the input textbox.
            txtUserInputUnits.SelectAll() 'Selects/highlights everything in the textbox.

        End If

    End Sub

End Class
