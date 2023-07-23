using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using WcfServiceLibraryDemo.Services.Models;

namespace WcfServiceLibraryDemo.Services
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        Task<bool> CreateAsync(UserModel user);

        [OperationContract]
        Task<bool> UpdateAsync(UserModel user);

        [OperationContract]
        Task<bool> DeleteAsync(int userId);

        [OperationContract]
        Task<IReadOnlyList<UserModel>> GetAllAsync();

        [OperationContract]
        Task<UserModel> GetByIdAsync(int userId);
    }
}
