' Program:  Airbnb Rental
' Author:   Evan Owenby
' Date:     February 21, 2023
' Prupose:  This application calculates and displays the total
'           cost of renting an airbnb for a specified number of days.

Option Strict On

Public Class frmAirbnb

    ' Cost per night stay - used in multiple procedures
    Const _cdecPricePerDay As Decimal = 79D

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        ' This event handler is executed when the user clicks the
        ' Display Cost button. It calculates and displays the cost
        ' of the rental (number of days times the cost per night).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the Total Cost label.
        ' Then, it sets the focus on the txtNumberOfDays Textbox object.

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        ' the txtNumberOfDays Textbox object.

        lblSubheader.Text = _cdecPricePerDay.ToString("C") & "per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()
    End Sub

End Class
