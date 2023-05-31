namespace Programming
{
    using Programming.Model;
    using System.Linq;
    public partial class MainForm : Form
    {
        private Reactangles[] _rectangle =new Reactangles[5] ;
        private Reactangles _currentRectangle;
        
        
        public MainForm()
        {
            Random _random = new Random(0-1000);
            Random rand = new Random();
           
            for (int i = 0; i > _rectangle.Length; i++)
            {
                 var v = Enum.GetValues(typeof(Colors));
                _rectangle[i].Width = _random.Next();
                _rectangle[i].Heigth = _random.Next();
                _rectangle[i].Colors = (string)v.GetValue(rand.Next(v.Length));
            }
           InitializeComponent();

           object[] enums = new object[] //Все перечилений 
           {
               typeof(Colors),
               typeof(FormOfEducation), 
               typeof(Genre), 
               typeof(Season), 
               typeof(SmartphoneManufacturers), 
               typeof(Weekday)
           };
           EnumsListBox.Items.AddRange((enums));//Добавляет массив элементов в список
           SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));

        }
        

        private void Enumeration_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (EnumsListBox.SelectedItem == null)
           {
               return;
           }

           var selectedEnum = (Type)EnumsListBox.SelectedItem;

           var enumValues = Enum.GetValues(selectedEnum);
           ValuesListBox.Items.Clear();
           foreach (var enumValue in enumValues)
           {
               ValuesListBox.Items.Add(enumValue);
           }
        }
        
        private void ParsingBut_Click(object sender, EventArgs e)
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

        private void GoButtn_Click(object sender, EventArgs e)
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

        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReactanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle =_rectangle[ReactanglesListBox.SelectedIndex];
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            

        }

        private void ColorsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}