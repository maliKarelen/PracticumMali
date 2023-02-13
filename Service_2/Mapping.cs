using AutoMapper;
using Repository.Entities;
using Service_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_2
{
    //רק בסיעתא דשמיא
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User,UserModel>().ReverseMap(); 
            CreateMap<ChildOfUser,ChildOfUserModel>().ReverseMap();
        }


    }
}
