using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigBAPPG
{
    internal class ConfigPPG
    {
        #region【SwitchPPGEDOptions，配置PPG Mode】
        public string SwitchPPGEDOptions(string PPGMode)  // PPG模式配置 形参是字符串的变量
        {
            string sendDatePPGMode; // 需发送的SCPI指令
            //public static string[] modeArray = new string[] { "Basic", "MultiRate", "1.5 VPP", "FEC", "56G" };
            
            switch (PPGMode)
            {
                case "Basic":
                    sendDatePPGMode = ":SwitchPPGEDOptions:1,0,0,0,0,0,0";
                    break;

                case "MultiRate":
                    sendDatePPGMode = ":SwitchPPGEDOptions:0,1,0,0,0,0,0";
                    break;

                case "1.5 VPP":
                    sendDatePPGMode = ":SwitchPPGEDOptions:0,0,1,0,0,0,0";
                    break;

                case "FEC":
                    sendDatePPGMode = ":SwitchPPGEDOptions:0,0,0,1,0,0,0";
                    break;

                case "56G":
                    sendDatePPGMode = ":SwitchPPGEDOptions:0,0,0,0,1,0,0";
                    break;

                default:
                    MessageBox.Show(
                        "input error",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    sendDatePPGMode = ":SwitchPPGEDOptions:invalid";
                    break;
            }
            return sendDatePPGMode;  //返回需要发送的SCPI指令
        }
        #endregion

        #region【SetBAConfigAdvV2 配置Modulation，速率，分频比】
        public string SetBAConfigAdvV2(string Modulation, string pSymbolRate, string ClockRatio)
        {
            // var config = (Modulation, pSymbolRate, ClockRatio);
            string sendDateMSC; //发送命令的变量

            if (Modulation == "NRZ" && pSymbolRate == "25.78125GBd" && ClockRatio == "Rate/4") //指定条件下的命令
            {
                sendDateMSC = ":SetBAConfigAdvV2:1,257812500,0,0,2,0,0,0";
                return sendDateMSC;
            }

            if (Modulation == "PAM4" && pSymbolRate == "53.125GBd" && ClockRatio == "Rate/2") //指定条件下的命令
            {
                sendDateMSC = ":SetBAConfigAdvV2:0,53125000,0,0,2,0,0,0";
                return sendDateMSC;
            }
            else
            {
                sendDateMSC = "invalid";
                return sendDateMSC;
            }
        }
        #endregion

        #region【SetPattern，选择码型，PAM4使用的码型带Q】
        public string SetPattern(string TestPattern)
        {
            // :SetPattern:1,18,0,1,3
            string sendDatePattern;

            switch (TestPattern) 
            {
                case "PN15": //用于NRZ
                    sendDatePattern = ":SetPattern:0,5,1,1,3";
                    break;

                case "PN31": //用于NRZ
                    sendDatePattern = ":SetPattern:0,8,1,1,3";
                    break;

                case "PN15Q": //用于PAM4
                    sendDatePattern = ":SetPattern:0,15,1,1,3";
                    break;

                case "PN31Q": //用于PAM4
                    sendDatePattern = ":SetPattern:0,18,1,1,3";
                    break;

                default:
                    sendDatePattern = "invalid";
                    break;
            }
            return sendDatePattern;
        }
        #endregion

        #region【Update7Taps 配置调节参数】
        public string Update7Taps(int PreCursor, int Amplitude, int PostCursor, int UpperEye, int LowerEye)
        {
            string sendDateUpdate7Taps;

            if(Amplitude > 1000)  // Vpp输入限制在1V以内
            {
                MessageBox.Show(
                    "VPP超出配置范围",
                    "Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                sendDateUpdate7Taps = "invalid";
            }

            else
            {
                sendDateUpdate7Taps = $":Update7Taps:0,{PreCursor},0,0,{Amplitude},{PostCursor},0,0,{UpperEye},{LowerEye}";
                /*
                MessageBox.Show(
                    sendDateUpdate7Taps,
                    "notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );*/
            }
            return sendDateUpdate7Taps;
        }
        #endregion

        #region【SetRXSensitivity RX端sen的模式】
        public string SetRXSensitivity()
        {
            string sendDateSetRXSensitivity = ":SetRXSensitivity:0,1";  //此项直接默认配置
            return sendDateSetRXSensitivity;
        }
        #endregion

        #region【SetBERSettings，配置BER的计数模式、测试时间】
        public string SetBERSettings(int timeSet)  // 指令写死
        {
            string sendDateSetBERSettings = $":SetBERSettings:0,0,1,0,0,0,{timeSet}";  // BER为计时模式，10s测试，BER 1s刷新1次，完成后则停止，可以取值。
            return sendDateSetBERSettings;
        }
        #endregion

        #region【StartBERTest 启动BER】
        public string StartBERTest()
        {
            string sendDtateStartBERTest = ":StartBERTest";
            return sendDtateStartBERTest;
        }
        #endregion

        #region【IsBERTRunning 检测当前BER测试是否在运行】
        public string IsBERTRunning()   
        {
            string sendDateIsBERTRunning = ":IsBERTRunning"; 
            return sendDateIsBERTRunning;
        }
        #endregion

        #region【ReadBERResult 只能读取单通道的BER值，基于10s测试完成后的结果】
        public string ReadBERResult(int BERReadChannel)  // 支持选择channel读取
        {
            string sendDateReadBERResult = $":ReadBERResult:{BERReadChannel}";
            return sendDateReadBERResult;
        }
        #endregion

        #region【clear BER date，4通道】
        public string ClearBERTest()
        {
            string sendDateClearBERTest = ":ClearBERTest:0";
            return sendDateClearBERTest;
        }
        #endregion

        #region【StopBERTest 关闭BER测试】
        public string StopBERTest()
        {
            string sendDateStopBERTest = ":StopBERTest";
            return sendDateStopBERTest;
        }
        #endregion

    }
}
