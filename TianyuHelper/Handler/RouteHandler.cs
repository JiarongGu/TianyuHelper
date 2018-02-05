using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TianyuHelper.Handler;
using TianyuHelper.Module;

namespace TianyuHelper.Module
{
    public class RouteHandler
    {
        public KeyHandler keyHandler { set; get; }
        public MemoryProcess process { set; get; }

        private double initSlope;

        private double tempSlope;

        private float initHeight;

        private float tempHeight;

        private double initDistance;

        private double tempDistance;

        private int turn;

        private int time;

        private int timeDelay;

        private double accuracy;

        public Coordinate initLocation { set; get; }
        public Coordinate tempLocation { set; get; }

        public RouteHandler(MemoryProcess process, KeyHandler keyhandler)
        {
            this.process = process;
            this.keyHandler = keyhandler;
        }

        public void initializeRoute(double x, double y, double z, double accuracy = 2.5)
        {
            this.accuracy = accuracy;
            tempLocation = process.getCoordinate();
            initLocation = new Coordinate((float)x, (float)y, (float)z);

            initSlope = getSlope(tempLocation.x, initLocation.x, tempLocation.y, initLocation.y);
            initDistance = getDistance(tempLocation.x, initLocation.x, tempLocation.y, initLocation.y);
            initHeight = tempLocation.z - initLocation.z;

            tempDistance = initDistance;
            tempHeight = initHeight;

            Console.WriteLine("Start: " + tempLocation.toString() +  " Distnation: " + initLocation.toString() +  " Distance: " + initDistance);
            turn = 0; time = 400; timeDelay = 0;
        }

        public bool startLinearRoute(bool withHeight = false)
        {
            double tempD = tempDistance;
            double tempZ = tempLocation.z;
            float tempX = tempLocation.x;
            float tempY = tempLocation.y;
            double tempS = findTempSlope(tempX, tempY);

            if (turn != 0) keyHandler.MouseMove(turn, 0, 4);
            if (time > 1500){
                keyHandler.KeyDoublePressHoldDelay("w", time / 2);
            }else{
                keyHandler.KeyPressDelay("w", time);
                if (timeDelay > 0) keyHandler.Sleep(timeDelay);
            }

            tempLocation = process.getCoordinate();
            if (withHeight){
                int timeHeight = (int)(8 * Math.Abs(tempZ - tempLocation.z));
                if (tempZ < tempLocation.z){
                    keyHandler.MouseMove(0, timeHeight < 80? timeHeight: 80, 3);
                } else {
                    keyHandler.MouseMove(0, timeHeight < 80 ? -timeHeight : -80, 3);
                }
            }
            tempDistance = findTempDistance(tempLocation.x, tempLocation.y);

            if (tempDistance == tempD) return false;
            if (tempDistance < accuracy) return true;

            double diffDistance = getDistance(tempLocation.x, tempX, tempLocation.y, tempY);
            double angle = getAngle(tempD, diffDistance);

            double tempSlope = findTempSlope(tempLocation.x, tempLocation.y);
            double position = ((tempX - initLocation.x) * (tempLocation.y - initLocation.y) - (tempY - initLocation.y) * (tempLocation.x - initLocation.x));
            if (double.IsNaN(angle)) angle = 0;

            //angle turn calculation
            int initAgnle = Convert.ToInt32(3.00117647 * angle - 0.01333333 * Math.Pow(angle, 2));
            turn = position > 0 ? initAgnle * -1 : initAgnle;
            time = (int)(tempDistance* 40);
            timeDelay = 400 - time;
            return false;
        }

        public bool startLinearHeight()
        {
            double tempH = tempHeight;
            if (tempHeight < 0){
                if (time > 1000) {
                    keyHandler.KeyDoublePressHoldDelay("SPACE", (int)(time * 0.5));
                } else {
                    keyHandler.KeyPressDelay("SPACE", time);
                }
            } else {
                if (time > 1000) {
                    keyHandler.KeyDoublePressHoldDelay("x", (int)(time * 0.5));
                } else {
                    keyHandler.KeyPressDelay("x", time);
                }
            }

            tempLocation = process.getCoordinate();
            tempHeight = tempLocation.z - initLocation.z;

            time = (int)(tempHeight * 100) > 600 ? (int)(tempHeight * 100) : 200;
            if (Math.Abs(tempHeight) < accuracy)
                return true;
            return false;
        }

        public bool startDropDown()
        {
            keyHandler.KeyPressDelay("NUMPADDOT",100);
            tempLocation = process.getCoordinate();
            tempHeight = tempLocation.z - initLocation.z;
            Console.WriteLine("tempHeight: " + tempHeight);
            keyHandler.Sleep(100);
            if (Math.Abs(tempHeight) < accuracy + (initHeight> 58 ? 32: 20))
            {
                keyHandler.KeyPressDelay("SPACE", 200);
                keyHandler.Sleep(1000);
                return true;
            }
            return false;
        }

        private double getAngle(double tempD, double diffDistance)
        {
            double cos = (Math.Pow(tempD, 2) + Math.Pow(diffDistance, 2) - Math.Pow(tempDistance, 2)) / (2 * tempD * diffDistance);
            return Math.Acos(cos) * 180 / Math.PI;
        }

        private double getSlope(float x1, float x2, float y1, float y2)
        {
            //return Math.Atan((y2 - y1) / (x2 - x1)) * 180 / Math.PI;
             return (y2 - y1) / (x2 - x1);
        }

        private double getDistance(float x1, float x2, float y1, float y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }

        private double findTempSlope(float x, float y)
        {
            return getSlope(x, initLocation.x, y, initLocation.y);
        }

        private double findTempDistance(float x, float y)
        {
            return getDistance(x, initLocation.x, y, initLocation.y);
        }
    }
}
