﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IIssueRepository
    {
        string Add(Issue issue);
        List<Issue> GetAll(int projectId);
        bool Remove(Issue issue);
        string Modify(Issue issue);
        int GetTotalNumberOfIssues(int projectId);
        List<string> GetIssuesByMonth(int projectId);
        List<string> GetIssuesByDiscoverer(int ProjectId);
        Issue GetIssueById(int id);

    }
}
