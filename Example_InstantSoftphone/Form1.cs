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
 * @see http://sites.google.com/site/sipekvoip/Home/documentation/tutorial
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common.CallControl;
using Sipek.Sip;
using Sipek.Common;

namespace InstantSoftphone
{
  public partial class Form1 : Form
  {
    #region Properties
    // Get call manager instance
    CCallManager CallManager
    {
      get { return CCallManager.Instance; }
    }

    private PhoneConfig _config = new PhoneConfig();
    internal PhoneConfig Config
    {
      get { return _config; }
    }

    private IStateMachine _call = null;

    #endregion

    #region Constructor
    public Form1()
    {
      InitializeComponent();

      // register callbacks
      CallManager.CallStateRefresh += new DCallStateRefresh(CallManager_CallStateRefresh);
      pjsipRegistrar.Instance.AccountStateChanged += new Sipek.Common.DAccountStateChanged(Instance_AccountStateChanged);

      // Inject VoIP stack engine to CallManager
      CallManager.StackProxy = pjsipStackProxy.Instance;
      //CallManager.Factory = new PhoneFactory(this);
      //CallManager.MediaProxy = new CMediaPlayerProxy();

      // Inject configuration settings SipekSdk
      CallManager.Config = Config;
      pjsipStackProxy.Instance.Config = Config;
      pjsipRegistrar.Instance.Config = Config;
      
      // Initialize
      CallManager.Initialize();
      // register accounts...
      pjsipRegistrar.Instance.registerAccounts();
    }
    #endregion

    #region Callbacks
    void Instance_AccountStateChanged(int accountId, int accState)
    {
      // MUST synchronize threads
      if (InvokeRequired)
        this.BeginInvoke(new DAccountStateChanged(OnRegistrationUpdate), new object[] { accountId, accState});
      else
        OnRegistrationUpdate(accountId, accState);
    }


    void CallManager_CallStateRefresh(int sessionId)
    {
      // MUST synchronize threads
      if (InvokeRequired)
        this.BeginInvoke(new DCallStateRefresh(OnStateUpdate), new object[] { sessionId });
      else
        OnStateUpdate(sessionId);
    }
    #endregion

    #region Synhronized callbacks
    private void OnRegistrationUpdate(int accountId, int accState)
    {
      textBoxRegState.Text = accState.ToString();
    }

    private void OnStateUpdate(int sessionId)
    {
      textBoxCallState.Text = CallManager.getCall(sessionId).StateId.ToString();
    }
    #endregion

    #region Button Handlers
    private void buttonMakeCall_Click(object sender, EventArgs e)
    {
      _call = CallManager.createOutboundCall(textBoxDial.Text);
    }

    private void buttonReleaseCall_Click(object sender, EventArgs e)
    {
      textBoxDial.Clear();
      CallManager.onUserRelease(_call.Session);
    }
    #endregion
  }
}