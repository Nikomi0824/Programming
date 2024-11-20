using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике, его размерах и координатах его центра.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Идентификатор количества всех объектов данного класса.
        /// </summary>
        private static int _allRectanglesCount = 1; 

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть положительна.
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительна.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount => _allRectanglesCount - 1; // Вычитаем 1, чтобы получить правильное количество

        /// <summary>
        /// Возвращает идентификатор прямоугольника.
        /// </summary>
        public int Id => _id;

        
        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна быть положительна.</param>
        /// <param name="width">Ширина. Должна быть положительна.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра.</param>
        public Rectangle(double height, double width, string color, Point2D center)
        {
            _id = _allRectanglesCount++;
            Height = height;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}