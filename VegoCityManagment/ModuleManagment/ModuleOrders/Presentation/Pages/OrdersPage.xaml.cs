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
using VegoCityManagment.ModuleManagment.Domain;
using VegoCityManagment.ModuleManagment.ModuleOrders.Domain;

namespace VegoCityManagment.ModuleManagment.ModuleOrders.Presentation.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        private readonly OrdersPageViewModel _viewModel;
        public OrdersPage()
        {
            InitializeComponent();

            _viewModel = (OrdersPageViewModel)DataContext;
        }

        public OrdersPage(DrawerController drawerController) : this()
        {
            _viewModel.Setup(drawerController);
        }

        private void OrdersFrame_Navigated(object sender, NavigationEventArgs e)
        {
            while(OrdersFrame.CanGoBack)
                OrdersFrame.RemoveBackEntry();
        }
    }
}
