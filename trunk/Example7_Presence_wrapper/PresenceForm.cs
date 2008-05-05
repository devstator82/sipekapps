using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common;

namespace Example7_Presence_wrapper
{
  public partial class PresenceForm : Form
  {
    // store presence instance
    pjsipPresenceAndMessaging messenger = pjsipPresenceAndMessaging.Instance;

    public PresenceForm()
    {
      InitializeComponent();

      // fill pjsip statuses to combo box
      comboBoxPresence.Items.AddRange(new object[] 
        { EUserStatus.AVAILABLE, 
          EUserStatus.BUSY, 
          EUserStatus.OTP, 
          EUserStatus.IDLE, 
          EUserStatus.AWAY, 
          EUserStatus.BRB, 
          EUserStatus.OFFLINE });

      // Initialize pjsip stack
      pjsipStackProxy.Instance.initialize();
      // add test buddy
      messenger.addBuddy("sip:buddy1@127.0.0.1", true, 0);

      //  register for status change event
      messenger.BuddyStatusChanged += new DBuddyStatusChanged(messenger_BuddyStatusChanged);
    }

    void messenger_BuddyStatusChanged(int buddyId, int status, string text)
    {
      if (this.InvokeRequired)
      {
        Invoke(new DBuddyStatusChanged(sync_BuddyStatusChanged), new object[] { buddyId, status, text });
      }
      else
      {
        sync_BuddyStatusChanged(buddyId, status, text);
      }
    }

    /// <summary>
    /// Update buddy status status
    /// </summary>
    /// <param name="accId"></param>
    /// <param name="accState"></param>
    private void sync_BuddyStatusChanged(int buddyId, int status, string text)
    {
      textBoxStatus.Text = text;
    }

    private void comboBoxPresence_SelectedIndexChanged(object sender, EventArgs e)
    {
      //comboBoxPresence.SelectedIndex
      if (comboBoxPresence.SelectedIndex > -1)
      messenger.setStatus(1, (EUserStatus)comboBoxPresence.SelectedIndex );
    }


  }

}