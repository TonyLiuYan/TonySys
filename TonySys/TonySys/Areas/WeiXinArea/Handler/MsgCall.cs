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
            throw new NotImplementedException();
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