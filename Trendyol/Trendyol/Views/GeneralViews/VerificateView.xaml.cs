﻿using System;
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

namespace Trendyol.Views.GeneralViews
{
    public partial class VerificateView : UserControl
    {
        public VerificateView()
        {
            InitializeComponent();
        }

        private void NumberCheck(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }

            if (textBox.Text.Length >= 4)
            {
                e.Handled = true;
                return;
            }
        }
    }
}