using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("user_Id")]
        public int UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("creation_Time")]
        public int CreationTime { get; set; }

        [JsonProperty("expiration_Time")]
        public int ExpirationTime { get; set; }
    }
}
