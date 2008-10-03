using System;
//using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common;
using Sipek.Common.CallControl;

namespace vmhtStackProject
{
    public partial class RegisterForm : Form
    {

      internal class PhoneConfig : IConfiguratorInterface
      {

        List<IAccount> _acclist = new List<IAccount>();
        RegisterForm _form;

        internal PhoneConfig(RegisterForm form)
        {
          _form = form;
          _acclist.Add(new AccountConfig(form));
        }

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
          get { return _acclist; }
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
            return false;
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
            return false;
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
          get { return 0; }
        }

        public bool IsNull
        {
          get { return false; }
        }

        public bool PublishEnabled
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

        public int SIPPort
        {
          get
          {
            return 5060;
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

        #endregion
      }

      class AccountConfig : IAccount
      {
        RegisterForm _form;
        public AccountConfig(RegisterForm form)
        {
          _form = form;
        }

        #region IAccount Members

        public string AccountName
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

        public string DisplayName
        {
          get
          {
            return "Sipek Instant Softphone";
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        public string DomainName
        {
          get
          {
            return "*";
          }
          set
          {
            //throw new Exception("The method or operation is not implemented.");
          }
        }

        public string HostName
        {
          get
          {
            return _form.textBoxDomain.Text;
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        public string Id
        {
          get
          {
            return "myId";
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
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

        public string Password
        {
          get
          {
            return _form.textBoxPW.Text;
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        public string ProxyAddress
        {
          get
          {
            return "";
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        public int RegState
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

        public ETransportMode TransportMode
        {
          get
          {
            return ETransportMode.TM_UDP;
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        public string UserName
        {
          get
          {
            return _form.textBoxUserName.Text;
          }
          set
          {
            throw new Exception("The method or operation is not implemented.");
          }
        }

        #endregion
      }

        #region Inner class (Account data holder)

        //class MyAccount : IAccount
        //{
        //    RegisterForm _form;


        //    public MyAccount(RegisterForm form)
        //    {
        //        _form = form;
        //    }

        //    #region IAccount Members

        //    public string AccountName
        //    {
        //        get { return _form.textBoxUserName.Text; }//"200"; }
        //        set { }
        //    }

        //    public string DisplayName
        //    {
        //        get { return ""; }
        //        set { }
        //    }

        //    public string DomainName
        //    {
        //        get { return "*"; }//"129.0.0.82:5060";}
        //        set { }
        //    }

        //    public string HostName
        //    {
        //        get { return _form.textBoxDomain.Text; }// "129.0.0.82:5060"; }//return "sip:129.0.0.82:5060";}
        //        set { }
        //    }

        //    public string Id
        //    {
        //        get { return _form.textBoxUserName.Text; }//"200"; }
        //        set { }
        //    }

        //    public string Password
        //    {
        //        get { return _form.textBoxPW.Text; }// "200"; }
        //        set { }
        //    }

        //    public string ProxyAddress
        //    {
        //        get { return ""; }
        //        set { }
        //    }

        //    public int RegState
        //    {
        //        get { return 0; }
        //        set { }
        //    }

        //    public string UserName
        //    {
        //        get { return _form.textBoxUserName.Text; }// "200"; }
        //        set { }
        //    }
        //    public int Index
        //    {
        //        get
        //        {
        //            return 0;
        //        }
        //        set
        //        {
        //            ;
        //        }
        //    }

        //    public ETransportMode TransportMode
        //    {
        //        get
        //        {
        //            return ETransportMode.TM_UDP;
        //        }
        //        set
        //        {
        //            ;
        //        }
        //    }

        //    #endregion
        //}

        #endregion


        pjsipRegistrar register = pjsipRegistrar.Instance;
        int indexparameter;
        String host;

      CCallManager CallManager
      {
        get { return CCallManager.Instance; }
      }

      PhoneConfig _config;
      IConfiguratorInterface Config
      {
        get { return _config;  }
      }

        public RegisterForm()
        {
            InitializeComponent();

            _config = new PhoneConfig(this);

            CallManager.StackProxy = pjsipStackProxy.Instance;

            CallManager.Config = Config;
            pjsipStackProxy.Instance.Config = Config;
            pjsipRegistrar.Instance.Config = Config;




            pjsipStackProxy.Instance.initialize();
            CallManager.Initialize();

            //  register event for registration status change
            register.AccountStateChanged += new DAccountStateChanged(proxy_AccountStateChanged);
            
            // collect account data from windows form 
            //acc = new MyAccount(this);


            // clean previous accounts (if any)
            //register.Config.Accounts.Clear();

            // add account data holder to proxy!
            //register.Config.Accounts.Add(acc);
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
                Invoke(new DAccountStateChanged(proxy_AccountStateChanged), new object[] { accountId, accState });
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
            if (accState != 0)
            {
                this.textBoxStatus.Text = accState.ToString();

                if (accState == 200)
                {
                    indexparameter = register.Config.Accounts[register.Config.DefaultAccountIndex].Index;
                    host = register.Config.Accounts[register.Config.DefaultAccountIndex].HostName;

                    CallForm l = new CallForm(indexparameter, host);
                    l.Show();
                  

                }
                else if (accState == 408)
                {

                    MessageBox.Show("Request Timeout");

                }
                else
                {
                    MessageBox.Show("Registration failed");
                }

            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.textBoxStatus.Text = "Waiting...";
            this.Refresh();

            //MessageBox.Show(registrar.Config.Accounts[0].Index.ToString());
            // send register request
            register.registerAccounts();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception j)
            { }

        }

      private void menuItem1_Click(object sender, EventArgs e)
      {
        Close();
      }

      private void menuItem2_Click(object sender, EventArgs e)
      {
        registerButton_Click(sender, e);
      }

      private void menuItem3_Click(object sender, EventArgs e)
      {
        exitButton_Click(sender, e);
      }

    }
}