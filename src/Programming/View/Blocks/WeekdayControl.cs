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
    public partial class WeekdayControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="WeekdayControl"/>.
        /// </summary>
        public WeekdayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки для парсинга дня недели.
        /// </summary>
        private void ParsingBut_Click(object sender, EventArgs e)
        {
             Weekday text;
             if (Enum.TryParse(ParseTextBox.Text, out text))
             {
                 ParseLabel.Text = $"Это день недели {text}={(int)text}";
             }
             else
             {
                 ParseLabel.Text = "Нет такого дня недели";
             }   
        }
    }
}
