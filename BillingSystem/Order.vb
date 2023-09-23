Public Class Order

    Dim ChickenRice As Double = 900
    Dim Biriyani As Double = 1200
    Dim NaziRice As Double = 1300
    Dim SeafoodRice As Double = 1300
    Dim MixedRice As Double = 1500
    Dim ChickenKottu As Double = 900
    Dim EggKottu As Double = 800
    Dim CheeseKottu As Double = 1200
    Dim MixedKottu As Double = 1300
    Dim ChickenB As Double = 2000
    Dim SausB As Double = 1500
    Dim EggB As Double = 1300
    Dim FishB As Double = 1500
    Dim Coke As Double = 150
    Dim Pepsi As Double = 150
    Dim Sprite As Double = 150
    Dim EGB As Double = 150
    Dim IceCream As Double = 250
    Dim MilkShake As Double = 250
    Dim FruitJuice As Double = 250
    Dim FruitSalad As Double = 250
    Dim Watalappan As Double = 250


    Private Sub btnorderdash_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnorderdash.Click

        Dash.Show()
        Me.Hide()

    End Sub

    Private Sub Order_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        comboxrice.Text = "Choose One"
        comboxrice.Items.Add("Chicken Rice")
        comboxrice.Items.Add("Biriyani")
        comboxrice.Items.Add("Nazi Rice")
        comboxrice.Items.Add("SeaFood Rice")
        comboxrice.Items.Add("Mixed Rice")

        comboxkottu.Text = "Choose One"
        comboxkottu.Items.Add("Chicken Kottu")
        comboxkottu.Items.Add("Egg Kottu")
        comboxkottu.Items.Add("Cheese Kottu")
        comboxkottu.Items.Add("Mixed Kottu")

        comboxburgur.Text = "Choose One"
        comboxburgur.Items.Add("Chicken")
        comboxburgur.Items.Add("Sausej")
        comboxburgur.Items.Add("Egg")
        comboxburgur.Items.Add("Fish")

        comboxdrinks.Text = "Choose One"
        comboxdrinks.Items.Add("Coke")
        comboxdrinks.Items.Add("Pepsi")
        comboxdrinks.Items.Add("Sprite")
        comboxdrinks.Items.Add("EGB")

        comboxdess.Text = "Choose One"
        comboxdess.Items.Add("Ice Cream")
        comboxdess.Items.Add("Milkshake")
        comboxdess.Items.Add("Fruit Juice")
        comboxdess.Items.Add("Fruit Salad")
        comboxdess.Items.Add("Watalappan")

    End Sub

    Private Sub updwnrice_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updwnrice.ValueChanged
        If comboxrice.Text = "Chicken Rice" Then
            txtboxrice.Text = updwnrice.Value * ChickenRice
        ElseIf comboxrice.Text = "Biriyani" Then
            txtboxrice.Text = updwnrice.Value * Biriyani
        ElseIf comboxrice.Text = "Nazi Rice" Then
            txtboxrice.Text = updwnrice.Value * NaziRice
        ElseIf comboxrice.Text = "SeaFood Rice" Then
            txtboxrice.Text = updwnrice.Value * SeafoodRice
        ElseIf comboxrice.Text = "Mixed Rice" Then
            txtboxrice.Text = updwnrice.Value * MixedRice
        End If
    End Sub

    Private Sub updwnkottu_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updwnkottu.ValueChanged

        If comboxkottu.Text = "Chicken Kottu" Then
            txtboxkottu.Text = updwnkottu.Value * ChickenKottu
        ElseIf comboxkottu.Text = "Egg Kottu" Then
            txtboxkottu.Text = updwnkottu.Value * EggKottu
        ElseIf comboxkottu.Text = "Cheese Kottu" Then
            txtboxkottu.Text = updwnkottu.Value * CheeseKottu
        ElseIf comboxkottu.Text = "Mixed Kottu" Then
            txtboxkottu.Text = updwnkottu.Value * MixedKottu
        End If

    End Sub

    Private Sub updwnpizza_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updwnpizza.ValueChanged

        If comboxburgur.Text = "Chicken" Then
            txtboxpizza.Text = updwnpizza.Value * ChickenB
        ElseIf comboxburgur.Text = "Sausej" Then
            txtboxpizza.Text = updwnpizza.Value * SausB
        ElseIf comboxburgur.Text = "Egg" Then
            txtboxpizza.Text = updwnpizza.Value * EggB
        ElseIf comboxburgur.Text = "Fish" Then
            txtboxpizza.Text = updwnpizza.Value * FishB
        End If


    End Sub

    Private Sub updwndrinks_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updwndrinks.ValueChanged

        If comboxdrinks.Text = "Coke" Then
            txtboxdrinks.Text = updwndrinks.Value * Coke
        ElseIf comboxdrinks.Text = "Pepsi" Then
            txtboxdrinks.Text = updwndrinks.Value * Pepsi
        ElseIf comboxdrinks.Text = "Sprite" Then
            txtboxdrinks.Text = updwndrinks.Value * Sprite
        ElseIf comboxdrinks.Text = "EGB" Then
            txtboxdrinks.Text = updwndrinks.Value * EGB
        End If

    End Sub

    Private Sub updwndess_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles updwndess.ValueChanged

        If comboxdess.Text = "Ice Cream" Then
            txtboxdess.Text = updwndess.Value * IceCream
        ElseIf comboxdess.Text = "Milkshake" Then
            txtboxdess.Text = updwndess.Value * MilkShake
        ElseIf comboxdess.Text = "Fruit Juice" Then
            txtboxdess.Text = updwndess.Value * FruitJuice
        ElseIf comboxdess.Text = "Fruit Salad" Then
            txtboxdess.Text = updwndess.Value * FruitSalad
        ElseIf comboxdess.Text = "Watalappan" Then
            txtboxdess.Text = updwndess.Value * Watalappan
        End If

    End Sub

    Private Sub btnorderadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnorderadd.Click

        tot1 = txtboxrice.Text
        tot2 = txtboxkottu.Text
        tot3 = txtboxpizza.Text
        tot4 = txtboxdrinks.Text
        tot5 = txtboxdess.Text

        txtordersubtot.Text = tot1 + tot2 + tot3 + tot4 + tot5
    End Sub

   Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub btnordernext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnordernext.Click

        Pay.Show()
        Me.Hide()

    End Sub

    Private Sub btnorderreset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnorderreset.Click
        updwnrice.Value = 0
        updwnkottu.Value = 0
        updwnpizza.Value = 0
        updwndrinks.Value = 0
        updwndess.Value = 0

        txtboxrice.Text = ""
        txtboxkottu.Text = ""
        txtboxpizza.Text = ""
        txtboxdrinks.Text = ""
        txtboxdess.Text = ""
        txtordersubtot.Text = ""

    End Sub

End Class