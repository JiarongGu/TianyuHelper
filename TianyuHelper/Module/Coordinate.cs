using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianyuHelper.Module
{
    public class Coordinate
    {
        public float x { set; get; }
        public float y { set; get; }
        public float z { set; get; }

        public Coordinate(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public String toString()
        {
            return Convert.ToInt32(x).ToString() + ", "
                + Convert.ToInt32(y).ToString() + ", "
                + Convert.ToInt32(z).ToString();
        }

        public String toRealString()
        {
            return x.ToString() + ", " + y.ToString() + ", " + z.ToString();
        }

        public float diffOfXY(Coordinate coordinate)
        {
            return Math.Abs(x - coordinate.x) + Math.Abs(y - coordinate.y);
        }
    }
}
