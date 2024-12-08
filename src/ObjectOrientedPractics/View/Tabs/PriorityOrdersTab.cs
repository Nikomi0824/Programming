using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="PriorityOrdersTab"/>.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Элемент класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _order;

        /// <summary>
        /// Возвращает и задает элемент класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder Order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }

        /// <summary>
        /// Коллекция элементов типа <see cref="string"/>, используемая для выбора времени доставки.
        /// </summary>
        private BindingList<string> _deliveryTimes = new BindingList<string>()
        {
            "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00",
            "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00"
        };

        /// <summary>
        /// Создает объект типа <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            BindingList<Item> items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(ItemFactory.Randomize());
            }
            Customer customer = CustomerFactory.Randomize();
            Order = new PriorityOrder(customer.Address, items, DateTime.Now, _deliveryTimes[0]);
            FillOrderStatusComboBox();
            FillOrderDeliveryTimeComboBox();
            FillOrderData();
        }

        /// <summary>
        /// Заполняет StatusComboBox элементами перечисления <see cref="OrderStatus"/>.
        /// </summary>
        private void FillOrderStatusComboBox()
        {
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatuses)
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Заполняет DeliveryTimeComboBox данными из _deliverytimes.
        /// </summary>
        private void FillOrderDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.DataSource = _deliveryTimes;
        }

        /// <summary>
        /// Заполняет IdTextBox, DataTextBox, StatusComboBox, ItemsListBox,
        /// AmountLabel, DeliveryTimeComboBox значениями из Order.
        /// </summary>
        private void FillOrderData()
        {
            IdTextBox.Text = Order.Id.ToString();
            DataTextBox.Text = Order.Date.ToString();
            StatusComboBox.SelectedItem = Order.OrderStatus;
            AddressControl.Address = Order.Address;

            // Обновление списка товаров в заказе
            OrderItemsListBox.DataSource = null; // Сброс источника данных
            OrderItemsListBox.DataSource = Order.Items;
            OrderItemsListBox.DisplayMember = nameof(Item.Name);

            // Обновление суммы заказа
            UpdateTotalAmount();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var newItem = ItemFactory.Randomize();
            Order.Items.Add(newItem);

            // Обновление данных после добавления товара
            FillOrderData();

            // Выбор последнего добавленного товара
            OrderItemsListBox.SelectedIndex = Order.Items.Count - 1;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1) return;

            int index = OrderItemsListBox.SelectedIndex;
            Order.Items.RemoveAt(index);

            // Обновление UI после удаления товара
            FillOrderData();

            // Установка нового выбранного индекса
            if (Order.Items.Count > index)
                OrderItemsListBox.SelectedIndex = index;
            else if (Order.Items.Count > 0)
                OrderItemsListBox.SelectedIndex = Order.Items.Count - 1;
            else
                OrderItemsListBox.SelectedIndex = -1;
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            BindingList<Item> items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(ItemFactory.Randomize());
            }
            Customer customer = CustomerFactory.Randomize();
            Order = new PriorityOrder(customer.Address, items, DateTime.Now, _deliveryTimes[0]);
            FillOrderData();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.Date = (string)DeliveryTimeComboBox.SelectedItem;
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var item in Order.Items)
            {
                totalAmount += Convert.ToDecimal(item.Cost);
            }
            TotalTotalLabel.Text = totalAmount.ToString();
        }
    }
}
