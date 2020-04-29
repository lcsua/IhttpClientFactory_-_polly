using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Core.Aplication.Interfaces;

namespace WebApp.Infrastructure.Services
{
    public class MeliService : IMeliService
    {
        public IHttpClientFactory _httpClientFactory { get; }
        public MeliService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        
        public async Task<ExpandoObject> GetMeliUser(long userId)
        {
            var httpClient = _httpClientFactory.CreateClient("MeliClient");
            var meliUser = await httpClient.GetStringAsync($"users/{userId}");
            return JsonConvert.DeserializeObject<ExpandoObject>(meliUser);
        }
    }
}
