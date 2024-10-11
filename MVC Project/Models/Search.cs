using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class Search
    {
        public string BranchName { get; set; }
        public int BranchCode { get; set; }

        public static List<Search> GetSearch()
        {
            List<Search> lst = new List<Search>();

            Search search = new Search();
            search.BranchName = "Bangladesh";
            search.BranchCode = 100;
            lst.Add(search);

            search = new Search();
            search.BranchName = "Arab";
            search.BranchCode = 110;
            lst.Add(search);


            return lst;
        }
    }
}