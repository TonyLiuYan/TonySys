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
        [AcceptVerbs("GET", "POST")]
        public ActionResult WeChatService()
        {
            LogHelper.Debug("接入微信开始", "微信调试");
            if (!JoinToken.Join(new MsgCall()))
            {
                LogHelper.Debug("微信接入失败", "微信调试");
                //签名验证未通过，请检查web.config配置
                return JavaScript("aler('签名验证未通过，请检查web.config配置');window.location=''");
            }

            LogHelper.Debug("接入微信完毕", "微信调试");

            return View();
        }
    }
}