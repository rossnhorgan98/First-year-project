Public Class frmPriceQuote
    
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
        Else
            'Add these details to the price quote at the end of the form
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
                tabPriceQuote.SelectedTab = tabBooking
            End If
        End If


    End Sub

    Private Sub btnNextBooking_Click(sender As Object, e As EventArgs) Handles btnNextBooking.Click

        'Single room prices
        Select Case cmbHotel.SelectedItem
            Case "Langher Lodge (2*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(63, 53, 43, 33)).ToString("C"))
            Case "Pana Palace (3*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(75, 65, 55, 45)).ToString("C"))
            Case "Coal-Quay Hotel (3*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(80, 68, 60, 48)).ToString("C"))
            Case "Jackeen Ville (1*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(46, 39, 36, 29)).ToString("C"))
            Case "Blue Cow Inn (2*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(82, 75, 72, 65)).ToString("C"))
            Case "Stellabourne Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(130, 110, 100, 90)).ToString("C"))
            Case "Simply-The-Best Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(77, 67, 57, 47)).ToString("C"))
            Case "BallyRocks Hotel (5*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(160, 125, 110, 95)).ToString("C"))
            Case "The Docks Motel (1*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(40, 35, 30, 25)).ToString("C"))
            Case "Shannon Lodge (3*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(80, 70, 66, 56)).ToString("C"))
            Case "Clohessy Court Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of single room: " & (CalculateCost(99, 89, 82, 72)).ToString("C"))
        End Select

        'Twin room prices
        Select Case cmbHotel.SelectedItem
            Case "Langher Lodge (2*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(123, 103, 83, 63)).ToString("C"))
            Case "Pana Palace (3*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(145, 125, 105, 85)).ToString("C"))
            Case "Coal-Quay Hotel (3*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(160, 128, 120, 88)).ToString("C"))
            Case "Jackeen Ville (1*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(86, 69, 66, 49)).ToString("C"))
            Case "Blue Cow Inn (2*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(162, 145, 142, 125)).ToString("C"))
            Case "Stellabourne Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(260, 220, 200, 180)).ToString("C"))
            Case "Simply-The-Best Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(147, 127, 107, 87)).ToString("C"))
            Case "BallyRocks Hotel (5*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(300, 275, 250, 200)).ToString("C"))
            Case "The Docks Motel (1*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(80, 65, 60, 45)).ToString("C"))
            Case "Shannon Lodge (3*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(160, 140, 126, 106)).ToString("C"))
            Case "Clohessy Court Hotel (4*)"
                lstPriceQuote.Items.Add("Cost of twin room: " & (CalculateCost(189, 169, 162, 142)).ToString("C"))
        End Select

        tabPriceQuote.SelectedTab = tabGuest
    End Sub

    Private Sub btnBackBooking_Click(sender As Object, e As EventArgs) Handles btnBackBooking.Click
        tabPriceQuote.SelectedTab = tabCustomer
    End Sub

    Private Sub btnBackAdditional_Click(sender As Object, e As EventArgs) Handles btnBackAdditional.Click
        tabPriceQuote.SelectedTab = tabGuest
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

    Private Sub btnNextGuest_Click(sender As Object, e As EventArgs) Handles btnNextGuest.Click
        tabPriceQuote.SelectedTab = tabAdditional
    End Sub

    Private Sub btnBackGuest_Click(sender As Object, e As EventArgs) Handles btnBackGuest.Click
        tabPriceQuote.SelectedTab = tabBooking
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

    Private Sub btnNextAdditional_Click(sender As Object, e As EventArgs) Handles btnNextAdditional.Click
        'Declare variables of fields
        Dim passport, card As String

        'Assign variables to fields
        passport = mtbPassportNumber.Text
        card = mtbCardNumber.Text

        'Make sure that no fields are left blank
        If (passport = Nothing) Or (card = Nothing) Or ((rdoMastercard.Checked = False) And (rdoVisa.Checked = False) And (rdoLaser.Checked = False) And (rdoAmEx.Checked = False)) Then
            MessageBox.Show("Please fill in all details before proceeding.")
        Else
            'Add the details to the invoice
            lstInvoice.Items.Add("Passport Number: " & passport)
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
            lstInvoice.Items.Add("Card Number:       " & card)
            tabPriceQuote.SelectedTab = tabInvoice
        End If

    End Sub

    Private Sub btnBackInvoice_Click(sender As Object, e As EventArgs) Handles btnBackInvoice.Click
        tabPriceQuote.SelectedTab = tabAdditional
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Allow the user to add a row
        Me.dgvGuests.Rows.Add(mtbNameGuest.Text, rdoOver16.Checked, mtbPassportGuest.Text)
        'Make sure the fields clear after adding a row
        mtbNameGuest.Clear()
        rdoOver16.Checked = False
        rdoUnder16.Checked = False
        mtbPassportGuest.Clear()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Allow the user to remove a row
        If dgvGuests.SelectedRows.Count > 0 Then
            For i As Integer = dgvGuests.SelectedRows.Count - 1 To 0 Step -1
                dgvGuests.Rows.RemoveAt(dgvGuests.SelectedRows(i).Index)
            Next
        Else
            MessageBox.Show("No rows to select.")
        End If

    End Sub

    Function CalculateCost(PeakWeekend As Double, PeakWeekday As Double, OffWeekend As Double, OffWeekday As Double) As Double

        Dim checkIn, checkOut As Date
        Dim days As Integer
        Dim dblCost As Double

        checkIn = CDate(mtbCheckIn.Text)
        checkOut = CDate(mtbCheckOut.Text)

        days = DateDiff(DateInterval.Day, checkIn, checkOut)

        If Month(checkIn) >= 3 And Month(checkIn) <= 8 Then
            Select Case checkIn.DayOfWeek
                Case DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
                    dblCost = days * PeakWeekend
                Case Else
                    dblCost = days * PeakWeekday
            End Select
        Else
            Select Case checkIn.DayOfWeek
                Case DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
                    dblCost = days * OffWeekend
                Case Else
                    dblCost = days * OffWeekday
            End Select
        End If

        Return dblCost

    End Function

    Private Sub btnNextPrice_Click(sender As Object, e As EventArgs) Handles btnNextPrice.Click
        tabPriceQuote.SelectedTab = tabAdditional
    End Sub

    Private Sub btnBackPrice_Click(sender As Object, e As EventArgs) Handles btnBackPrice.Click
        tabPriceQuote.SelectedTab = tabGuest
    End Sub
End Class