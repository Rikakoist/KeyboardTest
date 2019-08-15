using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;

namespace KeyboardTest
{
    public partial class KeyBoardWindow : Form
    {
        public int dropDownX = 0;
        public int dropDownY = 0;
        public int dropUpX = 0;
        public int dropUpY = 0;

        public int btnSizeX = 0;
        public int btnSizeY = 0;
        public int btnSPX = 0;
        public int btnSPY = 0;
        public int btnDis = 0;
        public int btnIDS = 0;
        public int batchN = 0;

        public List<String> btns = new List<String>();
        public String nowJson;

        public KeyBoardWindow()
        {
            InitializeComponent();
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Init(object sender, EventArgs e)
        {
            //List<Buttons> Bt = new List<Buttons>();
            //for (int i = 0; i < 255; i++)
            //{
            //    Bt.Add(new Buttons { Value = i, Tested = false });
            //}
        }



        private void ShowKeyCode(object sender, KeyEventArgs e)
        {
            try
            {
                CodeResultLabel.Text = e.KeyCode.ToString();
                DataResultLabel.Text = e.KeyData.ToString();
                ValueResultLabel.Text = e.KeyValue.ToString();
                foreach (Control Buttons in this.Controls)
                {
                    if (Buttons is Button)
                    {
                        if (Buttons.Text == ValueResultLabel.Text)
                        {
                            Buttons.BackColor = Color.Orange;
                        }
                    }
                }

                ButtonHistory.AppendText("Code = " + e.KeyCode.ToString() + ", Data = " + e.KeyData.ToString() + ", Value = " + e.KeyValue.ToString() + "\r\n");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dropDownX = e.X;
            dropDownY = e.Y;
            DropHistory.AppendText("MouseDown at (" + dropDownX + "," + dropDownY + ")\r\n");
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dropUpX = e.X;
            dropUpY = e.Y;
            DropHistory.AppendText("MouseUp at (" + dropDownX + "," + dropDownY + ")\r\n");
            DropHistory.AppendText("(" + dropDownX + "," + dropDownY + ") -> (" + dropUpX + "," + dropUpY + ")\r\n");
            DropHistory.AppendText("(" + (dropUpX - dropDownX) + "," + (dropUpY - dropDownY) + ")\r\n");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String cmd = cmdList.Text;
            String arg = argBox.Text;
            if (arg.Equals("")){
                if (cmd.Equals("start")){
                    Console.AppendText("Started.\r\n");
                    for(int i = 0; i < batchN; i++)
                    {
                        mButton tmpBtn = new mButton(btnSPX + (i * (btnDis + btnSizeX)), btnSPY, btnSizeX, btnSizeY);
                        drawButton(tmpBtn);
                        addBtnIntoConfig(convertIntoJson(tmpBtn));
                    }
                    Output.AppendText(nowJson);
                    Output.AppendText("\r\n============================================\r\n");
                    Output.AppendText(btnSizeX + "|" + btnSizeY + "|" + btnSPX + "|" + btnSPY + "|" + btnDis + "|" + btnIDS + "|" + batchN + "\r\n");
                    Output.AppendText("============================================\r\n");
                }
                else if (cmd.Equals("reset")){
                    resetDraw();
                } else { 
                    Console.AppendText("Arg input is unacceptable with this Cmd!\r\n");
                    return;
                }
            } else {
                if (cmd.Equals("setButtonSize")){
                    String[] args = arg.Split(',');
                    btnSizeX = int.Parse(args[0]); //MAY CRASH DUE TO YOUR WRONG INPUT!!!
                    btnSizeY = int.Parse(args[1]);
                    Console.AppendText("Button size is set to (" + args[0] + "," + args[1] + ") " + ".\r\n");
                }
                else if (cmd.Equals("setButtonStartPos")){
                    String[] args = arg.Split(',');
                    btnSPX = int.Parse(args[0]); //MAY CRASH DUE TO YOUR WRONG INPUT!!!
                    btnSPY = int.Parse(args[1]);
                    Console.AppendText("ButtonStartPos is set to (" + args[0] + "," + args[1] + ") " + ".\r\n");
                }else if (cmd.Equals("setButtonIDStart")){
                    int args = 0;
                    if (!int.TryParse(arg, out args))
                    {
                        Console.AppendText("Arg input is unacceptable with this Cmd!\r\n");
                        return;
                    }
                    btnIDS = args;
                    Console.AppendText("Button enum start ID is set to " + args + ".\r\n");
                }
                else if (cmd.Equals("setButtonDis")){
                    int args = 0;
                    if (!int.TryParse(arg, out args))
                    {
                        Console.AppendText("Arg input is unacceptable with this Cmd!\r\n");
                        return;
                    }
                    btnDis = args;
                    Console.AppendText("Distance between buttons is set to " + args + ".\r\n");
                }
                else if (cmd.Equals("setBatchNum")){
                    int args = 0;
                    if (!int.TryParse(arg, out args))
                    {
                        Console.AppendText("Arg input is unacceptable with this Cmd!\r\n");
                        return;
                    }
                    batchN = args;
                    Console.AppendText("Batch nums is set to " + args + ".\r\n");
                }
            }
        }

        private void CmdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if(CB.Text.Equals("setButtonStartPos") || CB.Text.Equals("setButtonSize"))
            {
                warning.Visible = true;
                return;
            }
            warning.Visible = false;
            return;
        }
        private void drawButton(mButton toBeDraw)
        {
            Graphics g = panel1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            Rectangle ra = new Rectangle(toBeDraw.btnX, toBeDraw.btnY, toBeDraw.btnW, toBeDraw.btnH);
            g.FillRectangle(sb,ra);
            sb.Dispose();
            g.Dispose();
        }
        private void drawButtonByConfig(String json)
        {
            int i = 0;
            List<String> btnsInList = JsonConvert.DeserializeObject<List<String>>(json);
            btnsInList.ForEach(tmpStr => drawButton(new mButton(JsonConvert.DeserializeObject<mButtonItem>(tmpStr))));
        }
        private void resetDraw()
        {
            nowJson = "";
            btns = new List<string>();
            Graphics g = panel1.CreateGraphics();
            panel1.Invalidate();
            Console.AppendText("Reset.\r\n");

        }
        private String convertIntoJson(mButton toBeConvert)
        {
            mButtonItem mbi = new mButtonItem();
            mbi.X = toBeConvert.btnX;
            mbi.Y = toBeConvert.btnY;
            mbi.W = toBeConvert.btnW;
            mbi.H = toBeConvert.btnH;
            return JsonConvert.SerializeObject(mbi);
        }
        private void addBtnIntoConfig(String json)
        {
            btns.Add(json);
            nowJson = JsonConvert.SerializeObject(btns);
        }

        private void DrawOnly_Click(object sender, EventArgs e)
        {
            drawButtonByConfig(importJson.Text);
        }

        private void ImportConfigAndDraw_Click(object sender, EventArgs e)
        {
            String[] config = importConfig.Text.Split('|');
            cmdList.Text = "setButtonSize";argBox.Text = config[0] + "," + config[1];Submit_Click(null, null);
            cmdList.Text = "setButtonStartPos";argBox.Text = config[2] + "," + config[3];Submit_Click(null, null);
            cmdList.Text = "setButtonIDStart";argBox.Text = config[5];Submit_Click(null, null);
            cmdList.Text = "setButtonDis";argBox.Text = config[4];Submit_Click(null, null);
            cmdList.Text = "setBatchNum";argBox.Text = config[6];Submit_Click(null, null);
            cmdList.Text = "reset";argBox.Text = "";
        }
    }
}



