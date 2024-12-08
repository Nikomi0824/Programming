﻿using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers { get; set; }
        /// <summary>
        /// Возвращает и задает выбранный объект класса <see cref="Order"/>.
        /// </summary>
        private Order CurrentOrder { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный объект класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder CurrentPriorityOrder { get; set; }

        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Order"/>.
        /// </summary>
        private BindingList<Order> Orders { get; set; } = new BindingList<Order>();

        /// <summary>
        /// Создает объект типа <see cref="OrdersTab"/> и инициализирует столбцы таблицы.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            OrdersDataGridView.ColumnCount = 7;
            OrdersDataGridView.Columns[0].Name = "Id";
            OrdersDataGridView.Columns[1].Name = "Created";
            OrdersDataGridView.Columns[2].Name = "Order Status";
            OrdersDataGridView.Columns[3].Name = "Customer Full Name";
            OrdersDataGridView.Columns[4].Name = "Delivery Address";
            OrdersDataGridView.Columns[5].Name = "Amount";
            OrdersDataGridView.Columns[6].Name = "Total";
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        /// <summary>
        /// При переходе на эту вкладку заполняет таблицу актуальными знавениями.
        /// </summary>
        public void RefreshData()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();
            UpdateOrders();
        }

        /// <summary>
        /// Инициализирует список заказов Orders и заполняет таблицу OrdersDataGridView.
        /// </summary>
        private void UpdateOrders()
        {
            for (int i = 0; i < Customers.Count; i++)
            {
                for (int j = 0; j < Customers[i].Order.Count; j++)
                {
                    Orders.Add(Customers[i].Order[j]);
                    string[] row = {
                        Customers[i].Order[j].Id.ToString(),
                        Customers[i].Order[j].Date,
                        Customers[i].Order[j].OrderStatus.ToString(),
                        Customers[i].FullName,
                        AddressToString(Customers[i].Order[j].Address),
                        Customers[i].Order[j].Amount.ToString(),
                        Customers[i].Order[j].Total.ToString()};
                    OrdersDataGridView.Rows.Add(row);
                }
            }
        }

        /// <summary>
        /// Конвертирует экземпляр класса <see cref="Address"/> в строку.
        /// </summary>
        /// <param name="address">Конвертируемый адрес.</param>
        /// <returns></returns>
        private string AddressToString(Address address)
        {
            return $"{address.Index} {address.Country} {address.City} {address.Street} {address.Building} {address.Apartment}";
        }

        /// <summary>
        /// Инициализирует все элементы управления данными выбранного заказа.
        /// </summary>
        /// <param name="order">Выбранный заказ.</param>
        private void UpdateOrderInfo(Order order)
        {
            if (order != null)
            {
                IdTextBox.Text = order.Id.ToString();
                DataTextBox.Text = order.Date;
                StatusComboBox.SelectedItem = order.OrderStatus.ToString(); 
                AddressControl.Address = order.Address;
                OrderItemsListBox.DataSource = order.Items; 
                OrderItemsListBox.DisplayMember = nameof(Item.DisplayInfo); 
                RefreshAmount(); 
            }
        }

        private void ClearSelection()
        {
            StatusComboBox.Items.Clear();
            ClearOrderInfo();
            AddressControl.ClearAllTextBoxes(true);
            CurrentOrder = null;
            TotalTotalLabel.Text = "0";
        }

        /// <summary>
        /// Очищает элементы управления.
        /// </summary>
        private void ClearOrderInfo()
        {
            IdTextBox.Clear();
            DataTextBox.Clear();
            OrderItemsListBox.DataSource = null; // Очищаем список товаров
        }

        /// <summary>
        /// Высчитывает актуальную стоимость товаров в корзине.
        /// </summary>
        private void RefreshAmount()
        {
            TotalTotalLabel.Text = CurrentOrder.Amount.ToString();
            TotalTotalLabel.Text = CurrentOrder.Total.ToString();
        }

        /// <summary>
        /// При выборе заказа инициализирует все элементы управления.
        /// Работает с приоритетными и не приоритетными заказами по разному.
        /// </summary>
        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                int selectedIndex = e.RowIndex;

                if (selectedIndex >= 0 && selectedIndex < Orders.Count)
                {
                    CurrentOrder = Orders[selectedIndex];

                    if (CurrentOrder != null)
                    {
                        if (StatusComboBox.Items.Count == 0)
                        {
                            StatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
                        }

                        UpdateOrderInfo(CurrentOrder);
                    }
                }
            }
            else
            {
                ClearSelection();
            }
        }

        /// <summary>
        /// При изменении значения StatusComboBox обновляет статус заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentOrder.OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.Text);
        }
    }
}
