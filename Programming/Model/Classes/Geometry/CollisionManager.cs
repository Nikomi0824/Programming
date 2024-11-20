﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Статический класс для проверки столкновений геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>True, если прямоугольники пересекаются, иначе false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double sumHalfWidths = (rectangle1.Width + rectangle2.Width) / 2;
            double sumHalfHeights = (rectangle1.Height + rectangle2.Height) / 2;

            return (deltaX < sumHalfWidths) && (deltaY < sumHalfHeights);
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>True, если кольца пересекаются, иначе false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double deltaX = ring1.Center.X - ring2.Center.X;
            double deltaY = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            double sumOuterRadii = ring1.OuterRadius + ring2.OuterRadius;

            // Проверка на пересечение внешних окружностей
            if (distance <= sumOuterRadii)
            {
                // Проверка, не находится ли одно кольцо полностью внутри другого
                double maxInnerRadius = Math.Max(ring1.InnerRadius, ring2.InnerRadius);
                double minOuterRadius = Math.Min(ring1.OuterRadius, ring2.OuterRadius);

                return distance + maxInnerRadius >= minOuterRadius;
            }

            return false;
        }
    }
}