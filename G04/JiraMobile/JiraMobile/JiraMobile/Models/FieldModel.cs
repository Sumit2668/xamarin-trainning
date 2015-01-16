using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JiraMobile.Models
{
	public class FieldIssues
	{
		public string Name {
			get;
			set;
		}

		public string Value {
			get;
			set;
		}

		public override string ToString ()
		{
			return string.Format ("[FieldIssues: Name={0}, Value={1}]", Name, Value);
		}
	}

	public static class FieldModel
	{
		static FieldModel ()
		{
			FieldModelList = new ObservableCollection<FieldIssues> {
				new FieldIssues {
					Name = "Status"
				},
				new FieldIssues {
					Name = "Resolution"
				},
				new FieldIssues {
					Name = "Affects Version/s"
				},
				new FieldIssues {
					Name = "Environment"
				},
				new FieldIssues {
					Name = "Issue Type"
				},
				new FieldIssues {
					Name = "Epic Link"
				},
				new FieldIssues {
					Name = "Priority"
				},
				new FieldIssues {
					Name = "Sprint"
				}
			};
		}
		public static IList<FieldIssues> FieldModelList { get; private set; }

	}
}

