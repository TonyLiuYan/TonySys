using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TonySys.Areas.WeiXinArea.Models
{
    public class WeChatRequestModel
    {
        public string Signature { get; set; }
        public string Timestamp { get; set; }
        public string Nonce { get; set; }

        public string Echostr { get; set; }
    }
}