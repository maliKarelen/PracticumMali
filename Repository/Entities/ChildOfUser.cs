using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    //רק בסיעתא דשמיא!!!!!!!!!!!
    public class ChildOfUser
    {


        public int ChildOfUserId { get; set; }

        public string Tz { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Status { get; set; }

    }
}
