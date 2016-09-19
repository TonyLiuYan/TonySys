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

            //一级按钮菜单
            List<Item> items = new List<Item>(){
                new Item
            {
                Name = "一级菜单1",
                Key = "1-1",
                Type = Dos.WeChat.Item.Click
            },
                new Item()
            {
                Name = "一级菜单2",
                Key = "1-2",
                Type = Dos.WeChat.Item.View,
                Url = "http://www.liuyanzhuyuhan.com/Home/Index"
            }, 
                new Item()
            {
                Name = "一级菜单3",
                Key = "1-3",
                Type = Dos.WeChat.Item.View,
                Url = "http://www.baidu.com"
            }};


            MenuHelper.Save(new WeChatParam
            {
                Menu = new MenuResult
                {
                    Button = items
                }
            });

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