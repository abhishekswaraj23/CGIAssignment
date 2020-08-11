using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CGIAssignment.Model
{
    public class MealGroup: ObservableCollection<Meal>
    {
        public string Category { get; private set; }

        public MealGroup(string name)
            : base()
        {
            Category = name;
        }

        public MealGroup(string name, IEnumerable<Meal> source)
            : base(source)
        {
            Category = name;
        }
    }
}
