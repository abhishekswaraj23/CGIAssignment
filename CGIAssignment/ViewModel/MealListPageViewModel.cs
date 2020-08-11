using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CGIAssignment.Model;
using CGIAssignment.View;
using Xamarin.Forms;
using System.Linq;

namespace CGIAssignment.ViewModel
{
    public class MealListPageViewModel : ViewModel
    {
        public INavigation Navigation { get; set; }
        public ObservableCollection<MealGroup> MealList { get; set; } = new ObservableCollection<MealGroup>();
        public MealListPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SetupMealList();
        }

        public ICommand ItemTapped => new Command((e) =>
        {
            var data = (Model.Meal)(e);
            Navigation.PushAsync(new MealDetailView(data));
        });

        public ICommand DeleteItemTapped => new Command<Meal>((e) =>
        {
            var data = (Model.Meal)(e);
            foreach (MealGroup group in MealList)
            {
                foreach (Meal m in group)
                {
                    if (m.Name.Equals(data.Name))
                    {
                        group.Remove(m);
                        break;
                    }
                }
            }

        });

        private void SetupMealList()
        {
            string category = "Break Fast";
            MealList.Add(new MealGroup(category, new[] { new Meal
                {
                Category=category,
                Name="Memphis-style Beef & Pork Meatloaf",
                Description="Ground Beef and Pork Meatloaf Baked with Parsley, Mushrooms, Oregano, Hot Sauce and Worcestershire",
                Energy=100
                },
                 new Meal
                {
                Category=category,
                Name="Michigan Potless Pot Pies",
                Description="A Pot Pie without the Pot -- Ground Beef, Carrots, Potatoes and Seasonings Baked in a Light, Flaky Crust",
                Energy=12
                },
                  new Meal
                {
                      Category=category,
                Name="Mongolian Ground Beef With Jasmine Rice",
                Description="Asian Seasoned Ground Beef, Snow Peas, Spinach and Carrots, Stir-Fried with Garlic Sauce, Served with Jasmine Rice",
                Energy=210
                },
                   new Meal
                {
                       Category=category,
                Name="Nachos Supreme With Beef",
                Description="Tortilla Chips Topped with Refried Beans, Seasoned Beef, Cheese Sauce, Sour Cream and Jalapenos",
                Energy=34
                }}));

            category = "Lunch";
            MealList.Add(new MealGroup(category, new[] { new Meal
                {
                Category=category,
                Name="Old Fashioned Meatloaf",
                Description="Traditional meatloaf with ground beef and ground turkey, seasoned with fresh thyme. Served with rich onion gravy",
                Energy=200
                },
                 new Meal
                {
                     Category=category,
                Name="Old Fashioned Salisbury Steak Dinners",
                Description="Old-Fashioned Salisbury Steak Served with Green Beans, Mashed Potatoes and Homemade Brown Gravy.",
                Energy=340
                },
                  new Meal
                {
                      Category=category,
                Name="Old-fashioned Meat Loaf With Gravy",
                Description="Baked Ground Beef Loaf with Onion Served with Brown Gravy",
                Energy=34
                },
                   new Meal
                {
                       Category=category,
                Name="Orange Peel Ground Beef And Jasmine Rice",
                Description="Asian Seasoned Ground Beef Stir-Fried with Snow Peas, Orange Peel and General Tso's Sauce, Served with Jasmine Rice",
                Energy=56
                },
                   new Meal
                {
                       Category=category,
                Name="Philly Cheesesteak Potato Bowl",
                Description="Mashed Potatoes Topped with Creamy Cheese Sauce, Ground Beef, Roasted Peppers & Onions, and Shredded Cheddar Cheese",
                Energy=78
                }}));

                category = "Dinner";
                MealList.Add(new MealGroup(category, new[] { new Meal
                {
                Category=category,
                Name="Portobello Meatloaf, Garlic Mashed Pot",
                Description="Portobello enhanced meatloaf with caramelized onion gravy and garlic mashed potatoes",
                Energy=120
                },
                 new Meal
                {
                     Category=category,
                Name="Potato Station",
                Description="Old fashioned Beef Mushroom Blend meatloaf with fresh mushrooms & thyme served with gravy, mashed potatoes & a large fountain beverage.",
                Energy=23
                }}));
        }


    }
}
