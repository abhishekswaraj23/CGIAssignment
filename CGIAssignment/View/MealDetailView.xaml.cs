using System;
using System.Collections.Generic;
using CGIAssignment.Model;
using CGIAssignment.ViewModel;
using Xamarin.Forms;

namespace CGIAssignment.View
{
    public partial class MealDetailView : ContentPage
    {
        public MealDetailView(Meal meal)
        {
            InitializeComponent();
            BindingContext = new MealDetailViewModel(meal,Navigation);
        }
    }
}
