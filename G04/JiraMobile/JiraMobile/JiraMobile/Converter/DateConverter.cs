using System;
using Xamarin.Forms;
using System.Globalization;
using Newtonsoft.Json;

namespace JiraMobile
{
	public class DateConverter : IValueConverter
	{
		public DateConverter ()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			DateTime dt = System.Convert.ToDateTime (value);

			return dt.ToString("d/M/yyyy HH:mm");
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

