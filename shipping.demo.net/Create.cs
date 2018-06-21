using Newtonsoft.Json;

namespace shipping.demo.net
{
    public class CreateDto
    {
            [JsonProperty("e_id")]
            public string Eid { get; set; }
            [JsonProperty("method")]
            public string Method { get; set; }
            [JsonProperty("content")]
            public ContentCreateDto Content { get; set; }
    }

    public class ContentCreateDto
    {

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("sender")]
        public SenderDto Sender { get; set; }
        [JsonProperty("receiver")]
        public ReceiverDto Receiver { get; set; }
    }

    public class SenderDto
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
    }
    public class ReceiverDto
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class RespCreateDto
    {
        [JsonProperty("result")]
        [JsonConverter(typeof(SingleValueObjectConverter<CreateResultDto>))]
        public CreateResultDto Result { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("error")]
        [JsonConverter(typeof(SingleValueObjectConverter<ErrorDto>))]
        public ErrorDto Error { get; set; }

    }

    public class ErrorDto
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("details")]
        public string Details { get; set; }
    }

    public class CreateResultDto
    {
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        [JsonProperty("remark")]
        public string Remark { get; set; }
        [JsonProperty("info")]
        [JsonConverter(typeof(SingleValueObjectConverter<InfoDto>))]
        public InfoDto Info { get; set; }
    }

    

    public class InfoDto
    {
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("billno")]
        public string BillNo { get; set; }
        [JsonProperty("state_info")]
        public string StateInfoDto { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }

}
