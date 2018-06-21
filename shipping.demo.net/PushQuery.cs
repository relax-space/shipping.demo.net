using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shipping.demo.net
{
    public class RespPushQueryDto
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(SingleValueObjectConverter<PushQueryResultDto>))]
        public PushQueryResultDto Result { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("error")]
        [JsonConverter(typeof(SingleValueObjectConverter<ErrorDto>))]
        public ErrorDto Error { get; set; }

    }

    public class PushQueryResultDto
    {
        [JsonProperty("billno")]
        public string BillNo { get; set; }
        [JsonProperty("orderno")]
        public string OrderNo { get; set; }
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
