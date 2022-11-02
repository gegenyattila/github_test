using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_test
{
    public class github_commit_test
    {
        public github_commit_test(string nev, int age)
        {
            this.nev = nev;
            this.age = age;
        }

        public string nev { get; set; }
        public int age { get; set; }
    }
}
