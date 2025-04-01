using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgrammingAppInformationSystem.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        private static readonly Regex _phoneRegex = new Regex(@"^[0-9+\-() \.]*$");

        public ContactControl()
        {
            InitializeComponent();
        }

        private void PhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !_phoneRegex.IsMatch(e.Text);
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            if (e.Key == Key.Space)
            {
                var textBox = e.Source as TextBox;
                if (textBox?.Name == "PhoneTextBox")
                {
                    e.Handled = true;
                }
            }
        }
    }
}
