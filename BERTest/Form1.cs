using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExfoSet;  // 自定义封装，EXFO和ATT的配置
using Param;  // 自定义封装,各种变量定义，用于仪表交互
using SubForm;  // 自定义封装，PPG/ATT connect的配置界面
using SocketCom; // 自定义封装，用于设备连接、数据发送接收
using ConfigBAPPG;
using ConfigEXFOATT;  
using System.Linq.Expressions;  // SCPI命令函数

namespace BER_test
{
    public partial class MainForm : Form
    {
        public MainForm()  // 窗体初始化
        {
            InitializeComponent();
        }

        public int ATTFlag = 0;  //ATT开关button的标志位
        Params par = new Params();  // 创建Params的实例，用于变量赋值传递给TCP库，打开设备连接
        SocketCommunication socketComPPG = new SocketCommunication();  // 创建PPG 连接对象
        SocketCommunication socketcomATT = new SocketCommunication();  // 创建ATT 连接对象
        ConfigPPG configPPG = new ConfigPPG();  //SCPI命令函数的实例
        ConfigATT configATT = new ConfigATT();  //SCPI命令函数的实例

        private void MainForm_Load(object sender, EventArgs e)
        {
            ExfoSetInit();  //初始化EXFO的界面参数
            AttSet();  //初始化Att
            InitPPG();  //初始化PPG开关、及事件订阅

        }

        #region【PPG/ATT TCP connect config show】
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubFormConnect subFormConnect = new SubFormConnect();
            subFormConnect.ShowDialog();
        }
        #endregion

