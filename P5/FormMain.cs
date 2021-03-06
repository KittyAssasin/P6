﻿using Builder;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        private Project _CurrentProject;
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            string selectedProjectName = selectAProject();
            while (selectedProjectName == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
            FakeProjectRepository FPR = new FakeProjectRepository();
            List<Project> projects = FPR.GetAll();
            foreach (Project p in projects)
                if (p.Name == selectedProjectName)
                    _CurrentProject = p;
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string selectedProjectName = selectAProject();
            if (selectedProjectName != "")
            {
                FakeProjectRepository FPR = new FakeProjectRepository();
                List<Project> projects = FPR.GetAll();
                foreach (Project p in projects)
                    if (p.Name == selectedProjectName)
                        _CurrentProject = p;
            }
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }
        //P6
        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueDashboard form = new FormIssueDashboard(_CurrentProject);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueRecord form = new FormIssueRecord(_CurrentProject);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueSelect selectForm = new FormIssueSelect(_CurrentProject);
            selectForm.ShowDialog();
            if (selectForm.selectedIssue != null)
            {
                FormIssueModify modifyForm = new FormIssueModify(selectForm.selectedIssue);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
            }
            selectForm.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FakeIssueRepository fIR = new FakeIssueRepository();
            FormIssueSelect selectForm = new FormIssueSelect(_CurrentProject);
            selectForm.ShowDialog();
            if (selectForm.selectedIssue != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + selectForm.selectedIssue.Title + "?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    fIR.Remove(selectForm.selectedIssue);
                else
                    MessageBox.Show("Removal Canceled", "Confirmation");
            }
            selectForm.Dispose();
        }
    }
}
