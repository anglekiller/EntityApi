using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Model
{
    public class Job
    {
        private int? jobid;
        private string job_desc;

        public int? Jobid { get => jobid; set => jobid = value; }
        public string Job_desc { get => job_desc; set => job_desc = value; }
    }
}
