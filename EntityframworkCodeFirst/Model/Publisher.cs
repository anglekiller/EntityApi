using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Model
{
    public class Publisher
    {
        private int? id;
        private string name;
        private string city;
        private string state;
        private string country;
        [Key]
        public int? Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
    }
}
