using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Dos.Common;
using Dos.WeChat;
using TonySys.Areas.WeiXinArea.Handler;


namespace TonySys.Areas.WeiXinArea.Controllers
{
    public class WeChatController : Controller
    {
        public ActionResult WeChatService()
        {
            if (!JoinToken.Join(new MsgCall()))
            {
                LogHelper.Debug("签名验证未通过，请检查web.config配置");
                //签名验证未通过，请检查web.config配置
            }
            LogHelper.Debug("返回视图");
            return View();
        }
    }
}