using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Data.Context;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;

namespace UploadDoc.Data.Repositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
                
        }
        public IEnumerable<User> GetAll()
        {
            return Query(x => x.IsActive);
        }

        public User Find(int userId)
        {
            return Find(x => x.Id == userId);
        }
    }
}
