namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DeliveryAddressGroupBox = new GroupBox();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            IndexTextBox = new TextBox();
            ApartmentLabel = new Label();
            CityLabel = new Label();
            BuildingLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            DeliveryAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeliveryAddressGroupBox
            // 
            DeliveryAddressGroupBox.Controls.Add(ApartmentTextBox);
            DeliveryAddressGroupBox.Controls.Add(CityTextBox);
            DeliveryAddressGroupBox.Controls.Add(BuildingTextBox);
            DeliveryAddressGroupBox.Controls.Add(StreetTextBox);
            DeliveryAddressGroupBox.Controls.Add(CountryTextBox);
            DeliveryAddressGroupBox.Controls.Add(IndexTextBox);
            DeliveryAddressGroupBox.Controls.Add(ApartmentLabel);
            DeliveryAddressGroupBox.Controls.Add(CityLabel);
            DeliveryAddressGroupBox.Controls.Add(BuildingLabel);
            DeliveryAddressGroupBox.Controls.Add(StreetLabel);
            DeliveryAddressGroupBox.Controls.Add(CountryLabel);
            DeliveryAddressGroupBox.Controls.Add(PostIndexLabel);
            DeliveryAddressGroupBox.Dock = DockStyle.Fill;
            DeliveryAddressGroupBox.Location = new Point(0, 0);
            DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            DeliveryAddressGroupBox.Size = new Size(715, 366);
            DeliveryAddressGroupBox.TabIndex = 0;
            DeliveryAddressGroupBox.TabStop = false;
            DeliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(423, 237);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(150, 31);
            ApartmentTextBox.TabIndex = 11;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(483, 120);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 31);
            CityTextBox.TabIndex = 10;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(143, 240);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(150, 31);
            BuildingTextBox.TabIndex = 9;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(143, 177);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(503, 31);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(143, 117);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(257, 31);
            CountryTextBox.TabIndex = 7;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(143, 53);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(150, 31);
            IndexTextBox.TabIndex = 6;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(316, 243);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(101, 25);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(431, 123);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(46, 25);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(39, 243);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(80, 25);
            BuildingLabel.TabIndex = 3;
            BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(39, 180);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(61, 25);
            StreetLabel.TabIndex = 2;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(39, 120);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(79, 25);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(39, 56);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(98, 25);
            PostIndexLabel.TabIndex = 0;
            PostIndexLabel.Text = "Post Index:";
            // 
            // AddressContro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeliveryAddressGroupBox);
            Name = "AddressContro";
            Size = new Size(715, 366);
            DeliveryAddressGroupBox.ResumeLayout(false);
            DeliveryAddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DeliveryAddressGroupBox;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox IndexTextBox;
        private Label ApartmentLabel;
        private Label CityLabel;
        private Label BuildingLabel;
        private Label StreetLabel;
    }
}
