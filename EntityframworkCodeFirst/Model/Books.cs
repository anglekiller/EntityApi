using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityframworkCodeFirst.Model
{
    public class Books
    {
        private int id;
        private string name;
        private string price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
    }
}
