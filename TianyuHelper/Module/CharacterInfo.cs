using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianyuHelper.Module
{
    public class CharacterInfo
    {
        public double current_hp { set; get; }
        public double current_mp { set; get; }
        public double max_hp { set; get; }
        public double max_mp { set; get; }

        public CharacterInfo(double current_hp, double current_mp,
            double max_hp, double max_mp)
        {
            this.current_hp = current_hp;
            this.current_mp = current_mp;
            this.max_hp = max_hp;
            this.max_mp = max_mp;
        }

        public string getHpToString()
        {
            return (current_hp.ToString() + "/" + max_hp.ToString());
        }

        public string getMpToString()
        {
            return (current_mp.ToString() + "/" + max_mp.ToString());
        }
    }
}
