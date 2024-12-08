﻿using ObjectOrientedPractics.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список элементов класса Customer.
        /// </summary>
        public BindingList<Customer> Customers { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="CustomersTab"/>.
        /// Выводит в CustomersListBox только имена покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListBox.DisplayMember = nameof(Customer.DisplayInfo);
        }

        /// <summary>
        /// При переходе на эту вкладку обновляет все элементы управления актуальными значениями.
        /// </summary>
        public void RefreshData()
        {
            DiscountsListBox.DisplayMember = null;
            DiscountsListBox.DisplayMember = nameof(IDiscount.Info);
        }

        /// <summary>
        /// Моментально отображает изменения в ListBox.
        /// </summary>
        private void UpdateDisplayMember()
        {
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Item.DisplayInfo);
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного покупателя.
        /// </summary>
        /// <param name="customer">Покупатель, текстовые поля которого необходимо обновить.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IDTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressControl.Address = customer.Address;
            IsPriorityCheckBox.Checked = customer.IsPriority;
            DiscountsListBox.DataSource = customer.Discount;
            DiscountsListBox.DisplayMember = nameof(IDiscount.Info);
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            DiscountsListBox.DataSource = null;
        }

        /// <summary>
        /// При изменении выбранного элемента CustomersListBox
        /// заполняет все текстовые поля значениями выбранного Customers
        /// и передает в AddressControl значение поля address выбранного объекта.
        /// Если покупатель не выбран, то очищает все текстовые поля.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                UpdateCustomerInfo(_currentCustomer);
            }
            else
            {
                ClearCustomerInfo();
                AddressControl.ClearAllTextBoxes(true);
            }
        }

        /// <summary>
        /// При нажатии на кнопку создает покупателя с рандомными значениями
        /// и добавляет его в CustomersListBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.DataSource == null)
            {
                CustomersListBox.DataSource = Customers;
            }
            Customers.Add(CustomerFactory.Randomize());
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// При нажатии на кнопку удаления покупателя удаляет выбранного покупателя из списка и из CustomersListBox.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Customers.RemoveAt(selectedIndex);
                CustomersListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Присваивает значение из FullNameTextBox в свойство FullName покупателя.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _currentCustomer.FullName = FullNameTextBox.Text;
                UpdateDisplayMember();
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Задает свойство IsPriority объекта класса <see cref="Customer"/>.
        /// </summary>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                if (IsPriorityCheckBox.Checked)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }
        }

        /// <summary>
        /// Добавляет новую скидку.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && _currentCustomer.Discount != null)
            {
                AddDiscountForm addDiscountForm = new AddDiscountForm();
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    _currentCustomer.Discount.Add(addDiscountForm.PercentDiscount);
                }
            }
        }

        /// <summary>
        /// Удаляет скидку.
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Discount.RemoveAt(DiscountsListBox.SelectedIndex);
        }

       
    }
}