        #region[ExfoSetInit]
        public void ExfoSetInit()  // ExfoSetInit
        {
            comboBoxChannel.Items.Clear(); // 通道选择项
            comboBoxChannel.Items.AddRange(Exfo.chooseChannel);  //添加通道选项
            comboBoxChannel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChannel.SelectedIndexChanged += new EventHandler((obj, e) =>  //绑定事件
            {
                if(comboBoxChannel.SelectedItem != null)
                {
                    par.pChannel = int.Parse(comboBoxChannel.SelectedItem.ToString());
                }
            });
            comboBoxChannel.SelectedIndex = 0;

            comboBoxMode.Items.Clear();
            comboBoxMode.Items.AddRange(Exfo.modeArray);
            comboBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;  //设置combobox下拉列表的风格，不设置不显示
            comboBoxMode.SelectedIndexChanged += new EventHandler((obj, e) =>
            {
                if (comboBoxMode.SelectedItem != null)
                {
                    par.pMode = comboBoxMode.SelectedItem.ToString();  // 提取Mode配置的参数，后面配置提取，以此类推
                }
            });
            comboBoxMode.SelectedIndex = 4;  // 选择默认的显示项

            comboBoxSymbolRate.Items.Clear();
            comboBoxSymbolRate.Items.AddRange(Exfo.symbolRateArray);
            comboBoxSymbolRate.DropDownStyle = ComboBoxStyle.DropDownList;  //设置combobox下拉列表的风格，不设置不显示
            comboBoxSymbolRate.SelectedIndexChanged += new EventHandler((obj, e) =>
            {
                if (comboBoxSymbolRate.SelectedItem != null)
                {
                    par.pSymbolRate = comboBoxSymbolRate.SelectedItem.ToString();
                }
            });
            comboBoxSymbolRate.SelectedIndex = 0;  // 选择默认的显示项

            comboBoxClockRatio.Items.Clear();
            comboBoxClockRatio.Items.AddRange(Exfo.clockRatioArray);
            comboBoxClockRatio.DropDownStyle = ComboBoxStyle.DropDownList;  //设置combobox下拉列表的风格，不设置不显示
            comboBoxClockRatio.SelectedIndexChanged += new EventHandler((obj, e) =>
            {
                if (comboBoxClockRatio.SelectedItem != null)
                {
                    par.pClockRatio = comboBoxClockRatio.SelectedItem.ToString();
                }
            });
            comboBoxClockRatio.SelectedIndex = 0;  // 选择默认的显示项

            comboBoxModulation.Items.Clear();
            Exfo.SetModulation(comboBoxModulation.Items);  // 初始化配置Modulation
            comboBoxModulation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModulation.SelectedIndexChanged += new EventHandler((obj, e) =>
            {
                par.pModulation = comboBoxModulation.SelectedItem.ToString();
            });
            comboBoxModulation.SelectedIndex = 1;

            comboBoxTestPattern.Items.Clear();
            Exfo.SetTestPattern(comboBoxTestPattern.Items);  // 初始化配置TestPattern
            comboBoxTestPattern.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTestPattern.SelectedIndexChanged += new EventHandler((obj, e) =>
            {
                par.pTestPattern = comboBoxTestPattern.SelectedItem.ToString();
            });
            comboBoxTestPattern.SelectedIndex = 4;

            textBoxAmp.Text = "600";  // 设置一个默认的Vpp
            par.pAmplitude = 600;
            textBoxAmp.TextChanged += (obj, e) =>
            {
                par.pAmplitude = int.Parse(textBoxAmp.Text.ToString());
            };

            textBoxBERTime.Text = "10";  //默认测试时间string
            par.pBERTime = int.Parse(textBoxBERTime.Text); //默认测试时间int
            textBoxBERTime.TextChanged += (obj, e) =>
            {
                par.pBERTime = int.Parse(textBoxBERTime.Text);
            };

            BarPreCousor.Value = 0;  // 初始化配置PreCousor滑条
            LabelPreCousor.Text = BarPreCousor.Value.ToString() + '%';
            BarPreCousor.Scroll += (sender, e) =>  //绑定实时滑动的事件，刷新滑动后的显示值
            {
                LabelPreCousor.Text = BarPreCousor.Value.ToString() + "%";
                par.pPreCursor = int.Parse(BarPreCousor.Value.ToString());
            };

            BarPostCousor.Value = 0;  // 初始化配置PostCousor滑条
            LabelPostCousor.Text = BarPostCousor.Value.ToString() + '%';
            BarPostCousor.Scroll += (sender, e) =>  //绑定实时滑动的事件，刷新滑动后的显示值
            {
                LabelPostCousor.Text = BarPostCousor.Value.ToString() + "%";
                par.pPostCursor = int.Parse(BarPostCousor.Value.ToString());
            };

            BarUpperEye.Value = 0;  // 初始化配置upper eye滑条
            LabelUpperEye.Text = BarUpperEye.Value.ToString() + '%';
            BarUpperEye.Scroll += (sender, e) =>  //绑定实时滑动的事件，刷新滑动后的显示值
            {
                LabelUpperEye.Text = BarUpperEye.Value.ToString() + "%";
                par.pUpperEye = int.Parse(BarUpperEye.Value.ToString());
            };

            BarLowerEye.Value = 0;  // 初始化配置lower eye滑条
            LabelLowerEye.Text = BarLowerEye.Value.ToString() + '%';
            BarLowerEye.Scroll += (sender, e) =>  //绑定实时滑动的事件，刷新滑动后的显示值
            {
                LabelLowerEye.Text = BarLowerEye.Value.ToString() + "%";
                par.pLowerEye = int.Parse(BarLowerEye.Value.ToString());
            };
        }

        private void TextBoxBERTime_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region【ATTset】
        public void AttSet()  //初始化ATT
        {
            comboBoxWaveLength.Items.Clear();
            comboBoxWaveLength.Items.AddRange(Exfo.waveLength);
            comboBoxWaveLength.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWaveLength.SelectedIndexChanged += new EventHandler((obj, e) =>  //可以简化成下面的
            {
                if (comboBoxWaveLength.SelectedItem != null)
                {
                    par.pWaveLength = int.Parse(comboBoxWaveLength.SelectedItem.ToString());
                }
            });
            comboBoxWaveLength.SelectedIndex = 0;

            BarAtt.Value = 0;
            LabelAtt.Text = BarAtt.Value.ToString() + "dB";
            BarAtt.Scroll += (sender, e) =>
            {
                LabelAtt.Text = BarAtt.Value.ToString() + "dB";
                par.pAtt = float.Parse(BarAtt.Value.ToString());
            };

            textBoxATTStart.Text = "0.5";  //初始化设置
            textBoxATTStop.Text = "3";
            textBoxATTStep.Text = "0.5";
        }
        #endregion

