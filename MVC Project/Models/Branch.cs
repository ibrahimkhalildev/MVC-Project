using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MVC_Project.Models
{
    internal class Branch
    {
        public string BranchName { get; set; }
        public int BranchCode { get; set; }

        public static List<Branch> GetBranch()
        {
            List<Branch> lst = new List<Branch>();
            
            Branch branch = new Branch();
            branch.BranchName = "Dhaka";
            branch.BranchCode = 210;
            lst.Add(branch);


            branch = new Branch();
            branch.BranchName = "Khulna";
            branch.BranchCode = 399;
            lst.Add(branch);
            
            return lst;
        }
    }
}