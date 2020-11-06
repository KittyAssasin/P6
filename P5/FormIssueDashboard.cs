using P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormIssueDashboard : Form
    {
        Project _CurrentProject;
        public FormIssueDashboard(Project project)
        {
            InitializeComponent();
            _CurrentProject = project;
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            this.lblTotalIssuesNumber.Text = fakeIssueRepository.GetTotalNumberOfIssues(_CurrentProject.Id).ToString();
            List<string> issuesByMonth = fakeIssueRepository.GetIssuesByMonth(_CurrentProject.Id);
            List<string> issuesByDiscoverer = fakeIssueRepository.GetIssuesByDiscoverer(_CurrentProject.Id);

            if (issuesByMonth.Count == 0)
                lstBoxIssuesbyMonth.Items.Add("No issues");
            else
                foreach (string listing in issuesByMonth)
                    lstBoxIssuesbyMonth.Items.Add(listing);

            if (issuesByDiscoverer.Count == 0)
                lstBoxIssuebyDiscoverer.Items.Add("No issues");
            else
                foreach (string listing in issuesByDiscoverer)
                    lstBoxIssuebyDiscoverer.Items.Add(listing);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
