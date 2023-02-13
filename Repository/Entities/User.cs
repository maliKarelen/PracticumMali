using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    //רק בסיעתא דשמיא!!!!!!!!!!!!!
    //public enum HMO
    //{
    //    MACABI, MEUCHEDET, LEUMIT, KLALIT
    //}


    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tz { get; set; }

        public DateTime BirthDate { get; set; }

        public int Gemder { get; set; }

        public EHMO UserHMO { get; set; }

        public List<ChildOfUser> ChildrenOfUser { get; set; }

        public int Status { get; set; } 
    }
}
