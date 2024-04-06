namespace Test
{
    public partial class Form1 : Form
    {
        private decimal fuelPrice;
        private decimal totalAmount;

        public Form1()
        {
            InitializeComponent();
            FillFuelTypes();
            //priceRubLit.Leave += PriceRubLit_Leave;                       
            /* priceRubLit.Enabled = false;*/

            priceRubLit.TextChanged += priceRubLit_TextChanged;
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
            //Quantity.Checked = true;
            //Quantity_CheckedChanged(null, EventArgs.Empty);

        }
        private Dictionary<string, decimal> fuelTypes = new Dictionary<string, decimal>
        {
            {"��-92", 50.50m},
            {"��-95", 55.50m},
            {"��-98", 58.80m},
            {"��", 60.60m}
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
            if (fuelTypes.ContainsKey(selectedFuelType))
            {
                decimal pricePerLiter = fuelTypes[selectedFuelType];
                priceRubLit.Text = pricePerLiter.ToString();

                // ����������� ����� ��������� ��� ����� ���� �������
                CalculateTotalCost();
            }
        }
        private void CalculateTotalCost()
        {
            if (comboBox_gasoline.SelectedItem == null)
                return;

            string selectedFuelType = comboBox_gasoline.Text;
            decimal pricePerLiter = fuelTypes[selectedFuelType];

            if (Quantity.Checked)
            {
                if (decimal.TryParse(QuantityLiter.Text, out decimal quantity))
                {
                    decimal totalCost = quantity * pricePerLiter;
                    toPayFuel2.Text = totalCost.ToString();
                }
                else
                {
                    toPayFuel2.Text = string.Empty;
                }
            }
            else if (Amount.Checked)
            {
                if (decimal.TryParse(AmountRuble.Text, out decimal amount))
                {
                    toPayFuel2.Text = amount.ToString();
                }
                else
                {
                    toPayFuel2.Text = string.Empty;
                }
            }
        }


        private void priceRubLit_TextChanged(object sender, EventArgs e) // ��������� �����
        {

        }

        private void Quantity_CheckedChanged(object sender, EventArgs e) // ����� �� ������
        {
            QuantityLiter.Enabled = Quantity.Checked;
            AmountRuble.Enabled = !Quantity.Checked;
            CalculateTotalCost();
        }
        private void QuantityLiter_TextChanged(object sender, EventArgs e) // ���� ����� ������
        {
            CalculateTotalCost();
        }

        private void Amount_CheckedChanged(object sender, EventArgs e) // ����� �� �����
        {
            AmountRuble.Enabled = Amount.Checked;
            QuantityLiter.Enabled = !Amount.Checked;
            CalculateTotalCost();
        }

        private void AmountRuble_TextChanged(object sender, EventArgs e) // ���� �� �������
        {
            CalculateTotalCost();
            /*// �������� ��������� ��� �������
            string selectedFuelType = comboBox_gasoline.Text;

            // ���������, ���� �� ����� ��� � �������
            if (fuelTypes.ContainsKey(selectedFuelType))
            {
                decimal pricePerLiter = fuelTypes[selectedFuelType];

                // ���������, ���� �� �������� ����� � AmountRuble textBox
                if (decimal.TryParse(AmountRuble.Text, out decimal amount) && amount > 0)
                {
                    // ��������� ���������� ������ ����� ������� ����� �� ����� ���� �� ����
                    decimal liters = amount / pricePerLiter;

                    // ������� ���������� ������ � textBox
                    QuantityLiter.Text = liters.ToString();
                }
            }
            else
            {
                // ���� ������ ����������� ��� �������, ������� ����
                QuantityLiter.Clear();
            }*/
        }
        private void toPayFuel2_TextChanged(object sender, EventArgs e)
        {

            // �������� ��������� ������� �� comboBox
            string selectedFuelType = comboBox_gasoline.Text;
            if (fuelTypes.ContainsKey(selectedFuelType))
            {
                decimal pricePerLiter = fuelTypes[selectedFuelType];

                // ���������, ���� �� �������� ����� � AmountRuble textBox
                if (decimal.TryParse(AmountRuble.Text, out decimal amount) && amount > 0)
                {
                    // ��������� ���������� ������ ����� ������� ����� �� ����� ���� �� ����
                    decimal liters = amount / pricePerLiter;

                    // ������� ���������� ������ � textBox
                    toPayFuel2.Text = liters.ToString("F2");
                    // �������� ����� � ������ ruble2 �� "���."
                    ruble2.Text = "���.";
                }

                else
                {                   
                    ruble2.Text = "���.";
                }
            }
            /*else
            {
                // ��������� ������������� ������ �������
                toPayFuel2.Text = "������ �����";

                // �������� ����� � ������ ruble2 �� "���."
                ruble2.Text = "���.";
            }*/

            /*else
            {
                // ��������� ������������� �����
                toPayFuel2.Text = "������ �����";
            }*/
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

            if (HotDog.Checked && !string.IsNullOrWhiteSpace(HotDogQuantity.Text))
            {
                if (decimal.TryParse(HotDogQuantity.Text, out decimal hotDogQuantity))
                    total += hotDogQuantity * 150;
            }
            if (Hamburger.Checked && !string.IsNullOrWhiteSpace(HamburgerQuantity.Text))
            {
                if (decimal.TryParse(HamburgerQuantity.Text, out decimal hamburgerQuantity))
                    total += hamburgerQuantity * 230;
            }
            if (FrenchFries.Checked && !string.IsNullOrWhiteSpace(FrenchFriesQuantity.Text))
            {
                if (decimal.TryParse(FrenchFriesQuantity.Text, out decimal frenchFriesQuantity))
                    total += frenchFriesQuantity * 100;
            }
            if (Shawerma.Checked && !string.IsNullOrWhiteSpace(ShawermaQuantity.Text))
            {
                if (decimal.TryParse(ShawermaQuantity.Text, out decimal shawermaQuantity))
                    total += shawermaQuantity * 270;
            }
            if (Tea.Checked && !string.IsNullOrWhiteSpace(TeaQuantity.Text))
            {
                if (decimal.TryParse(TeaQuantity.Text, out decimal teaQuantity))
                    total += teaQuantity * 50;
            }
            if (decimal.TryParse(toPayCafe2.Text, out decimal currentValue))
            {
                if (total != currentValue)
                    toPayCafe2.Text = total.ToString();
            }
            else
            {
                toPayCafe2.Text = total.ToString();
            }
        }
        private void toPayCafe2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void toPayAll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
