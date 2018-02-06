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
                default:
                    ShowStringValue();
                    break;
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
            int intDefault = default(int);
            valueMin.Text = intMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = intMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = intDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowLongValue()
        {
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            long longDefault = default(long);
            valueMin.Text = longMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = longMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = longDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowFloatValue()
        {
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            float floatDefault = default(float);
            valueMin.Text = floatMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = floatMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = floatDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDoubleValue()
        {
            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            double doubleDefault = default(double);
            valueMin.Text = doubleMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = doubleMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = doubleDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDecimalValue()
        {
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            decimal decimalDefault = default(decimal);
            valueMin.Text = decimalMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = decimalMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = decimalDefault.ToString(CultureInfo.InvariantCulture);
        }
        
        private void ShowStringValue()
        {
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            sbyte sbyteDefault = default(sbyte);
            valueMin.Text = sbyteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = sbyteMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = sbyteDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowCharValue()
        {
            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;
            byte byteDefault = default(byte);
            valueMin.Text = byteMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = byteMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = byteDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowBoolValue()
        {
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            short shortDefault = default(short);
            valueMin.Text = shortMin.ToString(CultureInfo.InvariantCulture);
            valueMax.Text = shortMax.ToString(CultureInfo.InvariantCulture);
            valueDefault.Text = shortDefault.ToString(CultureInfo.InvariantCulture);
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
