using JwtAuthentication.Models.AppModels;

namespace JwtAuthentication.Service.Interface
{
    public interface ILoginService
    {
        bool IsValidUser(Login loginUser);
        bool HasAlreadyLogin(Login loginUser);

        string GetStoredRefreshToken(string userName);
        string GetUserRole(string userName);
        void SaveRefreshToken(TokenResponse tokenResponse);

    }
}
