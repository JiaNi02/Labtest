using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LabtestApi.Entities;

    public class PostRecord
  {
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("userId")]
    public string UserId { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("body")]
    public string Body { get; set; }
  }

