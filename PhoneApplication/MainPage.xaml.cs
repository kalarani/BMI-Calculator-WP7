using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            bmi_grid.Opacity = 0;
        }

        private void calculate_button_Click(object sender, RoutedEventArgs e)
        {
            Double bmi_index = Double.Parse(weight.Text) / (Math.Pow(Double.Parse(height.Text)/100, 2));
            bmi_block.Text = bmi_index.ToString();
            bmi_grid.Opacity = 1;
        }
    }
}