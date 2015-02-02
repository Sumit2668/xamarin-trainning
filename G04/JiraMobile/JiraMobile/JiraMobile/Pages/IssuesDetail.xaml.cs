using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraMobile.Pages
{
    public partial class IssuesDetail
    {
		static RootIssueDetail dataSource;
		/// <summary>
		/// Data source for screen issues detail
		/// </summary>
		/// <value>The data source.</value>
		public static RootIssueDetail DataSource {
			get {
				return dataSource != null ? dataSource : (dataSource = new RootIssueDetail() );
			}
			set {
				dataSource = value;
			}
		}

		public static String ID { get; set; }

		public IssuesDetail(String id)
        {
			ID = id;
            InitializeComponent();
        }
	}
}
