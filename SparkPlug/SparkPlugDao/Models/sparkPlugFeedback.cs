using Newtonsoft.Json;
using System;

namespace SparkPlugDao.Models
{
    public class SparkPlugFeedback
    {
        [JsonProperty("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMessage { get; set; }
        public string _formName { get; set; }
        public string _formDomainName { get; set; }
    }
}
