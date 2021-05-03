using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Contacts.Entity.Model
{
    public class Contacts
    {
        [Key()]
        public int ContacID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
