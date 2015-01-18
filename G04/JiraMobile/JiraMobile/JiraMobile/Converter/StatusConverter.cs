using System;
using Xamarin.Forms;

namespace JiraMobile
{
	public class StatusConverter : IValueConverter
	{
		const string STATUS_DONE = "Done";
		const string STATUS_TODO = "To Do";
		const string STATUS_INPROGRESS = "In Progress";
		const string STATUS_CLOSED = "Closed";
		const string STATUS_CANCELLED = "Cancelled";
		const string STATUS_REOPENED = "Reopened";

		public StatusConverter ()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			Status status = (Status)value;
			//Int32 status = System.Convert.ToInt32 (value);

			ImageSource imgStatus = null;

			switch (status.name) {
			case STATUS_DONE:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.done.png");
				break;
			case STATUS_TODO:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.todo.png");
				break;
			case STATUS_INPROGRESS:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.inprogress.png");
				break;
			case STATUS_CLOSED:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.closed.png");
				break;
			case STATUS_CANCELLED:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.cancelled.png");
				break;
			case STATUS_REOPENED:
				imgStatus = ImageSource.FromResource ("JiraMobile.Images.reopen.png");
				break;
			default :
				break;


			}

			return imgStatus;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

