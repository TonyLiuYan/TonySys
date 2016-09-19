using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.Common;
using Dos.WeChat;

namespace TonySys.Areas.WeiXinArea.Handler
{
    public class MsgCall : IMsgCall
    {
        public void AfterMsgCall(ReceiveMsg msg, ResponseMsg repMsg)
        {
            
        }

        public ResponseMsg EventMsgCall(RecEventMsg msg)
        {
            var r = msg.GetTextResponse();
            switch (msg.Event.ToLower())
            {
                //关注公众号事件
                case RecEventMsg.Subscribe:
                    r.Data = (TextMsgData)("欢迎关注本公众号！");
                    
                    break;
                //菜单点击事件
                case RecEventMsg.Click:
                    if (msg.EventKey == "1-1")
                    {
                        r.Data = (TextMsgData)("您点击了测试菜单按钮！");
                    }
                    break;
                //二维码扫描事件
                case RecEventMsg.Scan:
                    r.Data = (TextMsgData)("您扫描了二维码！场景值：" + msg.EventKey);
                    break;
            }
            return r;

        }

        public ResponseMsg ImageMsgCall(RecImgMsg msg)
        {
            var r = msg.GetTextResponse();
            r.Data = (TextMsgData)("收到您的图片了");
            return r;
        }

        public ResponseMsg LinkMsgCall(RecLinkMsg msg)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg LocationMsgCall(RecLocationMsg msg)
        {
            throw new NotImplementedException();
        }

        public ResponseMsg TextMsgCall(RecTextMsg msg)
        {
            LogHelper.Debug("进入文本处理");

            //回复文本消息
            var r = msg.GetTextResponse();
            r.Data = (TextMsgData)(string.Format("已收到您的消息！您的OpenId：{0}。您发送的内容为：{1}。",msg.FromUserName, msg.Content));

            LogHelper.Debug(r.ToString());
            return r;
        }

        public ResponseMsg VoiceMsgCall(RecVoiceMsg msg)
        {
            var r = msg.GetTextResponse();

            r.Data = (TextMsgData)("收到您的语音了");
            return r;
        }
    }
}