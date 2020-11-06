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
    public partial class FormIssueSelect : Form
    {
        public Issue selectedIssue;
        private Project _CurrentProject;
        public FormIssueSelect(Project currentProject)
        {
            InitializeComponent();
            _CurrentProject = currentProject;
        }

        private void FormIssueSelect_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            FakeIssueRepository fIR = new FakeIssueRepository();
            FakeIssueStatusRepository fISR = new FakeIssueStatusRepository();
            foreach (Issue i in fIR.GetAll(_CurrentProject.Id))
            {
                string[] data =
                {
                    i.Id.ToString(),
                    i.Title,
                    i.DiscoveryDate.ToString(),
                    i.Discoverer,
                    i.InitialDescription,
                    i.Component,
                    fISR.GetValueById(i.IssueStatusId)
                };
                dataGridView1.Rows.Add(data);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            selectedIssue = null;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int chosenId = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FakeIssueRepository fIR = new FakeIssueRepository();
            selectedIssue = fIR.GetIssueById(chosenId);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
