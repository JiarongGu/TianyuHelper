using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TianyuHelper.Module;

namespace TianyuHelper.Module
{
    public class MemoryProcess
    {
        const int PROCESS_WM_READ = 0x0010;
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
          int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        //const uint WM_KEYDOWN = 0x0100;
        //const uint WM_KEYUP = 0x0101;
        //const uint WM_CHAR = 0x0102;
        //const int VK_TAB = 0x09;
        //const int VK_ENTER = 0x0D;
        //const int VK_UP = 0x26;
        //const int VK_DOWN = 0x28;
        //const int VK_RIGHT = 0x27;

        public int taskId { set; get; }
        public String taskDetail { set; get; }
        public string taskWindow { set; get; }

        private IntPtr processHandler = new IntPtr();

        public MemoryProcess() {}
        public MemoryProcess(int taskId, string taskDetail, string taskWindow)
        {
            this.taskId = taskId;
            this.taskDetail = taskDetail;
            this.taskWindow = taskWindow;
            processHandler = OpenProcess(PROCESS_WM_READ, false, taskId);
        }

        public Coordinate getCoordinate()
        {
            float x = BitConverter.ToSingle(readBytes(Const.COORDINATE_X), 0);
            float y = BitConverter.ToSingle(readBytes(Const.COORDINATE_Y), 0);
            float z = BitConverter.ToSingle(readBytes(Const.COORDINATE_Z), 0);
            return new Coordinate(x, y, z);
        }

        public CharacterInfo getCharacterInfo()
        {
            double current_hp = BitConverter.ToDouble(readBytes(Const.CURRENT_HP), 0);
            double current_mp = BitConverter.ToDouble(readBytes(Const.CURRENT_MP), 0);
            double max_hp = BitConverter.ToDouble(readBytes(Const.MAX_HP), 0);
            double max_mp = BitConverter.ToDouble(readBytes(Const.MAX_MP), 0);
            return new CharacterInfo(current_hp, current_mp, max_hp, max_mp);
        }

        private byte[] readBytes(int address)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[24];
            ReadProcessMemory((int)processHandler, address,buffer, buffer.Length, ref bytesRead);
            return buffer;
        }
    }
}
