using System.Threading.Tasks;
using RestSharp;
using Web_Attack.Common.Models.Requet;
using Web_Attack.Common.Models.Response;

namespace Web_Attack.Common.Services
{
    public class AuthenticationService
    {
        private const string BaseUrl = "https://webattackapi.azurewebsites.net/";

        public AuthenticationService()
        {
        }

        public async Task<UserRegisterResponse> RegisterUserAsync(RegisterRequest requestBody)
        {
            var client = new RestClient($"{BaseUrl}api/Auth/register");
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(requestBody);
            var result = await client.ExecuteAsync<UserRegisterResponse>(request);
            return result.Data;
        }

        public async Task<LoginResponse> LoginUserAsync(LoginRequest requestBody)
        {

            var client = new RestClient($"{BaseUrl}api/Auth/login");
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(requestBody);
            var result = await client.ExecuteAsync<LoginResponse>(request);
            return result.Data;
        }

    }
}