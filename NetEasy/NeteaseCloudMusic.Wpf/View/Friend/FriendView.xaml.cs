﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using NeteaseCloudMusic.Wpf.BindingConverter;
using NeteaseCloudMusic.Wpf.ViewModel;
using System.Collections;
using System.Globalization;
using Prism.Commands;

namespace NeteaseCloudMusic.Wpf.View
{
    /// <summary>
    /// FriendView.xaml 的交互逻辑
    /// </summary>
    public partial class FriendView 
    {
        public FriendView(FriendViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
            

        }
   
        
    }

   
    
}
