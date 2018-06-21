using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shipping.demo.net
{
    public class QueryDto
    {
        [JsonProperty("e_id")]
        public string Eid { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("content")]
        public ContentQueryDto Content { get; set; }
    }
    public class ContentQueryDto
    {
        [JsonProperty("orderno")]
        public string OrderNo { get; set; }
    }

    public class RespQueryDto
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(SingleValueObjectConverter<QueryResultDto>))]
        public QueryResultDto Result { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("error")]
        [JsonConverter(typeof(SingleValueObjectConverter<ErrorDto>))]
        public ErrorDto Error { get; set; }

    }

    public class QueryResultDto
    {
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        [JsonProperty("remark")]
        public string Remark { get; set; }
        [JsonProperty("info")]
        [JsonConverter(typeof(SingleValueArrayConverter<List<InfoDto>>))]
        public List<InfoDto> Info { get; set; }
    }

}
