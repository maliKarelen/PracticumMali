using AutoMapper;
using Repository.Entities;
using Repository.InterfacesRepository;
using Service_2.InterfacesService;
using Service_2.Models;

namespace Service_2.ClassesService
{
    //רק בסיעתא דשמיא!!!!!!!!!!!!!
    public class UserService : IUserService
    {
   //     AutoMapper.MapperConfiguration config = new AutoMapper.MapperConfiguration(
   //conf => conf.CreateMap<User, UserModel>());
        IMapper _mapper;
        IUserRepository _IUserRepository;

        public UserService(IUserRepository u,IMapper mapper)
        {
            _IUserRepository = u;
            _mapper = mapper;
        }

        public async Task<UserModel> AddAsync(UserModel model)
        {

           return _mapper.Map<UserModel>(await _IUserRepository.AddAsync(_mapper.Map<User>(model)));
        
        }

        public async Task DeleteAsync(int id)
        {
           _IUserRepository.DeleteAsync(id);
        }

        public async Task< List<UserModel>> GetAllAsync()
        {
            List<User> usersL = await _IUserRepository.GetAllAsync();
            var returnList = new List<UserModel>();
            foreach (User item in usersL)
            {
                returnList.Add(_mapper.Map<UserModel>(item));

            }
            return returnList;
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            return  _mapper.Map<UserModel>(await _IUserRepository.GetByIdAsync(id)) ;
        }

        public void UpdateAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
