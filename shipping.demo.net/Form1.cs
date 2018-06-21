using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace shipping.demo.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string url ="http://103.13.245.59:7186/v2";
        string url = "https://staging.p2shop.com.cn/shipping/v2";
        readonly JsonSerializerSettings jsonFormat = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateDto c = new CreateDto();
            c.Eid = "10001";
            c.Method = "spring.create";
            c.Content = new ContentCreateDto
            {
                Quantity = 1,
                Sender = new SenderDto
                {
                    Code = "CR00",
                    Name = "rose3c",
                    Company = "Eland",
                    Phone = "13051447878",
                    City = "北京市,北京市,通州区",
                    Address = "恒通商务园B37座"
                },
                Receiver = new ReceiverDto
                {
                    Code = "CR02",
                    Name = "hh",
                    Company = "Eland",
                    Phone = "13051447877",
                    City = "北京市,北京市,通州区",
                    Address = "恒通商务园B51座"
                }
            };
            string postData = JsonConvert.SerializeObject(c);
            string result = sendPost(url, postData);
            RespCreateDto resultObj = JsonConvert.DeserializeObject<RespCreateDto>(result, jsonFormat);
            MessageBox.Show(result);

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryDto c = new QueryDto();
            c.Eid = "10001";
            c.Method = "spring.query";
            c.Content = new ContentQueryDto
            {
                OrderNo = "1803021273351",
            };
            string postData = JsonConvert.SerializeObject(c);
            string result = sendPost(url, postData);
            RespQueryDto resultObj = JsonConvert.DeserializeObject<RespQueryDto>(result, jsonFormat);
            MessageBox.Show(result);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelDto c = new CancelDto();
            c.Eid = "10001";
            c.Method = "spring.cancel";
            c.Content = new ContentCancelDto
            {
                OrderNo = "1803021273351",
            };
            string postData = JsonConvert.SerializeObject(c);
            string result = sendPost(url, postData);
            RespCancelDto resultObj = JsonConvert.DeserializeObject<RespCancelDto>(result, jsonFormat);
            MessageBox.Show(result);
        }

        private void btnPushQuery_Click(object sender, EventArgs e)
        {
            string result = sendGet(url+ "?state=spring.push.query&bill_no=2017849728");
            RespPushQueryDto resultObj = JsonConvert.DeserializeObject<RespPushQueryDto>(result, jsonFormat);
            MessageBox.Show(result);
        }

        /// <summary>
        /// Post方式提交数据，返回网页的源代码
        /// </summary>
        /// <param name="url">发送请求的 URL</param>
        /// <param name="param">请求的参数集合</param>
        /// <returns>远程资源的响应结果</returns>
        private string sendPost(string url, string postData)
        {
            byte[] byteData = Encoding.GetEncoding("UTF-8").GetBytes(postData);
            string result = "";
            try
            {


                HttpWebRequest request = null;
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    //ServicePointManager.SecurityProtocol = spt; //不指定,使之自动协商/适应, 避免指定的版本与服务器不一样反而连不上
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    request = WebRequest.Create(url) as HttpWebRequest;
                    request.ProtocolVersion = HttpVersion.Version11;
                }
                else
                    request = WebRequest.Create(url) as HttpWebRequest;

                request.ContentType = "application/json";
                request.Referer = url;
                request.Accept = "*/*";
                request.Timeout = 30 * 1000;
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
                request.Method = "POST";
                request.ContentLength = byteData.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(byteData, 0, byteData.Length);
                stream.Flush();
                stream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream backStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(backStream, Encoding.GetEncoding("UTF-8"));
                result = sr.ReadToEnd();
                sr.Close();
                backStream.Close();
                response.Close();
                request.Abort();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Post方式提交数据，返回网页的源代码
        /// </summary>
        /// <param name="url">发送请求的 URL</param>
        /// <param name="param">请求的参数集合</param>
        /// <returns>远程资源的响应结果</returns>
        private string sendGet(string url)
        {
            string result = "";
            try
            {


                HttpWebRequest request = null;
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    //ServicePointManager.SecurityProtocol = spt; //不指定,使之自动协商/适应, 避免指定的版本与服务器不一样反而连不上
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    request = WebRequest.Create(url) as HttpWebRequest;
                    request.ProtocolVersion = HttpVersion.Version11;
                }
                else
                    request = WebRequest.Create(url) as HttpWebRequest;

                request.ContentType = "application/json";
                request.Referer = url;
                request.Accept = "*/*";
                request.Timeout = 30 * 1000;
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream backStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(backStream, Encoding.GetEncoding("UTF-8"));
                result = sr.ReadToEnd();
                sr.Close();
                backStream.Close();
                response.Close();
                request.Abort();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }


        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            System.IO.Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受
        }

      
    }
}
