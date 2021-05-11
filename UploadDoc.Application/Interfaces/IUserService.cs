using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.ViewModels;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Application.Interfaces
{
    public interface IUserService
    {
        UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user);

        bool Delete(string userId);
    }
}
