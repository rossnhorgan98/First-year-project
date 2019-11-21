Public Class frmMain

    'Declare variables for room rates and other costs
    Dim dblPeakWeekend, dblPeakWeekday, dblOffWeekend, dblOffWeekday, dblSingleCost, dblTwinCost, dblFoodCost, dblSuitCost, dblShirtCost, dblOtherCost, dblLaundryCost, dblTotalCost As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Return to Log In form
        frmLogIn.Show()
        Me.Close()
    End Sub

    Private Sub btnNextCustomer_Click(sender As Object, e As EventArgs) Handles btnNextCustomer.Click
        'Declare and assign variables to each detail entered about the customer
        Dim strName As String = mtbName.Text
        Dim strAge As String = mtbAge.Text
        Dim strAddress As String = txtAddress.Text
        Dim strTown As String = mtbTown.Text
        Dim strCounty As String = cmbCounty.Text
        Dim strContact As String = mtbContact.Text

        'Make sure that no fields are left blank
        If (strName = Nothing) Or (strAge = Nothing) Or (strAddress = Nothing) Or (strTown = Nothing) Or (strCounty = Nothing) Or (strContact = Nothing) Then
            MessageBox.Show("Please fill in all details before proceeding.")
            Call ErrorCount()
        Else
            'Add these details to the invoice at the end of the form
            lstInvoice.Items.Clear()
            lstInvoice.Items.Add("Customer Name:   " & strName)
            lstInvoice.Items.Add("Street Address:     " & strAddress)
            lstInvoice.Items.Add("                             " & strTown)
            lstInvoice.Items.Add("                             " & strCounty)
            lstInvoice.Items.Add("Contact Number:  " & strContact)

            'Make sure that customer is at least 16
            If strAge < 16 Then
                MessageBox.Show("Customer must be of at least 16 years of age to book a hotel room.")
            Else
                tabControl.SelectedTab = tabBooking
            End If
        End If
    End Sub

    Private Sub cmbLocation_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLocation.SelectionChangeCommitted
        'Determine which Hotel selection appears depending on the location that's selected
        Select Case cmbLocation.SelectedItem
            Case "Cork"
                cmbHotel.Items.Clear()
                cmbHotel.Items.Add("Langher Lodge (2*)")
                cmbHotel.Items.Add("Pana Palace (3*)")
                cmbHotel.Items.Add("Coal-Quay Hotel (3*)")
            Case "Dublin"
                cmbHotel.Items.Clear()
                cmbHotel.Items.Add("Jackeen Ville (1*)")
                cmbHotel.Items.Add("Blue Cow Inn (2*)")
                cmbHotel.Items.Add("Stellabourne Hotel (4*)")
            Case "Kerry"
                cmbHotel.Items.Clear()
                cmbHotel.Items.Add("Simply-The-Best Hotel (4*)")
                cmbHotel.Items.Add("BallyRocks Hotel (5*)")
            Case "Limerick"
                cmbHotel.Items.Clear()
                cmbHotel.Items.Add("The Docks Motel (1*)")
                cmbHotel.Items.Add("Shannon Lodge (3*)")
                cmbHotel.Items.Add("Clohessy Court Hotel (4*)")
        End Select
    End Sub

    Private Sub chkDryCleaning_CheckedChanged(sender As Object, e As EventArgs) Handles chkDryCleaning.CheckedChanged
        'Dry cleaning checkbox has to be selected in order to add items
        If chkDryCleaning.Checked = True Then
            lblSuits.Visible = True
            nudSuits.Visible = True
            lblShirts.Visible = True
            nudShirts.Visible = True
            lblOthers.Visible = True
            nudOthers.Visible = True
        Else
            lblSuits.Visible = False
            nudSuits.Visible = False
            nudSuits.Value = 0
            lblShirts.Visible = False
            nudShirts.Visible = False
            nudShirts.Value = 0
            lblOthers.Visible = False
            nudOthers.Visible = False
            nudOthers.Value = 0
        End If
    End Sub

    Private Sub chkLaundry_CheckedChanged(sender As Object, e As EventArgs) Handles chkLaundry.CheckedChanged
        'Laundry checkbox must be selected to add laundry bags
        If chkLaundry.Checked = True Then
            nudLaundry.Visible = True
            lblBags.Visible = True
        Else
            nudLaundry.Visible = False
            nudLaundry.Value = 0
            lblBags.Visible = False
        End If
    End Sub

    Private Sub chkBreakfast_CheckedChanged(sender As Object, e As EventArgs) Handles chkBreakfast.CheckedChanged
        'Breakfast checkbox has to be selected in order to choose Continental or Full Irish
        If chkBreakfast.Checked Then
            rdoContinental.Visible = True
            rdoFullIrish.Visible = True
        Else
            rdoContinental.Visible = False
            rdoContinental.Checked = False
            rdoFullIrish.Visible = False
            rdoFullIrish.Checked = False
        End If
    End Sub

    Private Sub btnNextBooking_Click(sender As Object, e As EventArgs) Handles btnNextBooking.Click

        'Make sure that no fields are left blank
        If (dtpCheckIn.Value = Nothing) Or (dtpCheckOut.Value = Nothing) Or (cmbHotel.Text = Nothing) Or (nudSingleRooms.Value = 0 And nudTwinRooms.Value = 0) Then
            MessageBox.Show("Please fill in all details before proceeding.")
            Call ErrorCount()
        ElseIf (dtpCheckIn.Value > dtpCheckOut.Value) Or (dtpCheckIn.Value = dtpCheckOut.Value) Then
            dtpCheckIn.ResetText()
            dtpCheckOut.ResetText()
            Call ErrorCount()
        Else
            'Declare and assign variables
            Dim dteCheckIn, dteCheckOut As Date
            Dim strHotel As String = cmbHotel.Text

            dteCheckIn = CDate(dtpCheckIn.Value)
            dteCheckOut = CDate(dtpCheckOut.Value)

            'Add the details to the listbox
            lstInvoice.Items.Add("Check In:             " & dteCheckIn)
            lstInvoice.Items.Add("Check Out:          " & dteCheckOut)
            lstInvoice.Items.Add("Hotel:                   " & strHotel)
            tabControl.SelectedTab = tabGuest
        End If

        dblSingleCost = 0
        dblTwinCost = 0

        'Clear price quote before entering details
        lstPriceQuote.Items.Clear()

        'Single room prices
        If nudSingleRooms.Value > 0 Then
            Select Case cmbHotel.SelectedItem
                Case "Langher Lodge (2*)"
                    dblSingleCost = (CalculateCost(63, 53, 43, 33))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(43, 53, 63)
                Case "Pana Palace (3*)"
                    dblSingleCost = (CalculateCost(75, 65, 55, 45))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(55, 65, 75)
                Case "Coal-Quay Hotel (3*)"
                    dblSingleCost = (CalculateCost(80, 68, 60, 48))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(60, 68, 80)
                Case "Jackeen Ville (1*)"
                    dblSingleCost = (CalculateCost(46, 39, 36, 29))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(36, 39, 46)
                Case "Blue Cow Inn (2*)"
                    dblSingleCost = (CalculateCost(82, 75, 72, 65))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(72, 75, 82)
                Case "Stellabourne Hotel (4*)"
                    dblSingleCost = (CalculateCost(130, 110, 100, 90))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(100, 110, 130)
                Case "Simply-The-Best Hotel (4*)"
                    dblSingleCost = (CalculateCost(77, 67, 57, 47))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(57, 67, 77)
                Case "BallyRocks Hotel (5*)"
                    dblSingleCost = (CalculateCost(160, 125, 110, 95))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(110, 125, 160)
                Case "The Docks Motel (1*)"
                    dblSingleCost = (CalculateCost(40, 35, 30, 25))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(30, 35, 40)
                Case "Shannon Lodge (3*)"
                    dblSingleCost = (CalculateCost(80, 70, 66, 56))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(66, 70, 80)
                Case "Clohessy Court Hotel (4*)"
                    dblSingleCost = (CalculateCost(99, 89, 82, 72))
                    lstPriceQuote.Items.Add("Cost of single room: " & dblSingleCost.ToString("C"))
                    FoodCost(82, 89, 99)
            End Select
            'Multiply the price by the number of rooms selected
            dblSingleCost *= nudSingleRooms.Value
            lstPriceQuote.Items.Add("No. of rooms: " & nudSingleRooms.Value)
            lstInvoice.Items.Add("No. of single rooms: " & nudSingleRooms.Value)
            
        End If

        'Twin room prices
        If nudTwinRooms.Value > 0 Then
            Select Case cmbHotel.SelectedItem
                Case "Langher Lodge (2*)"
                    dblTwinCost = (CalculateCost(123, 103, 83, 63))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(83, 103, 123)
                Case "Pana Palace (3*)"
                    dblTwinCost = (CalculateCost(145, 125, 105, 85))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(105, 125, 145)
                Case "Coal-Quay Hotel (3*)"
                    dblTwinCost = (CalculateCost(160, 128, 120, 88))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(120, 128, 160)
                Case "Jackeen Ville (1*)"
                    dblTwinCost = (CalculateCost(86, 69, 66, 49))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(66, 69, 86)
                Case "Blue Cow Inn (2*)"
                    dblTwinCost = (CalculateCost(162, 145, 142, 125))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(142, 145, 162)
                Case "Stellabourne Hotel (4*)"
                    dblTwinCost = (CalculateCost(260, 220, 200, 180))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(200, 220, 260)
                Case "Simply-The-Best Hotel (4*)"
                    dblTwinCost = (CalculateCost(147, 127, 107, 87))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(107, 127, 147)
                Case "BallyRocks Hotel (5*)"
                    dblTwinCost = (CalculateCost(300, 275, 250, 200))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(250, 275, 300)
                Case "The Docks Motel (1*)"
                    dblTwinCost = (CalculateCost(80, 65, 60, 45))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(60, 65, 80)
                Case "Shannon Lodge (3*)"
                    dblTwinCost = (CalculateCost(160, 140, 126, 106))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(126, 140, 160)
                Case "Clohessy Court Hotel (4*)"
                    dblTwinCost = (CalculateCost(189, 169, 162, 142))
                    lstPriceQuote.Items.Add("Cost of twin room: " & dblTwinCost.ToString("C"))
                    FoodCost(162, 169, 189)
            End Select
            'Multiply the price by the number of rooms slected
            dblTwinCost *= nudTwinRooms.Value
            lstPriceQuote.Items.Add("No. of rooms: " & nudTwinRooms.Value)
            lstInvoice.Items.Add("No. of twin rooms: " & nudTwinRooms.Value)
        End If

        'Set prices for optional extras
        dblSuitCost = 19.5
        dblShirtCost = 9.25
        dblOtherCost = 11.25
        dblLaundryCost = 15.5

        'Assign each variable to each numericupdown
        If nudSuits.Value > 0 Then
            dblSuitCost *= nudSuits.Value
            lstPriceQuote.Items.Add("Dry Cleaning (Suits): " & dblSuitCost.ToString("C"))
        End If

        If nudShirts.Value > 0 Then
            dblShirtCost *= nudShirts.Value
            lstPriceQuote.Items.Add("Dry Cleaning (Shirts): " & dblShirtCost.ToString("C"))
        End If

        If nudOthers.Value > 0 Then
            dblOtherCost *= nudOthers.Value
            lstPriceQuote.Items.Add("Dry Cleaning (Others): " & dblOtherCost.ToString("C"))
        End If

        If nudLaundry.Value > 0 Then
            dblLaundryCost *= nudLaundry.Value
            lstPriceQuote.Items.Add("Laundry Service: " & dblLaundryCost.ToString("C"))
        End If

    End Sub

    Function CalculateCost(dblPeakweekend, dblPeakWeekday, dblOffWeekend, dblOffWeekday) As Double

        'Declare variables
        Dim dteCheckIn, dteCheckOut As Date
        Dim intDays As Integer
        Dim dblCost As Double

        'Assign variables
        dteCheckIn = CDate(dtpCheckIn.Value)
        dteCheckOut = CDate(dtpCheckOut.Value)

        intDays = DateDiff(DateInterval.Day, dteCheckIn, dteCheckOut)

        'Deterimine prices depending on peak/off-peak and weekday/weekend factors
        'Friday is considered a weekend day 
        'Peak season
        For i As Integer = 0 To (intDays + 1)
            If Month(dteCheckIn) >= 3 And Month(dteCheckIn) <= 8 Then
                Select Case dteCheckIn.DayOfWeek
                    Case DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblCost += dblPeakweekend
                    Case Else
                        'when they check in during the week
                        dblCost += dblPeakWeekday
                End Select
            Else
                'outside of April to August
                'Off peak season
                Select Case dteCheckIn.DayOfWeek
                    Case DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblCost += dblOffWeekend
                    Case Else
                        'when they check in during the week
                        dblCost += dblOffWeekday
                End Select
            End If
            dteCheckIn = dteCheckIn.AddDays(1)
            i += 1
        Next

        Return dblCost

    End Function

    Function FoodCost(dblOffWeekend, dblPeakWeekday, dblPeakWeekend) As Double

        'Declare variables for Breakfast and Evening Meal
        Dim dblContinental, dblFullIrish, dblEveningMeal As Double

        'Assign variables depending on whether they are selected or not
        If rdoContinental.Checked = True Then
            dblContinental = dblOffWeekend * 0.075
            lstPriceQuote.Items.Add("Continental Breakfast: " & dblContinental.ToString("C"))
        ElseIf rdoFullIrish.Checked = True Then
            dblFullIrish = dblPeakWeekday * 0.1
            lstPriceQuote.Items.Add("Full Irish Breakfast: " & dblFullIrish.ToString("C"))
        End If

        If chkEveningMeal.Checked = True Then
            dblEveningMeal = dblPeakWeekend * 0.25
            lstPriceQuote.Items.Add("Evening Meal: " & dblEveningMeal.ToString("C"))
        End If

        Return dblFoodCost

    End Function

    Private Sub btnBackBooking_Click(sender As Object, e As EventArgs) Handles btnBackBooking.Click
        'Return to customer details page
        tabControl.SelectedTab = tabCustomer
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Make sure all details are entered before adding a guest
        If (mtbNameGuest.Text = Nothing) Or (rdoOver16.Checked = False And rdoUnder16.Checked = False) Or (mtbPassportGuest.Text = Nothing) Then
            MessageBox.Show("Please fill in all fields before adding a guest.")
            Call ErrorCount()
        Else
            'Allow the user to add a row
            Me.dgvGuests.Rows.Add(mtbNameGuest.Text, rdoOver16.Checked, mtbPassportGuest.Text)
            'Make sure the fields clear after adding a row
            mtbNameGuest.Clear()
            rdoOver16.Checked = False
            rdoUnder16.Checked = False
            mtbPassportGuest.Clear()
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Allow the user to remove a row
        If dgvGuests.SelectedRows.Count > 0 Then
            For i As Integer = dgvGuests.SelectedRows.Count - 1 To 0 Step -1
                dgvGuests.Rows.RemoveAt(dgvGuests.SelectedRows(i).Index)
            Next
        Else
            MessageBox.Show("No rows to select.")
            Call ErrorCount()
        End If

    End Sub

    Private Sub btnNextGuest_Click(sender As Object, e As EventArgs) Handles btnNextGuest.Click
        'Declare variables for number of adults and children
        Dim intChildrenNumber As Integer = 0
        Dim intAdultsNumber As Integer = 0

        'Count the numbers of adults and children from the table
        For Each row As DataGridViewRow In dgvGuests.Rows
            If row.Cells(1).Value.ToString = "False" Then
                intChildrenNumber += 1
            Else
                intAdultsNumber += 1
            End If
        Next

        'Declare variables for the costs per room for single and twin
        Dim dblSinglePerRoom, dblTwinPerRoom As Double

        'Assign these variables
        If dblSingleCost > 0 Then
            dblSinglePerRoom = dblSingleCost / nudSingleRooms.Value
        End If

        If dblTwinCost > 0 Then
            dblTwinPerRoom = dblTwinCost / nudTwinRooms.Value
        End If

        'Create a seperate loop for both single and twin rooms which will apply the discount for under 16's
        'If there are multiple rooms and multiple children we want to apply the discount to each room for 
        'as many children we have on the booking (assuming for twin room we put one child each)
        Dim i As Integer = intChildrenNumber, n As Integer = nudSingleRooms.Value, m As Integer = nudTwinRooms.Value
        If i > 0 Then
            'For each twin room subtract the discount for children from the total cost
            Do Until m = 0 Or i = 0
                dblTwinCost -= dblTwinPerRoom * 0.25
                i -= 1
                m -= 1
            Loop
            'For each single room subtract the discount for children from the total cost
            Do Until n = 0 Or i = 0
                dblSingleCost -= dblSinglePerRoom * 0.1
                i -= 1
                n -= 1
            Loop
        End If

        'Calculate the total cost
        dblTotalCost = dblSingleCost + dblTwinCost + dblSuitCost + dblShirtCost + dblOtherCost + dblLaundryCost + dblFoodCost
        'Apply 10% discount if room is booked 30+ days in advance
        Dim intDays As Integer = 0
        intDays = DateDiff(DateInterval.Day, Today, dtpCheckIn.Value)
        If intDays >= 30 Then
            dblTotalCost *= 0.9
            lstPriceQuote.Items.Add("10% discount for booking 30+ days in advance: " & "-" & (dblTotalCost / 9).ToString("C"))
        End If

        'Declare variables for total guests including main customer and total room capacity from those selected
        Dim intTotalPeople As Integer = intAdultsNumber + intChildrenNumber + 1
        Dim intTotalCapacity As Integer = nudSingleRooms.Value + (nudTwinRooms.Value * 2)

        'Don't allow there to be more or less guests than room capacity
        If intTotalPeople <> intTotalCapacity Then
            MessageBox.Show("There must be an equal number of guests to the room capacity selected.")
            Call ErrorCount()
        Else
            lstPriceQuote.Items.Add("No. of adults: " & (intAdultsNumber + 1))
            lstPriceQuote.Items.Add("No. of children " & intChildrenNumber)
            lstInvoice.Items.Add("No. of adults: " & (intAdultsNumber + 1))
            lstInvoice.Items.Add("No. of children " & intChildrenNumber)
            'Add total cost to price quote and invoice
            lstPriceQuote.Items.Add("")
            lstPriceQuote.Items.Add("Total Cost: " & dblTotalCost.ToString("C"))
            lstInvoice.Items.Add("Total Cost: " & dblTotalCost.ToString("C"))
            'Advance to price quote
            tabControl.SelectedTab = tabPriceQuote
        End If
    End Sub

    Private Sub btnBackGuest_Click(sender As Object, e As EventArgs) Handles btnBackGuest.Click
        'Return to Booking page
        tabControl.SelectedTab = tabBooking
    End Sub

    Private Sub btnNextPrice_Click(sender As Object, e As EventArgs) Handles btnNextPrice.Click
        'Advance to additional details page
        tabControl.SelectedTab = tabAdditional
    End Sub

    Private Sub btnBackPrice_Click(sender As Object, e As EventArgs) Handles btnBackPrice.Click
        'Return to guest page
        tabControl.SelectedTab = tabGuest
    End Sub

    Private Sub btnNextAdditional_Click(sender As Object, e As EventArgs) Handles btnNextAdditional.Click
        'Declare variables of fields
        Dim strPassport, strCard As String

        'Assign variables to fields
        strPassport = mtbPassportNumber.Text
        strCard = mtbCardNumber.Text

        'Make sure that no fields are left blank
        If (strPassport = Nothing) Or (strCard = Nothing) Or ((rdoMastercard.Checked = False) And (rdoVisa.Checked = False) And (rdoLaser.Checked = False) And (rdoAmEx.Checked = False)) Then
            MessageBox.Show("Please fill in all details before proceeding.")
            Call ErrorCount()
        Else
            'Add the details to the invoice
            lstInvoice.Items.Add("Passport Number: " & strPassport)
            'Make sure the selected payment type is shown
            If rdoMastercard.Checked Then
                lstInvoice.Items.Add("Payment Type:     MasterCard")
            ElseIf rdoVisa.Checked Then
                lstInvoice.Items.Add("Payment Type:     Visa")
            ElseIf rdoLaser.Checked Then
                lstInvoice.Items.Add("Payment Type:     Laser")
            ElseIf rdoAmEx.Checked Then
                lstInvoice.Items.Add("Payment Type:     American Express")
            End If
            lstInvoice.Items.Add("Card Number:       " & strCard)
            tabControl.SelectedTab = tabInvoice
        End If

    End Sub

    Private Sub btnBackAdditional_Click(sender As Object, e As EventArgs) Handles btnBackAdditional.Click
        'Return to price quote page
        tabControl.SelectedTab = tabPriceQuote
    End Sub

    Private Sub btnBackInvoice_Click(sender As Object, e As EventArgs) Handles btnBackInvoice.Click
        'Return to additional details page
        tabControl.SelectedTab = tabAdditional
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'Print the invoice
        PrintForm1.Print()
        Me.Close()
    End Sub
End Class