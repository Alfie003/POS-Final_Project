<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodmenuForm
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
        Dim WaffleLabel As System.Windows.Forms.Label
        Dim Cinnamon_RollLabel As System.Windows.Forms.Label
        Dim CroissantLabel As System.Windows.Forms.Label
        Dim BagelLabel As System.Windows.Forms.Label
        Dim TacosLabel As System.Windows.Forms.Label
        Dim Egg_DropLabel As System.Windows.Forms.Label
        Dim BurgerLabel As System.Windows.Forms.Label
        Dim FriesLabel As System.Windows.Forms.Label
        Dim CoffeeLabel As System.Windows.Forms.Label
        Dim Fruit_TeaLabel As System.Windows.Forms.Label
        Dim MilkteaLabel As System.Windows.Forms.Label
        Dim Total_PurchasedLabel As System.Windows.Forms.Label
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.FooddisplayPanel = New System.Windows.Forms.Panel()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Total_PurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.OrderInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDATABASEDataSet = New FINALPROGRAM.FINALDATABASEDataSet()
        Me.OrderlistGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReceiptButton = New System.Windows.Forms.Button()
        Me.ClearformButton = New System.Windows.Forms.Button()
        Me.PlaceorderButton = New System.Windows.Forms.Button()
        Me.OrderlistTextBox = New System.Windows.Forms.TextBox()
        Me.DrinksGroupBox = New System.Windows.Forms.GroupBox()
        Me.MilkteaAdd = New System.Windows.Forms.Button()
        Me.Fruit_TeaAdd = New System.Windows.Forms.Button()
        Me.CoffeeAdd = New System.Windows.Forms.Button()
        Me.MilkteaSub = New System.Windows.Forms.Button()
        Me.Fruit_TeaSub = New System.Windows.Forms.Button()
        Me.CoffeeSub = New System.Windows.Forms.Button()
        Me.MilkteaTextBox = New System.Windows.Forms.TextBox()
        Me.Fruit_TeaTextBox = New System.Windows.Forms.TextBox()
        Me.CoffeeTextBox = New System.Windows.Forms.TextBox()
        Me.SnacksGroupBox = New System.Windows.Forms.GroupBox()
        Me.FriesAdd = New System.Windows.Forms.Button()
        Me.BurgerAdd = New System.Windows.Forms.Button()
        Me.Egg_DropAdd = New System.Windows.Forms.Button()
        Me.TacosAdd = New System.Windows.Forms.Button()
        Me.FriesSub = New System.Windows.Forms.Button()
        Me.BurgerSub = New System.Windows.Forms.Button()
        Me.Egg_DropSub = New System.Windows.Forms.Button()
        Me.TacosSub = New System.Windows.Forms.Button()
        Me.FriesTextBox = New System.Windows.Forms.TextBox()
        Me.BurgerTextBox = New System.Windows.Forms.TextBox()
        Me.Egg_DropTextBox = New System.Windows.Forms.TextBox()
        Me.TacosTextBox = New System.Windows.Forms.TextBox()
        Me.PastriesGroupBox = New System.Windows.Forms.GroupBox()
        Me.WaffleSub = New System.Windows.Forms.Button()
        Me.Cinnamon_RollSub = New System.Windows.Forms.Button()
        Me.CroissantSub = New System.Windows.Forms.Button()
        Me.BagelSub = New System.Windows.Forms.Button()
        Me.BagelAdd = New System.Windows.Forms.Button()
        Me.CroissantAdd = New System.Windows.Forms.Button()
        Me.Cinnamon_RollAdd = New System.Windows.Forms.Button()
        Me.WaffleAdd = New System.Windows.Forms.Button()
        Me.BagelTextBox = New System.Windows.Forms.TextBox()
        Me.CroissantTextBox = New System.Windows.Forms.TextBox()
        Me.Cinnamon_RollTextBox = New System.Windows.Forms.TextBox()
        Me.WaffleTextBox = New System.Windows.Forms.TextBox()
        Me.HeaderfoodmenuPanel = New System.Windows.Forms.Panel()
        Me.l_header_foodmenu = New System.Windows.Forms.Label()
        Me.OrderInformationTableAdapter = New FINALPROGRAM.FINALDATABASEDataSetTableAdapters.OrderInformationTableAdapter()
        Me.TableAdapterManager = New FINALPROGRAM.FINALDATABASEDataSetTableAdapters.TableAdapterManager()
        WaffleLabel = New System.Windows.Forms.Label()
        Cinnamon_RollLabel = New System.Windows.Forms.Label()
        CroissantLabel = New System.Windows.Forms.Label()
        BagelLabel = New System.Windows.Forms.Label()
        TacosLabel = New System.Windows.Forms.Label()
        Egg_DropLabel = New System.Windows.Forms.Label()
        BurgerLabel = New System.Windows.Forms.Label()
        FriesLabel = New System.Windows.Forms.Label()
        CoffeeLabel = New System.Windows.Forms.Label()
        Fruit_TeaLabel = New System.Windows.Forms.Label()
        MilkteaLabel = New System.Windows.Forms.Label()
        Total_PurchasedLabel = New System.Windows.Forms.Label()
        Me.FooddisplayPanel.SuspendLayout()
        Me.PaymentGroupBox.SuspendLayout()
        CType(Me.OrderInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderlistGroupBox.SuspendLayout()
        Me.DrinksGroupBox.SuspendLayout()
        Me.SnacksGroupBox.SuspendLayout()
        Me.PastriesGroupBox.SuspendLayout()
        Me.HeaderfoodmenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WaffleLabel
        '
        WaffleLabel.AutoSize = True
        WaffleLabel.Location = New System.Drawing.Point(6, 40)
        WaffleLabel.Name = "WaffleLabel"
        WaffleLabel.Size = New System.Drawing.Size(70, 23)
        WaffleLabel.TabIndex = 0
        WaffleLabel.Text = "Waffle:"
        '
        'Cinnamon_RollLabel
        '
        Cinnamon_RollLabel.AutoSize = True
        Cinnamon_RollLabel.Location = New System.Drawing.Point(6, 80)
        Cinnamon_RollLabel.Name = "Cinnamon_RollLabel"
        Cinnamon_RollLabel.Size = New System.Drawing.Size(139, 23)
        Cinnamon_RollLabel.TabIndex = 2
        Cinnamon_RollLabel.Text = "Cinnamon Roll:"
        '
        'CroissantLabel
        '
        CroissantLabel.AutoSize = True
        CroissantLabel.Location = New System.Drawing.Point(6, 120)
        CroissantLabel.Name = "CroissantLabel"
        CroissantLabel.Size = New System.Drawing.Size(92, 23)
        CroissantLabel.TabIndex = 4
        CroissantLabel.Text = "Croissant:"
        '
        'BagelLabel
        '
        BagelLabel.AutoSize = True
        BagelLabel.Location = New System.Drawing.Point(6, 160)
        BagelLabel.Name = "BagelLabel"
        BagelLabel.Size = New System.Drawing.Size(62, 23)
        BagelLabel.TabIndex = 6
        BagelLabel.Text = "Bagel:"
        '
        'TacosLabel
        '
        TacosLabel.AutoSize = True
        TacosLabel.Location = New System.Drawing.Point(6, 40)
        TacosLabel.Name = "TacosLabel"
        TacosLabel.Size = New System.Drawing.Size(64, 23)
        TacosLabel.TabIndex = 0
        TacosLabel.Text = "Tacos:"
        '
        'Egg_DropLabel
        '
        Egg_DropLabel.AutoSize = True
        Egg_DropLabel.Location = New System.Drawing.Point(6, 80)
        Egg_DropLabel.Name = "Egg_DropLabel"
        Egg_DropLabel.Size = New System.Drawing.Size(95, 23)
        Egg_DropLabel.TabIndex = 2
        Egg_DropLabel.Text = "Egg Drop:"
        '
        'BurgerLabel
        '
        BurgerLabel.AutoSize = True
        BurgerLabel.Location = New System.Drawing.Point(6, 120)
        BurgerLabel.Name = "BurgerLabel"
        BurgerLabel.Size = New System.Drawing.Size(74, 23)
        BurgerLabel.TabIndex = 4
        BurgerLabel.Text = "Burger:"
        '
        'FriesLabel
        '
        FriesLabel.AutoSize = True
        FriesLabel.Location = New System.Drawing.Point(6, 160)
        FriesLabel.Name = "FriesLabel"
        FriesLabel.Size = New System.Drawing.Size(57, 23)
        FriesLabel.TabIndex = 6
        FriesLabel.Text = "Fries:"
        '
        'CoffeeLabel
        '
        CoffeeLabel.AutoSize = True
        CoffeeLabel.Location = New System.Drawing.Point(6, 40)
        CoffeeLabel.Name = "CoffeeLabel"
        CoffeeLabel.Size = New System.Drawing.Size(66, 23)
        CoffeeLabel.TabIndex = 0
        CoffeeLabel.Text = "Coffee:"
        '
        'Fruit_TeaLabel
        '
        Fruit_TeaLabel.AutoSize = True
        Fruit_TeaLabel.Location = New System.Drawing.Point(6, 80)
        Fruit_TeaLabel.Name = "Fruit_TeaLabel"
        Fruit_TeaLabel.Size = New System.Drawing.Size(93, 23)
        Fruit_TeaLabel.TabIndex = 2
        Fruit_TeaLabel.Text = "Fruit Tea:"
        '
        'MilkteaLabel
        '
        MilkteaLabel.AutoSize = True
        MilkteaLabel.Location = New System.Drawing.Point(6, 120)
        MilkteaLabel.Name = "MilkteaLabel"
        MilkteaLabel.Size = New System.Drawing.Size(77, 23)
        MilkteaLabel.TabIndex = 4
        MilkteaLabel.Text = "Milktea:"
        '
        'Total_PurchasedLabel
        '
        Total_PurchasedLabel.AutoSize = True
        Total_PurchasedLabel.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Bold)
        Total_PurchasedLabel.Location = New System.Drawing.Point(11, 68)
        Total_PurchasedLabel.Name = "Total_PurchasedLabel"
        Total_PurchasedLabel.Size = New System.Drawing.Size(151, 23)
        Total_PurchasedLabel.TabIndex = 0
        Total_PurchasedLabel.Text = "Total Purchased:"
        '
        'TopPanel
        '
        Me.TopPanel.BackgroundImage = Global.FINALPROGRAM.My.Resources.Resources.upper_panel_color
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1385, 100)
        Me.TopPanel.TabIndex = 0
        '
        'FooddisplayPanel
        '
        Me.FooddisplayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FooddisplayPanel.Controls.Add(Me.PaymentGroupBox)
        Me.FooddisplayPanel.Controls.Add(Me.OrderlistGroupBox)
        Me.FooddisplayPanel.Controls.Add(Me.DrinksGroupBox)
        Me.FooddisplayPanel.Controls.Add(Me.SnacksGroupBox)
        Me.FooddisplayPanel.Controls.Add(Me.PastriesGroupBox)
        Me.FooddisplayPanel.Controls.Add(Me.HeaderfoodmenuPanel)
        Me.FooddisplayPanel.Location = New System.Drawing.Point(126, 100)
        Me.FooddisplayPanel.Name = "FooddisplayPanel"
        Me.FooddisplayPanel.Size = New System.Drawing.Size(1100, 788)
        Me.FooddisplayPanel.TabIndex = 1
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.PaymentGroupBox.Controls.Add(Me.Label1)
        Me.PaymentGroupBox.Controls.Add(Total_PurchasedLabel)
        Me.PaymentGroupBox.Controls.Add(Me.Total_PurchasedTextBox)
        Me.PaymentGroupBox.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold)
        Me.PaymentGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PaymentGroupBox.Location = New System.Drawing.Point(739, 372)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(320, 238)
        Me.PaymentGroupBox.TabIndex = 6
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Payment - - - - -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Thank you for ordering!"
        '
        'Total_PurchasedTextBox
        '
        Me.Total_PurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Total Purchased", True))
        Me.Total_PurchasedTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Total_PurchasedTextBox.Location = New System.Drawing.Point(170, 64)
        Me.Total_PurchasedTextBox.Name = "Total_PurchasedTextBox"
        Me.Total_PurchasedTextBox.ReadOnly = True
        Me.Total_PurchasedTextBox.Size = New System.Drawing.Size(131, 30)
        Me.Total_PurchasedTextBox.TabIndex = 1
        Me.Total_PurchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OrderInformationBindingSource
        '
        Me.OrderInformationBindingSource.DataMember = "OrderInformation"
        Me.OrderInformationBindingSource.DataSource = Me.FINALDATABASEDataSet
        '
        'FINALDATABASEDataSet
        '
        Me.FINALDATABASEDataSet.DataSetName = "FINALDATABASEDataSet"
        Me.FINALDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderlistGroupBox
        '
        Me.OrderlistGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.OrderlistGroupBox.Controls.Add(Me.Button1)
        Me.OrderlistGroupBox.Controls.Add(Me.ReceiptButton)
        Me.OrderlistGroupBox.Controls.Add(Me.ClearformButton)
        Me.OrderlistGroupBox.Controls.Add(Me.PlaceorderButton)
        Me.OrderlistGroupBox.Controls.Add(Me.OrderlistTextBox)
        Me.OrderlistGroupBox.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderlistGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.OrderlistGroupBox.Location = New System.Drawing.Point(37, 360)
        Me.OrderlistGroupBox.Name = "OrderlistGroupBox"
        Me.OrderlistGroupBox.Size = New System.Drawing.Size(670, 250)
        Me.OrderlistGroupBox.TabIndex = 5
        Me.OrderlistGroupBox.TabStop = False
        Me.OrderlistGroupBox.Text = "Order List - - - - -"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(526, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Print Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReceiptButton
        '
        Me.ReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReceiptButton.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptButton.Location = New System.Drawing.Point(526, 115)
        Me.ReceiptButton.Name = "ReceiptButton"
        Me.ReceiptButton.Size = New System.Drawing.Size(111, 32)
        Me.ReceiptButton.TabIndex = 3
        Me.ReceiptButton.Text = "Receipt"
        Me.ReceiptButton.UseVisualStyleBackColor = True
        '
        'ClearformButton
        '
        Me.ClearformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearformButton.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearformButton.Location = New System.Drawing.Point(526, 77)
        Me.ClearformButton.Name = "ClearformButton"
        Me.ClearformButton.Size = New System.Drawing.Size(111, 32)
        Me.ClearformButton.TabIndex = 2
        Me.ClearformButton.Text = "Clear Form"
        Me.ClearformButton.UseVisualStyleBackColor = True
        '
        'PlaceorderButton
        '
        Me.PlaceorderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceorderButton.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceorderButton.Location = New System.Drawing.Point(526, 39)
        Me.PlaceorderButton.Name = "PlaceorderButton"
        Me.PlaceorderButton.Size = New System.Drawing.Size(111, 32)
        Me.PlaceorderButton.TabIndex = 1
        Me.PlaceorderButton.Text = "Place Order"
        Me.PlaceorderButton.UseVisualStyleBackColor = True
        '
        'OrderlistTextBox
        '
        Me.OrderlistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.OrderlistTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.OrderlistTextBox.Location = New System.Drawing.Point(10, 39)
        Me.OrderlistTextBox.Multiline = True
        Me.OrderlistTextBox.Name = "OrderlistTextBox"
        Me.OrderlistTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OrderlistTextBox.Size = New System.Drawing.Size(510, 200)
        Me.OrderlistTextBox.TabIndex = 0
        '
        'DrinksGroupBox
        '
        Me.DrinksGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.DrinksGroupBox.Controls.Add(Me.MilkteaAdd)
        Me.DrinksGroupBox.Controls.Add(Me.Fruit_TeaAdd)
        Me.DrinksGroupBox.Controls.Add(Me.CoffeeAdd)
        Me.DrinksGroupBox.Controls.Add(Me.MilkteaSub)
        Me.DrinksGroupBox.Controls.Add(Me.Fruit_TeaSub)
        Me.DrinksGroupBox.Controls.Add(Me.CoffeeSub)
        Me.DrinksGroupBox.Controls.Add(MilkteaLabel)
        Me.DrinksGroupBox.Controls.Add(Me.MilkteaTextBox)
        Me.DrinksGroupBox.Controls.Add(Fruit_TeaLabel)
        Me.DrinksGroupBox.Controls.Add(Me.Fruit_TeaTextBox)
        Me.DrinksGroupBox.Controls.Add(CoffeeLabel)
        Me.DrinksGroupBox.Controls.Add(Me.CoffeeTextBox)
        Me.DrinksGroupBox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.DrinksGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DrinksGroupBox.Location = New System.Drawing.Point(739, 105)
        Me.DrinksGroupBox.Name = "DrinksGroupBox"
        Me.DrinksGroupBox.Size = New System.Drawing.Size(320, 235)
        Me.DrinksGroupBox.TabIndex = 4
        Me.DrinksGroupBox.TabStop = False
        Me.DrinksGroupBox.Text = "Drinks - - - - -"
        '
        'MilkteaAdd
        '
        Me.MilkteaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MilkteaAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilkteaAdd.Location = New System.Drawing.Point(280, 120)
        Me.MilkteaAdd.Name = "MilkteaAdd"
        Me.MilkteaAdd.Size = New System.Drawing.Size(30, 25)
        Me.MilkteaAdd.TabIndex = 28
        Me.MilkteaAdd.Text = "+"
        Me.MilkteaAdd.UseVisualStyleBackColor = True
        '
        'Fruit_TeaAdd
        '
        Me.Fruit_TeaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fruit_TeaAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fruit_TeaAdd.Location = New System.Drawing.Point(280, 80)
        Me.Fruit_TeaAdd.Name = "Fruit_TeaAdd"
        Me.Fruit_TeaAdd.Size = New System.Drawing.Size(30, 25)
        Me.Fruit_TeaAdd.TabIndex = 27
        Me.Fruit_TeaAdd.Text = "+"
        Me.Fruit_TeaAdd.UseVisualStyleBackColor = True
        '
        'CoffeeAdd
        '
        Me.CoffeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CoffeeAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoffeeAdd.Location = New System.Drawing.Point(280, 40)
        Me.CoffeeAdd.Name = "CoffeeAdd"
        Me.CoffeeAdd.Size = New System.Drawing.Size(30, 25)
        Me.CoffeeAdd.TabIndex = 26
        Me.CoffeeAdd.Text = "+"
        Me.CoffeeAdd.UseVisualStyleBackColor = True
        '
        'MilkteaSub
        '
        Me.MilkteaSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MilkteaSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilkteaSub.Location = New System.Drawing.Point(200, 120)
        Me.MilkteaSub.Name = "MilkteaSub"
        Me.MilkteaSub.Size = New System.Drawing.Size(30, 25)
        Me.MilkteaSub.TabIndex = 25
        Me.MilkteaSub.Text = "-"
        Me.MilkteaSub.UseVisualStyleBackColor = True
        '
        'Fruit_TeaSub
        '
        Me.Fruit_TeaSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fruit_TeaSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fruit_TeaSub.Location = New System.Drawing.Point(200, 80)
        Me.Fruit_TeaSub.Name = "Fruit_TeaSub"
        Me.Fruit_TeaSub.Size = New System.Drawing.Size(30, 25)
        Me.Fruit_TeaSub.TabIndex = 24
        Me.Fruit_TeaSub.Text = "-"
        Me.Fruit_TeaSub.UseVisualStyleBackColor = True
        '
        'CoffeeSub
        '
        Me.CoffeeSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CoffeeSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoffeeSub.Location = New System.Drawing.Point(200, 40)
        Me.CoffeeSub.Name = "CoffeeSub"
        Me.CoffeeSub.Size = New System.Drawing.Size(30, 25)
        Me.CoffeeSub.TabIndex = 23
        Me.CoffeeSub.Text = "-"
        Me.CoffeeSub.UseVisualStyleBackColor = True
        '
        'MilkteaTextBox
        '
        Me.MilkteaTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MilkteaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Milktea", True))
        Me.MilkteaTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MilkteaTextBox.Location = New System.Drawing.Point(240, 117)
        Me.MilkteaTextBox.Name = "MilkteaTextBox"
        Me.MilkteaTextBox.ReadOnly = True
        Me.MilkteaTextBox.Size = New System.Drawing.Size(30, 30)
        Me.MilkteaTextBox.TabIndex = 5
        Me.MilkteaTextBox.Text = "0"
        Me.MilkteaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fruit_TeaTextBox
        '
        Me.Fruit_TeaTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Fruit_TeaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Fruit Tea", True))
        Me.Fruit_TeaTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Fruit_TeaTextBox.Location = New System.Drawing.Point(240, 77)
        Me.Fruit_TeaTextBox.Name = "Fruit_TeaTextBox"
        Me.Fruit_TeaTextBox.ReadOnly = True
        Me.Fruit_TeaTextBox.Size = New System.Drawing.Size(30, 30)
        Me.Fruit_TeaTextBox.TabIndex = 3
        Me.Fruit_TeaTextBox.Text = "0"
        Me.Fruit_TeaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CoffeeTextBox
        '
        Me.CoffeeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CoffeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Coffee", True))
        Me.CoffeeTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CoffeeTextBox.Location = New System.Drawing.Point(240, 37)
        Me.CoffeeTextBox.Name = "CoffeeTextBox"
        Me.CoffeeTextBox.ReadOnly = True
        Me.CoffeeTextBox.Size = New System.Drawing.Size(30, 30)
        Me.CoffeeTextBox.TabIndex = 1
        Me.CoffeeTextBox.Text = "0"
        Me.CoffeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SnacksGroupBox
        '
        Me.SnacksGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.SnacksGroupBox.Controls.Add(Me.FriesAdd)
        Me.SnacksGroupBox.Controls.Add(Me.BurgerAdd)
        Me.SnacksGroupBox.Controls.Add(Me.Egg_DropAdd)
        Me.SnacksGroupBox.Controls.Add(Me.TacosAdd)
        Me.SnacksGroupBox.Controls.Add(Me.FriesSub)
        Me.SnacksGroupBox.Controls.Add(Me.BurgerSub)
        Me.SnacksGroupBox.Controls.Add(Me.Egg_DropSub)
        Me.SnacksGroupBox.Controls.Add(Me.TacosSub)
        Me.SnacksGroupBox.Controls.Add(FriesLabel)
        Me.SnacksGroupBox.Controls.Add(Me.FriesTextBox)
        Me.SnacksGroupBox.Controls.Add(BurgerLabel)
        Me.SnacksGroupBox.Controls.Add(Me.BurgerTextBox)
        Me.SnacksGroupBox.Controls.Add(Egg_DropLabel)
        Me.SnacksGroupBox.Controls.Add(Me.Egg_DropTextBox)
        Me.SnacksGroupBox.Controls.Add(TacosLabel)
        Me.SnacksGroupBox.Controls.Add(Me.TacosTextBox)
        Me.SnacksGroupBox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.SnacksGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SnacksGroupBox.Location = New System.Drawing.Point(387, 105)
        Me.SnacksGroupBox.Name = "SnacksGroupBox"
        Me.SnacksGroupBox.Size = New System.Drawing.Size(320, 235)
        Me.SnacksGroupBox.TabIndex = 3
        Me.SnacksGroupBox.TabStop = False
        Me.SnacksGroupBox.Text = "Snacks - - - - -"
        '
        'FriesAdd
        '
        Me.FriesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FriesAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FriesAdd.Location = New System.Drawing.Point(280, 160)
        Me.FriesAdd.Name = "FriesAdd"
        Me.FriesAdd.Size = New System.Drawing.Size(30, 25)
        Me.FriesAdd.TabIndex = 22
        Me.FriesAdd.Text = "+"
        Me.FriesAdd.UseVisualStyleBackColor = True
        '
        'BurgerAdd
        '
        Me.BurgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BurgerAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BurgerAdd.Location = New System.Drawing.Point(280, 120)
        Me.BurgerAdd.Name = "BurgerAdd"
        Me.BurgerAdd.Size = New System.Drawing.Size(30, 25)
        Me.BurgerAdd.TabIndex = 21
        Me.BurgerAdd.Text = "+"
        Me.BurgerAdd.UseVisualStyleBackColor = True
        '
        'Egg_DropAdd
        '
        Me.Egg_DropAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Egg_DropAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egg_DropAdd.Location = New System.Drawing.Point(280, 80)
        Me.Egg_DropAdd.Name = "Egg_DropAdd"
        Me.Egg_DropAdd.Size = New System.Drawing.Size(30, 25)
        Me.Egg_DropAdd.TabIndex = 20
        Me.Egg_DropAdd.Text = "+"
        Me.Egg_DropAdd.UseVisualStyleBackColor = True
        '
        'TacosAdd
        '
        Me.TacosAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TacosAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TacosAdd.Location = New System.Drawing.Point(280, 40)
        Me.TacosAdd.Name = "TacosAdd"
        Me.TacosAdd.Size = New System.Drawing.Size(30, 25)
        Me.TacosAdd.TabIndex = 16
        Me.TacosAdd.Text = "+"
        Me.TacosAdd.UseVisualStyleBackColor = True
        '
        'FriesSub
        '
        Me.FriesSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FriesSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FriesSub.Location = New System.Drawing.Point(200, 160)
        Me.FriesSub.Name = "FriesSub"
        Me.FriesSub.Size = New System.Drawing.Size(30, 25)
        Me.FriesSub.TabIndex = 19
        Me.FriesSub.Text = "-"
        Me.FriesSub.UseVisualStyleBackColor = True
        '
        'BurgerSub
        '
        Me.BurgerSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BurgerSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BurgerSub.Location = New System.Drawing.Point(200, 120)
        Me.BurgerSub.Name = "BurgerSub"
        Me.BurgerSub.Size = New System.Drawing.Size(30, 25)
        Me.BurgerSub.TabIndex = 18
        Me.BurgerSub.Text = "-"
        Me.BurgerSub.UseVisualStyleBackColor = True
        '
        'Egg_DropSub
        '
        Me.Egg_DropSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Egg_DropSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egg_DropSub.Location = New System.Drawing.Point(200, 80)
        Me.Egg_DropSub.Name = "Egg_DropSub"
        Me.Egg_DropSub.Size = New System.Drawing.Size(30, 25)
        Me.Egg_DropSub.TabIndex = 17
        Me.Egg_DropSub.Text = "-"
        Me.Egg_DropSub.UseVisualStyleBackColor = True
        '
        'TacosSub
        '
        Me.TacosSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TacosSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TacosSub.Location = New System.Drawing.Point(200, 40)
        Me.TacosSub.Name = "TacosSub"
        Me.TacosSub.Size = New System.Drawing.Size(30, 25)
        Me.TacosSub.TabIndex = 16
        Me.TacosSub.Text = "-"
        Me.TacosSub.UseVisualStyleBackColor = True
        '
        'FriesTextBox
        '
        Me.FriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Fries", True))
        Me.FriesTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FriesTextBox.Location = New System.Drawing.Point(240, 157)
        Me.FriesTextBox.Name = "FriesTextBox"
        Me.FriesTextBox.ReadOnly = True
        Me.FriesTextBox.Size = New System.Drawing.Size(30, 30)
        Me.FriesTextBox.TabIndex = 7
        Me.FriesTextBox.Text = "0"
        Me.FriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BurgerTextBox
        '
        Me.BurgerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Burger", True))
        Me.BurgerTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BurgerTextBox.Location = New System.Drawing.Point(240, 117)
        Me.BurgerTextBox.Name = "BurgerTextBox"
        Me.BurgerTextBox.ReadOnly = True
        Me.BurgerTextBox.Size = New System.Drawing.Size(30, 30)
        Me.BurgerTextBox.TabIndex = 5
        Me.BurgerTextBox.Text = "0"
        Me.BurgerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Egg_DropTextBox
        '
        Me.Egg_DropTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Egg Drop", True))
        Me.Egg_DropTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Egg_DropTextBox.Location = New System.Drawing.Point(240, 77)
        Me.Egg_DropTextBox.Name = "Egg_DropTextBox"
        Me.Egg_DropTextBox.ReadOnly = True
        Me.Egg_DropTextBox.Size = New System.Drawing.Size(30, 30)
        Me.Egg_DropTextBox.TabIndex = 3
        Me.Egg_DropTextBox.Text = "0"
        Me.Egg_DropTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TacosTextBox
        '
        Me.TacosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Tacos", True))
        Me.TacosTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TacosTextBox.Location = New System.Drawing.Point(240, 37)
        Me.TacosTextBox.Name = "TacosTextBox"
        Me.TacosTextBox.ReadOnly = True
        Me.TacosTextBox.Size = New System.Drawing.Size(30, 30)
        Me.TacosTextBox.TabIndex = 1
        Me.TacosTextBox.Text = "0"
        Me.TacosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PastriesGroupBox
        '
        Me.PastriesGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.PastriesGroupBox.Controls.Add(Me.WaffleSub)
        Me.PastriesGroupBox.Controls.Add(Me.Cinnamon_RollSub)
        Me.PastriesGroupBox.Controls.Add(Me.CroissantSub)
        Me.PastriesGroupBox.Controls.Add(Me.BagelSub)
        Me.PastriesGroupBox.Controls.Add(Me.BagelAdd)
        Me.PastriesGroupBox.Controls.Add(Me.CroissantAdd)
        Me.PastriesGroupBox.Controls.Add(Me.Cinnamon_RollAdd)
        Me.PastriesGroupBox.Controls.Add(Me.WaffleAdd)
        Me.PastriesGroupBox.Controls.Add(BagelLabel)
        Me.PastriesGroupBox.Controls.Add(Me.BagelTextBox)
        Me.PastriesGroupBox.Controls.Add(CroissantLabel)
        Me.PastriesGroupBox.Controls.Add(Me.CroissantTextBox)
        Me.PastriesGroupBox.Controls.Add(Cinnamon_RollLabel)
        Me.PastriesGroupBox.Controls.Add(Me.Cinnamon_RollTextBox)
        Me.PastriesGroupBox.Controls.Add(WaffleLabel)
        Me.PastriesGroupBox.Controls.Add(Me.WaffleTextBox)
        Me.PastriesGroupBox.Font = New System.Drawing.Font("Bodoni MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastriesGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PastriesGroupBox.Location = New System.Drawing.Point(37, 105)
        Me.PastriesGroupBox.Name = "PastriesGroupBox"
        Me.PastriesGroupBox.Size = New System.Drawing.Size(320, 235)
        Me.PastriesGroupBox.TabIndex = 2
        Me.PastriesGroupBox.TabStop = False
        Me.PastriesGroupBox.Text = "Pastries - - - - - "
        '
        'WaffleSub
        '
        Me.WaffleSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WaffleSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaffleSub.Location = New System.Drawing.Point(200, 40)
        Me.WaffleSub.Name = "WaffleSub"
        Me.WaffleSub.Size = New System.Drawing.Size(30, 25)
        Me.WaffleSub.TabIndex = 15
        Me.WaffleSub.Text = "-"
        Me.WaffleSub.UseVisualStyleBackColor = True
        '
        'Cinnamon_RollSub
        '
        Me.Cinnamon_RollSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cinnamon_RollSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cinnamon_RollSub.Location = New System.Drawing.Point(200, 80)
        Me.Cinnamon_RollSub.Name = "Cinnamon_RollSub"
        Me.Cinnamon_RollSub.Size = New System.Drawing.Size(30, 25)
        Me.Cinnamon_RollSub.TabIndex = 14
        Me.Cinnamon_RollSub.Text = "-"
        Me.Cinnamon_RollSub.UseVisualStyleBackColor = True
        '
        'CroissantSub
        '
        Me.CroissantSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CroissantSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CroissantSub.Location = New System.Drawing.Point(200, 120)
        Me.CroissantSub.Name = "CroissantSub"
        Me.CroissantSub.Size = New System.Drawing.Size(30, 25)
        Me.CroissantSub.TabIndex = 13
        Me.CroissantSub.Text = "-"
        Me.CroissantSub.UseVisualStyleBackColor = True
        '
        'BagelSub
        '
        Me.BagelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BagelSub.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagelSub.Location = New System.Drawing.Point(200, 160)
        Me.BagelSub.Name = "BagelSub"
        Me.BagelSub.Size = New System.Drawing.Size(30, 25)
        Me.BagelSub.TabIndex = 12
        Me.BagelSub.Text = "-"
        Me.BagelSub.UseVisualStyleBackColor = True
        '
        'BagelAdd
        '
        Me.BagelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BagelAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagelAdd.Location = New System.Drawing.Point(280, 160)
        Me.BagelAdd.Name = "BagelAdd"
        Me.BagelAdd.Size = New System.Drawing.Size(30, 25)
        Me.BagelAdd.TabIndex = 11
        Me.BagelAdd.Text = "+"
        Me.BagelAdd.UseVisualStyleBackColor = True
        '
        'CroissantAdd
        '
        Me.CroissantAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CroissantAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CroissantAdd.Location = New System.Drawing.Point(280, 120)
        Me.CroissantAdd.Name = "CroissantAdd"
        Me.CroissantAdd.Size = New System.Drawing.Size(30, 25)
        Me.CroissantAdd.TabIndex = 10
        Me.CroissantAdd.Text = "+"
        Me.CroissantAdd.UseVisualStyleBackColor = True
        '
        'Cinnamon_RollAdd
        '
        Me.Cinnamon_RollAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cinnamon_RollAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cinnamon_RollAdd.Location = New System.Drawing.Point(280, 80)
        Me.Cinnamon_RollAdd.Name = "Cinnamon_RollAdd"
        Me.Cinnamon_RollAdd.Size = New System.Drawing.Size(30, 25)
        Me.Cinnamon_RollAdd.TabIndex = 9
        Me.Cinnamon_RollAdd.Text = "+"
        Me.Cinnamon_RollAdd.UseVisualStyleBackColor = True
        '
        'WaffleAdd
        '
        Me.WaffleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WaffleAdd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaffleAdd.Location = New System.Drawing.Point(280, 40)
        Me.WaffleAdd.Name = "WaffleAdd"
        Me.WaffleAdd.Size = New System.Drawing.Size(30, 25)
        Me.WaffleAdd.TabIndex = 8
        Me.WaffleAdd.Text = "+"
        Me.WaffleAdd.UseVisualStyleBackColor = True
        '
        'BagelTextBox
        '
        Me.BagelTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.BagelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Bagel", True))
        Me.BagelTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BagelTextBox.Location = New System.Drawing.Point(240, 157)
        Me.BagelTextBox.Name = "BagelTextBox"
        Me.BagelTextBox.ReadOnly = True
        Me.BagelTextBox.Size = New System.Drawing.Size(30, 30)
        Me.BagelTextBox.TabIndex = 7
        Me.BagelTextBox.Text = "0"
        Me.BagelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CroissantTextBox
        '
        Me.CroissantTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CroissantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Croissant", True))
        Me.CroissantTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CroissantTextBox.Location = New System.Drawing.Point(240, 117)
        Me.CroissantTextBox.Name = "CroissantTextBox"
        Me.CroissantTextBox.ReadOnly = True
        Me.CroissantTextBox.Size = New System.Drawing.Size(30, 30)
        Me.CroissantTextBox.TabIndex = 5
        Me.CroissantTextBox.Text = "0"
        Me.CroissantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cinnamon_RollTextBox
        '
        Me.Cinnamon_RollTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Cinnamon_RollTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Cinnamon Roll", True))
        Me.Cinnamon_RollTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cinnamon_RollTextBox.Location = New System.Drawing.Point(240, 77)
        Me.Cinnamon_RollTextBox.Name = "Cinnamon_RollTextBox"
        Me.Cinnamon_RollTextBox.ReadOnly = True
        Me.Cinnamon_RollTextBox.Size = New System.Drawing.Size(30, 30)
        Me.Cinnamon_RollTextBox.TabIndex = 3
        Me.Cinnamon_RollTextBox.Text = "0"
        Me.Cinnamon_RollTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WaffleTextBox
        '
        Me.WaffleTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.WaffleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderInformationBindingSource, "Waffle", True))
        Me.WaffleTextBox.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.WaffleTextBox.Location = New System.Drawing.Point(240, 37)
        Me.WaffleTextBox.Name = "WaffleTextBox"
        Me.WaffleTextBox.ReadOnly = True
        Me.WaffleTextBox.Size = New System.Drawing.Size(30, 30)
        Me.WaffleTextBox.TabIndex = 1
        Me.WaffleTextBox.Text = "0"
        Me.WaffleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeaderfoodmenuPanel
        '
        Me.HeaderfoodmenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.HeaderfoodmenuPanel.Controls.Add(Me.l_header_foodmenu)
        Me.HeaderfoodmenuPanel.Location = New System.Drawing.Point(37, 14)
        Me.HeaderfoodmenuPanel.Name = "HeaderfoodmenuPanel"
        Me.HeaderfoodmenuPanel.Size = New System.Drawing.Size(1026, 51)
        Me.HeaderfoodmenuPanel.TabIndex = 1
        '
        'l_header_foodmenu
        '
        Me.l_header_foodmenu.AutoSize = True
        Me.l_header_foodmenu.Font = New System.Drawing.Font("Bodoni MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_header_foodmenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.l_header_foodmenu.Location = New System.Drawing.Point(423, 5)
        Me.l_header_foodmenu.Name = "l_header_foodmenu"
        Me.l_header_foodmenu.Size = New System.Drawing.Size(180, 41)
        Me.l_header_foodmenu.TabIndex = 0
        Me.l_header_foodmenu.Text = "Food Menu"
        '
        'OrderInformationTableAdapter
        '
        Me.OrderInformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderInformationTableAdapter = Me.OrderInformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = FINALPROGRAM.FINALDATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FoodmenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.FINALPROGRAM.My.Resources.Resources.bagong_background_15_yung_opacity
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.FooddisplayPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FoodmenuForm"
        Me.Text = "Enjoy ordering! "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FooddisplayPanel.ResumeLayout(False)
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        CType(Me.OrderInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderlistGroupBox.ResumeLayout(False)
        Me.OrderlistGroupBox.PerformLayout()
        Me.DrinksGroupBox.ResumeLayout(False)
        Me.DrinksGroupBox.PerformLayout()
        Me.SnacksGroupBox.ResumeLayout(False)
        Me.SnacksGroupBox.PerformLayout()
        Me.PastriesGroupBox.ResumeLayout(False)
        Me.PastriesGroupBox.PerformLayout()
        Me.HeaderfoodmenuPanel.ResumeLayout(False)
        Me.HeaderfoodmenuPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents FooddisplayPanel As Panel
    Friend WithEvents HeaderfoodmenuPanel As Panel
    Friend WithEvents l_header_foodmenu As Label
    Friend WithEvents PastriesGroupBox As GroupBox
    Friend WithEvents FINALDATABASEDataSet As FINALDATABASEDataSet
    Friend WithEvents OrderInformationBindingSource As BindingSource
    Friend WithEvents OrderInformationTableAdapter As FINALDATABASEDataSetTableAdapters.OrderInformationTableAdapter
    Friend WithEvents TableAdapterManager As FINALDATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BagelTextBox As TextBox
    Friend WithEvents CroissantTextBox As TextBox
    Friend WithEvents Cinnamon_RollTextBox As TextBox
    Friend WithEvents WaffleTextBox As TextBox
    Friend WithEvents WaffleAdd As Button
    Friend WithEvents WaffleSub As Button
    Friend WithEvents Cinnamon_RollSub As Button
    Friend WithEvents CroissantSub As Button
    Friend WithEvents BagelSub As Button
    Friend WithEvents BagelAdd As Button
    Friend WithEvents CroissantAdd As Button
    Friend WithEvents Cinnamon_RollAdd As Button
    Friend WithEvents SnacksGroupBox As GroupBox
    Friend WithEvents DrinksGroupBox As GroupBox
    Friend WithEvents TacosSub As Button
    Friend WithEvents FriesTextBox As TextBox
    Friend WithEvents BurgerTextBox As TextBox
    Friend WithEvents Egg_DropTextBox As TextBox
    Friend WithEvents TacosTextBox As TextBox
    Friend WithEvents FriesAdd As Button
    Friend WithEvents BurgerAdd As Button
    Friend WithEvents Egg_DropAdd As Button
    Friend WithEvents TacosAdd As Button
    Friend WithEvents FriesSub As Button
    Friend WithEvents BurgerSub As Button
    Friend WithEvents Egg_DropSub As Button
    Friend WithEvents MilkteaAdd As Button
    Friend WithEvents Fruit_TeaAdd As Button
    Friend WithEvents CoffeeAdd As Button
    Friend WithEvents MilkteaSub As Button
    Friend WithEvents Fruit_TeaSub As Button
    Friend WithEvents CoffeeSub As Button
    Friend WithEvents MilkteaTextBox As TextBox
    Friend WithEvents Fruit_TeaTextBox As TextBox
    Friend WithEvents CoffeeTextBox As TextBox
    Friend WithEvents OrderlistGroupBox As GroupBox
    Friend WithEvents OrderlistTextBox As TextBox
    Friend WithEvents ReceiptButton As Button
    Friend WithEvents ClearformButton As Button
    Friend WithEvents PlaceorderButton As Button
    Friend WithEvents PaymentGroupBox As GroupBox
    Friend WithEvents Total_PurchasedTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
