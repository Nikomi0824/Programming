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
    public partial class SeasonControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="SeasonControl"/>.
        /// </summary>
        public SeasonControl()
        {
            InitializeComponent();
            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки для выбора сезона.
        /// </summary>
        private void GoButton_Click(object sender, EventArgs e)
        {
            string seasons = SeasonComboBox.Text;
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
    }
}
