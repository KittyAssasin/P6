using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            
        }
        public void Add(int Id, string value)
        {
            throw new NotImplementedException();
        }

        public List<IssueStatus> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetIdByStatus(string value)
        {
            throw new NotImplementedException();
        }

        public string GetValueById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
