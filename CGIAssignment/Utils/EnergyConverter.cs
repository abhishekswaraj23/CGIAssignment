using System;
using System.Globalization;
using Xamarin.Forms;

namespace CGIAssignment.Utils
{
    public class EnergyConverter : IValueConverter
    {
        public EnergyConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = (int)value;
            string res = "G";
            if(val<=50)
            {
                res = "G";
            }
            else if(val>50 && val<=100)
            {
                res = "B";
            }
            else
            {
                res = "R";
            }
             
            return res;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        
    }
}
