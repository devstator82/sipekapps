/* 
 * Copyright (C) 2008 Sasa Coh <sasacoh@gmail.com>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 
 * 
 * 
 * @see http://sipekphone.googlepages.com/pjsipwrapper
 * @see http://voipengine.googlepages.com/
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common;
using Sipek.Common.CallControl;

namespace SipekMobile
{
    public partial class SettingsForm : Form
    {

      CCallManager CallManager
      {
        get { return CCallManager.Instance; }
      }

      PhoneConfig _config;
      IConfiguratorInterface Config
      {
        get { return _config; }
      }

      #region Configuration 
      internal class PhoneConfig : IConfiguratorInterface
      {

        List<IAccount> _acclist = new List<IAccount>();
        SettingsForm _form;

        internal PhoneConfig(SettingsForm form)
        {
          _form = form;
          _acclist.Add(new AccountConfig(form));
        }

        #region IConfiguratorInterface Members

        public bool AAFlag
        {
          get
          {
            return false;
          }
          set
          {
            ;
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
            return false;
          }
          set
          {
            ;
          }
        }

        public string CFBNumber
        {
          get
          {
            return "";
          }
          set
          {
            ;
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
            ;
          }
        }

        public string CFNRNumber
        {
          get
          {
            return "";
          }
          set
          {
            ;
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
            ;
          }
        }

        public string CFUNumber
        {
          get
          {
            return "";
          }
          set
          {
            ;
          }
        }

        public List<string> CodecList
        {
          get
          {
            List<string> cl = new List<string>();
            cl.Add("PCMU");
            return cl;
          }
          set
          {
            ;
          }
        }

        public bool DNDFlag
        {
          get
          {
            return false;
          }
          set
          {
            ;
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
            return false;
          }
          set
          {
            ;
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
            ;
          }
        }

        public void Save()
        {
          ;
        }

        #endregion
      }

      class AccountConfig : IAccount
      {
        SettingsForm _form;
        public AccountConfig(SettingsForm form)
        {
          _form = form;
        }

        #region IAccount Members

        public string AccountName
        {
          get
          {
            return "";
          }
          set{}
        }

        public string DisplayName
        {
          get
          {
            return "Sipek Instant Softphone";
          }
          set{}
        }

        public string DomainName
        {
          get
          {
            return "*";
          }
          set{}
        }

        public string HostName
        {
          get
          {
            return _form.textBoxDomain.Text;
          }
          set {}
        }

        public string Id
        {
          get
          {
            return "myId";
          }
          set {}
        }

        public int Index
        {
          get
          {
            return 0;
          }
          set {}
        }

        public string Password
        {
          get
          {
            return _form.textBoxPW.Text;
          }
          set {}
        }

        public string ProxyAddress
        {
          get
          {
            return "";
          }
          set {}
        }

        public int RegState
        {
          get
          {
            return 0; 
          }
          set {}
        }

        public ETransportMode TransportMode
        {
          get
          {
            return ETransportMode.TM_UDP;
          }
          set {}
        }

        public string UserName
        {
          get
          {
            return _form.textBoxUserName.Text;
          }
          set {}
        }

        #endregion
      }
      #endregion


      public SettingsForm()
      {
        InitializeComponent();

        _config = new PhoneConfig(this);

        CallManager.StackProxy = pjsipStackProxy.Instance;

        CallManager.Config = Config;
        pjsipStackProxy.Instance.Config = Config;
        pjsipRegistrar.Instance.Config = Config;

        //  register event for registration status change
        pjsipRegistrar.Instance.AccountStateChanged += new DAccountStateChanged(proxy_AccountStateChanged);

        //pjsipStackProxy.Instance.ConfigMore.stunServer = "stun.siol.net";

        pjsipStackProxy.Instance.initialize();
        CallManager.Initialize();
        pjsipStackProxy.Instance.MessageWaitingIndication += new DMessageWaitingNotification(Instance_MessageWaitingIndication);
      }

      void Instance_MessageWaitingIndication(int mwi, string text)
      {
        //int i = text.Length;
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
            this.statusBar1.Text = accState.ToString();

            if (accState == 200)
            {
                int index = Config.Accounts[Config.DefaultAccountIndex].Index;

                (new PhoneForm(index, Config.Accounts[index].HostName)).Show();
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
          this.statusBar1.Text = "Waiting...";
          this.Refresh();

          // regsiter
          pjsipRegistrar.Instance.registerAccounts();
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
        pjsipStackProxy.Instance.shutdown();
        Close();
          //try
          //{
          //    System.Diagnostics.Process.GetCurrentProcess().Kill();
          //}
          //catch (Exception j)
          //{ }

      }

    }
}