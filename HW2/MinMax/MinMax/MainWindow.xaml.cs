using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace MinMax
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ListBoxItem)type.SelectedItem;

            switch (selectedItem.Content.ToString())
            {
                case "sbyte":
                    ShowStringValue();
                    break;
                case "byte":
                    ShowCharValue();
                    break;
                case "short":
                    ShowBoolValue();
                    break;
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
            }
        }

        private void ShowIntValue()
        {
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            valueMin.Text = intMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = intMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowLongValue()
        {
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            valueMin.Text = longMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = longMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowFloatValue()
        {
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            valueMin.Text = floatMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = floatMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDoubleValue()
        {
            var doubleMin = double.MinValue;
            var doubleMax = double.MaxValue;
            valueMin.Text = doubleMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = doubleMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDecimalValue()
        {
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            valueMin.Text = decimalMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = decimalMax.ToString(CultureInfo.InvariantCulture);
        }
        
        private void ShowStringValue()
        {
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            valueMin.Text = sbyteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = sbyteMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowCharValue()
        {
            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;
            valueMin.Text = byteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = byteMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowBoolValue()
        {
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            valueMin.Text = shortMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = shortMax.ToString(CultureInfo.InvariantCulture);
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
