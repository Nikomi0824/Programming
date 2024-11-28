using System;
using System.Drawing;
using System.Linq;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы случайного создания объектов класса <see cref="Rectangle"/>.
    /// </summary>
    public static class RectangleFactory
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Rectangle"/>.
        /// </summary>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize()
        {
            int height = _random.Next(10, 101);
            int width = _random.Next(10, 101);
            Color color = GetRandomColor();
            Point2D center = new Point2D(_random.Next(0, 101), _random.Next(0, 101));
            return new Rectangle(height, width, color.Name, center);
        }

        /// <summary>
        /// Создает случайно сгенерированный объект класса <see cref="Rectangle"/> в зависимости от размеров панели.
        /// </summary>
        /// <param name="canvasWidth">Ширина панели.</param>
        /// <param name="canvasHeight">Высота панели.</param>
        /// <returns>Объект класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            int minSize = 20;
            int maxWidth = Math.Min(100, canvasWidth / 2);
            int maxHeight = Math.Min(100, canvasHeight / 2);

            int width = _random.Next(minSize, maxWidth + 1);
            int height = _random.Next(minSize, maxHeight + 1);

            int x = _random.Next(width / 2, canvasWidth - width / 2 + 1);
            int y = _random.Next(height / 2, canvasHeight - height / 2 + 1);

            Color color = GetRandomColor();
            return new Rectangle(height, width, color.Name, new Point2D(x, y));
        }

        /// <summary>
        /// Возвращает случайный цвет из предопределенных цветов .NET.
        /// </summary>
        /// <returns>Случайный цвет.</returns>
        private static Color GetRandomColor()
        {
            var colors = typeof(Color).GetProperties()
                .Where(p => p.PropertyType == typeof(Color) && p.GetGetMethod().IsStatic)
                .Select(p => (Color)p.GetValue(null))
                .ToArray();

            return colors[_random.Next(colors.Length)];
        }
    }
}