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
                typeof(Colors), 
                typeof(Formofуeducation), 
                typeof(Genre),
                typeof(Season),
                typeof(SmartphoneManufacturers),
                typeof(Weekday)
            };
            EnumsListBox.Items.AddRange((enums));//Добавляет массив элементов в список

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

            var selectedEnum = (Type)EnumsListBox.SelectedItem;// SelectedIndices если требуется получить позиции индекса для
                                                               // всех выбранных элементов в множественном выборе ListBox.

            var enumValues = Enum.GetValues(selectedEnum);//Возвращает массив значений констант в указанном перечислении.
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);

            }
            
        }
        
        private void parsingBut_Click(object sender, EventArgs e)
        {
            string weekday = textBox1.Text;
           
        }

        private void goButtn_Click(object sender, EventArgs e)
        {
            string season = textBox2.Text;
            switch (season)
            {
                case "Spring":
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case "Autumn":
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}