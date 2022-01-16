using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Models
{
    public class UserList
    {
        public string Username { get; set; }
        [Display(Name="Staff Name")]
        public string StaffName { get; set; }
    }
}
