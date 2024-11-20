using Programming.Model.Classes.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.Blocks
{
    public partial class ReactanglesControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private Rectangle _currentRectangle;

        public ReactanglesControl()
        {
            Random random = new Random();

            InitializeComponent();

            CenterXTextBox.ReadOnly = true;
            CenterYTextBox.ReadOnly = true;
            IdTextBox.ReadOnly = true;

            for (int i = 0; i < 5; i++)
            {
                double x = random.Next(0, 101);
                double y = random.Next(0, 101);

                _rectangles.Add(new Rectangle(
                    height: random.Next(10, 101),
                    width: random.Next(10, 101),
                    color: ((Colors)random.Next(Enum.GetNames(typeof(Colors)).Length)).ToString(),
                    center: new Point2D(x, y)
                ));
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в списке прямоугольников.
        /// </summary>
        private void ReactanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReactanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[ReactanglesListBox.SelectedIndex];
                HeightTextBox.Text = _currentRectangle.Height.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorsTextBox.Text = _currentRectangle.Color;
                CenterXTextBox.Text = _currentRectangle.Center.X.ToString("F2");
                CenterYTextBox.Text = _currentRectangle.Center.Y.ToString("F2");
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        /// <summary>
        /// Находит индекс прямоугольника с максимальной шириной.
        /// </summary>
        /// <returns>Индекс прямоугольника с максимальной шириной или -1, если список пуст.</returns>
        private int FindRectangleWithMaxWidth()
        {
            if (_rectangles.Count == 0) return -1;

            int maxIndex = 0;
            double maxWidth = _rectangles[0].Width;

            for (int i = 1; i < _rectangles.Count; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Обрабатывает изменения текста в текстовом поле и выполняет валидацию.
        /// </summary>
        /// <param name="textBox">Текстовое поле для обработки.</param>
        /// <param name="setValue">Делегат для установки значения.</param>
        private void ValidateAndSetValue(TextBox textBox, Action<int> setValue)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                if (value < 10 || value > 100) throw new ArgumentOutOfRangeException();
                setValue(value);
                textBox.BackColor = Color.White;
            }
            catch
            {
                textBox.BackColor = Color.LightPink; 
            }
        }

        /// <summary>
        /// Обрабатывает изменения текста в текстовом поле ширины.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetValue(WidthTextBox, value => _currentRectangle.Width = value);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для поиска прямоугольника с максимальной шириной.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();

            if (index != -1)
            {
                ReactanglesListBox.SelectedIndex = index; 
                ReactanglesListBox_SelectedIndexChanged(null, null); 
            }
        }

        /// <summary>
        /// Обрабатывает изменения текста в текстовом поле высоты.
        /// </summary>
        private void HeightTextBox_TextChanged_1(object sender, EventArgs e)
        {
            ValidateAndSetValue(HeightTextBox, value => _currentRectangle.Height = value);
        }
    }
}