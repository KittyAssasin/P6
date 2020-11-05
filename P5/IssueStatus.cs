using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IssueStatus
    {
        public int Id;
        public string Value;

        public IssueStatus(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
