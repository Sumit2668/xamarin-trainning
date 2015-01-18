using System;
using Xamarin.Forms;

namespace JiraMobile
{
	public class AvatarConverter : IValueConverter
	{
		public AvatarConverter ()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			Assignee assignee = (Assignee)value;
			ImageSource img = ImageSource.FromUri(new Uri(assignee.avatarUrls.avt_16x16));
			return img;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