        #region【PPG/ATT TCP connect @ button】
        private async void PPGtcpConnect_Click(object sender, EventArgs e) // PPG button connect
        {
            if (socketComPPG.connectFlagFuc == 0)  // 判断TCP连接
            {
                socketComPPG.Initialize(SubFormConnect.PPGserverAddressValue, SubFormConnect.PPGserverPortValue);
                await socketComPPG.Connect();  //打开TCP
                if (socketComPPG.connectFlagFuc == 0) // 如果连接之后，连接状态还是false，说明超时，未连接成功。
                {
                    PPGtcpConnect.Text = "Disconnect";
                }

                else  //如果为true，说明连接成功。
                {
                    PPGtcpConnect.Text = "Connected";
                }
            }

            else  // 判断TCP连接
            {
                socketComPPG.Close();  //打开TCP
                PPGtcpConnect.Text = "Disconnect";
            }
        }
        private async void ATTtcpConnect_Click(object sender, EventArgs e)  // ATT button connect
        {
            if (socketcomATT.connectFlagFuc == 0)  // 判断TCP连接
            {
                socketcomATT.Initialize(SubFormConnect.ATTserverAddressValue, SubFormConnect.ATTserverPortValue);
                await socketcomATT.Connect();  //打开TCP
                
                if (socketcomATT.connectFlagFuc == 0) // 如果连接之后，连接状态还是false，说明超时，未连接成功。
                {
                    ATTtcpConnect.Text = "DisConnected";
                }

                else  //如果为true，说明连接成功。
                {
                    ATTtcpConnect.Text = "Connected";
                }
            }

            else  // 判断TCP连接
            {
                socketcomATT.Close();  //打开TCP
                socketcomATT.connectFlagFuc = 0;
                ATTtcpConnect.Text = "Disconnect";
            }
        }
        #endregion

