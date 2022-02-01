using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace MovieApp
{
    class MovieDataService
    {

        static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://www.omdbapi.com/")
        };

        public static async Task<List<Movie>> GetMoviesFromJsonFile()
        {
            List<Movie> movies;
            using (StreamReader r = new StreamReader("C:/Users/bsmith/source/repos/MovieApp/MovieApp/movies.json"))
            {
                string json = r.ReadToEnd();
                Response res = JsonConvert.DeserializeObject<Response>(json);
                movies = new List<Movie>(res.search);
            }
            return movies;
        }
        public static async Task<List<Movie>> GetMoviesString(string title)
        {
            Response response = null;

            try
            {
                var res = await client.GetAsync(client.BaseAddress + $"?s={title}&apikey=f0674f3f");
                if (res.IsSuccessStatusCode)
                {
                    var content = await res.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<Response>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\tERROR {0}", ex.Message);
            }
            return new List<Movie>(response.search);

        }

        public static async Task<List<Movie>> GetMovies()
        {
            Response response = null;
            // Get the user information.
            try
            {
                response = await client.GetFromJsonAsync<Response>(client.BaseAddress);
                //Console.WriteLine(response);
            }
            catch (Exception ex)
            {
               Console.Write(ex.ToString());
            }
            return new List<Movie>(response.search);
        }

    }
}
