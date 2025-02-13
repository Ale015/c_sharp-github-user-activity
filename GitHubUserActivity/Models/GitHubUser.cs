using System;
using Newtonsoft.Json;

namespace GitHubUserActivity.Models
{
    public class GitHubUser
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("bio")]
    public string Bio { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("public_repos")]
    public int NumRepos { get; set; }

    [JsonProperty("followers")]
    public int NumFollowers { get; set; }

    [JsonProperty("following")]
    public int NumFollowing { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("location")]
    public string Location { get; set; }

    [JsonProperty("repos_url")]
    public string ReposUrl { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
}}