        #region【PPG ON/OFF event】
        public void InitPPG()
        {
            checkPPG.SetItemChecked(1, true);  // 默认选中的是OFF
            checkPPG.ItemCheck += CheckPPG_ItemCheck;  //checklistbox的变更订阅事件，传递给事件的传递方法为CheckPPG_ItemCheck
        }  
        private void CheckPPG_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)  // 如果当前有选项处于选中
            {
                if (e.Index == 0)  // PPG ON
                {
                    checkPPG.SetItemChecked (1, false);  //如果ON被勾选，OFF就配置为不勾选。
                    excutePPGon();  // event ON
                }

                else               // PPG OFF
                {
                    checkPPG.SetItemChecked (0, false);  //如果OFF被勾选，ON就配置为不勾选。
                    excutePPGoff();  // event OFF
                }
            } 
        }

        private void excutePPGon()  // PPG open func
        {
            socketComPPG.SendData(configPPG.SwitchPPGEDOptions(par.pMode));  //写入PPG选择模式
            Thread.Sleep(10); //延时10ms

            socketComPPG.SendData(configPPG.SetBAConfigAdvV2(par.pModulation, par.pSymbolRate, par.pClockRatio));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetPattern(par.pTestPattern));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.Update7Taps(par.pPreCursor, par.pAmplitude, par.pPostCursor, par.pUpperEye, par.pLowerEye));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetRXSensitivity());
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetBERSettings(par.pBERTime));  //设置测试模式和测试时间 10s测试结束
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.ClearBERTest());  // 清除BER
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.StartBERTest());  //启动BER测试
            Thread.Sleep(10);
        }

        private void excutePPGoff()  // PPG close func
        {
            socketComPPG.SendData(configPPG.ClearBERTest());  // 清除BER
            socketComPPG.SendData(configPPG.StopBERTest());  //关闭PPG
        }

        private void buttonBERRefresh_Click(object sender, EventArgs e)  // PPG refresh@open func
        {
            socketComPPG.SendData(configPPG.SwitchPPGEDOptions(par.pMode));  //写入PPG选择模式
            Thread.Sleep(10); //延时10ms

            socketComPPG.SendData(configPPG.SetBAConfigAdvV2(par.pModulation, par.pSymbolRate, par.pClockRatio));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetPattern(par.pTestPattern));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.Update7Taps(par.pPreCursor, par.pAmplitude, par.pPostCursor, par.pUpperEye, par.pLowerEye));
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetRXSensitivity());
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.SetBERSettings(par.pBERTime));  //设置测试模式和测试时间 10s测试结束
            MessageBox.Show(
                par.pBERTime.ToString(),
                "notice",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.ClearBERTest());  // 清除BER
            Thread.Sleep(10);

            socketComPPG.SendData(configPPG.StartBERTest());  // 启动BER测试
            Thread.Sleep(10);
        }

        #endregion

        #region【save读取BER，基于测试停止】
        private async void saveBERButt_Click(object sender, EventArgs e)  //基于不阻塞程序使用async/await 异步
        {
            socketComPPG.SendData(configPPG.IsBERTRunning());  //发送命令检查BER有么有测试停止
            StringBuilder BERTestStatu = await socketComPPG.ReceiveData();  // 接收返回数据

            try
            {
                if (BERTestStatu == null)
                {
                    MessageBox.Show("BERTestStatu is null", "BERTestStatu Notice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;  //return 退出方法
                }

                if (BERTestStatu != null)
                {
                    char BERTestStatu31 = BERTestStatu[31];  //取出第31位字符，也就是BERteststatu的判断位

                    if (BERTestStatu31 == '1')  ////为1 代表BER Testing
                    {
                        MessageBox.Show("BER Testing", "BERTestStatu Notice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }

                    if (BERTestStatu31 == '0')  //为0 代表BER Test Done
                    {
                        socketComPPG.SendData(configPPG.ReadBERResult(par.pChannel));  //生成选中CH的BER读取命令
                        await Task.Delay(10);  // 异步等待10ms

                        StringBuilder BERResult = await Task.Run(() => socketComPPG.ReceiveData());  //接收的BER显示到BERlabel
                        BERlabel.Text = BERResult.ToString();  // 赋值到label

                        MessageBox.Show(  // 检测有没有接收到数据，可删除
                            BERlabel.Text,
                            "notice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                }    
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }
        #endregion

        #region【ATT open or close】
        private async void attOutput_Click(object sender, EventArgs e)
        {
            if (ATTFlag == 0)
            {
                socketcomATT.SendData(configATT.wlChange(par.pWaveLength));  //配置波长
                await Task.Delay(10);

                socketcomATT.SendData(configATT.ATTMode());  //配置功率模式，遍历衰减还是遍历功率
                await Task.Delay(10);

                socketcomATT.SendData(configATT.OperateMode());  //配置输出模式
                await Task.Delay(10);

                socketcomATT.SendData(configATT.ATTOpen());  //打开光衰输出
                await Task.Delay(10);

                ATTFlag = 1;
                attOutput.Text = "Outputing";

                double ATTStart = double.Parse(textBoxATTStart.Text);  //获取面板配置
                double ATTStop = double.Parse(textBoxATTStop.Text);
                double ATTStep = double.Parse(textBoxATTStep.Text);

                for (double i0 = ATTStart; i0 <= ATTStop; i0 += ATTStep)
                {
                    LabelAtt.Text = i0.ToString() + "dB";
                    socketcomATT.SendData(configATT.ATTlevel(i0));  //配置衰减量级
                    await Task.Delay(1000);
                }
            }

            else
            {
                socketcomATT.SendData(configATT.ATTClose());
                await Task.Delay(10);
                ATTFlag = 0;
                attOutput.Text = "Closed";

                socketcomATT.SendData("*IDN?\r\n");
                await Task.Delay(10);
                await socketcomATT.ReceiveData();

                MessageBox.Show(socketcomATT.receivedData.ToString(), "Device info");

            }
        }
        #endregion
    }
}
