using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Blocks
{
    /// <summary>
    /// Содержит логику выбора перечислений вкладки Enums.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="EnumerationControl"/>.
        /// Инициализирует массив перечислеий enums и заполняет EnumsListBox названиями этих перечислений.
        /// Выбирает первый элемент EnumsListBox.
        /// </summary>
        public EnumerationControl()
        {
            InitializeComponent();

            object[] enums = new object[]
            {
               typeof(Colors),
               typeof(FormOfEducation),
               typeof(Genre),
               typeof(Season),
               typeof(SmartphoneManufacturers),
               typeof(Weekday)
            };
            EnumsListBox.Items.AddRange((enums));
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// При изменении индекса выбранного элемента EnumsListBox
        /// запоняет ValuesListBox константами выбранного перечисления.
        /// Выбирает первый элемент ValuesListBox.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        /// <summary>
        /// При изменении индекса выбранного элемента ValuesListBox
        /// Преобразует элемент в числовой вид и записывает его в IntTextBox.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            int selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }
    }
}
