namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            priceRubLit = new TextBox();
            AmountRuble = new TextBox();
            QuantityLiter = new TextBox();
            Amount = new RadioButton();
            Quantity = new RadioButton();
            comboBox_gasoline = new ComboBox();
            panel4 = new Panel();
            ruble2 = new Label();
            toPayFuel2 = new TextBox();
            toPayFuel = new Label();
            ruble = new Label();
            liter = new Label();
            gasoline = new Label();
            rubleLiter = new Label();
            price = new Label();
            panel2 = new Panel();
            TeaQuantity = new TextBox();
            ShawermaQuantity = new TextBox();
            FrenchFriesQuantity = new TextBox();
            HamburgerQuantity = new TextBox();
            HotDogQuantity = new TextBox();
            TeaPrice = new TextBox();
            ShawermaPrice = new TextBox();
            FrenchFriesPrice = new TextBox();
            HamburgerPrice = new TextBox();
            HotDogPrice = new TextBox();
            Tea = new CheckBox();
            Shawerma = new CheckBox();
            FrenchFries = new CheckBox();
            Hamburger = new CheckBox();
            HotDog = new CheckBox();
            toPayCafe = new Label();
            Quantity2 = new Label();
            price2 = new Label();
            panel5 = new Panel();
            ruble3 = new Label();
            toPayCafe2 = new TextBox();
            panel3 = new Panel();
            ruble4 = new Label();
            toPayAll = new TextBox();
            button1 = new Button();
            GasStation = new Label();
            Cafe = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(priceRubLit);
            panel1.Controls.Add(AmountRuble);
            panel1.Controls.Add(QuantityLiter);
            panel1.Controls.Add(Amount);
            panel1.Controls.Add(Quantity);
            panel1.Controls.Add(comboBox_gasoline);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(toPayFuel);
            panel1.Controls.Add(ruble);
            panel1.Controls.Add(liter);
            panel1.Controls.Add(gasoline);
            panel1.Controls.Add(rubleLiter);
            panel1.Controls.Add(price);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 299);
            panel1.TabIndex = 0;
            // 
            // priceRubLit
            // 
            priceRubLit.Enabled = false;
            priceRubLit.Location = new Point(78, 56);
            priceRubLit.Name = "priceRubLit";
            priceRubLit.Size = new Size(121, 21);
            priceRubLit.TabIndex = 17;
            priceRubLit.TextChanged += priceRubLit_TextChanged;
            // 
            // AmountRuble
            // 
            AmountRuble.Location = new Point(154, 143);
            AmountRuble.Name = "AmountRuble";
            AmountRuble.Size = new Size(100, 21);
            AmountRuble.TabIndex = 16;
            AmountRuble.TextChanged += AmountRuble_TextChanged;
            // 
            // QuantityLiter
            // 
            QuantityLiter.Location = new Point(154, 114);
            QuantityLiter.Name = "QuantityLiter";
            QuantityLiter.Size = new Size(100, 21);
            QuantityLiter.TabIndex = 15;
            QuantityLiter.TextChanged += QuantityLiter_TextChanged;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Times New Roman", 12F);
            Amount.Location = new Point(15, 144);
            Amount.Name = "Amount";
            Amount.Size = new Size(72, 23);
            Amount.TabIndex = 14;
            Amount.TabStop = true;
            Amount.Text = "Сумма";
            Amount.UseVisualStyleBackColor = true;
            Amount.CheckedChanged += Amount_CheckedChanged;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Times New Roman", 12F);
            Quantity.Location = new Point(15, 117);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(107, 23);
            Quantity.TabIndex = 13;
            Quantity.TabStop = true;
            Quantity.Text = "Количество";
            Quantity.UseVisualStyleBackColor = true;
            Quantity.CheckedChanged += Quantity_CheckedChanged;
            // 
            // comboBox_gasoline
            // 
            comboBox_gasoline.FormattingEnabled = true;
            comboBox_gasoline.Location = new Point(78, 27);
            comboBox_gasoline.Name = "comboBox_gasoline";
            comboBox_gasoline.Size = new Size(121, 23);
            comboBox_gasoline.TabIndex = 12;
            comboBox_gasoline.SelectedIndexChanged += comboBox_gasoline_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(ruble2);
            panel4.Controls.Add(toPayFuel2);
            panel4.Location = new Point(15, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 73);
            panel4.TabIndex = 11;
            // 
            // ruble2
            // 
            ruble2.AutoSize = true;
            ruble2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ruble2.Location = new Point(296, 40);
            ruble2.Name = "ruble2";
            ruble2.Size = new Size(45, 23);
            ruble2.TabIndex = 18;
            ruble2.Text = "руб.";
            // 
            // toPayFuel2
            // 
            toPayFuel2.BackColor = SystemColors.Control;
            toPayFuel2.BorderStyle = BorderStyle.None;
            toPayFuel2.Enabled = false;
            toPayFuel2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toPayFuel2.Location = new Point(80, 3);
            toPayFuel2.Name = "toPayFuel2";
            toPayFuel2.RightToLeft = RightToLeft.Yes;
            toPayFuel2.Size = new Size(214, 56);
            toPayFuel2.TabIndex = 0;
            toPayFuel2.TextChanged += toPayFuel2_TextChanged;
            // 
            // toPayFuel
            // 
            toPayFuel.AutoSize = true;
            toPayFuel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            toPayFuel.Location = new Point(16, 193);
            toPayFuel.Name = "toPayFuel";
            toPayFuel.Size = new Size(98, 22);
            toPayFuel.TabIndex = 10;
            toPayFuel.Text = "К оплате:";
            // 
            // ruble
            // 
            ruble.AutoSize = true;
            ruble.Font = new Font("Times New Roman", 12F);
            ruble.Location = new Point(260, 143);
            ruble.Name = "ruble";
            ruble.Size = new Size(36, 19);
            ruble.TabIndex = 9;
            ruble.Text = "руб.";
            // 
            // liter
            // 
            liter.AutoSize = true;
            liter.Font = new Font("Times New Roman", 12F);
            liter.Location = new Point(260, 119);
            liter.Name = "liter";
            liter.Size = new Size(21, 19);
            liter.TabIndex = 8;
            liter.Text = "л.";
            // 
            // gasoline
            // 
            gasoline.AutoSize = true;
            gasoline.Font = new Font("Times New Roman", 12F);
            gasoline.Location = new Point(16, 30);
            gasoline.Name = "gasoline";
            gasoline.Size = new Size(58, 19);
            gasoline.TabIndex = 5;
            gasoline.Text = "Бензин";
            // 
            // rubleLiter
            // 
            rubleLiter.AutoSize = true;
            rubleLiter.Font = new Font("Times New Roman", 12F);
            rubleLiter.Location = new Point(221, 61);
            rubleLiter.Name = "rubleLiter";
            rubleLiter.Size = new Size(60, 19);
            rubleLiter.TabIndex = 7;
            rubleLiter.Text = "руб. / л.";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Times New Roman", 12F);
            price.Location = new Point(16, 61);
            price.Name = "price";
            price.Size = new Size(43, 19);
            price.TabIndex = 6;
            price.Text = "Цена";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(TeaQuantity);
            panel2.Controls.Add(ShawermaQuantity);
            panel2.Controls.Add(FrenchFriesQuantity);
            panel2.Controls.Add(HamburgerQuantity);
            panel2.Controls.Add(HotDogQuantity);
            panel2.Controls.Add(TeaPrice);
            panel2.Controls.Add(ShawermaPrice);
            panel2.Controls.Add(FrenchFriesPrice);
            panel2.Controls.Add(HamburgerPrice);
            panel2.Controls.Add(HotDogPrice);
            panel2.Controls.Add(Tea);
            panel2.Controls.Add(Shawerma);
            panel2.Controls.Add(FrenchFries);
            panel2.Controls.Add(Hamburger);
            panel2.Controls.Add(HotDog);
            panel2.Controls.Add(toPayCafe);
            panel2.Controls.Add(Quantity2);
            panel2.Controls.Add(price2);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(414, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 299);
            panel2.TabIndex = 1;
            // 
            // TeaQuantity
            // 
            TeaQuantity.Location = new Point(289, 149);
            TeaQuantity.Name = "TeaQuantity";
            TeaQuantity.Size = new Size(72, 21);
            TeaQuantity.TabIndex = 31;
            // 
            // ShawermaQuantity
            // 
            ShawermaQuantity.Location = new Point(289, 120);
            ShawermaQuantity.Name = "ShawermaQuantity";
            ShawermaQuantity.Size = new Size(72, 21);
            ShawermaQuantity.TabIndex = 30;
            // 
            // FrenchFriesQuantity
            // 
            FrenchFriesQuantity.Location = new Point(289, 92);
            FrenchFriesQuantity.Name = "FrenchFriesQuantity";
            FrenchFriesQuantity.Size = new Size(72, 21);
            FrenchFriesQuantity.TabIndex = 29;
            // 
            // HamburgerQuantity
            // 
            HamburgerQuantity.Location = new Point(289, 67);
            HamburgerQuantity.Name = "HamburgerQuantity";
            HamburgerQuantity.Size = new Size(72, 21);
            HamburgerQuantity.TabIndex = 28;
            // 
            // HotDogQuantity
            // 
            HotDogQuantity.Location = new Point(289, 38);
            HotDogQuantity.Name = "HotDogQuantity";
            HotDogQuantity.Size = new Size(72, 21);
            HotDogQuantity.TabIndex = 27;
            // 
            // TeaPrice
            // 
            TeaPrice.Enabled = false;
            TeaPrice.Location = new Point(201, 149);
            TeaPrice.Name = "TeaPrice";
            TeaPrice.Size = new Size(73, 21);
            TeaPrice.TabIndex = 26;
            TeaPrice.Text = "50,00 руб";
            TeaPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // ShawermaPrice
            // 
            ShawermaPrice.Enabled = false;
            ShawermaPrice.Location = new Point(201, 119);
            ShawermaPrice.Name = "ShawermaPrice";
            ShawermaPrice.Size = new Size(73, 21);
            ShawermaPrice.TabIndex = 25;
            ShawermaPrice.Text = "270,00 руб";
            ShawermaPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // FrenchFriesPrice
            // 
            FrenchFriesPrice.Enabled = false;
            FrenchFriesPrice.Location = new Point(201, 94);
            FrenchFriesPrice.Name = "FrenchFriesPrice";
            FrenchFriesPrice.Size = new Size(73, 21);
            FrenchFriesPrice.TabIndex = 24;
            FrenchFriesPrice.Text = "100,00 руб";
            FrenchFriesPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // HamburgerPrice
            // 
            HamburgerPrice.Enabled = false;
            HamburgerPrice.Location = new Point(201, 67);
            HamburgerPrice.Name = "HamburgerPrice";
            HamburgerPrice.Size = new Size(73, 21);
            HamburgerPrice.TabIndex = 23;
            HamburgerPrice.Text = "230,00 руб";
            HamburgerPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // HotDogPrice
            // 
            HotDogPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            HotDogPrice.Enabled = false;
            HotDogPrice.Location = new Point(201, 38);
            HotDogPrice.Name = "HotDogPrice";
            HotDogPrice.RightToLeft = RightToLeft.No;
            HotDogPrice.Size = new Size(73, 21);
            HotDogPrice.TabIndex = 22;
            HotDogPrice.Text = "150,00 руб";
            HotDogPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // Tea
            // 
            Tea.AutoSize = true;
            Tea.Font = new Font("Times New Roman", 12F);
            Tea.Location = new Point(16, 146);
            Tea.Name = "Tea";
            Tea.Size = new Size(54, 23);
            Tea.TabIndex = 21;
            Tea.Text = "Чай";
            Tea.UseVisualStyleBackColor = true;
            Tea.CheckedChanged += Tea_CheckedChanged;
            // 
            // Shawerma
            // 
            Shawerma.AutoSize = true;
            Shawerma.Font = new Font("Times New Roman", 12F);
            Shawerma.Location = new Point(16, 121);
            Shawerma.Name = "Shawerma";
            Shawerma.Size = new Size(81, 23);
            Shawerma.TabIndex = 20;
            Shawerma.Text = "Шаурма";
            Shawerma.UseVisualStyleBackColor = true;
            Shawerma.CheckedChanged += Shawerma_CheckedChanged;
            // 
            // FrenchFries
            // 
            FrenchFries.AutoSize = true;
            FrenchFries.Font = new Font("Times New Roman", 12F);
            FrenchFries.Location = new Point(16, 96);
            FrenchFries.Name = "FrenchFries";
            FrenchFries.Size = new Size(130, 23);
            FrenchFries.TabIndex = 19;
            FrenchFries.Text = "Картофель фри";
            FrenchFries.UseVisualStyleBackColor = true;
            FrenchFries.CheckedChanged += FrenchFries_CheckedChanged;
            // 
            // Hamburger
            // 
            Hamburger.AutoSize = true;
            Hamburger.Font = new Font("Times New Roman", 12F);
            Hamburger.Location = new Point(16, 71);
            Hamburger.Name = "Hamburger";
            Hamburger.Size = new Size(97, 23);
            Hamburger.TabIndex = 18;
            Hamburger.Text = "Гамбургер";
            Hamburger.UseVisualStyleBackColor = true;
            Hamburger.CheckedChanged += Hamburger_CheckedChanged;
            // 
            // HotDog
            // 
            HotDog.AutoSize = true;
            HotDog.Font = new Font("Times New Roman", 12F);
            HotDog.Location = new Point(16, 46);
            HotDog.Name = "HotDog";
            HotDog.Size = new Size(81, 23);
            HotDog.TabIndex = 17;
            HotDog.Text = "Хот-дог";
            HotDog.UseVisualStyleBackColor = true;
            HotDog.CheckedChanged += HotDog_CheckedChanged;
            // 
            // toPayCafe
            // 
            toPayCafe.AutoSize = true;
            toPayCafe.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            toPayCafe.Location = new Point(17, 191);
            toPayCafe.Name = "toPayCafe";
            toPayCafe.Size = new Size(98, 22);
            toPayCafe.TabIndex = 15;
            toPayCafe.Text = "К оплате:";
            // 
            // Quantity2
            // 
            Quantity2.AutoSize = true;
            Quantity2.Location = new Point(289, 18);
            Quantity2.Name = "Quantity2";
            Quantity2.Size = new Size(42, 15);
            Quantity2.TabIndex = 14;
            Quantity2.Text = "Кол-во";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(211, 18);
            price2.Name = "price2";
            price2.Size = new Size(32, 15);
            price2.TabIndex = 13;
            price2.Text = "Цена";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(ruble3);
            panel5.Controls.Add(toPayCafe2);
            panel5.Location = new Point(16, 218);
            panel5.Name = "panel5";
            panel5.Size = new Size(345, 73);
            panel5.TabIndex = 12;
            // 
            // ruble3
            // 
            ruble3.AutoSize = true;
            ruble3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ruble3.Location = new Point(297, 40);
            ruble3.Name = "ruble3";
            ruble3.Size = new Size(45, 23);
            ruble3.TabIndex = 10;
            ruble3.Text = "руб.";
            // 
            // toPayCafe2
            // 
            toPayCafe2.BackColor = SystemColors.ButtonFace;
            toPayCafe2.BorderStyle = BorderStyle.None;
            toPayCafe2.Enabled = false;
            toPayCafe2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toPayCafe2.ForeColor = SystemColors.InfoText;
            toPayCafe2.Location = new Point(146, 3);
            toPayCafe2.Name = "toPayCafe2";
            toPayCafe2.RightToLeft = RightToLeft.Yes;
            toPayCafe2.Size = new Size(146, 56);
            toPayCafe2.TabIndex = 1;
            toPayCafe2.TextChanged += toPayCafe2_TextChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(ruble4);
            panel3.Controls.Add(toPayAll);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(12, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 100);
            panel3.TabIndex = 2;
            // 
            // ruble4
            // 
            ruble4.AutoSize = true;
            ruble4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            ruble4.Location = new Point(704, 57);
            ruble4.Name = "ruble4";
            ruble4.Size = new Size(69, 36);
            ruble4.TabIndex = 2;
            ruble4.Text = "руб.";
            // 
            // toPayAll
            // 
            toPayAll.BackColor = SystemColors.ButtonFace;
            toPayAll.BorderStyle = BorderStyle.None;
            toPayAll.Font = new Font("Times New Roman", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toPayAll.Location = new Point(439, 7);
            toPayAll.Name = "toPayAll";
            toPayAll.Size = new Size(257, 84);
            toPayAll.TabIndex = 1;
            toPayAll.TextChanged += toPayAll_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(15, 10);
            button1.Name = "button1";
            button1.Size = new Size(152, 81);
            button1.TabIndex = 0;
            button1.Text = "ИТОГ";
            button1.UseVisualStyleBackColor = false;
            // 
            // GasStation
            // 
            GasStation.AutoSize = true;
            GasStation.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            GasStation.Location = new Point(15, 5);
            GasStation.Name = "GasStation";
            GasStation.Size = new Size(132, 22);
            GasStation.TabIndex = 3;
            GasStation.Text = "Автозаправка";
            // 
            // Cafe
            // 
            Cafe.AutoSize = true;
            Cafe.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            Cafe.Location = new Point(418, 5);
            Cafe.Name = "Cafe";
            Cafe.Size = new Size(110, 22);
            Cafe.TabIndex = 4;
            Cafe.Text = "Мини-кафе";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cafe);
            Controls.Add(GasStation);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Заправка 101 км.";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label toPayFuel;
        private Label ruble;
        private Label liter;
        private Label gasoline;
        private Label rubleLiter;
        private Label price;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Label GasStation;
        private Label Cafe;
        private Label toPayCafe;
        private Label Quantity2;
        private Label price2;
        private Button button1;
        private ComboBox comboBox_gasoline;
        private CheckBox HotDog;
        private TextBox TeaQuantity;
        private TextBox ShawermaQuantity;
        private TextBox FrenchFriesQuantity;
        private TextBox HamburgerQuantity;
        private TextBox HotDogQuantity;
        private TextBox TeaPrice;
        private TextBox ShawermaPrice;
        private TextBox FrenchFriesPrice;
        private TextBox HamburgerPrice;
        private TextBox HotDogPrice;
        private CheckBox Tea;
        private CheckBox Shawerma;
        private CheckBox FrenchFries;
        private CheckBox Hamburger;
        private TextBox priceRubLit;
        private TextBox AmountRuble;
        private TextBox QuantityLiter;
        private RadioButton Amount;
        private RadioButton Quantity;
        private TextBox toPayFuel2;
        private Label ruble2;
        private TextBox toPayCafe2;
        private Label ruble3;
        private TextBox toPayAll;
        private Label ruble4;
    }
}
