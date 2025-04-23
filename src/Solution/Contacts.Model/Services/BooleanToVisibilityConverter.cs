using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace Contacts.Model.Services
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует булево значение в значение Visibility.
        /// </summary>
        /// <param name="value">Булево значение для преобразования</param>
        /// <param name="targetType">Тип, в который выполняется преобразование (не используется)</param>
        /// <param name="parameter">Дополнительный параметр (не используется)</param>
        /// <param name="culture">Информация о культуре (не используется)</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        /// <summary>
        /// Преобразует значение Visibility обратно в булево значение.
        /// </summary>
        /// <param name="value">Значение Visibility для обратного преобразования</param>
        /// <param name="targetType">Тип, в который выполняется преобразование (не используется)</param>
        /// <param name="parameter">Дополнительный параметр (не используется)</param>
        /// <param name="culture">Информация о культуре (не используется)</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibility)
            {
                return visibility == Visibility.Visible;
            }
            return false;
        }
    }
}
