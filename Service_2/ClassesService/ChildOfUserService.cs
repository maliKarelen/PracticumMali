using AutoMapper;
using Azure;
using Repository.Entities;
using Repository.InterfacesRepository;
using Service_2.InterfacesService;
using Service_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_2.ClassesService
{
    public class ChildOfUserService : IChildOfUserService
    {
        //AutoMapper.MapperConfiguration config = new AutoMapper.MapperConfiguration(
        //   conf => conf.CreateMap<ChildOfUser, ChildOfUserModel>());
        IMapper _mapper;


        IChildOfUserRepository _childOfUserRepository;

        public ChildOfUserService(IChildOfUserRepository c,IMapper mapper)
        {
            _childOfUserRepository = c;
            _mapper = mapper;
        }

        public async Task<ChildOfUserModel> AddAsync(ChildOfUserModel model)
        {
            
            return  _mapper.Map<ChildOfUserModel>(await _childOfUserRepository.AddAsync(_mapper.Map<ChildOfUser>(model)));

        }

        public async Task DeleteAsync(int id)
        {
            _childOfUserRepository.DeleteAsync(id);
        }

        public async Task< List<ChildOfUserModel>> GetAllAsync()
        {
            List<ChildOfUser> children =await _childOfUserRepository.GetAllAsync();
            var returnList = new List<ChildOfUserModel>();
            foreach (ChildOfUser item in children)
            {
                returnList.Add(_mapper.Map<ChildOfUserModel>(item));

            }
            return returnList;
        }

        public async Task< ChildOfUserModel> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildOfUserModel>(await _childOfUserRepository.GetByIdAsync(id));
        }

        public void UpdateAsync(ChildOfUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
