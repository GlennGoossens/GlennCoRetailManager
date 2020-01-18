
using GRMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace GRMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLogginInUserInfo(string token);
    }
}