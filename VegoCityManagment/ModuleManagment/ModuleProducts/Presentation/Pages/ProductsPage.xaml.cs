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
using VegoCityManagment.ModuleManagment.ModuleProducts.Domain;

namespace VegoCityManagment.ModuleManagment.ModuleProducts.Presentation.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private readonly ProductsPageViewModel _viewModel;
        public ProductsPage()
        {
            InitializeComponent();

            _viewModel = (ProductsPageViewModel)DataContext;
        }

        public ProductsPage(DrawerController drawerController) : this()
        {
            _viewModel.Setup(drawerController);
        }

        private void ProductsPageContainer_Navigated(object sender, NavigationEventArgs e)
        {
            while(ProductsPageContainer.CanGoBack)
                ProductsPageContainer.RemoveBackEntry();
        }
    }
}
