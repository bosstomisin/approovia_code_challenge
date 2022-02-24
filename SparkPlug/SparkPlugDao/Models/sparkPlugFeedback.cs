using Newtonsoft.Json;
using System;

namespace SparkPlugDao.Models
{
    public class sparkPlugFeedback
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string customerMessage { get; set; }
        public string _formName { get; set; }
        public string _formDomainName { get; set; }
    }
}
