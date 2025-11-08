using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// TlsVersions data
    /// </summary>
    public class TlsVersions
    {
        [JsonProperty("TLSv1")]
        public bool TLSv1 { get; set; }

        [JsonProperty("TLSv1.1")]
        public bool TLSv11 { get; set; }

        [JsonProperty("TLSv1.2")]
        public bool TLSv12 { get; set; }

        [JsonProperty("TLSv1.3")]
        public bool TLSv13 { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("tlsVersions")]
        public TlsVersions TlsVersions { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
