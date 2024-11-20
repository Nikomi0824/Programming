using Programming.Model.Classes;
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
    /// UserControl для отображения и управления фильмами.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        private Random _random = new Random();

        public MoviesControl()
        {
            for (int i = 0; i < _movies.Length; i++)
            {


                _movies[i] = new Movie
                {
                    Duration = _random.Next(60, 180),
                    Year = _random.Next(1900, DateTime.Now.Year + 1),
                    Rating = _random.NextDouble() * 10,
                };
            }
            InitializeComponent();
        }
        /// <summary>
        /// Находит индекс фильма с максимальным рейтингом.
        /// </summary>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        private int FindMovieWithMaxRating()
        {
            int maxIndex = -1;
            double maxRating = double.MinValue;

            for (int i = 0; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > maxRating)
                {
                    maxRating = _movies[i].Rating;
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
        private void HandleTextBoxChange(TextBox textBox, Action<double> setValue)
        {
            try
            {
                double value = double.Parse(textBox.Text);
                setValue(value);
                textBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.LightPink;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                textBox.BackColor = Color.LightPink;
            }
            catch (Exception)
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки для поиска фильма с максимальным рейтингом.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindMovieWithMaxRating();

            if (index != -1)
            {
                FilmsListBox.SelectedIndex = index;
                FilmsListBox_SelectedIndexChanged(null, null);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле RatingTextBox.
        /// </summary>
        private void RatingTextBox_TextChanged_1(object sender, EventArgs e)
        {
            HandleTextBoxChange(RatingTextBox, value =>
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(_currentMovie.Rating));
                _currentMovie.Rating = value;
            });
        }

        /// <summary>
        /// Обработчик изменения текста в поле YearTextBox.
        /// </summary>
        private void YearTextBox_TextChanged_1(object sender, EventArgs e)
        {
            HandleTextBoxChange(YearTextBox, value =>
            {
                Validator.AssertValueInRange((int)value, 1900, DateTime.Now.Year + 1, nameof(_currentMovie.Year));
                _currentMovie.Year = (int)value;
            });
        }

        /// <summary>
        /// Обработчик изменения текста в поле DurationTextBox.
        /// </summary>
        private void DurationTextBox_TextChanged_1(object sender, EventArgs e)
        {
            HandleTextBoxChange(DurationTextBox, value =>
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration must be non-negative.");
                }
                Validator.AssertOnPositiveValue(value, nameof(_currentMovie.Duration));
                _currentMovie.Duration = (int)value;
            });
        }

        /// <summary>
        /// Обработчик события изменения выбранного фильма в списке.
        /// </summary>
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedIndex != -1)
            {
                _currentMovie = _movies[FilmsListBox.SelectedIndex];
                DurationTextBox.Text = _currentMovie.Duration.ToString();
                YearTextBox.Text = _currentMovie.Year.ToString();
                RatingTextBox.Text = _currentMovie.Rating.ToString("F1");
            }
        }
    }
}
