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
    public partial class FormIssueRecord : Form
    {
        private Project _CurrentProject;
        public FormIssueRecord(Project project)
        {
            InitializeComponent();
            _CurrentProject = project;
        }

        private void FormIssueRecord_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeAppUserRepository fAUR = new FakeAppUserRepository();
            FakeIssueStatusRepository fISR = new FakeIssueStatusRepository();
            FakeIssueRepository fIR = new FakeIssueRepository();

            this.txtBoxId.Text = fIR.GetNextId().ToString();
            this.dateTimePickerDiscoveryDate.Value = DateTime.Now;
            foreach (AppUser appUser in fAUR.GetAll())
                comboBoxDiscoverer.Items.Add(appUser.LastName + ", " + appUser.FirstName);

            foreach (IssueStatus issueStatus in fISR.GetAll())
                comboBoxStatus.Items.Add(issueStatus.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCreateIssue_Click(object sender, EventArgs e)
        {
            FakeIssueRepository fIR = new FakeIssueRepository();
            FakeIssueStatusRepository fISR = new FakeIssueStatusRepository();
            if (comboBoxDiscoverer.SelectedItem != null && comboBoxStatus.SelectedItem != null)
            {
                Issue newIssue = new Issue
                {
                    Id = fIR.GetNextId(),
                    ProjectId = _CurrentProject.Id,
                    Title = this.txtBoxTitle.Text,
                    DiscoveryDate = this.dateTimePickerDiscoveryDate.Value,
                    Discoverer = this.comboBoxDiscoverer.SelectedItem.ToString(),
                    Component = this.txtBoxComponent.Text,
                    IssueStatusId = fISR.GetIdByStatus(this.comboBoxStatus.SelectedItem.ToString()),
                    InitialDescription = this.txtBoxDescription.Text
                };
                string added = fIR.Add(newIssue);
                if (added == fIR.NO_ERROR)
                {
                    MessageBox.Show("Successfully Added Issue");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Add Issue: " + added);
                }
            } else
            {
                MessageBox.Show("Please Enter Discoverer and Status");
            }
        }
    }
}
