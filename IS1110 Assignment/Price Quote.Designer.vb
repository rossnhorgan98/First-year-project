<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceQuote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPriceQuote))
        Me.tabPriceQuote = New System.Windows.Forms.TabControl()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.lblNavigate = New System.Windows.Forms.Label()
        Me.mtbTown = New System.Windows.Forms.MaskedTextBox()
        Me.mtbName = New System.Windows.Forms.MaskedTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNextCustomer = New System.Windows.Forms.Button()
        Me.mtbAge = New System.Windows.Forms.MaskedTextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.mtbContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.btnBackBooking = New System.Windows.Forms.Button()
        Me.btnNextBooking = New System.Windows.Forms.Button()
        Me.grpOptionalExtras = New System.Windows.Forms.GroupBox()
        Me.rdoContinental = New System.Windows.Forms.RadioButton()
        Me.rdoFullIrish = New System.Windows.Forms.RadioButton()
        Me.nudLaundry = New System.Windows.Forms.NumericUpDown()
        Me.lblLaundry = New System.Windows.Forms.Label()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkEveningMeal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudOthers = New System.Windows.Forms.NumericUpDown()
        Me.lblOthers = New System.Windows.Forms.Label()
        Me.nudShirts = New System.Windows.Forms.NumericUpDown()
        Me.lblShirts = New System.Windows.Forms.Label()
        Me.lblSuits = New System.Windows.Forms.Label()
        Me.nudSuits = New System.Windows.Forms.NumericUpDown()
        Me.lblDryCleaning = New System.Windows.Forms.Label()
        Me.grpHotel = New System.Windows.Forms.GroupBox()
        Me.nudTwinRooms = New System.Windows.Forms.NumericUpDown()
        Me.nudSingleRooms = New System.Windows.Forms.NumericUpDown()
        Me.lblTwinRooms = New System.Windows.Forms.Label()
        Me.lblSingleRooms = New System.Windows.Forms.Label()
        Me.nudGuests2 = New System.Windows.Forms.NumericUpDown()
        Me.lblGuestsNumber2 = New System.Windows.Forms.Label()
        Me.nudGuests = New System.Windows.Forms.NumericUpDown()
        Me.lblGuestNumber = New System.Windows.Forms.Label()
        Me.cmbHotel = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.grpBookingDates = New System.Windows.Forms.GroupBox()
        Me.mtbCheckIn = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCheckOut = New System.Windows.Forms.MaskedTextBox()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.tabGuest = New System.Windows.Forms.TabPage()
        Me.dgvGuests = New System.Windows.Forms.DataGridView()
        Me.rdoUnder16 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoOver16 = New System.Windows.Forms.RadioButton()
        Me.lblGuestPassport = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.mtbPassportGuest = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNameGuest = New System.Windows.Forms.MaskedTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBackGuest = New System.Windows.Forms.Button()
        Me.btnNextGuest = New System.Windows.Forms.Button()
        Me.tabAdditional = New System.Windows.Forms.TabPage()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.mtbPassportNumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnNextAdditional = New System.Windows.Forms.Button()
        Me.btnBackAdditional = New System.Windows.Forms.Button()
        Me.grpPaymentDetails = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdoLaser = New System.Windows.Forms.RadioButton()
        Me.rdoAmEx = New System.Windows.Forms.RadioButton()
        Me.rdoVisa = New System.Windows.Forms.RadioButton()
        Me.rdoMastercard = New System.Windows.Forms.RadioButton()
        Me.mtbCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.tabInvoice = New System.Windows.Forms.TabPage()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnBackInvoice = New System.Windows.Forms.Button()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.tabPrice = New System.Windows.Forms.TabPage()
        Me.lstPriceQuote = New System.Windows.Forms.ListBox()
        Me.btnNextPrice = New System.Windows.Forms.Button()
        Me.btnBackPrice = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPassport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPriceQuote.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.grpOptionalExtras.SuspendLayout()
        CType(Me.nudLaundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShirts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSuits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHotel.SuspendLayout()
        CType(Me.nudTwinRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSingleRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGuests2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookingDates.SuspendLayout()
        Me.tabGuest.SuspendLayout()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdditional.SuspendLayout()
        Me.grpPaymentDetails.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInvoice.SuspendLayout()
        Me.tabPrice.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPriceQuote
        '
        Me.tabPriceQuote.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.tabPriceQuote.Controls.Add(Me.tabCustomer)
        Me.tabPriceQuote.Controls.Add(Me.tabBooking)
        Me.tabPriceQuote.Controls.Add(Me.tabGuest)
        Me.tabPriceQuote.Controls.Add(Me.tabPrice)
        Me.tabPriceQuote.Controls.Add(Me.tabAdditional)
        Me.tabPriceQuote.Controls.Add(Me.tabInvoice)
        Me.tabPriceQuote.Location = New System.Drawing.Point(35, 12)
        Me.tabPriceQuote.Multiline = True
        Me.tabPriceQuote.Name = "tabPriceQuote"
        Me.tabPriceQuote.SelectedIndex = 0
        Me.tabPriceQuote.Size = New System.Drawing.Size(690, 654)
        Me.tabPriceQuote.TabIndex = 0
        '
        'tabCustomer
        '
        Me.tabCustomer.BackColor = System.Drawing.Color.GhostWhite
        Me.tabCustomer.Controls.Add(Me.lblNavigate)
        Me.tabCustomer.Controls.Add(Me.mtbTown)
        Me.tabCustomer.Controls.Add(Me.mtbName)
        Me.tabCustomer.Controls.Add(Me.btnExit)
        Me.tabCustomer.Controls.Add(Me.btnNextCustomer)
        Me.tabCustomer.Controls.Add(Me.mtbAge)
        Me.tabCustomer.Controls.Add(Me.lblAge)
        Me.tabCustomer.Controls.Add(Me.cmbCounty)
        Me.tabCustomer.Controls.Add(Me.lblCounty)
        Me.tabCustomer.Controls.Add(Me.lblTown)
        Me.tabCustomer.Controls.Add(Me.txtAddress)
        Me.tabCustomer.Controls.Add(Me.lblAddress)
        Me.tabCustomer.Controls.Add(Me.mtbContact)
        Me.tabCustomer.Controls.Add(Me.lblContact)
        Me.tabCustomer.Controls.Add(Me.lblName)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 4)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomer.Size = New System.Drawing.Size(661, 646)
        Me.tabCustomer.TabIndex = 0
        Me.tabCustomer.Text = "Customer Details"
        '
        'lblNavigate
        '
        Me.lblNavigate.AutoSize = True
        Me.lblNavigate.Location = New System.Drawing.Point(115, 17)
        Me.lblNavigate.Name = "lblNavigate"
        Me.lblNavigate.Size = New System.Drawing.Size(433, 17)
        Me.lblNavigate.TabIndex = 11
        Me.lblNavigate.Text = "All fields are mandatory, use the tab key to navigate between fields."
        '
        'mtbTown
        '
        Me.mtbTown.Location = New System.Drawing.Point(187, 225)
        Me.mtbTown.Mask = "LLLLLLLLLLLLLLL"
        Me.mtbTown.Name = "mtbTown"
        Me.mtbTown.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbTown.Size = New System.Drawing.Size(144, 22)
        Me.mtbTown.TabIndex = 4
        '
        'mtbName
        '
        Me.mtbName.Location = New System.Drawing.Point(187, 50)
        Me.mtbName.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbName.Name = "mtbName"
        Me.mtbName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbName.Size = New System.Drawing.Size(144, 22)
        Me.mtbName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(118, 497)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExit.Size = New System.Drawing.Size(97, 39)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNextCustomer
        '
        Me.btnNextCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextCustomer.Location = New System.Drawing.Point(418, 497)
        Me.btnNextCustomer.Name = "btnNextCustomer"
        Me.btnNextCustomer.Size = New System.Drawing.Size(102, 39)
        Me.btnNextCustomer.TabIndex = 8
        Me.btnNextCustomer.Text = "Next"
        Me.btnNextCustomer.UseVisualStyleBackColor = True
        '
        'mtbAge
        '
        Me.mtbAge.Location = New System.Drawing.Point(187, 331)
        Me.mtbAge.Mask = "999"
        Me.mtbAge.Name = "mtbAge"
        Me.mtbAge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbAge.Size = New System.Drawing.Size(28, 22)
        Me.mtbAge.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(40, 334)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 17)
        Me.lblAge.TabIndex = 10
        Me.lblAge.Text = "Age:"
        '
        'cmbCounty
        '
        Me.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Items.AddRange(New Object() {"Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cmbCounty.Location = New System.Drawing.Point(187, 280)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(144, 24)
        Me.cmbCounty.TabIndex = 5
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(37, 283)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(56, 17)
        Me.lblCounty.TabIndex = 8
        Me.lblCounty.Text = "County:"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(37, 228)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(73, 17)
        Me.lblTown.TabIndex = 6
        Me.lblTown.Text = "Town/City:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(187, 163)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(144, 40)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(37, 166)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(106, 17)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Street Address:"
        '
        'mtbContact
        '
        Me.mtbContact.Location = New System.Drawing.Point(187, 104)
        Me.mtbContact.Mask = "(999) 000-0000"
        Me.mtbContact.Name = "mtbContact"
        Me.mtbContact.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbContact.Size = New System.Drawing.Size(144, 22)
        Me.mtbContact.TabIndex = 2
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(40, 107)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(114, 17)
        Me.lblContact.TabIndex = 2
        Me.lblContact.Text = "Contact Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(37, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'tabBooking
        '
        Me.tabBooking.BackColor = System.Drawing.Color.GhostWhite
        Me.tabBooking.Controls.Add(Me.btnBackBooking)
        Me.tabBooking.Controls.Add(Me.btnNextBooking)
        Me.tabBooking.Controls.Add(Me.grpOptionalExtras)
        Me.tabBooking.Controls.Add(Me.grpHotel)
        Me.tabBooking.Controls.Add(Me.grpBookingDates)
        Me.tabBooking.Location = New System.Drawing.Point(4, 4)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBooking.Size = New System.Drawing.Size(661, 646)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking Details"
        '
        'btnBackBooking
        '
        Me.btnBackBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackBooking.Location = New System.Drawing.Point(53, 574)
        Me.btnBackBooking.Name = "btnBackBooking"
        Me.btnBackBooking.Size = New System.Drawing.Size(104, 34)
        Me.btnBackBooking.TabIndex = 16
        Me.btnBackBooking.Text = "Back"
        Me.btnBackBooking.UseVisualStyleBackColor = True
        '
        'btnNextBooking
        '
        Me.btnNextBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextBooking.Location = New System.Drawing.Point(451, 574)
        Me.btnNextBooking.Name = "btnNextBooking"
        Me.btnNextBooking.Size = New System.Drawing.Size(96, 34)
        Me.btnNextBooking.TabIndex = 15
        Me.btnNextBooking.Text = "Next"
        Me.btnNextBooking.UseVisualStyleBackColor = True
        '
        'grpOptionalExtras
        '
        Me.grpOptionalExtras.Controls.Add(Me.rdoContinental)
        Me.grpOptionalExtras.Controls.Add(Me.rdoFullIrish)
        Me.grpOptionalExtras.Controls.Add(Me.nudLaundry)
        Me.grpOptionalExtras.Controls.Add(Me.lblLaundry)
        Me.grpOptionalExtras.Controls.Add(Me.chkBreakfast)
        Me.grpOptionalExtras.Controls.Add(Me.chkEveningMeal)
        Me.grpOptionalExtras.Controls.Add(Me.Label1)
        Me.grpOptionalExtras.Controls.Add(Me.nudOthers)
        Me.grpOptionalExtras.Controls.Add(Me.lblOthers)
        Me.grpOptionalExtras.Controls.Add(Me.nudShirts)
        Me.grpOptionalExtras.Controls.Add(Me.lblShirts)
        Me.grpOptionalExtras.Controls.Add(Me.lblSuits)
        Me.grpOptionalExtras.Controls.Add(Me.nudSuits)
        Me.grpOptionalExtras.Controls.Add(Me.lblDryCleaning)
        Me.grpOptionalExtras.Location = New System.Drawing.Point(53, 371)
        Me.grpOptionalExtras.Name = "grpOptionalExtras"
        Me.grpOptionalExtras.Size = New System.Drawing.Size(511, 177)
        Me.grpOptionalExtras.TabIndex = 2
        Me.grpOptionalExtras.TabStop = False
        Me.grpOptionalExtras.Text = "Optional Extras"
        '
        'rdoContinental
        '
        Me.rdoContinental.AutoSize = True
        Me.rdoContinental.Location = New System.Drawing.Point(149, 117)
        Me.rdoContinental.Name = "rdoContinental"
        Me.rdoContinental.Size = New System.Drawing.Size(100, 21)
        Me.rdoContinental.TabIndex = 12
        Me.rdoContinental.TabStop = True
        Me.rdoContinental.Text = "Continental"
        Me.rdoContinental.UseVisualStyleBackColor = True
        Me.rdoContinental.Visible = False
        '
        'rdoFullIrish
        '
        Me.rdoFullIrish.AutoSize = True
        Me.rdoFullIrish.Location = New System.Drawing.Point(261, 117)
        Me.rdoFullIrish.Name = "rdoFullIrish"
        Me.rdoFullIrish.Size = New System.Drawing.Size(81, 21)
        Me.rdoFullIrish.TabIndex = 13
        Me.rdoFullIrish.TabStop = True
        Me.rdoFullIrish.Text = "Full Irish"
        Me.rdoFullIrish.UseVisualStyleBackColor = True
        Me.rdoFullIrish.Visible = False
        '
        'nudLaundry
        '
        Me.nudLaundry.Location = New System.Drawing.Point(255, 78)
        Me.nudLaundry.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudLaundry.Name = "nudLaundry"
        Me.nudLaundry.Size = New System.Drawing.Size(60, 22)
        Me.nudLaundry.TabIndex = 10
        '
        'lblLaundry
        '
        Me.lblLaundry.AutoSize = True
        Me.lblLaundry.Location = New System.Drawing.Point(134, 80)
        Me.lblLaundry.Name = "lblLaundry"
        Me.lblLaundry.Size = New System.Drawing.Size(115, 17)
        Me.lblLaundry.TabIndex = 8
        Me.lblLaundry.Text = "Laundry Service:"
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(38, 117)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(90, 21)
        Me.chkBreakfast.TabIndex = 11
        Me.chkBreakfast.Text = "Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkEveningMeal
        '
        Me.chkEveningMeal.AutoSize = True
        Me.chkEveningMeal.Location = New System.Drawing.Point(358, 117)
        Me.chkEveningMeal.Name = "chkEveningMeal"
        Me.chkEveningMeal.Size = New System.Drawing.Size(115, 21)
        Me.chkEveningMeal.TabIndex = 14
        Me.chkEveningMeal.Text = "Evening Meal"
        Me.chkEveningMeal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 7
        '
        'nudOthers
        '
        Me.nudOthers.Location = New System.Drawing.Point(445, 40)
        Me.nudOthers.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudOthers.Name = "nudOthers"
        Me.nudOthers.Size = New System.Drawing.Size(60, 22)
        Me.nudOthers.TabIndex = 9
        '
        'lblOthers
        '
        Me.lblOthers.AutoSize = True
        Me.lblOthers.Location = New System.Drawing.Point(374, 42)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(65, 17)
        Me.lblOthers.TabIndex = 5
        Me.lblOthers.Text = "Other(s):"
        '
        'nudShirts
        '
        Me.nudShirts.Location = New System.Drawing.Point(308, 40)
        Me.nudShirts.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudShirts.Name = "nudShirts"
        Me.nudShirts.Size = New System.Drawing.Size(60, 22)
        Me.nudShirts.TabIndex = 8
        '
        'lblShirts
        '
        Me.lblShirts.AutoSize = True
        Me.lblShirts.Location = New System.Drawing.Point(244, 42)
        Me.lblShirts.Name = "lblShirts"
        Me.lblShirts.Size = New System.Drawing.Size(58, 17)
        Me.lblShirts.TabIndex = 3
        Me.lblShirts.Text = "Shirt(s):"
        '
        'lblSuits
        '
        Me.lblSuits.AutoSize = True
        Me.lblSuits.Location = New System.Drawing.Point(134, 42)
        Me.lblSuits.Name = "lblSuits"
        Me.lblSuits.Size = New System.Drawing.Size(53, 17)
        Me.lblSuits.TabIndex = 2
        Me.lblSuits.Text = "Suit(s):"
        '
        'nudSuits
        '
        Me.nudSuits.Location = New System.Drawing.Point(191, 40)
        Me.nudSuits.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudSuits.Name = "nudSuits"
        Me.nudSuits.Size = New System.Drawing.Size(54, 22)
        Me.nudSuits.TabIndex = 7
        '
        'lblDryCleaning
        '
        Me.lblDryCleaning.AutoSize = True
        Me.lblDryCleaning.Location = New System.Drawing.Point(35, 42)
        Me.lblDryCleaning.Name = "lblDryCleaning"
        Me.lblDryCleaning.Size = New System.Drawing.Size(93, 17)
        Me.lblDryCleaning.TabIndex = 0
        Me.lblDryCleaning.Text = "Dry Cleaning:"
        '
        'grpHotel
        '
        Me.grpHotel.Controls.Add(Me.nudTwinRooms)
        Me.grpHotel.Controls.Add(Me.nudSingleRooms)
        Me.grpHotel.Controls.Add(Me.lblTwinRooms)
        Me.grpHotel.Controls.Add(Me.lblSingleRooms)
        Me.grpHotel.Controls.Add(Me.nudGuests2)
        Me.grpHotel.Controls.Add(Me.lblGuestsNumber2)
        Me.grpHotel.Controls.Add(Me.nudGuests)
        Me.grpHotel.Controls.Add(Me.lblGuestNumber)
        Me.grpHotel.Controls.Add(Me.cmbHotel)
        Me.grpHotel.Controls.Add(Me.cmbLocation)
        Me.grpHotel.Controls.Add(Me.lblHotel)
        Me.grpHotel.Controls.Add(Me.lblLocation)
        Me.grpHotel.Location = New System.Drawing.Point(53, 150)
        Me.grpHotel.Name = "grpHotel"
        Me.grpHotel.Size = New System.Drawing.Size(511, 215)
        Me.grpHotel.TabIndex = 1
        Me.grpHotel.TabStop = False
        Me.grpHotel.Text = "Hotel"
        '
        'nudTwinRooms
        '
        Me.nudTwinRooms.Location = New System.Drawing.Point(364, 124)
        Me.nudTwinRooms.Name = "nudTwinRooms"
        Me.nudTwinRooms.Size = New System.Drawing.Size(46, 22)
        Me.nudTwinRooms.TabIndex = 12
        '
        'nudSingleRooms
        '
        Me.nudSingleRooms.Location = New System.Drawing.Point(145, 124)
        Me.nudSingleRooms.Name = "nudSingleRooms"
        Me.nudSingleRooms.Size = New System.Drawing.Size(45, 22)
        Me.nudSingleRooms.TabIndex = 11
        '
        'lblTwinRooms
        '
        Me.lblTwinRooms.AutoSize = True
        Me.lblTwinRooms.Location = New System.Drawing.Point(264, 126)
        Me.lblTwinRooms.Name = "lblTwinRooms"
        Me.lblTwinRooms.Size = New System.Drawing.Size(94, 17)
        Me.lblTwinRooms.TabIndex = 10
        Me.lblTwinRooms.Text = "Twin room(s):"
        '
        'lblSingleRooms
        '
        Me.lblSingleRooms.AutoSize = True
        Me.lblSingleRooms.Location = New System.Drawing.Point(35, 126)
        Me.lblSingleRooms.Name = "lblSingleRooms"
        Me.lblSingleRooms.Size = New System.Drawing.Size(104, 17)
        Me.lblSingleRooms.TabIndex = 9
        Me.lblSingleRooms.Text = "Single room(s):"
        '
        'nudGuests2
        '
        Me.nudGuests2.Location = New System.Drawing.Point(398, 161)
        Me.nudGuests2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudGuests2.Name = "nudGuests2"
        Me.nudGuests2.Size = New System.Drawing.Size(41, 22)
        Me.nudGuests2.TabIndex = 7
        '
        'lblGuestsNumber2
        '
        Me.lblGuestsNumber2.AutoSize = True
        Me.lblGuestsNumber2.Location = New System.Drawing.Point(258, 160)
        Me.lblGuestsNumber2.Name = "lblGuestsNumber2"
        Me.lblGuestsNumber2.Size = New System.Drawing.Size(134, 17)
        Me.lblGuestsNumber2.TabIndex = 6
        Me.lblGuestsNumber2.Text = "No. of guests (<16):"
        '
        'nudGuests
        '
        Me.nudGuests.Location = New System.Drawing.Point(171, 161)
        Me.nudGuests.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudGuests.Name = "nudGuests"
        Me.nudGuests.Size = New System.Drawing.Size(42, 22)
        Me.nudGuests.TabIndex = 5
        '
        'lblGuestNumber
        '
        Me.lblGuestNumber.AutoSize = True
        Me.lblGuestNumber.Location = New System.Drawing.Point(31, 163)
        Me.lblGuestNumber.Name = "lblGuestNumber"
        Me.lblGuestNumber.Size = New System.Drawing.Size(134, 17)
        Me.lblGuestNumber.TabIndex = 4
        Me.lblGuestNumber.Text = "No. of guests (16+):"
        '
        'cmbHotel
        '
        Me.cmbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHotel.FormattingEnabled = True
        Me.cmbHotel.Location = New System.Drawing.Point(181, 82)
        Me.cmbHotel.Name = "cmbHotel"
        Me.cmbHotel.Size = New System.Drawing.Size(195, 24)
        Me.cmbHotel.TabIndex = 4
        '
        'cmbLocation
        '
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Items.AddRange(New Object() {"Cork", "Dublin", "Kerry", "Limerick"})
        Me.cmbLocation.Location = New System.Drawing.Point(181, 36)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(195, 24)
        Me.cmbLocation.TabIndex = 3
        '
        'lblHotel
        '
        Me.lblHotel.AutoSize = True
        Me.lblHotel.Location = New System.Drawing.Point(31, 85)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(45, 17)
        Me.lblHotel.TabIndex = 1
        Me.lblHotel.Text = "Hotel:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(32, 45)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(66, 17)
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = "Location:"
        '
        'grpBookingDates
        '
        Me.grpBookingDates.Controls.Add(Me.mtbCheckIn)
        Me.grpBookingDates.Controls.Add(Me.mtbCheckOut)
        Me.grpBookingDates.Controls.Add(Me.lblCheckIn)
        Me.grpBookingDates.Controls.Add(Me.lblCheckOut)
        Me.grpBookingDates.Location = New System.Drawing.Point(53, 35)
        Me.grpBookingDates.Name = "grpBookingDates"
        Me.grpBookingDates.Size = New System.Drawing.Size(511, 109)
        Me.grpBookingDates.TabIndex = 0
        Me.grpBookingDates.TabStop = False
        Me.grpBookingDates.Text = "Booking Dates"
        '
        'mtbCheckIn
        '
        Me.mtbCheckIn.Location = New System.Drawing.Point(181, 30)
        Me.mtbCheckIn.Mask = "00/00/0000"
        Me.mtbCheckIn.Name = "mtbCheckIn"
        Me.mtbCheckIn.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCheckIn.Size = New System.Drawing.Size(100, 22)
        Me.mtbCheckIn.TabIndex = 1
        Me.mtbCheckIn.ValidatingType = GetType(Date)
        '
        'mtbCheckOut
        '
        Me.mtbCheckOut.Location = New System.Drawing.Point(181, 60)
        Me.mtbCheckOut.Mask = "00/00/0000"
        Me.mtbCheckOut.Name = "mtbCheckOut"
        Me.mtbCheckOut.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCheckOut.Size = New System.Drawing.Size(100, 22)
        Me.mtbCheckOut.TabIndex = 2
        Me.mtbCheckOut.ValidatingType = GetType(Date)
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Location = New System.Drawing.Point(32, 33)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(66, 17)
        Me.lblCheckIn.TabIndex = 1
        Me.lblCheckIn.Text = "Check In:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(35, 63)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(78, 17)
        Me.lblCheckOut.TabIndex = 0
        Me.lblCheckOut.Text = "Check Out:"
        '
        'tabGuest
        '
        Me.tabGuest.BackColor = System.Drawing.Color.GhostWhite
        Me.tabGuest.Controls.Add(Me.btnRemove)
        Me.tabGuest.Controls.Add(Me.dgvGuests)
        Me.tabGuest.Controls.Add(Me.rdoUnder16)
        Me.tabGuest.Controls.Add(Me.Label4)
        Me.tabGuest.Controls.Add(Me.rdoOver16)
        Me.tabGuest.Controls.Add(Me.lblGuestPassport)
        Me.tabGuest.Controls.Add(Me.lblGuestName)
        Me.tabGuest.Controls.Add(Me.mtbPassportGuest)
        Me.tabGuest.Controls.Add(Me.mtbNameGuest)
        Me.tabGuest.Controls.Add(Me.btnAdd)
        Me.tabGuest.Controls.Add(Me.btnBackGuest)
        Me.tabGuest.Controls.Add(Me.btnNextGuest)
        Me.tabGuest.Location = New System.Drawing.Point(4, 4)
        Me.tabGuest.Name = "tabGuest"
        Me.tabGuest.Size = New System.Drawing.Size(661, 646)
        Me.tabGuest.TabIndex = 3
        Me.tabGuest.Text = "Guest Details"
        '
        'dgvGuests
        '
        Me.dgvGuests.AllowUserToAddRows = False
        Me.dgvGuests.AllowUserToDeleteRows = False
        Me.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmName, Me.clmAge, Me.clmPassport})
        Me.dgvGuests.Location = New System.Drawing.Point(106, 240)
        Me.dgvGuests.Name = "dgvGuests"
        Me.dgvGuests.ReadOnly = True
        Me.dgvGuests.RowTemplate.Height = 24
        Me.dgvGuests.Size = New System.Drawing.Size(456, 274)
        Me.dgvGuests.TabIndex = 30
        '
        'rdoUnder16
        '
        Me.rdoUnder16.AutoSize = True
        Me.rdoUnder16.Location = New System.Drawing.Point(520, 136)
        Me.rdoUnder16.Name = "rdoUnder16"
        Me.rdoUnder16.Size = New System.Drawing.Size(53, 21)
        Me.rdoUnder16.TabIndex = 29
        Me.rdoUnder16.TabStop = True
        Me.rdoUnder16.Text = "<16"
        Me.rdoUnder16.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Age:"
        '
        'rdoOver16
        '
        Me.rdoOver16.AutoSize = True
        Me.rdoOver16.Location = New System.Drawing.Point(425, 136)
        Me.rdoOver16.Name = "rdoOver16"
        Me.rdoOver16.Size = New System.Drawing.Size(53, 21)
        Me.rdoOver16.TabIndex = 27
        Me.rdoOver16.TabStop = True
        Me.rdoOver16.Text = "16+"
        Me.rdoOver16.UseVisualStyleBackColor = True
        '
        'lblGuestPassport
        '
        Me.lblGuestPassport.AutoSize = True
        Me.lblGuestPassport.Location = New System.Drawing.Point(286, 184)
        Me.lblGuestPassport.Name = "lblGuestPassport"
        Me.lblGuestPassport.Size = New System.Drawing.Size(122, 17)
        Me.lblGuestPassport.TabIndex = 26
        Me.lblGuestPassport.Text = "Passport Number:"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(286, 88)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(49, 17)
        Me.lblGuestName.TabIndex = 25
        Me.lblGuestName.Text = "Name:"
        '
        'mtbPassportGuest
        '
        Me.mtbPassportGuest.Location = New System.Drawing.Point(425, 181)
        Me.mtbPassportGuest.Mask = "AAAAAAAA"
        Me.mtbPassportGuest.Name = "mtbPassportGuest"
        Me.mtbPassportGuest.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPassportGuest.Size = New System.Drawing.Size(148, 22)
        Me.mtbPassportGuest.TabIndex = 24
        '
        'mtbNameGuest
        '
        Me.mtbNameGuest.Location = New System.Drawing.Point(425, 85)
        Me.mtbNameGuest.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbNameGuest.Name = "mtbNameGuest"
        Me.mtbNameGuest.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbNameGuest.Size = New System.Drawing.Size(148, 22)
        Me.mtbNameGuest.TabIndex = 23
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(78, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 31)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBackGuest
        '
        Me.btnBackGuest.Location = New System.Drawing.Point(78, 546)
        Me.btnBackGuest.Name = "btnBackGuest"
        Me.btnBackGuest.Size = New System.Drawing.Size(88, 35)
        Me.btnBackGuest.TabIndex = 21
        Me.btnBackGuest.Text = "Back"
        Me.btnBackGuest.UseVisualStyleBackColor = True
        '
        'btnNextGuest
        '
        Me.btnNextGuest.Location = New System.Drawing.Point(472, 546)
        Me.btnNextGuest.Name = "btnNextGuest"
        Me.btnNextGuest.Size = New System.Drawing.Size(101, 35)
        Me.btnNextGuest.TabIndex = 20
        Me.btnNextGuest.Text = "Next"
        Me.btnNextGuest.UseVisualStyleBackColor = True
        '
        'tabAdditional
        '
        Me.tabAdditional.BackColor = System.Drawing.Color.GhostWhite
        Me.tabAdditional.Controls.Add(Me.lblPassportNumber)
        Me.tabAdditional.Controls.Add(Me.mtbPassportNumber)
        Me.tabAdditional.Controls.Add(Me.btnNextAdditional)
        Me.tabAdditional.Controls.Add(Me.btnBackAdditional)
        Me.tabAdditional.Controls.Add(Me.grpPaymentDetails)
        Me.tabAdditional.Location = New System.Drawing.Point(4, 4)
        Me.tabAdditional.Name = "tabAdditional"
        Me.tabAdditional.Size = New System.Drawing.Size(661, 646)
        Me.tabAdditional.TabIndex = 2
        Me.tabAdditional.Text = "Additional Details"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Location = New System.Drawing.Point(65, 53)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(122, 17)
        Me.lblPassportNumber.TabIndex = 9
        Me.lblPassportNumber.Text = "Passport Number:"
        '
        'mtbPassportNumber
        '
        Me.mtbPassportNumber.Location = New System.Drawing.Point(198, 50)
        Me.mtbPassportNumber.Mask = "AAAAAAAA"
        Me.mtbPassportNumber.Name = "mtbPassportNumber"
        Me.mtbPassportNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPassportNumber.Size = New System.Drawing.Size(126, 22)
        Me.mtbPassportNumber.TabIndex = 8
        '
        'btnNextAdditional
        '
        Me.btnNextAdditional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextAdditional.Location = New System.Drawing.Point(529, 499)
        Me.btnNextAdditional.Name = "btnNextAdditional"
        Me.btnNextAdditional.Size = New System.Drawing.Size(93, 36)
        Me.btnNextAdditional.TabIndex = 6
        Me.btnNextAdditional.Text = "Next"
        Me.btnNextAdditional.UseVisualStyleBackColor = True
        '
        'btnBackAdditional
        '
        Me.btnBackAdditional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackAdditional.Location = New System.Drawing.Point(68, 499)
        Me.btnBackAdditional.Name = "btnBackAdditional"
        Me.btnBackAdditional.Size = New System.Drawing.Size(93, 36)
        Me.btnBackAdditional.TabIndex = 7
        Me.btnBackAdditional.Text = "Back"
        Me.btnBackAdditional.UseVisualStyleBackColor = True
        '
        'grpPaymentDetails
        '
        Me.grpPaymentDetails.Controls.Add(Me.PictureBox4)
        Me.grpPaymentDetails.Controls.Add(Me.PictureBox3)
        Me.grpPaymentDetails.Controls.Add(Me.PictureBox2)
        Me.grpPaymentDetails.Controls.Add(Me.PictureBox1)
        Me.grpPaymentDetails.Controls.Add(Me.rdoLaser)
        Me.grpPaymentDetails.Controls.Add(Me.rdoAmEx)
        Me.grpPaymentDetails.Controls.Add(Me.rdoVisa)
        Me.grpPaymentDetails.Controls.Add(Me.rdoMastercard)
        Me.grpPaymentDetails.Controls.Add(Me.mtbCardNumber)
        Me.grpPaymentDetails.Controls.Add(Me.lblCardNumber)
        Me.grpPaymentDetails.Controls.Add(Me.lblPaymentType)
        Me.grpPaymentDetails.Location = New System.Drawing.Point(68, 120)
        Me.grpPaymentDetails.Name = "grpPaymentDetails"
        Me.grpPaymentDetails.Size = New System.Drawing.Size(554, 194)
        Me.grpPaymentDetails.TabIndex = 1
        Me.grpPaymentDetails.TabStop = False
        Me.grpPaymentDetails.Text = "Payment Details"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(327, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(69, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(116, 88)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(327, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'rdoLaser
        '
        Me.rdoLaser.AutoSize = True
        Me.rdoLaser.Location = New System.Drawing.Point(191, 101)
        Me.rdoLaser.Name = "rdoLaser"
        Me.rdoLaser.Size = New System.Drawing.Size(65, 21)
        Me.rdoLaser.TabIndex = 3
        Me.rdoLaser.TabStop = True
        Me.rdoLaser.Text = "Laser"
        Me.rdoLaser.UseVisualStyleBackColor = True
        '
        'rdoAmEx
        '
        Me.rdoAmEx.AutoSize = True
        Me.rdoAmEx.Location = New System.Drawing.Point(402, 101)
        Me.rdoAmEx.Name = "rdoAmEx"
        Me.rdoAmEx.Size = New System.Drawing.Size(142, 21)
        Me.rdoAmEx.TabIndex = 4
        Me.rdoAmEx.TabStop = True
        Me.rdoAmEx.Text = "American Express"
        Me.rdoAmEx.UseVisualStyleBackColor = True
        '
        'rdoVisa
        '
        Me.rdoVisa.AutoSize = True
        Me.rdoVisa.Location = New System.Drawing.Point(402, 38)
        Me.rdoVisa.Name = "rdoVisa"
        Me.rdoVisa.Size = New System.Drawing.Size(56, 21)
        Me.rdoVisa.TabIndex = 2
        Me.rdoVisa.TabStop = True
        Me.rdoVisa.Text = "Visa"
        Me.rdoVisa.UseVisualStyleBackColor = True
        '
        'rdoMastercard
        '
        Me.rdoMastercard.AutoSize = True
        Me.rdoMastercard.Location = New System.Drawing.Point(191, 40)
        Me.rdoMastercard.Name = "rdoMastercard"
        Me.rdoMastercard.Size = New System.Drawing.Size(102, 21)
        Me.rdoMastercard.TabIndex = 1
        Me.rdoMastercard.TabStop = True
        Me.rdoMastercard.Text = "MasterCard"
        Me.rdoMastercard.UseVisualStyleBackColor = True
        '
        'mtbCardNumber
        '
        Me.mtbCardNumber.Location = New System.Drawing.Point(149, 153)
        Me.mtbCardNumber.Mask = "00000000"
        Me.mtbCardNumber.Name = "mtbCardNumber"
        Me.mtbCardNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardNumber.Size = New System.Drawing.Size(116, 22)
        Me.mtbCardNumber.TabIndex = 5
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(14, 156)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(96, 17)
        Me.lblCardNumber.TabIndex = 1
        Me.lblCardNumber.Text = "Card Number:"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(7, 40)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(103, 17)
        Me.lblPaymentType.TabIndex = 0
        Me.lblPaymentType.Text = "Payment Type:"
        '
        'tabInvoice
        '
        Me.tabInvoice.Controls.Add(Me.btnFinish)
        Me.tabInvoice.Controls.Add(Me.btnBackInvoice)
        Me.tabInvoice.Controls.Add(Me.lstInvoice)
        Me.tabInvoice.Location = New System.Drawing.Point(4, 4)
        Me.tabInvoice.Name = "tabInvoice"
        Me.tabInvoice.Size = New System.Drawing.Size(661, 646)
        Me.tabInvoice.TabIndex = 4
        Me.tabInvoice.Text = "Invoice"
        Me.tabInvoice.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinish.Location = New System.Drawing.Point(520, 568)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(108, 35)
        Me.btnFinish.TabIndex = 11
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnBackInvoice
        '
        Me.btnBackInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackInvoice.Location = New System.Drawing.Point(40, 568)
        Me.btnBackInvoice.Name = "btnBackInvoice"
        Me.btnBackInvoice.Size = New System.Drawing.Size(106, 35)
        Me.btnBackInvoice.TabIndex = 10
        Me.btnBackInvoice.Text = "Back"
        Me.btnBackInvoice.UseVisualStyleBackColor = True
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 16
        Me.lstInvoice.Location = New System.Drawing.Point(40, 34)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(588, 468)
        Me.lstInvoice.TabIndex = 9
        '
        'tabPrice
        '
        Me.tabPrice.Controls.Add(Me.btnBackPrice)
        Me.tabPrice.Controls.Add(Me.btnNextPrice)
        Me.tabPrice.Controls.Add(Me.lstPriceQuote)
        Me.tabPrice.Location = New System.Drawing.Point(4, 4)
        Me.tabPrice.Name = "tabPrice"
        Me.tabPrice.Size = New System.Drawing.Size(661, 646)
        Me.tabPrice.TabIndex = 5
        Me.tabPrice.Text = "Price Quote"
        Me.tabPrice.UseVisualStyleBackColor = True
        '
        'lstPriceQuote
        '
        Me.lstPriceQuote.FormattingEnabled = True
        Me.lstPriceQuote.ItemHeight = 16
        Me.lstPriceQuote.Location = New System.Drawing.Point(47, 36)
        Me.lstPriceQuote.Name = "lstPriceQuote"
        Me.lstPriceQuote.Size = New System.Drawing.Size(581, 436)
        Me.lstPriceQuote.TabIndex = 0
        '
        'btnNextPrice
        '
        Me.btnNextPrice.Location = New System.Drawing.Point(529, 549)
        Me.btnNextPrice.Name = "btnNextPrice"
        Me.btnNextPrice.Size = New System.Drawing.Size(99, 38)
        Me.btnNextPrice.TabIndex = 1
        Me.btnNextPrice.Text = "Next"
        Me.btnNextPrice.UseVisualStyleBackColor = True
        '
        'btnBackPrice
        '
        Me.btnBackPrice.Location = New System.Drawing.Point(47, 549)
        Me.btnBackPrice.Name = "btnBackPrice"
        Me.btnBackPrice.Size = New System.Drawing.Size(103, 38)
        Me.btnBackPrice.TabIndex = 2
        Me.btnBackPrice.Text = "Back"
        Me.btnBackPrice.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(78, 151)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(111, 35)
        Me.btnRemove.TabIndex = 31
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'clmName
        '
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        Me.clmName.ReadOnly = True
        '
        'clmAge
        '
        Me.clmAge.HeaderText = "16+?"
        Me.clmAge.Name = "clmAge"
        Me.clmAge.ReadOnly = True
        '
        'clmPassport
        '
        Me.clmPassport.HeaderText = "Passport No."
        Me.clmPassport.Name = "clmPassport"
        Me.clmPassport.ReadOnly = True
        '
        'frmPriceQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(763, 686)
        Me.Controls.Add(Me.tabPriceQuote)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPriceQuote"
        Me.Text = "Price Quote"
        Me.tabPriceQuote.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.tabCustomer.PerformLayout()
        Me.tabBooking.ResumeLayout(False)
        Me.grpOptionalExtras.ResumeLayout(False)
        Me.grpOptionalExtras.PerformLayout()
        CType(Me.nudLaundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOthers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShirts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSuits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHotel.ResumeLayout(False)
        Me.grpHotel.PerformLayout()
        CType(Me.nudTwinRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSingleRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGuests2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBookingDates.ResumeLayout(False)
        Me.grpBookingDates.PerformLayout()
        Me.tabGuest.ResumeLayout(False)
        Me.tabGuest.PerformLayout()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdditional.ResumeLayout(False)
        Me.tabAdditional.PerformLayout()
        Me.grpPaymentDetails.ResumeLayout(False)
        Me.grpPaymentDetails.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInvoice.ResumeLayout(False)
        Me.tabPrice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPriceQuote As System.Windows.Forms.TabControl
    Friend WithEvents tabCustomer As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNextCustomer As System.Windows.Forms.Button
    Friend WithEvents mtbAge As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents cmbCounty As System.Windows.Forms.ComboBox
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents mtbContact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents tabBooking As System.Windows.Forms.TabPage
    Friend WithEvents tabAdditional As System.Windows.Forms.TabPage
    Friend WithEvents mtbName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbTown As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpOptionalExtras As System.Windows.Forms.GroupBox
    Friend WithEvents grpBookingDates As System.Windows.Forms.GroupBox
    Friend WithEvents mtbCheckIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCheckOut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents nudLaundry As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLaundry As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudOthers As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOthers As System.Windows.Forms.Label
    Friend WithEvents nudShirts As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblShirts As System.Windows.Forms.Label
    Friend WithEvents lblSuits As System.Windows.Forms.Label
    Friend WithEvents nudSuits As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDryCleaning As System.Windows.Forms.Label
    Friend WithEvents btnBackBooking As System.Windows.Forms.Button
    Friend WithEvents btnNextBooking As System.Windows.Forms.Button
    Friend WithEvents grpPaymentDetails As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rdoLaser As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAmEx As System.Windows.Forms.RadioButton
    Friend WithEvents rdoVisa As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMastercard As System.Windows.Forms.RadioButton
    Friend WithEvents mtbCardNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCardNumber As System.Windows.Forms.Label
    Friend WithEvents lblPaymentType As System.Windows.Forms.Label
    Friend WithEvents btnNextAdditional As System.Windows.Forms.Button
    Friend WithEvents btnBackAdditional As System.Windows.Forms.Button
    Friend WithEvents tabGuest As System.Windows.Forms.TabPage
    Friend WithEvents rdoContinental As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFullIrish As System.Windows.Forms.RadioButton
    Friend WithEvents chkBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents chkEveningMeal As System.Windows.Forms.CheckBox
    Friend WithEvents grpHotel As System.Windows.Forms.GroupBox
    Friend WithEvents nudGuests2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGuestsNumber2 As System.Windows.Forms.Label
    Friend WithEvents nudGuests As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGuestNumber As System.Windows.Forms.Label
    Friend WithEvents cmbHotel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents lblHotel As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnBackGuest As System.Windows.Forms.Button
    Friend WithEvents btnNextGuest As System.Windows.Forms.Button
    Friend WithEvents nudTwinRooms As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSingleRooms As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTwinRooms As System.Windows.Forms.Label
    Friend WithEvents lblSingleRooms As System.Windows.Forms.Label
    Friend WithEvents tabInvoice As System.Windows.Forms.TabPage
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox
    Friend WithEvents lblPassportNumber As System.Windows.Forms.Label
    Friend WithEvents mtbPassportNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents btnBackInvoice As System.Windows.Forms.Button
    Friend WithEvents dgvGuests As System.Windows.Forms.DataGridView
    Friend WithEvents rdoUnder16 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdoOver16 As System.Windows.Forms.RadioButton
    Friend WithEvents lblGuestPassport As System.Windows.Forms.Label
    Friend WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents mtbPassportGuest As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbNameGuest As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblNavigate As System.Windows.Forms.Label
    Friend WithEvents tabPrice As System.Windows.Forms.TabPage
    Friend WithEvents btnBackPrice As System.Windows.Forms.Button
    Friend WithEvents btnNextPrice As System.Windows.Forms.Button
    Friend WithEvents lstPriceQuote As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents clmName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPassport As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
