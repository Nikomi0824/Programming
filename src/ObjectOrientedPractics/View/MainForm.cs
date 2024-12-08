using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ���������� � ������� � �����������.
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;

        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            CustomersTab.RefreshData();
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                ItemsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 1)
            {
                CustomersTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
        }

        /// <summary>
        /// ��� ��������� ������ ������� ���������� ������ ����������� ������ �������.
        /// </summary>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            CustomersTab.RefreshData();
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }
    }
}
