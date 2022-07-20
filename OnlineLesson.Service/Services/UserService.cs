using AutoMapper;
using OnlineLesson.Data.IRepositories;
using OnlineLesson.Domain.Entities;
using OnlineLesson.Service.DTOs;
using OnlineLesson.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLesson.Service.Services
{
    public class UserService : IUserService
    {
        private IGenericRepository<User> userRepository;
        private IMapper mapper;

        public UserService(IGenericRepository<User> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public User Create(UserForCreationDto userDto)
        {
            var mappedUser = mapper.Map<User>(userDto);

            return userRepository.Create(mappedUser);
        }

        public bool Delete(Expression<Func<User, bool>> predicate)
        {
            return userRepository.Delete(predicate);
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            return userRepository.Get(predicate);
        }

        public IQueryable<User> GetAll(Expression<Func<User, bool>> predicate = null)
        {
            return userRepository.GetAll(predicate);
        }

        public User Update(int Id, UserForCreationDto userDto)
        {
            var mappedUser = mapper.Map<User>(userDto);

            return userRepository.Update(Id, mappedUser);
        }
    }
}
