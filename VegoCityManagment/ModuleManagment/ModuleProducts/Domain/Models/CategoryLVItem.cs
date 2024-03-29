﻿using MVVMBaseByNH.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegoCityManagment.Shared.Domain;

namespace VegoCityManagment.ModuleManagment.ModuleProducts.Domain.Models
{
    public class CategoryLVItem : NotifiedProperties
    {
        private bool _isChecked;
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsChecked { get => _isChecked; set { _isChecked = value; PropertyWasChanged(); } }
        public Command OnClick { get; set; }
        public Command OnEditClick { get; set; }
        public Command OnDeleteClick { get; set; }
    }
}
