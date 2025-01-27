using JwtAuthentication.Model;

namespace JwtAuthentication.Service.Interface
{
    public interface IUserService
    {
        ResponseModel GetUserById(short id);
    }
}
