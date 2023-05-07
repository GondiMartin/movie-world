using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MovieWorld.MVVM.Models;

namespace MovieWorld.MVVM.Services
{
    public class MovieService
    {
        private readonly Uri serverUrl = new Uri("https://api.themoviedb.org/3/");
        private readonly string apiKey = "7ccff5e2ca4d41346f25fbd8858a1ee2";

        private async Task<T> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = serverUrl;
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
        }
        public async Task<List<Movie>> GetPopularMoviesAsync()
        {
            return await GetAsync<List<Movie>>(new Uri("movie/popular"));
        }
    }
}
