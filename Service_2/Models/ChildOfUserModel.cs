using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_2.Models
{
    public class ChildOfUserModel
    {


        public int ChildOfUserId { get; set; }

        public string Name { get; set; }

        public string Tz { get; set; }

        public DateTime BirthDate { get; set; }

        public int Status { get; set; }

    }
}
