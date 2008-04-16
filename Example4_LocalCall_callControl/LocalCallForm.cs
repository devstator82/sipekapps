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


namespace Example4_LocalCall_callControl
{
  public partial class LocalCallForm : Form
  {
    delegate void DCallStateRefresh(int sessionId);

    // create factory
    CCallManager _manager;

    public LocalCallForm()
    {
      InitializeComponent();
      // initialize Call Control
      _manager = CCallManager.getInstance();

      // Assign pjsipWrapper instance as abstractProxy 
      _manager.Factory.CommonProxy = CSipCommonProxy.GetInstance();
      // initialize Call Control
      _manager.Initialize();
      // subscribe to CallStateChanged event
      _manager.CallStateRefresh += new CCallManager.DCallStateRefresh(_manager_CallStateRefresh);
    }
    
    void _manager_CallStateRefresh(int sessionId)
    {
        if (this.InvokeRequired)
        {
          // synchronize threads
          this.Invoke(new DCallStateRefresh(CallStateRefreshed), new object[] { sessionId });
        }
        else
        {
          CallStateRefreshed(sessionId);
        }
    }

    void CallStateRefreshed(int sessionId)
    {
        // get call instance
        IStateMachine call = _manager.getCall(sessionId);

        // sessionId belongs to an outgoing call leg
        if (sessionId == 0)
        {
          textBoxOutCallState.Text = call.State.ToString();
          textBoxOutCallState.Tag = sessionId;
        }
        else
          if (sessionId == 1) // incoming call leg
          {
            textBoxIncCallState.Text = call.State.ToString();
            textBoxIncCallState.Tag = sessionId;
          }
      }

    private void buttonOutCall_Click(object sender, EventArgs e)
    {
        // check if number of calls (allow only 1)
        if (_manager.Count > 0) return;

        // create call
        IStateMachine call = _manager.createOutboundCall("sip:127.0.0.1");
        // show the result
        int sessionId = (call == null ? -1 : call.Session);
    }

    private void buttonIncRelease_Click(object sender, EventArgs e)
    {
        _manager.onUserRelease((int)textBoxIncCallState.Tag);
    }

    private void buttonIncAnswer_Click(object sender, EventArgs e)
    {
      _manager.onUserAnswer((int)textBoxIncCallState.Tag);
    }

    private void buttonOutRelease_Click(object sender, EventArgs e)
    {
      _manager.onUserRelease((int)textBoxOutCallState.Tag);
    }


  }
}