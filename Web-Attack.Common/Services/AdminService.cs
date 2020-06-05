using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Web_Attack.Common.Common;
using Web_Attack.Common.Models.Response;

namespace Web_Attack.Common.Services
{
    public class AdminService
    {
        private const string BaseUrl = "https://webattackapi.azurewebsites.net/";

        public async Task<List<TotalRequestDto>> GetRequestCard()
        {
            try
            {
                var client = new RestClient($"{BaseUrl}api/Dashboard");
                var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

                var result = await client.ExecuteAsync<List<TotalRequestDto>>(request);
                return result.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        public async Task<List<WeeklyRequest>> GetWeeklyRequests()
        {
            try
            {
                var client = new RestClient($"{BaseUrl}api/Dashboard/weekly-request");
                var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

                var result = await client.ExecuteAsync<List<WeeklyRequest>>(request);
                return result.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public async Task<List<RequestStream>> GetRequestStreamAsync()
        {
            try
            {
                var client = new RestClient($"{BaseUrl}api/Admin/request-stream");
                var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

                var result = await client.ExecuteAsync<List<RequestStream>>(request);
                return result.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public async Task<List<UserListDto>> GetUsersAsync()
        {
            try
            {
                var client = new RestClient("https://webattackapi.azurewebsites.net/api/Admin/get-users");
                var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };
                var result = await client.ExecuteAsync<List<UserListDto>>(request);
                return result.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<UserListDto> UpdateUserAsync(UserListDto user)
        {
            try
            {
                var client = new RestClient("https://webattackapi.azurewebsites.net/api/Admin/update-user");
                var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
                request.AddJsonBody(user);
                var result = await client.ExecuteAsync<UserListDto>(request);
                return result.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}