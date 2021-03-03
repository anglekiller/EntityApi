using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Model
{
    public class Users
    {
        
        private int? userId;
        private string email_address;
        private string password;
        private string first_name;
        private string middle_name;
        private string last_name;
        private int? jobId;
        private string job_level;
        private int? pub_id;
        private DateTime? hire_date;
        public Job Job{ set; get; }
        public Publisher publisher { set; get; }
        [Key]
        public int? UserId { get => userId; set => userId = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public string Password { get => password; set => password = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Middle_name { get => middle_name; set => middle_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public int? JobId { get => jobId; set => jobId = value; }
        public string Job_level { get => job_level; set => job_level = value; }
        public int? Pub_id { get => pub_id; set => pub_id = value; }
        public DateTime? Hire_date { get => hire_date; set => hire_date = value; }
    }
}
