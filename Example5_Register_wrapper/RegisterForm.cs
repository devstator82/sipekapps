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
  public partial class RegisterForm : Form
  {
    #region Inner class (Account data holder)
    class MyAccount : IAccount
    {
      RegisterForm _form;

      public MyAccount(RegisterForm form)
      {
        _form = form;
      }

      #region IAccount Members

      public string AccountName
      {
        get { return _form.textBoxId.Text; }
        set { }
      }

      public string DisplayName
      {
        get { return ""; }
        set { }
      }

      public string DomainName
      {
        get { return _form.textBoxDomain.Text; }
        set { }
      }

      public string HostName
      {
        get { return _form.textBoxRegistrar.Text; }
        set { }
      }

      public string Id
      { 
        get { return _form.textBoxId.Text; }
        set { }
      }

      public string Password
      {
        get { return _form.textBoxPassword.Text; }
        set { }
      }

      public string ProxyAddress
      {
        get { return ""; }
        set { }
      }

      public int RegState
      {
        get { return 0; }
        set { }
      }

      public string UserName
      {
        get { return _form.textBoxUsername.Text; }
        set { }
      }

      #endregion
    }
    #endregion

    // store registrar proxy instance
    pjsipRegistrar registrar = pjsipRegistrar.Instance;

    public RegisterForm()
    {
      InitializeComponent();

      // Initialize pjsip stack
      pjsipStackProxy.Instance.initialize();

      //  register event for registration status change
      registrar.AccountStateChanged += new DAccountStateChanged(proxy_AccountStateChanged);
    }

    /// <summary>
    /// Invoke status refresh. First check for cross threading!!!
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="accState"></param>
    void proxy_AccountStateChanged(int accountId, int accState)
    {
      if (this.InvokeRequired)
      {
        Invoke(new DAccountStateChanged(proxy_AccountStateChanged), new object[] {accountId, accState});
      }
      else 
      {
        sync_AccountStateChanged(accountId, accState);
      }
    }
    /// <summary>
    /// Update registration status
    /// </summary>
    /// <param name="accId"></param>
    /// <param name="accState"></param>
    private void sync_AccountStateChanged(int accId, int accState)
    {
          this.textBoxStatus.Text = accState.ToString();
    }

    /// <summary>
    /// On click handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonRegister_Click(object sender, EventArgs e)
    {
      // collect account data from windows form 
      MyAccount acc = new MyAccount(this);

      // clean previous accounts (if any)
      registrar.Config.Accounts.Clear();

      // add account data holder to proxy!
      registrar.Config.Accounts.Add(acc);
      
      // send register request
      registrar.registerAccounts();
    }

  }


 

}