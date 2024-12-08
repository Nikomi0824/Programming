using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие изменения списка товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает список элементов класс Item.
        /// </summary>
        public BindingList<Item> Items { get; set; } = new BindingList<Item>();

        /// <summary>
        /// Возвращает и задает список элементов класса Item при поиске подстроки.
        /// </summary>
        public BindingList<Item> DisplayedItems { get; set; } = new BindingList<Item>();

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// Выводит в ItemsListBox только название товара.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        /// <summary>
        /// При переходе на эту вкладку обновляет все элементы управления актуальными значениями.
        /// </summary>
        public void RefreshData()
        {
            FindTextBox.Clear();
            DisplayedItems = null;
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            OrderByComboBox.SelectedIndex = 0;
        }

        private void InitializeComboBoxes()
        {
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            OrderByComboBox.Items.Add("По имени");
            OrderByComboBox.Items.Add("По возрастанию цены");
            OrderByComboBox.Items.Add("По убыванию цены");
        }

        /// <summary>
        /// Обновляет данные ListBox в зависимости от фильтрации.
        /// </summary>
        public void UpdateDisplayedItems()
        {
            if (Items == null || Items.Count == 0)
            {
                return;
            }
            DisplayedItems = DataTools.ItemsFiltering(Items, FindTextBox.Text, (x1, x2) => { return x1.Name.Contains(x2); });
            var selectedIndex = DisplayedItems.IndexOf(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = DisplayedItems;
            ItemsListBox.SelectedIndex = selectedIndex >= 0 ? selectedIndex : -1;
            UpdateDisplayMember();
        }

        /// <summary>
        /// Сортирует список товаров.
        /// </summary>
        public void UpdateOrderItems()
        {
            if (Items == null || Items.Count == 0)
            {
                return;
            }
            if (OrderByComboBox.SelectedIndex == 0)
            {
                DataTools.SortItems(Items, DataTools.CompareName);
            }
            else if (OrderByComboBox.SelectedIndex == 1)
            {
                DataTools.SortItems(Items, DataTools.CompareAscendingCost);
            }
            else if (OrderByComboBox.SelectedIndex == 2)
            {
                DataTools.SortItems(Items, DataTools.CompareDescendingCost);
            }
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Моментально отображает изменения в ListBox.
        /// </summary>
        private void UpdateDisplayMember()
        {
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного товара.
        /// </summary>
        /// <param name="item">Товар, текстовые поля которого необходимо обновить.</param>
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            CategoryComboBox.Text = item.Category.ToString();
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
        private void ClearItemInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;
            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;
            DescriptionTextBox.Clear();
            DescriptionTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// При изменении выбранного элемента ItemsListBox
        /// заполняет все текстовые поля значениями выбранного Item.
        /// Заполняет CategoryComboBox значениями перечисления.
        /// Если товар не выбран, то очищает все текстовые поля.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                if (CategoryComboBox.Items.Count == 0)
                {
                    CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
                }
                if (DisplayedItems == null)
                {
                    _currentItem = Items[ItemsListBox.SelectedIndex];
                }
                else
                {
                    _currentItem = Items[Items.IndexOf(DisplayedItems[ItemsListBox.SelectedIndex])];
                }
                UpdateItemInfo(_currentItem);
            }
            else
            {
                CategoryComboBox.Items.Clear();
                ClearItemInfo();
            }
        }

        /// <summary>
        /// При нажатии на кнопку создает товар с рандомными значениями
        /// и добавляет его в ItemsListBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.DataSource == null)
            {
                ItemsListBox.DataSource = Items;
            }
            var newItem = ItemFactory.Randomize();
            Items.Add(newItem);
            var args = new EventArgs();
            ItemsChanged?.Invoke(this, args);
            UpdateOrderItems();
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Присваивает значение из CostTextBox в свойство Cost товара.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                CostTextBox.BackColor = Color.White;
                if (_currentItem.Cost != Double.Parse(CostTextBox.Text))
                {
                    _currentItem.Cost = Double.Parse(CostTextBox.Text);
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из NameTextBox в свойство Name товара.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                if (_currentItem.Name != NameTextBox.Text)
                {
                    _currentItem.Name = NameTextBox.Text;
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
                UpdateDisplayMember();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        

        /// <summary>
        /// Присваивает значение из CategoryComboBox в свойство Category товара.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            if (_currentItem.Category != (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text))
            {
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                var args = new EventArgs();
                ItemsChanged?.Invoke(this, args);
            }
        }

        /// <summary>
        /// Фильтрует список товаров по строке.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
            if (DisplayedItems.Count == 0)
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Сортирует список товаров.
        /// </summary>
        private void OrderByComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Items == null)
            {
                return;
            }
            UpdateOrderItems();
        }

        /// <summary>
        /// При нажатии на кнопку удаления товара удаляет выбранный товар из списка и из ItemsListBox.
        /// </summary>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || DisplayedItems.Count == 0)
            {
                return;
            }
            var selectedIndex = Items.IndexOf(DisplayedItems[ItemsListBox.SelectedIndex]);
            if (selectedIndex != -1)
            {
                Items.RemoveAt(selectedIndex);
                var args = new EventArgs();
                ItemsChanged?.Invoke(this, args);
                UpdateOrderItems();
                ItemsListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Присваивает значение из DescriptionTextBox в свойство Info товара.
        /// Ели значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void DescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                if (_currentItem.Info != DescriptionTextBox.Text)
                {
                    _currentItem.Info = DescriptionTextBox.Text;
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
            }
            catch
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
