using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianyuHelper.Module
{
    public class ActionEvent
    {
        public string type { get; set; }
        public string action { get; set; }
        public string value { get; set; }
        public string tag { get; set; }

        public ActionEvent(string task, string action, string value, string tag = "")
        {
            this.type = type;
            this.action = action;
            this.value = value;
            this.tag = tag;
        }

        public ActionEvent(string textLine)
        {
            this.type = getTextByDelimiter(textLine,  '\0', '#');
            this.action = getTextByDelimiter(textLine, '<', '>');
            this.value = getTextByDelimiter(textLine, '>', '[').Trim();
            this.tag = getTextByDelimiter(textLine, '[', ']');
        }

        public string getActionName()
        {
            string actionName = "";
            if (type == "Key") actionName = "键盘";
            if (type == "Mouse") actionName = "鼠标";
            if (type == "Route") actionName = "寻路";
            if (type == "Gather") actionName = "采集";

            if (action == "PRESS") actionName += "按键";
            if (action == "MOVE") actionName += "移动";
            if (action == "CLICK") actionName += "点击";
            if (action == "LHEIGHT") actionName += "高度";
            if (action == "LSTRAIGHT") actionName += "距离";
            if (action == "DROPDOWN") actionName += "下落";
            if (action == "START") actionName += "开始";
            if (action == "END") actionName += "结束";
            if (action == "POINT") actionName += "坐标";

            return actionName; 
        }

        public string getActionText()
        {
            return type + "# <" + action + "> " + value + " [" + tag + "]";
        }

        public string getActionDetail()
        {
            return getActionName() + " " + value;
        }
        private string getTextByDelimiter(string text, char upper, char lower)
        {
            int startIndex = text.IndexOf(upper);
            int endIndex = text.IndexOf(lower);
            startIndex = startIndex >= 0 ? startIndex+1 : 0;
            endIndex = endIndex >= 0 ? endIndex : text.Length;
            if (startIndex == 0 && endIndex == text.Length) return "";
            return text.Substring(startIndex, endIndex-startIndex);
        }
    }
}
