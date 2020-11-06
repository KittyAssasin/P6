using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            if (_IssueStatuses.Count == 0)
            {
                Add(0, "Open");
                Add(1, "Assigned");
                Add(2, "Fixed");
                Add(3, "Closed - Won't fix");
                Add(4, "Closed - Fixed");
                Add(5, "Closed - by design");
            }
        }
        public void Add(int Id, string value)
        {
            _IssueStatuses.Add(new IssueStatus { Id = Id, Value = value });
        }

        public List<IssueStatus> GetAll()
        {
            List<IssueStatus> issueStatuses = new List<IssueStatus>();
            foreach (IssueStatus issueStatus in _IssueStatuses)
            {
                issueStatuses.Add(issueStatus);
            }
            return issueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            foreach (IssueStatus issueStatus in _IssueStatuses)
            {
                if (issueStatus.Value == value)
                    return issueStatus.Id;
            }
            return -1;
        }

        public string GetValueById(int Id)
        {
            foreach (IssueStatus issueStatus in _IssueStatuses)
            {
                if (issueStatus.Id == Id)
                    return issueStatus.Value;
            }
            return "";
        }
    }
}
