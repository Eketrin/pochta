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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        Dictionary<string, int> sortirovka = new Dictionary<string, int>();
        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            
            string text = Input.Text;
            if (text != "")
            {
                List.Items.Add(text);
                
                if (sortirovka.ContainsKey(text)) //если есть
                {
                    sortirovka[text] = (sortirovka[text]) + 1;
                }
                else //если есть
                {
                    sortirovka.Add(text, 1);
                }
            }
        }
        public string FirstL(string text)
        {
            string firstLetters = "";
            foreach (var part in text.Split(' '))
            {
                firstLetters += part.Substring(0, 1).ToUpper();
            }
            return firstLetters;
        }
        private void DoResult_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var item in sortirovka.OrderByDescending(x => x.Value))
            {
                if (FirstL(item.Key) == Search.Text)
                {
                    Result.Text += item.Key + " " + item.Value + "\n";
                }
                else continue;
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }
    }
}
