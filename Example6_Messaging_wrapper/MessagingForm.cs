using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common;

namespace Example5_Register_wrapper
{
  public partial class MessagingForm : Form
  {

    pjsipPresenceAndMessaging messenger = pjsipPresenceAndMessaging.Instance;

    public MessagingForm()
    {
      InitializeComponent();

      // Initialize pjsip stack
      pjsipStackProxy.Instance.initialize();

      //  register event for message received event
      messenger.MessageReceived += new DMessageReceived(messenger_MessageReceived);
    }

    void messenger_MessageReceived(string from, string text)
    {
      if (this.InvokeRequired)
      {
        Invoke(new DMessageReceived(sync_EventReceived), new object[] { from, text });
      }
      else
      {
        sync_EventReceived(from, text);
      }
    }

    /// <summary>
    /// Update registration status
    /// </summary>
    /// <param name="accId"></param>
    /// <param name="accState"></param>
    private void sync_EventReceived(string from, string text)
    {
      label2.Text = "Echo from: " + from;
      textBoxReceiver.Text = text;
    }

    private void buttonBuddy1_Click(object sender, EventArgs e)
    {
      messenger.sendMessage("sip:127.0.0.1", textBoxSender.Text, 0);
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
      textBoxSender.Clear();
    }

  }

}