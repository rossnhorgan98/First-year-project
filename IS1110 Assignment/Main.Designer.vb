<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblPage1 = New System.Windows.Forms.Label()
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
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblPage2 = New System.Windows.Forms.Label()
        Me.btnBackBooking = New System.Windows.Forms.Button()
        Me.btnNextBooking = New System.Windows.Forms.Button()
        Me.grpOptionalExtras = New System.Windows.Forms.GroupBox()
        Me.chkLaundry = New System.Windows.Forms.CheckBox()
        Me.chkDryCleaning = New System.Windows.Forms.CheckBox()
        Me.lblBags = New System.Windows.Forms.Label()
        Me.rdoContinental = New System.Windows.Forms.RadioButton()
        Me.rdoFullIrish = New System.Windows.Forms.RadioButton()
        Me.nudLaundry = New System.Windows.Forms.NumericUpDown()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkEveningMeal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudOthers = New System.Windows.Forms.NumericUpDown()
        Me.lblOthers = New System.Windows.Forms.Label()
        Me.nudShirts = New System.Windows.Forms.NumericUpDown()
        Me.lblShirts = New System.Windows.Forms.Label()
        Me.lblSuits = New System.Windows.Forms.Label()
        Me.nudSuits = New System.Windows.Forms.NumericUpDown()
        Me.grpHotel = New System.Windows.Forms.GroupBox()
        Me.nudTwinRooms = New System.Windows.Forms.NumericUpDown()
        Me.nudSingleRooms = New System.Windows.Forms.NumericUpDown()
        Me.lblTwinRooms = New System.Windows.Forms.Label()
        Me.lblSingleRooms = New System.Windows.Forms.Label()
        Me.cmbHotel = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.grpBookingDates = New System.Windows.Forms.GroupBox()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.tabGuest = New System.Windows.Forms.TabPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblPage3 = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.dgvGuests = New System.Windows.Forms.DataGridView()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPassport = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.tabPriceQuote = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.lblPage4 = New System.Windows.Forms.Label()
        Me.btnBackPrice = New System.Windows.Forms.Button()
        Me.btnNextPrice = New System.Windows.Forms.Button()
        Me.lstPriceQuote = New System.Windows.Forms.ListBox()
        Me.tabAdditional = New System.Windows.Forms.TabPage()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.lblPage5 = New System.Windows.Forms.Label()
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
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lblPage6 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnBackInvoice = New System.Windows.Forms.Button()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.tabControl.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBooking.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOptionalExtras.SuspendLayout()
        CType(Me.nudLaundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShirts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSuits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHotel.SuspendLayout()
        CType(Me.nudTwinRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSingleRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookingDates.SuspendLayout()
        Me.tabGuest.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPriceQuote.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdditional.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPaymentDetails.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInvoice.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.tabControl.Controls.Add(Me.tabCustomer)
        Me.tabControl.Controls.Add(Me.tabBooking)
        Me.tabControl.Controls.Add(Me.tabGuest)
        Me.tabControl.Controls.Add(Me.tabPriceQuote)
        Me.tabControl.Controls.Add(Me.tabAdditional)
        Me.tabControl.Controls.Add(Me.tabInvoice)
        Me.tabControl.Location = New System.Drawing.Point(35, 12)
        Me.tabControl.Multiline = True
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(710, 690)
        Me.tabControl.TabIndex = 0
        '
        'tabCustomer
        '
        Me.tabCustomer.BackColor = System.Drawing.Color.GhostWhite
        Me.tabCustomer.Controls.Add(Me.PictureBox5)
        Me.tabCustomer.Controls.Add(Me.lblPage1)
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
        Me.tabCustomer.Size = New System.Drawing.Size(681, 682)
        Me.tabCustomer.TabIndex = 0
        Me.tabCustomer.Text = "Customer Details"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(237, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(193, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'lblPage1
        '
        Me.lblPage1.AutoSize = True
        Me.lblPage1.Location = New System.Drawing.Point(285, 508)
        Me.lblPage1.Name = "lblPage1"
        Me.lblPage1.Size = New System.Drawing.Size(75, 17)
        Me.lblPage1.TabIndex = 12
        Me.lblPage1.Text = "Page (1/6)"
        '
        'lblNavigate
        '
        Me.lblNavigate.AutoSize = True
        Me.lblNavigate.Location = New System.Drawing.Point(124, 108)
        Me.lblNavigate.Name = "lblNavigate"
        Me.lblNavigate.Size = New System.Drawing.Size(433, 17)
        Me.lblNavigate.TabIndex = 11
        Me.lblNavigate.Text = "All fields are mandatory, use the tab key to navigate between fields."
        '
        'mtbTown
        '
        Me.mtbTown.Location = New System.Drawing.Point(196, 316)
        Me.mtbTown.Mask = "LLLLLLLLLLLLLLL"
        Me.mtbTown.Name = "mtbTown"
        Me.mtbTown.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbTown.Size = New System.Drawing.Size(144, 22)
        Me.mtbTown.TabIndex = 4
        '
        'mtbName
        '
        Me.mtbName.Location = New System.Drawing.Point(196, 141)
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
        Me.mtbAge.Location = New System.Drawing.Point(196, 422)
        Me.mtbAge.Mask = "999"
        Me.mtbAge.Name = "mtbAge"
        Me.mtbAge.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbAge.Size = New System.Drawing.Size(28, 22)
        Me.mtbAge.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(49, 425)
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
        Me.cmbCounty.Location = New System.Drawing.Point(196, 371)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(144, 24)
        Me.cmbCounty.TabIndex = 5
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(46, 374)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(56, 17)
        Me.lblCounty.TabIndex = 8
        Me.lblCounty.Text = "County:"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(46, 319)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(73, 17)
        Me.lblTown.TabIndex = 6
        Me.lblTown.Text = "Town/City:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(196, 254)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(144, 40)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(46, 257)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(106, 17)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Street Address:"
        '
        'mtbContact
        '
        Me.mtbContact.Location = New System.Drawing.Point(196, 195)
        Me.mtbContact.Mask = "(999) 000-0000"
        Me.mtbContact.Name = "mtbContact"
        Me.mtbContact.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbContact.Size = New System.Drawing.Size(144, 22)
        Me.mtbContact.TabIndex = 2
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(49, 198)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(114, 17)
        Me.lblContact.TabIndex = 2
        Me.lblContact.Text = "Contact Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(46, 144)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'tabBooking
        '
        Me.tabBooking.BackColor = System.Drawing.Color.GhostWhite
        Me.tabBooking.Controls.Add(Me.PictureBox6)
        Me.tabBooking.Controls.Add(Me.lblPage2)
        Me.tabBooking.Controls.Add(Me.btnBackBooking)
        Me.tabBooking.Controls.Add(Me.btnNextBooking)
        Me.tabBooking.Controls.Add(Me.grpOptionalExtras)
        Me.tabBooking.Controls.Add(Me.grpHotel)
        Me.tabBooking.Controls.Add(Me.grpBookingDates)
        Me.tabBooking.Location = New System.Drawing.Point(4, 4)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBooking.Size = New System.Drawing.Size(681, 682)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking Details"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(237, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(170, 69)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'lblPage2
        '
        Me.lblPage2.AutoSize = True
        Me.lblPage2.Location = New System.Drawing.Point(283, 629)
        Me.lblPage2.Name = "lblPage2"
        Me.lblPage2.Size = New System.Drawing.Size(75, 17)
        Me.lblPage2.TabIndex = 17
        Me.lblPage2.Text = "Page (2/6)"
        '
        'btnBackBooking
        '
        Me.btnBackBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackBooking.Location = New System.Drawing.Point(56, 620)
        Me.btnBackBooking.Name = "btnBackBooking"
        Me.btnBackBooking.Size = New System.Drawing.Size(104, 34)
        Me.btnBackBooking.TabIndex = 16
        Me.btnBackBooking.Text = "Back"
        Me.btnBackBooking.UseVisualStyleBackColor = True
        '
        'btnNextBooking
        '
        Me.btnNextBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextBooking.Location = New System.Drawing.Point(471, 620)
        Me.btnNextBooking.Name = "btnNextBooking"
        Me.btnNextBooking.Size = New System.Drawing.Size(96, 34)
        Me.btnNextBooking.TabIndex = 15
        Me.btnNextBooking.Text = "Next"
        Me.btnNextBooking.UseVisualStyleBackColor = True
        '
        'grpOptionalExtras
        '
        Me.grpOptionalExtras.Controls.Add(Me.chkLaundry)
        Me.grpOptionalExtras.Controls.Add(Me.chkDryCleaning)
        Me.grpOptionalExtras.Controls.Add(Me.lblBags)
        Me.grpOptionalExtras.Controls.Add(Me.rdoContinental)
        Me.grpOptionalExtras.Controls.Add(Me.rdoFullIrish)
        Me.grpOptionalExtras.Controls.Add(Me.nudLaundry)
        Me.grpOptionalExtras.Controls.Add(Me.chkBreakfast)
        Me.grpOptionalExtras.Controls.Add(Me.chkEveningMeal)
        Me.grpOptionalExtras.Controls.Add(Me.Label1)
        Me.grpOptionalExtras.Controls.Add(Me.nudOthers)
        Me.grpOptionalExtras.Controls.Add(Me.lblOthers)
        Me.grpOptionalExtras.Controls.Add(Me.nudShirts)
        Me.grpOptionalExtras.Controls.Add(Me.lblShirts)
        Me.grpOptionalExtras.Controls.Add(Me.lblSuits)
        Me.grpOptionalExtras.Controls.Add(Me.nudSuits)
        Me.grpOptionalExtras.Location = New System.Drawing.Point(56, 417)
        Me.grpOptionalExtras.Name = "grpOptionalExtras"
        Me.grpOptionalExtras.Size = New System.Drawing.Size(548, 178)
        Me.grpOptionalExtras.TabIndex = 2
        Me.grpOptionalExtras.TabStop = False
        Me.grpOptionalExtras.Text = "Optional Extras"
        '
        'chkLaundry
        '
        Me.chkLaundry.AutoSize = True
        Me.chkLaundry.Location = New System.Drawing.Point(17, 79)
        Me.chkLaundry.Name = "chkLaundry"
        Me.chkLaundry.Size = New System.Drawing.Size(133, 21)
        Me.chkLaundry.TabIndex = 17
        Me.chkLaundry.Text = "Laundry Service"
        Me.chkLaundry.UseVisualStyleBackColor = True
        '
        'chkDryCleaning
        '
        Me.chkDryCleaning.AutoSize = True
        Me.chkDryCleaning.Location = New System.Drawing.Point(17, 40)
        Me.chkDryCleaning.Name = "chkDryCleaning"
        Me.chkDryCleaning.Size = New System.Drawing.Size(111, 21)
        Me.chkDryCleaning.TabIndex = 16
        Me.chkDryCleaning.Text = "Dry Cleaning"
        Me.chkDryCleaning.UseVisualStyleBackColor = True
        '
        'lblBags
        '
        Me.lblBags.AutoSize = True
        Me.lblBags.Location = New System.Drawing.Point(227, 80)
        Me.lblBags.Name = "lblBags"
        Me.lblBags.Size = New System.Drawing.Size(49, 17)
        Me.lblBags.TabIndex = 15
        Me.lblBags.Text = "bag(s)"
        Me.lblBags.Visible = False
        '
        'rdoContinental
        '
        Me.rdoContinental.AutoSize = True
        Me.rdoContinental.Location = New System.Drawing.Point(113, 117)
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
        Me.rdoFullIrish.Location = New System.Drawing.Point(219, 117)
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
        Me.nudLaundry.Location = New System.Drawing.Point(156, 78)
        Me.nudLaundry.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudLaundry.Name = "nudLaundry"
        Me.nudLaundry.Size = New System.Drawing.Size(60, 22)
        Me.nudLaundry.TabIndex = 10
        Me.nudLaundry.Visible = False
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(17, 117)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(90, 21)
        Me.chkBreakfast.TabIndex = 11
        Me.chkBreakfast.Text = "Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkEveningMeal
        '
        Me.chkEveningMeal.AutoSize = True
        Me.chkEveningMeal.Location = New System.Drawing.Point(17, 151)
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
        Me.nudOthers.Location = New System.Drawing.Point(471, 40)
        Me.nudOthers.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudOthers.Name = "nudOthers"
        Me.nudOthers.Size = New System.Drawing.Size(60, 22)
        Me.nudOthers.TabIndex = 9
        Me.nudOthers.Visible = False
        '
        'lblOthers
        '
        Me.lblOthers.AutoSize = True
        Me.lblOthers.Location = New System.Drawing.Point(400, 42)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(65, 17)
        Me.lblOthers.TabIndex = 5
        Me.lblOthers.Text = "Other(s):"
        Me.lblOthers.Visible = False
        '
        'nudShirts
        '
        Me.nudShirts.Location = New System.Drawing.Point(325, 40)
        Me.nudShirts.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudShirts.Name = "nudShirts"
        Me.nudShirts.Size = New System.Drawing.Size(60, 22)
        Me.nudShirts.TabIndex = 8
        Me.nudShirts.Visible = False
        '
        'lblShirts
        '
        Me.lblShirts.AutoSize = True
        Me.lblShirts.Location = New System.Drawing.Point(261, 42)
        Me.lblShirts.Name = "lblShirts"
        Me.lblShirts.Size = New System.Drawing.Size(58, 17)
        Me.lblShirts.TabIndex = 3
        Me.lblShirts.Text = "Shirt(s):"
        Me.lblShirts.Visible = False
        '
        'lblSuits
        '
        Me.lblSuits.AutoSize = True
        Me.lblSuits.Location = New System.Drawing.Point(134, 42)
        Me.lblSuits.Name = "lblSuits"
        Me.lblSuits.Size = New System.Drawing.Size(53, 17)
        Me.lblSuits.TabIndex = 2
        Me.lblSuits.Text = "Suit(s):"
        Me.lblSuits.Visible = False
        '
        'nudSuits
        '
        Me.nudSuits.Location = New System.Drawing.Point(191, 40)
        Me.nudSuits.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudSuits.Name = "nudSuits"
        Me.nudSuits.Size = New System.Drawing.Size(54, 22)
        Me.nudSuits.TabIndex = 7
        Me.nudSuits.Visible = False
        '
        'grpHotel
        '
        Me.grpHotel.Controls.Add(Me.nudTwinRooms)
        Me.grpHotel.Controls.Add(Me.nudSingleRooms)
        Me.grpHotel.Controls.Add(Me.lblTwinRooms)
        Me.grpHotel.Controls.Add(Me.lblSingleRooms)
        Me.grpHotel.Controls.Add(Me.cmbHotel)
        Me.grpHotel.Controls.Add(Me.cmbLocation)
        Me.grpHotel.Controls.Add(Me.lblHotel)
        Me.grpHotel.Controls.Add(Me.lblLocation)
        Me.grpHotel.Location = New System.Drawing.Point(56, 196)
        Me.grpHotel.Name = "grpHotel"
        Me.grpHotel.Size = New System.Drawing.Size(511, 215)
        Me.grpHotel.TabIndex = 1
        Me.grpHotel.TabStop = False
        Me.grpHotel.Text = "Hotel"
        '
        'nudTwinRooms
        '
        Me.nudTwinRooms.Location = New System.Drawing.Point(358, 149)
        Me.nudTwinRooms.Name = "nudTwinRooms"
        Me.nudTwinRooms.Size = New System.Drawing.Size(46, 22)
        Me.nudTwinRooms.TabIndex = 12
        '
        'nudSingleRooms
        '
        Me.nudSingleRooms.Location = New System.Drawing.Point(142, 149)
        Me.nudSingleRooms.Name = "nudSingleRooms"
        Me.nudSingleRooms.Size = New System.Drawing.Size(45, 22)
        Me.nudSingleRooms.TabIndex = 11
        '
        'lblTwinRooms
        '
        Me.lblTwinRooms.AutoSize = True
        Me.lblTwinRooms.Location = New System.Drawing.Point(248, 154)
        Me.lblTwinRooms.Name = "lblTwinRooms"
        Me.lblTwinRooms.Size = New System.Drawing.Size(94, 17)
        Me.lblTwinRooms.TabIndex = 10
        Me.lblTwinRooms.Text = "Twin room(s):"
        '
        'lblSingleRooms
        '
        Me.lblSingleRooms.AutoSize = True
        Me.lblSingleRooms.Location = New System.Drawing.Point(32, 154)
        Me.lblSingleRooms.Name = "lblSingleRooms"
        Me.lblSingleRooms.Size = New System.Drawing.Size(104, 17)
        Me.lblSingleRooms.TabIndex = 9
        Me.lblSingleRooms.Text = "Single room(s):"
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
        Me.grpBookingDates.Controls.Add(Me.dtpCheckOut)
        Me.grpBookingDates.Controls.Add(Me.dtpCheckIn)
        Me.grpBookingDates.Controls.Add(Me.lblCheckIn)
        Me.grpBookingDates.Controls.Add(Me.lblCheckOut)
        Me.grpBookingDates.Location = New System.Drawing.Point(56, 81)
        Me.grpBookingDates.Name = "grpBookingDates"
        Me.grpBookingDates.Size = New System.Drawing.Size(511, 109)
        Me.grpBookingDates.TabIndex = 0
        Me.grpBookingDates.TabStop = False
        Me.grpBookingDates.Text = "Booking Dates"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckOut.Location = New System.Drawing.Point(149, 60)
        Me.dtpCheckOut.MinDate = New Date(2016, 11, 15, 0, 0, 0, 0)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(111, 22)
        Me.dtpCheckOut.TabIndex = 3
        Me.dtpCheckOut.Value = New Date(2016, 11, 15, 0, 0, 0, 0)
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckIn.Location = New System.Drawing.Point(149, 28)
        Me.dtpCheckIn.MinDate = New Date(2016, 11, 14, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(111, 22)
        Me.dtpCheckIn.TabIndex = 1
        Me.dtpCheckIn.Value = New Date(2016, 11, 14, 0, 0, 0, 0)
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
        Me.lblCheckOut.Location = New System.Drawing.Point(32, 65)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(78, 17)
        Me.lblCheckOut.TabIndex = 0
        Me.lblCheckOut.Text = "Check Out:"
        '
        'tabGuest
        '
        Me.tabGuest.BackColor = System.Drawing.Color.GhostWhite
        Me.tabGuest.Controls.Add(Me.PictureBox7)
        Me.tabGuest.Controls.Add(Me.lblPage3)
        Me.tabGuest.Controls.Add(Me.lblEnter)
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
        Me.tabGuest.Size = New System.Drawing.Size(681, 682)
        Me.tabGuest.TabIndex = 3
        Me.tabGuest.Text = "Guest Details"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(263, 13)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(198, 74)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 34
        Me.PictureBox7.TabStop = False
        '
        'lblPage3
        '
        Me.lblPage3.AutoSize = True
        Me.lblPage3.Location = New System.Drawing.Point(287, 619)
        Me.lblPage3.Name = "lblPage3"
        Me.lblPage3.Size = New System.Drawing.Size(75, 17)
        Me.lblPage3.TabIndex = 33
        Me.lblPage3.Text = "Page (3/6)"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(186, 105)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(322, 17)
        Me.lblEnter.TabIndex = 32
        Me.lblEnter.Text = "Please enter in details for additional guests if any."
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.Location = New System.Drawing.Point(477, 228)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(123, 35)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove guest"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'dgvGuests
        '
        Me.dgvGuests.AllowUserToAddRows = False
        Me.dgvGuests.AllowUserToDeleteRows = False
        Me.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmName, Me.clmAge, Me.clmPassport})
        Me.dgvGuests.Location = New System.Drawing.Point(121, 304)
        Me.dgvGuests.Name = "dgvGuests"
        Me.dgvGuests.ReadOnly = True
        Me.dgvGuests.RowTemplate.Height = 24
        Me.dgvGuests.Size = New System.Drawing.Size(456, 274)
        Me.dgvGuests.TabIndex = 30
        '
        'clmName
        '
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        Me.clmName.ReadOnly = True
        '
        'clmAge
        '
        Me.clmAge.HeaderText = "16+"
        Me.clmAge.Name = "clmAge"
        Me.clmAge.ReadOnly = True
        '
        'clmPassport
        '
        Me.clmPassport.HeaderText = "Passport No."
        Me.clmPassport.Name = "clmPassport"
        Me.clmPassport.ReadOnly = True
        '
        'rdoUnder16
        '
        Me.rdoUnder16.AutoSize = True
        Me.rdoUnder16.Location = New System.Drawing.Point(338, 215)
        Me.rdoUnder16.Name = "rdoUnder16"
        Me.rdoUnder16.Size = New System.Drawing.Size(53, 21)
        Me.rdoUnder16.TabIndex = 3
        Me.rdoUnder16.TabStop = True
        Me.rdoUnder16.Text = "<16"
        Me.rdoUnder16.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Age:"
        '
        'rdoOver16
        '
        Me.rdoOver16.AutoSize = True
        Me.rdoOver16.Location = New System.Drawing.Point(243, 215)
        Me.rdoOver16.Name = "rdoOver16"
        Me.rdoOver16.Size = New System.Drawing.Size(53, 21)
        Me.rdoOver16.TabIndex = 2
        Me.rdoOver16.TabStop = True
        Me.rdoOver16.Text = "16+"
        Me.rdoOver16.UseVisualStyleBackColor = True
        '
        'lblGuestPassport
        '
        Me.lblGuestPassport.AutoSize = True
        Me.lblGuestPassport.Location = New System.Drawing.Point(104, 263)
        Me.lblGuestPassport.Name = "lblGuestPassport"
        Me.lblGuestPassport.Size = New System.Drawing.Size(122, 17)
        Me.lblGuestPassport.TabIndex = 26
        Me.lblGuestPassport.Text = "Passport Number:"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(104, 167)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(49, 17)
        Me.lblGuestName.TabIndex = 25
        Me.lblGuestName.Text = "Name:"
        '
        'mtbPassportGuest
        '
        Me.mtbPassportGuest.Location = New System.Drawing.Point(243, 260)
        Me.mtbPassportGuest.Mask = "AAAAAAAA"
        Me.mtbPassportGuest.Name = "mtbPassportGuest"
        Me.mtbPassportGuest.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPassportGuest.Size = New System.Drawing.Size(148, 22)
        Me.mtbPassportGuest.TabIndex = 4
        '
        'mtbNameGuest
        '
        Me.mtbNameGuest.Location = New System.Drawing.Point(243, 164)
        Me.mtbNameGuest.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbNameGuest.Name = "mtbNameGuest"
        Me.mtbNameGuest.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbNameGuest.Size = New System.Drawing.Size(148, 22)
        Me.mtbNameGuest.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(477, 179)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 31)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add guest"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBackGuest
        '
        Me.btnBackGuest.Location = New System.Drawing.Point(93, 610)
        Me.btnBackGuest.Name = "btnBackGuest"
        Me.btnBackGuest.Size = New System.Drawing.Size(88, 35)
        Me.btnBackGuest.TabIndex = 8
        Me.btnBackGuest.Text = "Back"
        Me.btnBackGuest.UseVisualStyleBackColor = True
        '
        'btnNextGuest
        '
        Me.btnNextGuest.Location = New System.Drawing.Point(499, 610)
        Me.btnNextGuest.Name = "btnNextGuest"
        Me.btnNextGuest.Size = New System.Drawing.Size(101, 35)
        Me.btnNextGuest.TabIndex = 7
        Me.btnNextGuest.Text = "Next"
        Me.btnNextGuest.UseVisualStyleBackColor = True
        '
        'tabPriceQuote
        '
        Me.tabPriceQuote.Controls.Add(Me.PictureBox8)
        Me.tabPriceQuote.Controls.Add(Me.lblPage4)
        Me.tabPriceQuote.Controls.Add(Me.btnBackPrice)
        Me.tabPriceQuote.Controls.Add(Me.btnNextPrice)
        Me.tabPriceQuote.Controls.Add(Me.lstPriceQuote)
        Me.tabPriceQuote.Location = New System.Drawing.Point(4, 4)
        Me.tabPriceQuote.Name = "tabPriceQuote"
        Me.tabPriceQuote.Size = New System.Drawing.Size(681, 682)
        Me.tabPriceQuote.TabIndex = 5
        Me.tabPriceQuote.Text = "Price Quote"
        Me.tabPriceQuote.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(231, 15)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(222, 81)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 4
        Me.PictureBox8.TabStop = False
        '
        'lblPage4
        '
        Me.lblPage4.AutoSize = True
        Me.lblPage4.Location = New System.Drawing.Point(295, 626)
        Me.lblPage4.Name = "lblPage4"
        Me.lblPage4.Size = New System.Drawing.Size(71, 17)
        Me.lblPage4.TabIndex = 3
        Me.lblPage4.Text = "Page(4/6)"
        '
        'btnBackPrice
        '
        Me.btnBackPrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackPrice.Location = New System.Drawing.Point(50, 615)
        Me.btnBackPrice.Name = "btnBackPrice"
        Me.btnBackPrice.Size = New System.Drawing.Size(103, 38)
        Me.btnBackPrice.TabIndex = 2
        Me.btnBackPrice.Text = "Back"
        Me.btnBackPrice.UseVisualStyleBackColor = True
        '
        'btnNextPrice
        '
        Me.btnNextPrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextPrice.Location = New System.Drawing.Point(532, 615)
        Me.btnNextPrice.Name = "btnNextPrice"
        Me.btnNextPrice.Size = New System.Drawing.Size(99, 38)
        Me.btnNextPrice.TabIndex = 1
        Me.btnNextPrice.Text = "Next"
        Me.btnNextPrice.UseVisualStyleBackColor = True
        '
        'lstPriceQuote
        '
        Me.lstPriceQuote.FormattingEnabled = True
        Me.lstPriceQuote.ItemHeight = 16
        Me.lstPriceQuote.Location = New System.Drawing.Point(50, 102)
        Me.lstPriceQuote.Name = "lstPriceQuote"
        Me.lstPriceQuote.Size = New System.Drawing.Size(581, 436)
        Me.lstPriceQuote.TabIndex = 0
        '
        'tabAdditional
        '
        Me.tabAdditional.BackColor = System.Drawing.Color.GhostWhite
        Me.tabAdditional.Controls.Add(Me.PictureBox9)
        Me.tabAdditional.Controls.Add(Me.lblPage5)
        Me.tabAdditional.Controls.Add(Me.lblPassportNumber)
        Me.tabAdditional.Controls.Add(Me.mtbPassportNumber)
        Me.tabAdditional.Controls.Add(Me.btnNextAdditional)
        Me.tabAdditional.Controls.Add(Me.btnBackAdditional)
        Me.tabAdditional.Controls.Add(Me.grpPaymentDetails)
        Me.tabAdditional.Location = New System.Drawing.Point(4, 4)
        Me.tabAdditional.Name = "tabAdditional"
        Me.tabAdditional.Size = New System.Drawing.Size(681, 682)
        Me.tabAdditional.TabIndex = 2
        Me.tabAdditional.Text = "Additional Details"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(239, 17)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(201, 95)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        '
        'lblPage5
        '
        Me.lblPage5.AutoSize = True
        Me.lblPage5.Location = New System.Drawing.Point(290, 603)
        Me.lblPage5.Name = "lblPage5"
        Me.lblPage5.Size = New System.Drawing.Size(75, 17)
        Me.lblPage5.TabIndex = 10
        Me.lblPage5.Text = "Page (5/6)"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Location = New System.Drawing.Point(69, 147)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(186, 17)
        Me.lblPassportNumber.TabIndex = 9
        Me.lblPassportNumber.Text = "Customer Passport Number:"
        '
        'mtbPassportNumber
        '
        Me.mtbPassportNumber.Location = New System.Drawing.Point(293, 144)
        Me.mtbPassportNumber.Mask = "AAAAAAAA"
        Me.mtbPassportNumber.Name = "mtbPassportNumber"
        Me.mtbPassportNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPassportNumber.Size = New System.Drawing.Size(126, 22)
        Me.mtbPassportNumber.TabIndex = 1
        '
        'btnNextAdditional
        '
        Me.btnNextAdditional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextAdditional.Location = New System.Drawing.Point(533, 593)
        Me.btnNextAdditional.Name = "btnNextAdditional"
        Me.btnNextAdditional.Size = New System.Drawing.Size(93, 36)
        Me.btnNextAdditional.TabIndex = 7
        Me.btnNextAdditional.Text = "Next"
        Me.btnNextAdditional.UseVisualStyleBackColor = True
        '
        'btnBackAdditional
        '
        Me.btnBackAdditional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackAdditional.Location = New System.Drawing.Point(72, 593)
        Me.btnBackAdditional.Name = "btnBackAdditional"
        Me.btnBackAdditional.Size = New System.Drawing.Size(93, 36)
        Me.btnBackAdditional.TabIndex = 8
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
        Me.grpPaymentDetails.Location = New System.Drawing.Point(72, 214)
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
        Me.PictureBox2.Size = New System.Drawing.Size(69, 50)
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
        Me.rdoLaser.TabIndex = 4
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
        Me.rdoAmEx.TabIndex = 5
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
        Me.rdoVisa.TabIndex = 3
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
        Me.rdoMastercard.TabIndex = 2
        Me.rdoMastercard.TabStop = True
        Me.rdoMastercard.Text = "MasterCard"
        Me.rdoMastercard.UseVisualStyleBackColor = True
        '
        'mtbCardNumber
        '
        Me.mtbCardNumber.Location = New System.Drawing.Point(130, 156)
        Me.mtbCardNumber.Mask = "00000000"
        Me.mtbCardNumber.Name = "mtbCardNumber"
        Me.mtbCardNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardNumber.Size = New System.Drawing.Size(116, 22)
        Me.mtbCardNumber.TabIndex = 6
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
        Me.tabInvoice.Controls.Add(Me.PictureBox10)
        Me.tabInvoice.Controls.Add(Me.lblPage6)
        Me.tabInvoice.Controls.Add(Me.btnFinish)
        Me.tabInvoice.Controls.Add(Me.btnBackInvoice)
        Me.tabInvoice.Controls.Add(Me.lstInvoice)
        Me.tabInvoice.Location = New System.Drawing.Point(4, 4)
        Me.tabInvoice.Name = "tabInvoice"
        Me.tabInvoice.Size = New System.Drawing.Size(681, 682)
        Me.tabInvoice.TabIndex = 4
        Me.tabInvoice.Text = "Invoice"
        Me.tabInvoice.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(281, 13)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(154, 81)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 13
        Me.PictureBox10.TabStop = False
        '
        'lblPage6
        '
        Me.lblPage6.AutoSize = True
        Me.lblPage6.Location = New System.Drawing.Point(295, 634)
        Me.lblPage6.Name = "lblPage6"
        Me.lblPage6.Size = New System.Drawing.Size(71, 17)
        Me.lblPage6.TabIndex = 12
        Me.lblPage6.Text = "Page(6/6)"
        '
        'btnFinish
        '
        Me.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinish.Location = New System.Drawing.Point(499, 625)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(130, 35)
        Me.btnFinish.TabIndex = 1
        Me.btnFinish.Text = "Finish and Print"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnBackInvoice
        '
        Me.btnBackInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackInvoice.Location = New System.Drawing.Point(41, 625)
        Me.btnBackInvoice.Name = "btnBackInvoice"
        Me.btnBackInvoice.Size = New System.Drawing.Size(106, 35)
        Me.btnBackInvoice.TabIndex = 2
        Me.btnBackInvoice.Text = "Back"
        Me.btnBackInvoice.UseVisualStyleBackColor = True
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 16
        Me.lstInvoice.Location = New System.Drawing.Point(41, 100)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(588, 468)
        Me.lstInvoice.TabIndex = 9
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(775, 714)
        Me.Controls.Add(Me.tabControl)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OnlyTheBest.com"
        Me.tabControl.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.tabCustomer.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBooking.ResumeLayout(False)
        Me.tabBooking.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.grpBookingDates.ResumeLayout(False)
        Me.grpBookingDates.PerformLayout()
        Me.tabGuest.ResumeLayout(False)
        Me.tabGuest.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPriceQuote.ResumeLayout(False)
        Me.tabPriceQuote.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdditional.ResumeLayout(False)
        Me.tabAdditional.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPaymentDetails.ResumeLayout(False)
        Me.grpPaymentDetails.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInvoice.ResumeLayout(False)
        Me.tabInvoice.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
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
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents nudLaundry As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudOthers As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOthers As System.Windows.Forms.Label
    Friend WithEvents nudShirts As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblShirts As System.Windows.Forms.Label
    Friend WithEvents lblSuits As System.Windows.Forms.Label
    Friend WithEvents nudSuits As System.Windows.Forms.NumericUpDown
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
    Friend WithEvents tabPriceQuote As System.Windows.Forms.TabPage
    Friend WithEvents btnBackPrice As System.Windows.Forms.Button
    Friend WithEvents btnNextPrice As System.Windows.Forms.Button
    Friend WithEvents lstPriceQuote As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblBags As System.Windows.Forms.Label
    Friend WithEvents dtpCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPage1 As System.Windows.Forms.Label
    Friend WithEvents lblPage2 As System.Windows.Forms.Label
    Friend WithEvents lblPage3 As System.Windows.Forms.Label
    Friend WithEvents lblPage4 As System.Windows.Forms.Label
    Friend WithEvents lblPage5 As System.Windows.Forms.Label
    Friend WithEvents lblPage6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents chkLaundry As System.Windows.Forms.CheckBox
    Friend WithEvents chkDryCleaning As System.Windows.Forms.CheckBox
    Friend WithEvents clmName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPassport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
