using OnlineLesson.Domain.Entities;
using OnlineLesson.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLesson.Service.Interfaces
{
    public interface IUserService
    {
        User Create(UserForCreationDto userDto);
        User Get(Expression<Func<User, bool>> predicate);
        IQueryable<User> GetAll(Expression<Func<User, bool>> predicate = null);
        User Update(int Id, UserForCreationDto userDto);
        bool Delete(Expression<Func<User, bool>> predicate);
    }
}
