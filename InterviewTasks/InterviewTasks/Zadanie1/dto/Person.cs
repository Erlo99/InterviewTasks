using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks.Zadanie1
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<EmailAddress> Emails { get; set; }
    }
}
