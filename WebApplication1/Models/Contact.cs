using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public  string Firstname{ get; set;}
        public string LastName { get; set; }

        public string Nickname { get; set; }

        public int Place { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false ;



    }
}
