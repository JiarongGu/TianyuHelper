using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TianyuHelper.Module;

namespace TianyuHelper.Handler
{
    public class ScriptHandler
    {
        public string scriptName { set; get; }
        public List<ActionEvent> actionEvents { set; get; }
        public int scriptIndex { set; get; }

        private MemoryProcess process;

        private KeyHandler keyHandler;

        private RouteHandler routeHandler;
        
        #region GatherVariables
        private int gatherStartIndex;

        private string gatherKey;

        private int gatherQuantity;

        private int gatherTime;
        #endregion

        public event ActionEventHandler actionEventHandler;

        public delegate void ActionEventHandler(object sender, TaskEventArgs e);
        protected virtual void onActionStart(TaskEventArgs e)
        {
            ActionEventHandler handler = actionEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void initializeScript()
        {
            this.scriptIndex = 0;
        }

        public bool runNextEvent()
        {
            TaskEventArgs args = new TaskEventArgs();
            args.currentScript = scriptName;
            args.currentAction = actionEvents[scriptIndex].getActionDetail();
            args.type = (int)TypeEnum.action;
            onActionStart(args);

            runEvent(actionEvents[scriptIndex]);
            scriptIndex++;
            if (scriptIndex == actionEvents.Count)
                return true;
            return false;
        }

        public ScriptHandler(MemoryProcess process, KeyHandler keyHandler, RouteHandler routeHandler) 
        {
            actionEvents = new List<ActionEvent>();
            this.process = process;
            this.keyHandler = keyHandler;
            this.routeHandler = routeHandler;
        }

        public void addActionEvent(string textLine)
        {
            if (textLine.Trim() == "") return;
            actionEvents.Add(new ActionEvent(textLine));
        }
        
        private bool runEvent(ActionEvent actionEvent)
        {
            string action = actionEvent.action;
            string[] sValue = actionEvent.value.Split(',');
            string tag = actionEvent.tag;
            if (actionEvent.type == Const.EVENT_MOUSE) return runMouseActionEvent(action, sValue, Convert.ToInt32(tag));
            if (actionEvent.type == Const.EVENT_KEY) return runKeyActionEvent(action, sValue, Convert.ToInt32(tag));
            if (actionEvent.type == Const.EVENT_ROUTE) return runRouteActionEvent(action, sValue, Convert.ToBoolean(tag == "" ? "False" : tag));
            if (actionEvent.type == Const.EVENT_GATHER) return runGatherActionEvent(action, sValue, Convert.ToBoolean(tag == "" ? "False" : tag));
            return true;
        }

        internal void clearQuest()
        {
            scriptName = "";
            actionEvents.Clear();
        }

        private bool runKeyActionEvent(string action, string[] sValue, int tag)
        {
            if(action == Const.ACTION_PRESS) keyHandler.KeyPress(sValue[0]);
            keyHandler.Sleep(tag);
            return true;
        }

        private bool runMouseActionEvent(string action, string[] sValue, int tag)
        {
            if (action == Const.ACTION_CLICK) keyHandler.MouseClick(sValue[0]); 
            if (action == Const.ACTION_MOVE) keyHandler.MouseMove(int.Parse(sValue[0]), int.Parse(sValue[1]));
            keyHandler.Sleep(tag);
            return true;
        }

        private bool runRouteActionEvent(string action, string[] sValue, bool tag)
        {
            double[] dValue = Array.ConvertAll(sValue, double.Parse);
            if (dValue.Length == 3) routeHandler.initializeRoute(dValue[0], dValue[1], dValue[2]);
            if (dValue.Length == 4) routeHandler.initializeRoute(dValue[0], dValue[1], dValue[2], dValue[3]);
            if (action == Const.ACTION_LSTRIGHT) while (!routeHandler.startLinearRoute(tag)) { };
            if (action == Const.ACTION_LHEIGHT) while (!routeHandler.startLinearHeight()) { };
            if (action == Const.ACTION_DROPDOWN) while (!routeHandler.startDropDown()) { };
            return true;
        }

        private bool runGatherActionEvent(string action, string[] sValue, bool tag)
        {   
            if (action == Const.ACTION_START)
            {
                gatherStartIndex = scriptIndex;
                gatherKey = sValue[0];
                gatherQuantity = Convert.ToInt32(sValue[1]);
                gatherTime = Convert.ToInt32(sValue[2]);
            }

            if (action == Const.ACTION_POINT)
            {
                if (gatherQuantity > 0) {
                    double[] dValue = Array.ConvertAll(sValue, double.Parse);
                    routeHandler.initializeRoute(dValue[0], dValue[1], dValue[2], dValue[3]);
                    while (!routeHandler.startLinearRoute()) { }
                    keyHandler.KeyPressDelay(gatherKey);
                    keyHandler.Sleep(gatherTime);
                    gatherQuantity--;
                }
                else {
                    return true;
                }
            }

            if (action == Const.ACTION_END && gatherQuantity > 0)
            {
                scriptIndex = gatherStartIndex;
            }
            return true;
        }
    }
}