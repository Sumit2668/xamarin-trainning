using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraMobile.Pages
{
    public partial class IssueDetail
    {
        public IssueDetail()
        {
            InitializeComponent();
            this.ItemsSource = new List<IssueDetail>
            {

            };
        }
    }
}
