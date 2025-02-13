using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitHubUserActivity.Models
{
   public class GitHubRepository
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
    
    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }
    
    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("stargazers_count")]
    public int StargazersCount { get; set; }

    [JsonProperty("forks_count")]
    public int ForksCount { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
}

}