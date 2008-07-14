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

  #region Inner class (Account data holder)

  class MyConfig : IConfiguratorInterface
  {
    #region IConfiguratorInterface Members

    public bool AAFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public List<IAccount> Accounts
    {
      get { 
        List<IAccount> accounts = new List<IAccount>();
        accounts.Add(new MyAccount());
        return accounts;
      }
    }

    public bool CFBFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFBNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool CFNRFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFNRNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool CFUFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFUNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public List<string> CodecList
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool DNDFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public int DefaultAccountIndex
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool IsNull
    {
      get { throw new Exception("The method or operation is not implemented."); }
    }

    public int SIPPort
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public void Save()
    {
      throw new Exception("The method or operation is not implemented.");
    }

    public bool PublishEnabled
    {
      get
      {
        return true;
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }
    #endregion

  }

  class MyAccount : IAccount
  {

    #region IAccount Members
    public MyAccount()
    { }

    public string AccountName
    {
      get { return ""; }
      set { }
    }

    public string DisplayName
    {
      get { return ""; }
      set { }
    }

    public string DomainName
    {
      get { return ""; }
      set { }
    }

    public string HostName
    {
      get { return ""; }
      set { }
    }

    public string Id
    {
      get { return ""; }
      set { }
    }

    public string Password
    {
      get { return ""; }
      set { }
    }

    public string ProxyAddress
    {
      get { return ""; }
      set { }
    }

    public int RegState
    {
      get { return 200; }
      set { }
    }

    public string UserName
    {
      get { return ""; }
      set { }
    }
    public int Index
    {
      get
      {
        return 0;
      }
      set
      {
        ;
      }
    }

    public ETransportMode TransportMode
    {
      get
      {
        return ETransportMode.TM_UDP;
      }
      set
      {
        ;
      }
    }

    #endregion
  }

  #endregion


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
      SipConfigStruct.Instance.publishEnabled = true;
      pjsipStackProxy.Instance.initialize();
      messenger.Config = new MyConfig();

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
        messenger.setStatus(0, (EUserStatus)comboBoxPresence.SelectedIndex );
    }


  }

}