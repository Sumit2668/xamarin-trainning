using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Reminder
{
	public class TodoListPage : ContentPage
	{
		ListView listView;
		DatePicker datePicker;
		public TodoListPage ()
		{
			Title = "Todo";

			NavigationPage.SetHasNavigationBar (this, true);

			// date label
			//var dateLabel = new Label ();
			//dateLabel.BindingContext = this.datePicker;
			//Binding dateLabelBinding = new Binding("Date");
			//dateLabel.SetBinding (Label.TextProperty, dateLabelBinding);

			// list view
			listView = new ListView {
			    RowHeight = 40
			};
			listView.ItemTemplate = new DataTemplate (typeof (TodoItemCell));

			if (Device.OS == TargetPlatform.iOS)
				listView.ItemsSource = new string [1] {""};

			listView.ItemSelected += (sender, e) => {
				var todoItem = (TodoItem)e.SelectedItem;
				var todoPage = new TodoItemPage();
				todoPage.BindingContext = todoItem;
				Navigation.PushAsync(todoPage);
			};

			//date picker
			//datePicker = new DatePicker ();
			//datePicker.DateSelected += (sender, e) => {
			//};

			//layout
			var layout = new StackLayout();
			if (Device.OS == TargetPlatform.WinPhone) { // WinPhone doesn't have the title showing
				layout.Children.Add(new Label{Text="Todo", 
					Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold)});
			}

			layout.Children.Add (dateLabel);
			layout.Children.Add(listView);
			layout.Children.Add (datePicker);
			layout.VerticalOptions = LayoutOptions.FillAndExpand;
			Content = layout;

			ToolbarItem tbi = null;
			if (Device.OS == TargetPlatform.iOS)
			{
				tbi = new ToolbarItem("+", null, () =>
					{
						var todoItem = new TodoItem();
						var todoPage = new TodoItemPage();
						todoPage.BindingContext = todoItem;
						Navigation.PushAsync(todoPage);
					}, 0, 0);
			}
			if (Device.OS == TargetPlatform.Android) { // BUG: Android doesn't support the icon being null
				tbi = new ToolbarItem ("+", "plus", () => {
					var todoItem = new TodoItem();
					var todoPage = new TodoItemPage();
					todoPage.BindingContext = todoItem;
					Navigation.PushAsync(todoPage);
				}, 0, 0);
			}
			if (Device.OS == TargetPlatform.WinPhone)
			{
				tbi = new ToolbarItem("Add", "add.png", () =>
					{
						var todoItem = new TodoItem();
						var todoPage = new TodoItemPage();
						todoPage.BindingContext = todoItem;
						Navigation.PushAsync(todoPage);
					}, 0, 0);
			}

			ToolbarItems.Add (tbi);
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			listView.ItemsSource = App.Database.GetItems ();
		}
	}
}

