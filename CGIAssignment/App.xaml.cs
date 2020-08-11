using System;
using CGIAssignment.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CGIAssignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MealListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
