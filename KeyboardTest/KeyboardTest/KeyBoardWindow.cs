using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTest
{
    public partial class KeyBoardWindow : Form
    {
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
                foreach(Control Buttons in this.Controls)
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
    }
}
