using System;
using Xamarin.Forms;

namespace JiraMobile
{
	public class AvatarProjectConverter : IValueConverter
	{
		public AvatarProjectConverter ()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null) 
			{
				return null;
			}

			AvatarUrls avt = (AvatarUrls)value;
			ImageSource img = ImageSource.FromUri(new Uri(avt.avt_48x48));
			return img;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value;
		}

		#endregion
	}
}

