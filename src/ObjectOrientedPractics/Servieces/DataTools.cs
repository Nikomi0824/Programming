﻿
using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс, предоставляющий доступ к методам фильтрации.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Сравнение двух товаров для сортировки по возрастанию цены.
        /// </summary>
        /// <param name="x1">Первый товар.</param>
        /// <param name="x2">Второй товар.</param>
        /// <returns>True если цена первого меньше второго.</returns>
        public static bool CompareAscendingCost(Item x1, Item x2)
        {
            return x1.Cost < x2.Cost;
        }

        /// <summary>
        /// Сравнение двух товаров для сортировки по убыванию цены.
        /// </summary>
        /// <param name="x1">Первый товар.</param>
        /// <param name="x2">Второй товар.</param>
        /// <returns>True если цена второго меньше первого.</returns>
        public static bool CompareDescendingCost(Item x1, Item x2)
        {
            return x1.Cost > x2.Cost;
        }

        /// <summary>
        /// Сравнение двух товаров для сортировки по названию.
        /// </summary>
        /// <param name="x1">Первый товар.</param>
        /// <param name="x2">Второй товар.</param>
        /// <returns>True если название первого меньше второго.</returns>
        public static bool CompareName(Item x1, Item x2)
        {
            if (x1.Name.CompareTo(x2.Name) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Сравнивает значения и создает новый список, с удовлетворяющими элементами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="value">Значение, с которым сравнивается значение товара.</param>
        /// <param name="compare">Метод сравнения.</param>
        /// <returns>Новый список с удовлетворяющими элементами.</returns>
        public static BindingList<Item> ItemsFiltering(BindingList<Item> items, string value, Func<Item, string, bool> compare)
        {
            var newItems = new BindingList<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (compare(items[i], value))
                {
                    newItems.Add(items[i]);
                }
            }
            return newItems;
        }

        /// <summary>
        /// Создает новый список и заполняет его отфильтованными элементами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="compare">Метод сортировки.</param>
        /// <returns>Новый список с отфильтованными элементами.</returns>
        public static void SortItems(BindingList<Item> items, Func<Item, Item, bool> compare)
        {
            var length = items.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (compare(items[j], items[j - 1]))
                    {
                        var tempVar = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = tempVar;
                    }
                }

            }
        }
    }
}
