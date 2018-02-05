using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoIt;
using TianyuHelper.Module;

namespace TianyuHelper.Handler
{
    public class KeyHandler
    {
        private int winHeight;
        private int winWidth;
        private int winPosX;
        private int winPosY;
        private string taskWindow;
        public KeyHandler(MemoryProcess process)
        {
            this.taskWindow = process.taskWindow;
            var winClientSize = AutoItX.WinGetClientSize(taskWindow);
            winHeight = winClientSize.Height;
            winWidth = winClientSize.Width;
            var winPos = AutoItX.WinGetPos(taskWindow);
            winPosX = winPos.X;
            winPosY = winPos.Y;
        }

        public void KeyPress(string key)
        {
            AutoItX.Send("{"+ key +"}");
        }

        public void KeyPressDelay(string key, int timeDelay = 100)
        {
            AutoItX.Send("{" + key + " down}");
            Thread.Sleep(timeDelay);
            AutoItX.Send("{" + key + " up}");
        }

        public void KeyDown(string key)
        {
            AutoItX.Send("{" + key + " down}");
        }


        public void KeyUp(string key)
        {
            AutoItX.Send("{" + key + " up}");
        }

        public void KeyDoublePressHold(string key)
        {
            AutoItX.Send("{" + key + "}");
            Thread.Sleep(100);
            AutoItX.Send("{" + key + " down}");
        }

        public void KeyDoublePressHoldDelay(string key, int delayTime = 400)
        {
            AutoItX.Send("{" + key + "}");
            Thread.Sleep(50);
            AutoItX.Send("{" + key + " down}");
            Thread.Sleep(delayTime);
            AutoItX.Send("{" + key + " Up}");
        }


        public void KeyCombo(string key1, string key2, string key3 = "")
        {
            AutoItX.Send("{" + key1 + " down}",1);
            Thread.Sleep(50);
            AutoItX.Send("{" + key2 + " down}",1);
            Thread.Sleep(50);
            if (key3 != "")
            {
                AutoItX.Send("{" + key3 + " down}", 1);
                Thread.Sleep(50);
                AutoItX.Send("{" + key3 + " up}" , 1);
            }
            AutoItX.Send("{" + key2 + " up}" , 1);
            Thread.Sleep(50);
            AutoItX.Send("{" + key1 + " up}" , 1);
            Thread.Sleep(50);
        }

        public void Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public void MouseClick(string button = "LEFT")
        {
            AutoItX.MouseDown(button);
            Thread.Sleep(100);
            AutoItX.MouseUp(button);
        }

        public void MouseDown(string button = "LEFT")
        {
            AutoItX.MouseDown(button);
        }

        public void MouseUp(string button = "LEFT")
        {
            AutoItX.MouseUp(button);
        }
        
        public void MouseMove(int x, int y, int speed = -1)
        {
            Point point = GetMousePosition();
            AutoItX.MouseMove(point.X + x, point.Y + y,speed);
            //autoIt.MouseMove(winWidth / 2 + winPosX + x, Convert.ToInt32(winHeight * 0.36) + winPosY + y, speed);
        }

        public static Point GetMousePosition()
        {
            Point point = Control.MousePosition;
            return new Point(point.X, point.Y);
        }
    }
}
