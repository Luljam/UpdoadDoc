using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Application.ViewModels;

namespace UploadDoc.Application.Interfaces
{
    public interface IUserService
    {
        UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user);
    }
}
