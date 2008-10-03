using System;
//using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;
using Sipek.Sip;
using System.Runtime.InteropServices;
using System.Diagnostics;
//using System.Media;

namespace vmhtStackProject
{
    public partial class CallForm : Form
    {
        ICallProxyInterface call;
        //SoundPlayer player = new SoundPlayer("\\Program Files\\vmhtStackProject\\Alarm5.wav");
        //SoundPlayer playerTone = new SoundPlayer("\\Program Files\\vmhtStackProject\\ringout.wav");
        bool incomingEnable = false;
        bool confirmedEnable = false;
        int numberCallLost = 0;
              
        //call back state changed
        void proxy_stateChanged(int callId, ESessionState callState, string info)
        {
            if (this.InvokeRequired)
            {
                Invoke(new DCallStateChanged(proxy_stateChanged), new object[] { callId, callState, info });
            }
            else
            {
                sync_StateChanged(callId, callState, info);
            }
        }
         
        private void sync_StateChanged(int callId, ESessionState callState, string info)
        {
            textBoxCallState.Text = callState.ToString();

            if (callState == ESessionState.SESSION_STATE_DISCONNECTED && confirmedEnable == true)
            {
                Process.GetCurrentProcess().Close();
                MessageBox.Show("Call Closed!!");
                Process.GetCurrentProcess().Kill();
                
            }else if (callState == ESessionState.SESSION_STATE_DISCONNECTED && incomingEnable == true)
            {
                callState= ESessionState.SESSION_STATE_NULL;
                incomingEnable = false;
                callButton.Visible = true;
                textBoxExtension.Visible = true;
                label1.Visible = true;
                textBoxCallState.Text = "";
                //player.Stop();
                numberCallLost += 1;
                textBoxNumberCallLost.Text = numberCallLost.ToString();

            }if (callState == ESessionState.SESSION_STATE_DISCONNECTED && incomingEnable == false && confirmedEnable == false)
            {
                Process.GetCurrentProcess().Close();
                MessageBox.Show("Service or Option unavailable!!");
                Process.GetCurrentProcess().Kill();
            }

            if(callState == ESessionState.SESSION_STATE_INCOMING)
            {
                answerButton.Visible = true;
                incomingEnable = true;
                //player.PlayLooping();
                callButton.Visible = false;
                textBoxExtension.Visible = false;
                label1.Visible = false;
                textBoxCallState.Text = "Incoming Call!!!";
            }

            if (callState == ESessionState.SESSION_STATE_CALLING)
            {
                //playerTone.PlayLooping();

            }


            if (callState == ESessionState.SESSION_STATE_CONFIRMED)
            {
                //playerTone.Stop();
                confirmedEnable = true;
                incomingEnable = false;
                textBoxCallState.Text = callState.ToString(); 
                this.exitButton.Visible = false;
                this.releaseButton.Visible = true;
            }
        }
       

        int indexparameter;
        String host;
        int sessionId;

        public CallForm(int indexparameter, String host)
        {
            InitializeComponent();
            this.indexparameter = indexparameter;
            this.host = host;
          
            ICallProxyInterface.CallStateChanged += new DCallStateChanged(proxy_stateChanged);
            call = pjsipStackProxy.Instance.createCallProxy();
            
    
      }

        private void callButton_Click(object sender, EventArgs e)
        {
            String userCall = textBoxExtension.Text; //"150";
            String dialed = "sip:" + userCall + "@" + host;
            sessionId = call.makeCall(dialed, indexparameter);

            if (sessionId >= 0)
            {
               answerButton.Visible = false;
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            //player.Stop();
            call.acceptCall();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                call.endCall();

            }
            catch (Exception o)
            { }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception o)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            call.dialDtmf(textBox1.Text, EDtmfMode.DM_Inband);
            textBox1.Text = "";
        }
    }
}