using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConfigEXFOATT
{
    internal class ConfigATT
    {
        #region【选择波长】
        public string wlChange(int wavelength)  //选择波长
        {
            string wlChangeSCPI = $"LINStrument0:INP:WAV {wavelength} NM\r\n"; 
            return wlChangeSCPI;
        }
        #endregion

        #region【选择功率衰减模式】
        public string ATTMode()  //选择功率衰减模式
        {
            string ATTModeSCPI = "LINStrument0:CONT:MODE ATT\r\n";
            return ATTModeSCPI;
        }
        #endregion

        #region【配置输出模式】
        public string OperateMode()
        {
            string OperateModeSCPI = "LINStrument0:OUTP:APM REFerence\r\n";
            return OperateModeSCPI;
        }
        #endregion

        #region【选择功率衰减量】
        public string ATTlevel(double ATTSetValue)  //选择功率衰减量 int ATTLevelInput 遍历备用
        {
            string ATTlevelSCPI = $"LINStrument0:INP:RATT {ATTSetValue} DB\r\n";
            return ATTlevelSCPI;
        }
        #endregion

        #region【ATT打开输出】
        public string ATTOpen()  
        {
            string ATTOpenSCPI = "LINStrument0:OUTP ON\r\n";  //LINStrument<FTB-3500-BI-EI>:设备型号助记符
            return ATTOpenSCPI;
        }
        #endregion

        #region【ATT关闭输出】
        public string ATTClose()    
        {
            string ATTCloseSCPI = "LINStrument0:OUTP:STAT OFF\r\n";
            return ATTCloseSCPI;
        }
        #endregion
    }
}
