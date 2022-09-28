using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    public class ConnectedWebsiteResponse
    {
        [JsonProperty("sites")]
        public List<Site> Sites { get; set; }

        [JsonProperty("total_items")]
        public long TotalItems { get; set; }

        [JsonProperty("_links")]
        public List<MailChimpLinkV2> Links { get; set; }
    }

    public class MailChimpLinkV2
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("targetSchema")]
        public string TargetSchema { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class Site
    {
        [JsonProperty("foreign_id")]
        public string ForeignId { get; set; }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("site_script")]
        public MailChimpSiteScript SiteScript { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("_links")]
        public List<MailChimpLink> Links { get; set; }
    }

    public class MailChimpSiteScript
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }
    }
}
