using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class tlsVersions
{
    [JsonProperty("TLSv1")]
    public bool tLSv1 { get; set; }

    [JsonProperty("TLSv1.1")]
    public bool tLSv11 { get; set; }

    [JsonProperty("TLSv1.2")]
    public bool tLSv12 { get; set; }

    [JsonProperty("TLSv1.3")]
    public bool tLSv13 { get; set; }

}

public class data
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("tlsVersions")]
    public tlsVersions tlsVersions { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
