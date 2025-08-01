Imports System.Drawing.Printing

Public Class FoodmenuForm
    Private Sub FoodMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FINALDATABASEDataSet.OrderInformation' table. You can move, or remove it, as needed.
        Me.OrderInformationTableAdapter.Fill(Me.FINALDATABASEDataSet.OrderInformation)
        OrderInformationBindingSource.AddNew()
    End Sub

    Private Sub OrderInformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrderInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FINALDATABASEDataSet)

    End Sub

    Private Sub WaffleAdd_Click(sender As Object, e As EventArgs) Handles WaffleAdd.Click
        Dim number As Integer
        Integer.TryParse(WaffleTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        WaffleTextBox.Text = number.ToString()
    End Sub

    Private Sub WaffleSub_Click(sender As Object, e As EventArgs) Handles WaffleSub.Click
        Dim number As Integer
        Integer.TryParse(WaffleTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        WaffleTextBox.Text = number.ToString()
    End Sub

    Private Sub Cinnamon_RollAdd_Click(sender As Object, e As EventArgs) Handles Cinnamon_RollAdd.Click
        Dim number As Integer
        Integer.TryParse(Cinnamon_RollTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        Cinnamon_RollTextBox.Text = number.ToString()
    End Sub

    Private Sub Cinnamon_RollSub_Click(sender As Object, e As EventArgs) Handles Cinnamon_RollSub.Click
        Dim number As Integer
        Integer.TryParse(Cinnamon_RollTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        Cinnamon_RollTextBox.Text = number.ToString()
    End Sub

    Private Sub CroissantAdd_Click(sender As Object, e As EventArgs) Handles CroissantAdd.Click
        Dim number As Integer
        Integer.TryParse(CroissantTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        CroissantTextBox.Text = number.ToString()
    End Sub

    Private Sub CroissantSub_Click(sender As Object, e As EventArgs) Handles CroissantSub.Click
        Dim number As Integer
        Integer.TryParse(CroissantTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        CroissantTextBox.Text = number.ToString()
    End Sub

    Private Sub BagelAdd_Click(sender As Object, e As EventArgs) Handles BagelAdd.Click
        Dim number As Integer
        Integer.TryParse(BagelTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        BagelTextBox.Text = number.ToString()
    End Sub

    Private Sub BagelSub_Click(sender As Object, e As EventArgs) Handles BagelSub.Click
        Dim number As Integer
        Integer.TryParse(BagelTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        BagelTextBox.Text = number.ToString()
    End Sub

    Private Sub TacosAdd_Click(sender As Object, e As EventArgs) Handles TacosAdd.Click
        Dim number As Integer
        Integer.TryParse(TacosTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        TacosTextBox.Text = number.ToString()
    End Sub

    Private Sub TacosSub_Click(sender As Object, e As EventArgs) Handles TacosSub.Click
        Dim number As Integer
        Integer.TryParse(TacosTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        TacosTextBox.Text = number.ToString()
    End Sub

    Private Sub Egg_DropAdd_Click(sender As Object, e As EventArgs) Handles Egg_DropAdd.Click
        Dim number As Integer
        Integer.TryParse(Egg_DropTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        Egg_DropTextBox.Text = number.ToString()
    End Sub

    Private Sub Egg_DropSub_Click(sender As Object, e As EventArgs) Handles Egg_DropSub.Click
        Dim number As Integer
        Integer.TryParse(Egg_DropTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        Egg_DropTextBox.Text = number.ToString()
    End Sub

    Private Sub BurgerAdd_Click(sender As Object, e As EventArgs) Handles BurgerAdd.Click
        Dim number As Integer
        Integer.TryParse(BurgerTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        BurgerTextBox.Text = number.ToString()
    End Sub

    Private Sub BurgerSub_Click(sender As Object, e As EventArgs) Handles BurgerSub.Click
        Dim number As Integer
        Integer.TryParse(BurgerTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        BurgerTextBox.Text = number.ToString()
    End Sub

    Private Sub FriesAdd_Click(sender As Object, e As EventArgs) Handles FriesAdd.Click
        Dim number As Integer
        Integer.TryParse(FriesTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        FriesTextBox.Text = number.ToString()
    End Sub

    Private Sub FriesSub_Click(sender As Object, e As EventArgs) Handles FriesSub.Click
        Dim number As Integer
        Integer.TryParse(FriesTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        FriesTextBox.Text = number.ToString()
    End Sub

    Private Sub CoffeeAdd_Click(sender As Object, e As EventArgs) Handles CoffeeAdd.Click
        Dim number As Integer
        Integer.TryParse(CoffeeTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        CoffeeTextBox.Text = number.ToString()
    End Sub

    Private Sub CoffeeSub_Click(sender As Object, e As EventArgs) Handles CoffeeSub.Click
        Dim number As Integer
        Integer.TryParse(CoffeeTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        CoffeeTextBox.Text = number.ToString()
    End Sub

    Private Sub Fruit_TeaAdd_Click(sender As Object, e As EventArgs) Handles Fruit_TeaAdd.Click
        Dim number As Integer
        Integer.TryParse(Fruit_TeaTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        Fruit_TeaTextBox.Text = number.ToString()
    End Sub

    Private Sub Fruit_TeaSub_Click(sender As Object, e As EventArgs) Handles Fruit_TeaSub.Click
        Dim number As Integer
        Integer.TryParse(Fruit_TeaTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        Fruit_TeaTextBox.Text = number.ToString()
    End Sub

    Private Sub MilkteaAdd_Click(sender As Object, e As EventArgs) Handles MilkteaAdd.Click
        Dim number As Integer
        Integer.TryParse(MilkteaTextBox.Text, number)
        number += 1
        If number <= 0 Then
            number = 0
        End If
        MilkteaTextBox.Text = number.ToString()
    End Sub

    Private Sub MilkteaSub_Click(sender As Object, e As EventArgs) Handles MilkteaSub.Click
        Dim number As Integer
        Integer.TryParse(MilkteaTextBox.Text, number)
        number -= 1
        If number <= 0 Then
            number = 0
        End If
        MilkteaTextBox.Text = number.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlaceorderButton.Click
        Dim food_waffle As Integer
        Dim food_cinnamon As Integer
        Dim food_croissant As Integer
        Dim food_bagel As Integer
        Dim food_tacos As Integer
        Dim food_eggdrop As Integer
        Dim food_burger As Integer
        Dim food_fries As Integer
        Dim food_coffee As Integer
        Dim food_fruittea As Integer
        Dim food_milktea As Integer
        Dim total_foodcount As Integer

        Dim orderText As String = ""

        If Integer.TryParse(WaffleTextBox.Text, food_waffle) AndAlso food_waffle > 0 Then
            food_waffle = 40 * food_waffle
            orderText &= "Waffle: ₱" & food_waffle & ".00" & vbCrLf
        End If

        If Integer.TryParse(Cinnamon_RollTextBox.Text, food_cinnamon) AndAlso food_cinnamon > 0 Then
            food_cinnamon = 69 * food_cinnamon
            orderText &= "Cinnamon Roll: ₱" & food_cinnamon & ".00" & vbCrLf
        End If

        If Integer.TryParse(CroissantTextBox.Text, food_croissant) AndAlso food_croissant > 0 Then
            food_croissant = 99 * food_croissant
            orderText &= "Croissant: ₱" & food_croissant & ".00" & vbCrLf
        End If

        If Integer.TryParse(BagelTextBox.Text, food_bagel) AndAlso food_bagel > 0 Then
            food_bagel = 58 * food_bagel
            orderText &= "Bagel: ₱" & food_bagel & ".00" & vbCrLf
        End If

        If Integer.TryParse(TacosTextBox.Text, food_tacos) AndAlso food_tacos > 0 Then
            food_tacos = 99 * food_tacos
            orderText &= "Tacos: ₱" & food_tacos & ".00" & vbCrLf
        End If

        If Integer.TryParse(Egg_DropTextBox.Text, food_eggdrop) AndAlso food_eggdrop > 0 Then
            food_eggdrop = 129 * food_eggdrop
            orderText &= "Egg Drop: ₱" & food_eggdrop & ".00" & vbCrLf
        End If

        If Integer.TryParse(BurgerTextBox.Text, food_burger) AndAlso food_burger > 0 Then
            food_burger = 68 * food_burger
            orderText &= "Burger: ₱" & food_burger & ".00" & vbCrLf
        End If

        If Integer.TryParse(FriesTextBox.Text, food_fries) AndAlso food_fries > 0 Then
            food_fries = 49 * food_fries
            orderText &= "Fries: ₱" & food_fries & ".00" & vbCrLf
        End If

        If Integer.TryParse(CoffeeTextBox.Text, food_coffee) AndAlso food_coffee > 0 Then
            food_coffee = 49 * food_coffee
            orderText &= "Coffee: ₱" & food_coffee & ".00" & vbCrLf
        End If

        If Integer.TryParse(Fruit_TeaTextBox.Text, food_fruittea) AndAlso food_fruittea > 0 Then
            food_fruittea = 54 * food_fruittea
            orderText &= "Fruit Tea: ₱" & food_fruittea & ".00" & vbCrLf
        End If

        If Integer.TryParse(MilkteaTextBox.Text, food_milktea) AndAlso food_milktea > 0 Then
            food_milktea = 69 * food_milktea
            orderText &= "Milktea: ₱" & food_milktea & ".00" & vbCrLf
        End If

        total_foodcount = food_waffle + food_cinnamon + food_croissant + food_bagel + food_tacos + food_eggdrop + food_burger + food_fries + food_coffee + food_fruittea + food_milktea
        Total_PurchasedTextBox.Text = "₱" & total_foodcount & ".00"

        OrderlistTextBox.Text = orderText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearformButton.Click
        WaffleTextBox.Text = ""
        Cinnamon_RollTextBox.Text = ""
        CroissantTextBox.Text = ""
        BagelTextBox.Text = ""
        TacosTextBox.Text = ""
        Egg_DropTextBox.Text = ""
        BurgerTextBox.Text = ""
        FriesTextBox.Text = ""
        CoffeeTextBox.Text = ""
        Fruit_TeaTextBox.Text = ""
        MilkteaTextBox.Text = ""
        Total_PurchasedTextBox.Text = ""
    End Sub

    Private Sub ReceiptButton_Click(sender As Object, e As EventArgs) Handles ReceiptButton.Click
        Try
            OrderInformationBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(FINALDATABASEDataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error saving data: " & ex.Message)
        End Try
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim content As String = OrderlistTextBox.Text
        Dim total As String = Total_PurchasedTextBox.Text

        If String.IsNullOrWhiteSpace(content) Then
            MessageBox.Show("Please enter the receipt content to print.")
            Return
        End If

        Dim printDocument As New PrintDocument()

        Dim paperSize As New PaperSize("Receipt", 300, 150)

        printDocument.DefaultPageSettings.PaperSize = paperSize
        printDocument.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim x As Integer = 10
        Dim y As Integer = 10

        Dim content As String = OrderlistTextBox.Text
        Dim total As String = Total_PurchasedTextBox.Text

        Dim lines As String() = content.Split({Environment.NewLine}, StringSplitOptions.None)

        For Each line As String In lines
            e.Graphics.DrawString(line, font, brush, x, y)
            y += 20
        Next


        e.Graphics.DrawString("Total: " & total, font, brush, x, y + 40)

        e.HasMorePages = False
    End Sub


End Class