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

namespace TestWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //主页按钮
        private void Homepage(object sender, RoutedEventArgs e)
        {

        }

        //最大化或还原窗口
        private void FullOrRestore(object sender, RoutedEventArgs e)
        {

        }

        //关闭程序
        private void ShutDown(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        //拖放窗口
        private void DropMove(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //最小化窗口
        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
