using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.ViewModels;
using UploadDoc.Auth;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Interfaces;

namespace UploadDoc.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            if (string.IsNullOrEmpty(user.Email))
            {
                throw new Exception("Email/Password are required.");
            }


            User _user = userRepository.Find(x => x.IsActive && x.Email.ToLower() == user.Email.ToLower());
            if (_user == null)
            {
                throw new Exception("User not found");
            }
            return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(_user), TokenService.GenerateToken(_user));
        }

        public bool Delete(string userId)
        {
            if (userId == null)
            {
                throw new Exception("UserID is empty.");
            }

            User _user = userRepository.Find(u => u.Id.ToString() == userId && u.IsActive);
            if (_user == null)
            {
                throw new Exception("User not found");
            }
            
            return userRepository.Delete(_user);
        }
    }
}