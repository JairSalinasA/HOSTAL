using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCES.Entities
{
    public class Users
    {
        public int userid { get; set; }
        public string loginname { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string position { get; set; }
        public string email { get; set; }
    }
}
