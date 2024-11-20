using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes.Geometry;
using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.Blocks
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="ReactanglesCollisionControl"/>.
    /// </summary>
    public partial class ReactanglesCollisionControl : UserControl
    {
        /// <summary>   
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();
        /// <summary>
        /// Список панелей для отображения прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();
        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        public ReactanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectanglesControl();
        }

        /// <summary>
        /// Инициализирует элементы управления для прямоугольников.
        /// </summary>
        private void InitializeRectanglesControl()
        {
            IdTextBox2.ReadOnly = true;
            
        }

        /// <summary>
        /// Обновляет информацию о прямоугольнике в текстовых полях.
        /// </summary>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IdTextBox2.Text = rectangle.Id.ToString();
            XTextBox2.Text = rectangle.Center.X.ToString();
            YTextBox2.Text = rectangle.Center.Y.ToString();
            WidthTextBox2.Text = rectangle.Width.ToString();
            HeightTextBox2.Text = rectangle.Height.ToString();
        }

        /// <summary>
        /// Очищает информацию о прямоугольнике в текстовых полях.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdTextBox2.Text = string.Empty;
            XTextBox2.Text = string.Empty;
            YTextBox2.Text = string.Empty;
            WidthTextBox2.Text = string.Empty;
            HeightTextBox2.Text = string.Empty;
        }

        /// <summary>
        /// Находит и обновляет цвет панелей в зависимости от наличия коллизий.
        /// </summary>
        private void FindCollisions()
        {
            Color noCollisionColor = Color.FromArgb(127, 127, 255, 127);
            Color collisionColor = Color.FromArgb(127, 255, 127, 127);

            for (int i = 0; i < _rectangles.Count; i++)
            {
                bool hasCollision = false;
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i != j && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        hasCollision = true;
                        break;
                    }
                }
                _rectanglePanels[i].BackColor = hasCollision ? collisionColor : noCollisionColor;
            }
        }

        /// <summary>
        /// Создает панель для отображения прямоугольника.
        /// </summary>
        private Panel CreateRectanglePanel(Rectangle rectangle)
        {
            Panel panel = new Panel
            {
                Location = new Point((int)rectangle.Center.X - (int)rectangle.Width / 2,
                                     (int)rectangle.Center.Y - (int)rectangle.Height / 2),
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Height,
                BackColor = Color.FromArgb(127, 127, 255, 127)
            };
            return panel;
        }

        /// <summary>
        /// Изменяет размеры и локацию панели на соответствующие им значения переданного в метод элемента.
        /// </summary>
        /// <param name="rectangle">Элемент, панель которого обновляется.</param>
        private void UpdateRectanglePanel(int index)
        {
            Rectangle rectangle = _rectangles[index];
            Panel panel = _rectanglePanels[index];
            panel.Location = new Point((int)rectangle.Center.X - panel.Width / 2,
                                       (int)rectangle.Center.Y - panel.Height / 2);
            panel.Width = (int)rectangle.Width;
            panel.Height = (int)rectangle.Height;
        }

        /// <summary>
        /// Получает строку с информацией о прямоугольнике.
        /// </summary>
        private string GetRectangleInfo(Rectangle rectangle)
        {
            return $"Id: {rectangle.Id}; X: {rectangle.Center.X:F2}; Y: {rectangle.Center.Y:F2}; W: {rectangle.Width}; H: {rectangle.Height}";
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки для удаления прямоугольника.
        /// </summary>
        private void RemoveRectanglePictureBox_Click(object sender, EventArgs e)
        {
            if (ReactanglesListBoxListBox2.SelectedIndex != -1)
            {
                int index = ReactanglesListBoxListBox2.SelectedIndex;
                _rectangles.RemoveAt(index);
                ReactanglesListBoxListBox2.Items.RemoveAt(index);

                CanvasPanel.Controls.Remove(_rectanglePanels[index]);
                _rectanglePanels.RemoveAt(index);

                if (ReactanglesListBoxListBox2.Items.Count > 0)
                {
                    ReactanglesListBoxListBox2.SelectedIndex = 0;
                }
                else
                {
                    ClearRectangleInfo();
                }

                FindCollisions();
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки для добавления нового прямоугольника.
        /// </summary>
        private void AddRectanglePictureBox_Click_1(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(newRectangle);
            ReactanglesListBoxListBox2.Items.Add(GetRectangleInfo(newRectangle));

            Panel panel = CreateRectanglePanel(newRectangle);
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);

            FindCollisions();
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле X и обновляет соответствующий прямоугольник.
        /// </summary>
        private void XTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(XTextBox2.Text, out double x))
            {
                if (x < 0)
                {
                    MessageBox.Show("X не может быть отрицательным.");
                    return;
                }
                _currentRectangle.Center.X = x;
                UpdateRectanglePanel(ReactanglesListBoxListBox2.SelectedIndex);
                ReactanglesListBoxListBox2.Items[ReactanglesListBoxListBox2.SelectedIndex] = GetRectangleInfo(_currentRectangle);
                FindCollisions();
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле Y и обновляет соответствующий прямоугольник.
        /// </summary>
        private void YTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(YTextBox2.Text, out double y))
            {
                if (y < 0)
                {
                    MessageBox.Show("Y не может быть отрицательным.");
                    return;
                }
                _currentRectangle.Center.Y = y;
                UpdateRectanglePanel(ReactanglesListBoxListBox2.SelectedIndex);
                ReactanglesListBoxListBox2.Items[ReactanglesListBoxListBox2.SelectedIndex] = GetRectangleInfo(_currentRectangle);
                FindCollisions();
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле ширины и обновляет соответствующий прямоугольник.
        /// </summary>
        private void WidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(WidthTextBox2.Text, out double width))
            {
                if (width < 0)
                {
                    MessageBox.Show("Ширина не может быть отрицательной.");
                    return;
                }
                _currentRectangle.Width = width;
                UpdateRectanglePanel(ReactanglesListBoxListBox2.SelectedIndex);
                ReactanglesListBoxListBox2.Items[ReactanglesListBoxListBox2.SelectedIndex] = GetRectangleInfo(_currentRectangle);
                FindCollisions();
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле высоты и обновляет соответствующий прямоугольник.
        /// </summary>
        private void HeightTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(HeightTextBox2.Text, out double height))
            {
                if (height < 0)
                {
                    MessageBox.Show("Высота не может быть отрицательной.");
                    return;
                }
                _currentRectangle.Height = height;
                UpdateRectanglePanel(ReactanglesListBoxListBox2.SelectedIndex);
                ReactanglesListBoxListBox2.Items[ReactanglesListBoxListBox2.SelectedIndex] = GetRectangleInfo(_currentRectangle);
                FindCollisions();
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в списке прямоугольников.
        /// </summary>
        private void ReactanglesListBoxListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ReactanglesListBoxListBox2.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[ReactanglesListBoxListBox2.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

       
    }
}