using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_test
{
    public class github_commit_test
    {
        public github_commit_test(string nev, int age, string job)
        {
            this.nev = nev;
            this.age = age;
            this.job = job
        }

        public string nev { get; set; }
        public int age { get; set; }
        public string job {get; set;}
    }
}
