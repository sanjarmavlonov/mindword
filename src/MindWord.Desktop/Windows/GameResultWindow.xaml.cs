﻿using MindWord.Domain.Entities;
using MindWord.Service.ViewModel;
using System;
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
using System.Windows.Shapes;

namespace MindWord.Desktop.Windows
{
    /// <summary>
    /// Interaction logic for GameResultWindow.xaml
    /// </summary>
    public partial class GameResultWindow : Window
    {
        static List<WordAnswerViewModel> answers;
        public void SaveAnswers(List<WordAnswerViewModel> Answers)
        {
            answers = Answers;
        }
        public GameResultWindow()
        {
            InitializeComponent();
        }

        private void SearchBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInfo_click(object sender, RoutedEventArgs e)
        {
            try
            {
                var res = (WordAnswerViewModel)dgData.SelectedItem;
                int id = res.Id;
                var result = answers.First(x => x.Id == id);
                var desc = result.Info;
                HelperShowWindow helperShowWindow = new HelperShowWindow();
                helperShowWindow.tbHelperShow.Text = desc;
                helperShowWindow.Height = 270;
                helperShowWindow.Width = 400;
                helperShowWindow.ShowDialog();
            }
            catch
            {
                HelperShowWindow helperShowWindow = new HelperShowWindow();
                helperShowWindow.tbHelperShow.Text = "Sorry, Description is not found!";
                helperShowWindow.ShowDialog();
            }
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
