using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shipping.demo.net
{
    public class CancelDto
    {
        [JsonProperty("e_id")]
        public string Eid { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("content")]
        public ContentCancelDto Content { get; set; }
    }
    public class ContentCancelDto
    {
        [JsonProperty("orderno")]
        public string OrderNo { get; set; }
    }

    public class RespCancelDto
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(SingleValueObjectConverter<CancelResultDto>))]
        public CancelResultDto Result { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("error")]
        [JsonConverter(typeof(SingleValueObjectConverter<ErrorDto>))]
        public ErrorDto Error { get; set; }

    }

    public class CancelResultDto
    {
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        [JsonProperty("remark")]
        public string Remark { get; set; }
        [JsonProperty("info")]
        [JsonConverter(typeof(SingleValueArrayConverter<List<string>>))]
        public List<string> Info { get; set; }
    }
}
