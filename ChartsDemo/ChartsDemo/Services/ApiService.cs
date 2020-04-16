using ChartsDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChartsDemo.Services
{
    class ApiService
    {
        private readonly string Uri = "http://192.168.39.1:45455/";
        public async Task<DepDaysModel> GetDepDaysAsync(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync($"{Uri}/Absence/departement/{id}");
            var DepDays = JsonConvert.DeserializeObject<DepDaysModel>(json);
            return DepDays;
        }

        public async Task<AbsBySex> GetAbsBySexAsync(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync($"{Uri}/Absence/Sex/pourcentage/{id}");
            var AbsBySex = JsonConvert.DeserializeObject<AbsBySex>(json);
            return AbsBySex;
        }

        public async Task<AbsByStatusMarital> GetAbsByStatusMaritalAsync(int id)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync($"{Uri}/Absence/Marital/{id}");
            var AbsByStatusMarital = JsonConvert.DeserializeObject<AbsByStatusMarital>(json);
            return AbsByStatusMarital;
        }
    }
}
