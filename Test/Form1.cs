using System.Globalization;

namespace Test
{
    public partial class Form1 : Form
    {
        private decimal fuelPrice;
        private decimal totalAmount;
        private static decimal totalRevenue;

        public Form1()
        {
            InitializeComponent();
            FillFuelTypes();
            this.FormClosing += FormMain_FormClosing;
            HotDogQuantity.Enabled = false;
            HamburgerQuantity.Enabled = false;
            FrenchFriesQuantity.Enabled = false;
            ShawermaQuantity.Enabled = false;
            TeaQuantity.Enabled = false;
            HotDogQuantity.TextChanged += toPayCafe2_TextChanged;
            HamburgerQuantity.TextChanged += toPayCafe2_TextChanged;
            FrenchFriesQuantity.TextChanged += toPayCafe2_TextChanged;
            ShawermaQuantity.TextChanged += toPayCafe2_TextChanged;
            TeaQuantity.TextChanged += toPayCafe2_TextChanged;
        }
        private Dictionary<string, decimal> fuelTypes = new Dictionary<string, decimal>
        {
            {"АИ-98", 58.80m},
            {"АИ-92", 50.50m},
            {"АИ-95", 55.50m},
            {"ДТ",    60.60m}
        };
        private void FillFuelTypes()
        {
            comboBox_gasoline.DataSource = new BindingSource(fuelTypes, null);
            comboBox_gasoline.DisplayMember = "Key";
            comboBox_gasoline.ValueMember = "Value";
        }
        private void comboBox_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFuelType = comboBox_gasoline.Text;
            if (fuelTypes.ContainsKey(selectedFuelType)) {
                decimal pricePerLiter = fuelTypes[selectedFuelType];
                priceRubLit.Text = pricePerLiter.ToString();

                CalculateTotalCost();
            }
        }
        private void CalculateTotalCost()
        {
            if (comboBox_gasoline.SelectedItem == null)
                return;

            string selectedFuelType = comboBox_gasoline.Text;
            decimal pricePerLiter = fuelTypes[selectedFuelType];

            if (Quantity.Checked) {
                if (decimal.TryParse(QuantityLiter.Text, out decimal quantity)) {
                    decimal totalCost = quantity * pricePerLiter;
                    toPayFuel2.Text = totalCost.ToString();
                }
                else {
                    toPayFuel2.Text = string.Empty;
                }
            }
            else if (Amount.Checked) {
                if (decimal.TryParse(AmountRuble.Text, out decimal amount)) {
                    toPayFuel2.Text = amount.ToString();
                }
                else {
                    toPayFuel2.Text = string.Empty;
                }
            }
        }
        private void priceRubLit_TextChanged(object sender, EventArgs e)
        {
            string selectedFuelType = comboBox_gasoline.Text;

            if (fuelTypes.ContainsKey(selectedFuelType)) {
                decimal pricePerLiter = fuelTypes[selectedFuelType];
                priceRubLit.Text = pricePerLiter.ToString("F2");
            }
            else {
                priceRubLit.Text = "Ошибка ввода";
            }
        }
        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            QuantityLiter.Enabled = Quantity.Checked;
            if (AmountRuble.Enabled = !Quantity.Checked) {
                ruble2.Text = "лит.";
                toPayFuel.Text = "К выдаче:";
                QuantityLiter.Clear();
            }
            CalculateTotalCost();
        }
        private void QuantityLiter_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }
        private void Amount_CheckedChanged(object sender, EventArgs e)
        {
            AmountRuble.Enabled = Amount.Checked;
            if (QuantityLiter.Enabled = !Amount.Checked) {
                ruble2.Text = "руб.";
                toPayFuel.Text = "К оплате:";
                AmountRuble.Clear();
            }
            CalculateTotalCost();
        }
        private void AmountRuble_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }
        private void toPayFuel2_TextChanged(object sender, EventArgs e)
        {
            string selectedFuelType = comboBox_gasoline.Text;
            if (fuelTypes.ContainsKey(selectedFuelType)) {
                decimal pricePerLiter = fuelTypes[selectedFuelType];

                if (decimal.TryParse(AmountRuble.Text, out decimal amount) && amount > 0) {
                    decimal liters = amount / pricePerLiter;
                    toPayFuel2.Text = liters.ToString("F2");
                }
            }
        }
        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            HotDogQuantity.Enabled = HotDog.Checked;
            if (!HotDog.Checked)
                HotDogQuantity.Text = "";
            CalculateTotal();
        }
        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            HamburgerQuantity.Enabled = Hamburger.Checked;
            if (!Hamburger.Checked)
                HamburgerQuantity.Text = "";
            CalculateTotal();
        }
        private void FrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            FrenchFriesQuantity.Enabled = FrenchFries.Checked;
            if (!FrenchFries.Checked)
                FrenchFriesQuantity.Text = "";
            CalculateTotal();
        }
        private void Shawerma_CheckedChanged(object sender, EventArgs e)
        {
            ShawermaQuantity.Enabled = Shawerma.Checked;
            if (!Shawerma.Checked)
                ShawermaQuantity.Text = "";
            CalculateTotal();
        }
        private void Tea_CheckedChanged(object sender, EventArgs e)
        {
            TeaQuantity.Enabled = Tea.Checked;
            if (!Tea.Checked)
                TeaQuantity.Text = "";
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal total = 0;

            if (HotDog.Checked && !string.IsNullOrWhiteSpace(HotDogQuantity.Text)) {
                if (decimal.TryParse(HotDogQuantity.Text, out decimal hotDogQuantity))
                    total += hotDogQuantity * 150;
            }
            if (Hamburger.Checked && !string.IsNullOrWhiteSpace(HamburgerQuantity.Text)) {
                if (decimal.TryParse(HamburgerQuantity.Text, out decimal hamburgerQuantity))
                    total += hamburgerQuantity * 230;
            }
            if (FrenchFries.Checked && !string.IsNullOrWhiteSpace(FrenchFriesQuantity.Text)) {
                if (decimal.TryParse(FrenchFriesQuantity.Text, out decimal frenchFriesQuantity))
                    total += frenchFriesQuantity * 100;
            }
            if (Shawerma.Checked && !string.IsNullOrWhiteSpace(ShawermaQuantity.Text)) {
                if (decimal.TryParse(ShawermaQuantity.Text, out decimal shawermaQuantity))
                    total += shawermaQuantity * 270;
            }
            if (Tea.Checked && !string.IsNullOrWhiteSpace(TeaQuantity.Text)) {
                if (decimal.TryParse(TeaQuantity.Text, out decimal teaQuantity))
                    total += teaQuantity * 50;
            }
            if (decimal.TryParse(toPayCafe2.Text, out decimal currentValue)) {
                if (total != currentValue)
                    toPayCafe2.Text = total.ToString();
            }
            else {
                toPayCafe2.Text = total.ToString();
            }
        }
        private void toPayCafe2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private async void totalSum_Click(object sender, EventArgs e)
        {            
            decimal toPayCafe = decimal.Parse(toPayCafe2.Text);
            decimal totalAmount = toPayCafe;
            
            if (Quantity.Checked) {
                string selectedFuelType = comboBox_gasoline.Text;
                if (fuelTypes.ContainsKey(selectedFuelType)) {
                    decimal pricePerLiter = fuelTypes[selectedFuelType];
                    decimal liters = decimal.Parse(QuantityLiter.Text);
                    totalAmount += pricePerLiter * liters;
                }
            }
            else {
                decimal gasAmount = decimal.Parse(AmountRuble.Text);
                totalAmount += gasAmount;
            }            
            toPayAll.Text = totalAmount.ToString();
            if (!string.IsNullOrWhiteSpace(toPayAll.Text)) {
                decimal currentTotal;
                if (decimal.TryParse(toPayAll.Text, out currentTotal)) {
                    totalRevenue += currentTotal;
                }
            }

            await Task.Delay(5000);
            var result = MessageBox.Show("Очистить форму для следующего клиента?", "Запрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                toPayFuel2.Text = "";
                Quantity.Checked = false;
                Amount.Checked = false;
                HotDog.Checked = false;
                Hamburger.Checked = false;
                FrenchFries.Checked = false;
                Shawerma.Checked = false;
                Tea.Checked = false;
                AmountRuble.Enabled = false;
                QuantityLiter.Text = "";
                AmountRuble.Text = "";
                toPayAll.Text = "";
            }
            else {
                await Task.Delay(5000);
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toPayAll.Text)) {
                decimal currentTotal;
                if (decimal.TryParse(toPayAll.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out currentTotal)) {
                    totalRevenue += currentTotal;
                }
                else {
                    MessageBox.Show($"Ошибка парсинга значения '{toPayAll.Text}'. Выручка за день будет некорректной.");
                }
            }
            MessageBox.Show($"Выручка за день: {totalRevenue:C}");
        }
    }
}
