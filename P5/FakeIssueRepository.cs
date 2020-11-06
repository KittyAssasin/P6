using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueRepository : IIssueRepository
    {
        public readonly string NO_ERROR = "";
        public readonly string EMPTY_TITLE_ERROR = "A Title is required.";
        public readonly string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public readonly string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public readonly string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        public readonly string ISSUE_NOT_FOUND_ERROR = "An Issue was not found.";
        private static List<Issue> _Issues = new List<Issue>();
        public FakeIssueRepository()
        {
            if (_Issues.Count == 0)
            {
                // Populate some temporary values to work with
                Add(new Issue
                {
                    Id = 0,
                    ProjectId = 0,
                    Title = "TestTitle",
                    DiscoveryDate = DateTime.Now,
                    Discoverer = "dave",
                    InitialDescription = "Lol there's a problem",
                    Component = "Super critical component",
                    IssueStatusId = 0
                });
            }
        }
        public string Add(Issue issue)
        {
            string validation = ValidateIssue(issue);
            if (validation == NO_ERROR)
                _Issues.Add(issue);
            return validation;
        }

        public List<Issue> GetAll(int projectId)
        {
            return _Issues;
        }

        public Issue GetIssueById(int id)
        {
            foreach (Issue issue in _Issues)
                if (issue.Id == id)
                    return issue;
            return null;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<Issue> currentProjectIssues = new List<Issue>();
            foreach (Issue issue in _Issues)
                if (issue.ProjectId == ProjectId)
                    currentProjectIssues.Add(issue);

            Dictionary<string, int> nameCountPairs = new Dictionary<string, int>();
            foreach (Issue issue in currentProjectIssues)
            {
                if (!nameCountPairs.ContainsKey(issue.Discoverer))
                    nameCountPairs.Add(issue.Discoverer, 0);
                nameCountPairs[issue.Discoverer]++;
            }

            List<string> discovererCount = new List<string>();
            foreach (string discoverer in nameCountPairs.Keys)
                discovererCount.Add(discoverer + ": " + nameCountPairs[discoverer]);

            return discovererCount;
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            List<Issue> currentProjectIssues = new List<Issue>();
            foreach (Issue issue in _Issues)
                if (issue.ProjectId == ProjectId)
                    currentProjectIssues.Add(issue);

            Dictionary<string, int> dateCountPairs = new Dictionary<string, int>();
            foreach (Issue issue in currentProjectIssues)
            {
                string yearMonthString = issue.DiscoveryDate.Year + " - " + issue.DiscoveryDate.Month;
                if (!dateCountPairs.ContainsKey(yearMonthString))
                    dateCountPairs.Add(yearMonthString, 0);
                dateCountPairs[yearMonthString]++;
            }

            List<string> dateCount = new List<string>();
            foreach (string date in dateCountPairs.Keys)
                dateCount.Add(date + " - " + dateCountPairs[date]);

            return dateCount;
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            List<Issue> currentProjectIssues = new List<Issue>();
            foreach (Issue issue in _Issues)
                if (issue.ProjectId == ProjectId)
                    currentProjectIssues.Add(issue);

            return currentProjectIssues.Count;
        }

        public string Modify(Issue issue)
        {
            string validation = ValidateIssue(issue);
            if (validation != NO_ERROR)
                return validation;

            int index = 0;
            foreach (Issue i in _Issues)
            {
                if (issue.Id == i.Id)
                {
                    _Issues[index] = issue;
                    return NO_ERROR;
                }
                index++;
            }
            return ISSUE_NOT_FOUND_ERROR;
        }

        public bool Remove(Issue issue)
        {
            int index = 0;
            foreach (Issue repositoryIssue in _Issues)
            {
                if (repositoryIssue.Id == issue.Id)
                {
                    _Issues.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }

        public string ValidateIssue(Issue issue)
        {
            issue.Title = issue.Title.Trim();
            if (issue.Title == "")
                return EMPTY_TITLE_ERROR;

            if (issue.DiscoveryDate == null || issue.DiscoveryDate.Equals(new DateTime()))
                return EMPTY_DISCOVERY_DATETIME_ERROR;

            if (issue.DiscoveryDate.CompareTo(DateTime.Now) > 0)
                return FUTURE_DISCOVERY_DATETIME_ERROR;

            if (issue.Discoverer == "" || issue.Discoverer == null)
                return EMPTY_DISCOVERER_ERROR;

            return NO_ERROR;
        }

        public bool IsDuplicate(string title)
        {
            foreach (Issue issue in _Issues)
            {
                if (issue.Title == title)
                    return true;
            }
            return false;
        }
        private int GetNextId()
        {
            int currentMaxId = -1;
            foreach (Issue i in _Issues)
            {
                if (currentMaxId < i.Id)
                    currentMaxId = i.Id;
            }
            return ++currentMaxId;
        }
    }
}
