namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Представляет геометрическое кольцо.
    /// </summary>
    public class Ring
    {
        private double _innerRadius;
        private double _outerRadius;

        /// <summary>
        /// Получает или задает центральную точку кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Получает или задает внутренний радиус кольца.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (_outerRadius != 0 && value > _outerRadius)
                {
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего радиуса.");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Получает или задает внешний радиус кольца.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (_innerRadius != 0 && value < _innerRadius)
                {
                    throw new ArgumentException("Внешний радиус не может быть меньше внутреннего радиуса.");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Получает площадь кольца.
        /// </summary>
        public double Area => Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));

        /// <summary>
        /// Инициализирует новый экземпляр класса Ring.
        /// </summary>
        /// <param name="center">Центральная точка кольца.</param>
        /// <param name="innerRadius">Внутренний радиус кольца.</param>
        /// <param name="outerRadius">Внешний радиус кольца.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }
    }
}