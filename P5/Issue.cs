using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Issue
    {
        private int Id;
        private int ProjectId;
        public string Title;
        public DateTime DiscoveryDate;
        public string Discoverer;
        public string InitialDescription;
        public string Component;
        public int IssueStatusId;
    }
}
