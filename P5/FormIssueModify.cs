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
    public partial class FormIssueModify : Form
    {
        Issue toModify;
        public FormIssueModify(Issue issue)
        {
            InitializeComponent();
            toModify = issue;
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueStatusRepository fISR = new FakeIssueStatusRepository();
            FakeAppUserRepository fAUR = new FakeAppUserRepository();

            this.txtBoxId.Text = toModify.Id.ToString();
            this.txtBoxTitle.Text = toModify.Title;
            this.dateTimePicker.Value = toModify.DiscoveryDate;

            foreach (AppUser appUser in fAUR.GetAll())
                comboBoxDiscoverer.Items.Add(appUser.LastName + ", " + appUser.FirstName);
            this.comboBoxDiscoverer.SelectedItem = toModify.Discoverer;

            this.txtBoxComponent.Text = toModify.Component;

            foreach (IssueStatus issueStatus in fISR.GetAll())
                comboBoxStatus.Items.Add(issueStatus.Value);
            this.comboBoxStatus.SelectedItem = fISR.GetValueById(toModify.IssueStatusId);
            
            this.txtBoxDescription.Text = toModify.InitialDescription;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FakeIssueRepository fIR = new FakeIssueRepository();
            FakeIssueStatusRepository fISR = new FakeIssueStatusRepository();
            if (comboBoxDiscoverer.SelectedItem != null && comboBoxStatus.SelectedItem != null)
            {
                Issue newIssue = new Issue
                {
                    Id = toModify.Id,
                    ProjectId = toModify.ProjectId,
                    Title = this.txtBoxTitle.Text,
                    DiscoveryDate = this.dateTimePicker.Value,
                    Discoverer = this.comboBoxDiscoverer.SelectedItem.ToString(),
                    Component = this.txtBoxComponent.Text,
                    IssueStatusId = fISR.GetIdByStatus(this.comboBoxStatus.SelectedItem.ToString()),
                    InitialDescription = this.txtBoxDescription.Text
                };
                string added = fIR.Modify(newIssue);
                if (added == fIR.NO_ERROR)
                {
                    MessageBox.Show("Successfully Modified Issue");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Modify Issue: " + added);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Discoverer and Status");
            }
        }
    }
}
