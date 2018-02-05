using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TianyuHelper.Module;

namespace TianyuHelper.Handler
{
    public class RunTimeHandler
    {
        public List<ScriptHandler> scripts { set; get; }

        private DateTime startTime;

        private DateTime endTime;

        private DateTime runTime;

        private DateTime listDelay;

        private DateTime total;

        private DateTime listStartTime;

        private DateTime listEndTime;

        private int loopTimes;

        private bool isStartTime;

        private bool isEndTime;

        private bool isListTime;

        public int counter;

        private bool running;

        public event ScriptEventHandler scriptEventHandler;

        public delegate void ScriptEventHandler(object sender, TaskEventArgs e);
        protected virtual void onScriptUpdate(TaskEventArgs e)
        {
            ScriptEventHandler handler = scriptEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public RunTimeHandler()
        {
            scripts = new List<ScriptHandler>();
        }

        public void initializeRunTime(DateTime startTime, DateTime endTime, DateTime runTime, DateTime listDelay, 
            int loopTimes, bool isStartTime, bool isEndTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.runTime = runTime;
            this.listDelay = listDelay;
            this.loopTimes = loopTimes;
            this.isStartTime = isStartTime;
            this.isEndTime = isEndTime;

            isListTime = false;
            counter = 0;
            running = false;
            total = new DateTime();
            total = runTime.Add(listDelay.TimeOfDay);
        }

        public void addScripts(ScriptHandler scriptHandler)
        {
            scripts.Add(scriptHandler);
            scriptHandler.actionEventHandler += scriptHandler_taskEventHandler;
        }

        public void scriptHandler_taskEventHandler(object sender, TaskEventArgs e)
        {
            onScriptUpdate(e);
        }

        private bool isRun()
        {
            DateTime now = DateTime.Now;

            bool isRun = false;

            if (isStartTime) { if (now.TimeOfDay > startTime.TimeOfDay){ isRun = true;} else { isRun = false;} }

            if (isEndTime){ if (now.TimeOfDay < endTime.TimeOfDay) { isRun = true; } else { isRun = false; running = false; } }

            if (!isStartTime && !isEndTime) {
                if (isListTime)
                {
                    if ((now.TimeOfDay > listStartTime.TimeOfDay && now.TimeOfDay < listEndTime.TimeOfDay) || listStartTime == listEndTime)
                    {
                        isRun = true;
                    }
                    else
                    {
                        listStartTime = listStartTime.Add(total.TimeOfDay);
                        listEndTime = listEndTime.Add(total.TimeOfDay);
                    }
                }
                else
                {
                    bool isIn = false;
                    DateTime tempTimeStart = new DateTime();
                    DateTime tempTimeEnd = new DateTime();
                    for (int i = 0; i < 24; i++)
                    {
                        if (i == 0) {
                            tempTimeStart = startTime;
                        } else {
                        tempTimeStart = tempTimeStart.Add(total.TimeOfDay);
                        }
                        tempTimeEnd = tempTimeStart.Add(runTime.TimeOfDay);

                        if (now.TimeOfDay > tempTimeStart.TimeOfDay && now.TimeOfDay < tempTimeEnd.TimeOfDay)
                        {
                            isIn = true;
                            i = 24;
                        }
                    }
                    if (isIn || tempTimeStart == tempTimeEnd)
                    {
                        listStartTime = tempTimeStart;
                        listEndTime = tempTimeEnd;
                        isListTime = true;
                        isRun = true;
                    }
                }
            }
            if (loopTimes > 0 && counter >= loopTimes)
            {
                isRun = false;
                running = false;
            }
            return isRun;
        }
    
        public void runScripts()
        {
            running = true;
            bool complete = false;
            while (running) {
                if (isRun()){
                    foreach (ScriptHandler script in scripts)
                    {
                        script.initializeScript();
                        while (!script.runNextEvent()) { };
                        complete = true;
                        Thread.Sleep(1000);
                        //Console.WriteLine("Quest " + runIndex + " Script " + getCurrentScript().scriptIndex);
                    }
                } else {
                    complete = false;
                    Thread.Sleep(1000);
                }

                if (complete)
                {
                    counter++;
                    TaskEventArgs args = new TaskEventArgs();
                    args.isComplete = true;
                    args.counter = counter;
                    args.type = (int)TypeEnum.script;
                    onScriptUpdate(args);

                    Console.WriteLine("Quest Completed " + counter);
                }
            }
        }
    }
}
