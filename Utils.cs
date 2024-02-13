using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Windows.Forms;



namespace WithdrawerConfiger
{
    public static class SentenceUtils
    {
        public static readonly string Hitokoto = @"https://v1.hitokoto.cn/";

        public struct HitokotoReply
        {
            public int id { get;set; }
            public string uuid { get;set; }
            public string hitokoto { get;set; }
            public string type { get;set; }
            public string from { get;set; }
            public string from_who { get;set; }
            public string uploader { get;set; }
            public int uploader_id { get;set; }
            public int  judge_id { get;set; }
            public string method { get;set; }
            public string timestamp { get;set; }
            public int length { get;set; }
        }

        public static HitokotoReply Request(string args = "")
        {
            HttpWebRequest req = HttpWebRequest.Create(Hitokoto + args) as HttpWebRequest;
            req.Method = "GET";
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            string h = new StreamReader(resp.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<HitokotoReply>(h);
        }
    }
}