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
using Sipek.Common;
using Sipek.Sip;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Sipek.Common.CallControl;
//using System.Media;

namespace SipekMobile
{
    public partial class PhoneForm : Form
    {
      //SoundPlayer player = new SoundPlayer("\\Program Files\\vmhtStackProject\\Alarm5.wav");
      //SoundPlayer playerTone = new SoundPlayer("\\Program Files\\vmhtStackProject\\ringout.wav");
      IStateMachine _currentCall;

      CCallManager CallManager
      {
        get { return CCallManager.Instance; }
      }

        
      private void sync_StateChanged(int sessionId)
      {
        statusBar1.Text = CallManager.getCall(sessionId).StateId.ToString();
      }
     
      public PhoneForm(int indexparameter, String host)
      {
        InitializeComponent();
          
        // register callback
        CallManager.CallStateRefresh += new DCallStateRefresh(CallManager_CallStateRefresh);
      }

      void CallManager_CallStateRefresh(int sessionId)
      {
        if (this.InvokeRequired)
        {
          Invoke(new DCallStateRefresh(sync_StateChanged), new object[] { sessionId });
        }
        else
        {
          sync_StateChanged(sessionId);
        }
      }

      private void callButton_Click(object sender, EventArgs e)
      {
          _currentCall = CallManager.createOutboundCall(textBoxNumber.Text);
      }


      private void releaseButton_Click(object sender, EventArgs e)
      {
          try
          {
            CallManager.onUserRelease(_currentCall.Session);

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

    }
}