using System;
using System.Windows.Input;
using CGIAssignment.Model;
using Xamarin.Forms;

namespace CGIAssignment.ViewModel
{
    public class MealDetailViewModel:ViewModel
    {
        public Meal MealDetail { get; set; }
        public INavigation Navigation { get; set; }

        public MealDetailViewModel(Meal meal,INavigation navigation)
        {
            MealDetail = meal;
            Navigation = navigation;
        }

        public ICommand BackTapped => new Command((e) =>
        {
            Navigation.PopAsync();
        });
    }
}
