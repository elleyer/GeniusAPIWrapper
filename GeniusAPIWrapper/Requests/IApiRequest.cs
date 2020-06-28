using System.Threading.Tasks;
using GeniusAPIWrapper.JsonData;

namespace GeniusAPIWrapper.Requests
{
    public interface IApiRequest
    {
        Task<IResponse> SendWebRequest(params string[] data);
    }
}