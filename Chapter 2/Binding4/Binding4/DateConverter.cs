using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Binding4
{
    public class DateConverter : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, string language )
        {
            DateTime date = ( DateTime )value;
            return date.ToString( "d" );
        }

        public object ConvertBack( object value, Type targetType, object parameter, string language )
        {
            string strValue = value as string;
            DateTime resultDateTime;
            if ( DateTime.TryParse( strValue, out resultDateTime ) )
            {
                return resultDateTime;
            }
            throw new Exception( "Unable to convert string to date time" );
        }
    }
}
