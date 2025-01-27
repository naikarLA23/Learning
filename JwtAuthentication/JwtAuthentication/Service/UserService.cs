using JwtAuthentication.Model;
using JwtAuthentication.Models.Enums;
using JwtAuthentication.Service.Interface;

namespace JwtAuthentication.Service
{
    public class UserService : IUserService
    {

        public ResponseModel GetUserById(short id)
        {
            try
            {
                //using var dbContext = new TrackerContext();
                //return new ResponseModel() { Status = ResponseStatus.Success.ToString(), Message = "Record fetched successfully", Data = dbContext.Users.First(g => g.Id == id) };
                return new ResponseModel() { Status = ResponseStatus.Success.ToString(), Message = "Record fetched successfully", 
                    Data = new object() };

            }
            catch (Exception ex)
            {
                return new ResponseModel() { Status = ResponseStatus.Error.ToString(), Message = ex.Message};
            }
        }
     
    }
}
