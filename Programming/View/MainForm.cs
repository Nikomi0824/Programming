namespace Programming
{
    using System.Linq;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] //��� ����������� 
            { 
                typeof(Colors), 
                typeof(Formof�education), 
                typeof(Genre),
                typeof(Season),
                typeof(SmartphoneManufacturers),
                typeof(Weekday)
            };
            EnumsListBox.Items.AddRange((enums));//��������� ������ ��������� � ������

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

            var selectedEnum = (Type)EnumsListBox.SelectedItem;// SelectedIndices ���� ��������� �������� ������� ������� ���
                                                               // ���� ��������� ��������� � ������������� ������ ListBox.

            var enumValues = Enum.GetValues(selectedEnum);//���������� ������ �������� �������� � ��������� ������������.
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
                    MessageBox.Show("���! ������!");
                    break;
                case "Winter":
                    MessageBox.Show("����! �������!");
                    break;
            }
        }
    }
}