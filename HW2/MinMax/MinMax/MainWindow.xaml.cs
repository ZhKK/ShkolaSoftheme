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
            int intMin = -2147483648;
            int intMax = 2147483647;
            valueMin.Text = intMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = intMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowLongValue()
        {
            long longMin = -9223372036854775808L;
            long longMax = 9223372036854775807L;
            valueMin.Text = longMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = longMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowFloatValue()
        {
            float floatMin = -1.4e-45F;
            float floatMax = 3.4e+38F;
            valueMin.Text = floatMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = floatMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDoubleValue()
        {
            var doubleMin = -4.9e-324;
            var doubleMax = 1.7e+308;
            valueMin.Text = doubleMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = doubleMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDecimalValue()
        {
            decimal decimalMin = -1.0e-28M;
            decimal decimalMax = 7.9e+28M;
            valueMin.Text = decimalMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = decimalMax.ToString(CultureInfo.InvariantCulture);
        }
        
        private void ShowStringValue()
        {
            sbyte sbyteMin = -128;
            sbyte sbyteMax = 127;
            valueMin.Text = sbyteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = sbyteMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowCharValue()
        {
            byte byteMin = 0;
            byte byteMax = 255;
            valueMin.Text = byteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = byteMax.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowBoolValue()
        {
            short shortMin = -32768;
            short shortMax = 32767;
            valueMin.Text = shortMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = shortMax.ToString(CultureInfo.InvariantCulture);
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
