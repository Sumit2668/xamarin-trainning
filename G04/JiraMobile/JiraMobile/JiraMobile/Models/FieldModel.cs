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
					Name = "Project"
				},
				new FieldIssues {
					Name = "Creator"
				},
				new FieldIssues {
					Name = "Assignee"
				},
				new FieldIssues {
					Name = "Status"
				},
				new FieldIssues {
					Name = "Resolution"
				},
				new FieldIssues {
					Name = "Environment"
				},
				new FieldIssues {
					Name = "Issue Type"
				},
				new FieldIssues {
					Name = "Priority"
				}
			};
		}
		public static IList<FieldIssues> FieldModelList { get; private set; }

		static FieldIssues GetByName(string name)
		{
			foreach (var model in FieldModelList) {
				if (model.Name.Equals (name)) {

					return model;
				}
			}

			return null;
		}
	}
}

