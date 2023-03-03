namespace Programming
{
    using System.Linq;
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] //Все перечилений 
            {
                typeof(Colors), typeof(Formofeducation), typeof(Genre),typeof(Season),typeof(SmartphoneManufacturers), typeof(Weekday)
            };
            EnumsListBox.Items.AddRange((enums));//Добавляет массив элементов в список
           SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Enumaration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;// 

            var enumValues = Enum.GetValues(selectedEnum);//
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }
        
        private void parsingBut_Click(object sender, EventArgs e)
        {

            Weekday text;
            if(Enum.TryParse(ParseTextBox.Text,out text))
            {
                ParseLabel.Text = $"Это день недели {text}={(int)text}";
            }
            else
            {
                ParseLabel.Text = "Нет такого дня недели";
            }
        }

        private void goButtn_Click(object sender, EventArgs e)
        {
            string seasons =SeasonComboBox.Text;
            
            switch (seasons)
            {

                case "Spring":
                    this.BackColor = Color.Green;
                    break;
                case "Autumn":
                    this.BackColor = Color.Orange;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }    
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedIndex == null)
            {
                return;
            }
            int selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }

        private void SesonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}