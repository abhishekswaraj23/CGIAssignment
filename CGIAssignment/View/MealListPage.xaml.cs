using System;
using System.Collections.Generic;
using CGIAssignment.ViewModel;
using Xamarin.Forms;

namespace CGIAssignment.View
{
    public partial class MealListPage : ContentPage
    {
        public MealListPage()
        {
            InitializeComponent();
            BindingContext = new MealListPageViewModel(Navigation);
        }
    }
}
