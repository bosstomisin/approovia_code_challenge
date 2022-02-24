using Newtonsoft.Json;
using System;

namespace SparkPlug.Data
{
    public class Customer
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
