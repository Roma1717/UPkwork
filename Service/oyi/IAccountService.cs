using System.Security.Claims;
using Domain.Models;
using Domain.Response;

namespace Service.oyi;

public interface IAccountService
{
    Task<BaseResponse<string>> Register(User model);
    Task<BaseResponse<ClaimsIdentity>> Login(User model);
    Task<BaseResponse<ClaimsIdentity>> ConfirmEmail(User model, string code, string confirmCode);
    Task<BaseResponse<ClaimsIdentity>> IsCreatedAccount(User model);
}