using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
        User Find(int userId);
    }
}
