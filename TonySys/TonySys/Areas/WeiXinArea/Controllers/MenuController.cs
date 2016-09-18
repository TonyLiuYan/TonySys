using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dos.WeChat;

namespace TonySys.Areas.WeiXinArea.Controllers
{
    public class MenuController : Controller
    {
        // GET: WeiXinArea/Menu
        public ActionResult Create()
        {
            WeChatParam weChatParam=new WeChatParam();

            MenuResult menuResult=new MenuResult();
           
            List<Item> items=new List<Item>();

            Item item1 = new Item
            {
                Name = "一级菜单1",
                Key = "1-1",
                Type = Dos.WeChat.Item.Click
            };

            items.Add(item1);

            menuResult.Button = items;

            weChatParam.Menu = menuResult;

            Dos.WeChat.MenuHelper.Save(weChatParam);
          
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Get()
        {
            return View();
        }
    }
}