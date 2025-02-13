using System.Net.Http;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GitHubUserActivity.Models;
using Newtonsoft.Json;

namespace GitHubUserActivity.Services
{
    public class GitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "CSharp-Console-App");
        }

        public async Task<GitHubUser> ObterInformacoesUsuario(string username)
        {
            try
            {
                string url = $"https://api.github.com/users/{username}";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Deserializa a resposta JSON para o modelo GitHubUser
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    GitHubUser user = JsonConvert.DeserializeObject<GitHubUser>(jsonResponse);

                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados: {ex.Message}");
                return null;
            }
        }

        public async Task<List<GitHubRepository>> ObterRepositorios(string username){

            try
            {
                string url = $"https://api.github.com/users/{username}/repos";

                HttpResponseMessage response  = await _httpClient.GetAsync(url);

                if(response.IsSuccessStatusCode){
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<GitHubRepository> gitRepos = JsonConvert.DeserializeObject<List<GitHubRepository>>(jsonResponse);

                    return gitRepos;
                } else {
                    return null;
                };

            }
            catch (System.Exception error)
            {
                Console.WriteLine($"Erro ao buscar dados: {error.Message}");
                return null;
            }
        }




    }
}
