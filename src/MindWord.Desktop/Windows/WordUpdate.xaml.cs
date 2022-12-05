﻿using Integrated.Interfaces;
using Integrated.Services;
using MindWord.DataAccess.Interfaces.Repositories;
using MindWord.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace MindWord.Desktop.Windows
{
    /// <summary>
    /// Interaction logic for WordUpdate.xaml
    /// </summary>
    public partial class WordUpdate : Window
    {
        public WordUpdate()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void txWord_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }


        private async void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txWord_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
