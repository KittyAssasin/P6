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
        List<Issue> Issues;
        public string Add(Issue issue)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetAll(int projectId)
        {
            throw new NotImplementedException();
        }

        public Issue GetIssueById(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetIssuesByMonth(int projectId)
        {
            throw new NotImplementedException();
        }

        public int GetTotalNumberOfIssues(int projectId)
        {
            throw new NotImplementedException();
        }

        public string Modify(Issue issue)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Issue issue)
        {
            throw new NotImplementedException();
        }

        public string ValidateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        public bool IsDuplicate(string title)
        {
            throw new NotImplementedException();
        }
    }
}
