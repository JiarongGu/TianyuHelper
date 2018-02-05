using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianyuHelper.Module
{
    public class TaskEventArgs : EventArgs
    {
        public string currentAction { set; get; }
        public string currentScript { set; get; }
        public int type { set; get; }
        public int counter { set; get; }
        public bool isComplete { set; get; }
        public TaskEventArgs()
        {
        }

    }
}
