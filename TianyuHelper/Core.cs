using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TianyuHelper.Handler;
using TianyuHelper.Module;

namespace TianyuHelper
{
    public class Core
    {
        public MemoryProcess process { set; get; }
        public KeyHandler keyHandler { set; get; }
        public FileHandler fileHandler { set; get; }
        public RouteHandler routeHandler { set; get; }
        public ScriptHandler scriptHandler { set; get; }
        public RunTimeHandler runTimeHandler { set; get; }

        public List<Coordinate> coordinates = new List<Coordinate>();

        private Thread th;

        private Thread scriptsRunTime;

        public Core() {
            fileHandler = new FileHandler();
            runTimeHandler = new RunTimeHandler();
        }

        public void initalize(MemoryProcess process)
        {
            this.process = process;
            keyHandler = new KeyHandler(this.process);
            routeHandler = new RouteHandler(this.process, this.keyHandler);
            scriptHandler = new ScriptHandler(this.process, this.keyHandler, this.routeHandler);
        }

        public void initalizeRunTime(DateTime startTime, DateTime endTime, DateTime runTime, DateTime listDelay,
            int loopTimes, bool isStartTime, bool isEndTime)
        {
            runTimeHandler.initializeRunTime(startTime, endTime, runTime, listDelay, 
                loopTimes, isStartTime, isEndTime);
        }

        public string getCoordinate()
        {
            return process.getCoordinate().toString();
        }

        public List<string> getFileScripts()
        {
            return fileHandler.getFileScripts();
        }

        public List<ActionEvent> readScript(int index, string questName)
        {
            scriptHandler.scriptName = questName;
            foreach (string line in fileHandler.readScript(index))
            {
                scriptHandler.addActionEvent(line);
            }
            return scriptHandler.actionEvents;
        }

        public void clearQuest()
        {
            scriptHandler.clearQuest();
        }

        public string getCharacterHp()
        {
            return process.getCharacterInfo().getHpToString();
        }

        public string getCharacterMp()
        {
            return process.getCharacterInfo().getMpToString();
        }

        public void startScripts()
        {
            scriptsRunTime = new Thread(scriptsThread);
            scriptsRunTime.Start();
        }


        private void scriptsThread()
        {
            scriptsRunTime.Abort();
        }

        public void sendTest()
        {
            th = new Thread(testThread1);
            th.Start();
        }
        public void stopTest()
        {
            th.Abort();
        }

        private void testThread1()
        {
            runTimeHandler.runScripts();
        }

        public void addScriptToRun()
        {
            runTimeHandler.addScripts(scriptHandler);
        }
    }
}
