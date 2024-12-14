using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExfoSet
{
    internal class Exfo
    {
        #region【EXFO参数配置定义】
        public static string[] modeArray = new string[] { "Basic", "MultiRate", "1.5 VPP", "FEC", "56G" };  // mode
        public static string[] symbolRateArray = new string[] { "57.8GBd", "53.125GBd", "49.765",
        "28.9GBd", "28.125GBd", "28.05GBd", "27.95GBd", "26.5625GBd", "25.78125GBd"};  // symbolRate
        
        public static string[] clockRatioArray = new string[] { "Rate/2", "Rate/4", "Rate/8", "Rate/16" };  // clockRatio
        public static string[] waveLength = new string[] { "1310", "1550" };
        public static string[] chooseChannel = new string[] { "1", "2", "3", "4"};

        public enum Modulation  // Modulation   
        {
            NRZ,
            PAM4,
        }
            
        public enum TestPattern  // TestPattern
        {
            PN7Q,
            PN9Q,
            PN11Q,
            PN13Q,
            PN15Q,
            PN16Q,
            PN23Q,
            PN31Q,
        }
        #endregion

        #region【SetModulation】
        public static void SetModulation(IList obj)
        {
            obj.Clear();
            foreach(Modulation i in Enum.GetValues(typeof(Modulation)))
            {
                obj.Add(i.ToString());
            }
        }
        #endregion

        #region【SetTestPattern】
        public static void SetTestPattern(IList obj)
        {
            obj.Clear();
            foreach(TestPattern i in Enum.GetValues(typeof(TestPattern)))
            {
                obj.Add(i.ToString());
            }
        }
        #endregion

    }
}
