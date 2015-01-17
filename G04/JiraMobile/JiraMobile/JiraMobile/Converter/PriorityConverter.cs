using System;
using Xamarin.Forms;

namespace JiraMobile
{
	public class PriorityConverter : IValueConverter
	{
		const int PRIORITY_BLOCKER = 1;
		const int PRIORITY_CRITICAL = 2;
		const int PRIORITY_MAJOR = 3;
		const int PRIORITY_MINOR = 4;
		const int PRIORITY_TRAVIAL = 5;

		public PriorityConverter ()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			int priority = Int32.Parse(value.ToString());
			ImageSource img = ImageSource.FromResource ("JiraMobile.Images.major.png");
			switch (priority) {
			case PRIORITY_BLOCKER:
				img = ImageSource.FromResource ("JiraMobile.Images.blocker.png");
				break;
			case PRIORITY_CRITICAL:
				img = ImageSource.FromResource ("JiraMobile.Images.critical.png");
				break;
			case PRIORITY_MAJOR:
				img = ImageSource.FromResource ("JiraMobile.Images.major.png");
				break;
			case PRIORITY_MINOR:
				img = ImageSource.FromResource ("JiraMobile.Images.minor.png");
				break;
			case PRIORITY_TRAVIAL:
				img = ImageSource.FromResource ("JiraMobile.Images.trivial.png");
				break;
			}

			return img;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

