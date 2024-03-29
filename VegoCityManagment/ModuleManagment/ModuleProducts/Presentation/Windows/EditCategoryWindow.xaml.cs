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
using System.Windows.Shapes;
using VegoCityManagment.ModuleManagment.ModuleProducts.Domain;

namespace VegoCityManagment.ModuleManagment.ModuleProducts.Presentation.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditCategoryWindow.xaml
    /// </summary>
    public partial class EditCategoryWindow : Window
    {
        private readonly EditCategoryWindowViewModel _viewModel;
        public EditCategoryWindow()
        {
            InitializeComponent();

            _viewModel = (EditCategoryWindowViewModel)DataContext;

            _viewModel.CloseWindow = this.Close;
        }

        public EditCategoryWindow(int categoryId) : this()
        {
            _viewModel.SetCategory(categoryId);
        }
    }
}
