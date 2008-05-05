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

    // assign manager instance
    CCallManager _manager = CCallManager.Instance;

    // instance of ouotgoing call
    IStateMachine outcall = null;
    // instance of incoming call
    IStateMachine incall = null;

    public LocalCallForm()
    {
      InitializeComponent();

      // initialize Call Control and assign pjsipWrapper instance 
      _manager.Initialize(pjsipStackProxy.Instance);

      // subscribe to CallStateChanged and CallIncoming events
      _manager.CallStateRefresh += new DCallStateRefresh(_manager_CallStateRefresh);
      _manager.IncomingCallNotification += new DIncomingCallNotification(_manager_IncomingCallNotification);
    }

    /// <summary>
    /// Incoming call callback. Just assign incall.
    /// </summary>
    /// <param name="sessionId"></param>
    /// <param name="number"></param>
    /// <param name="info"></param>
    void _manager_IncomingCallNotification(int sessionId, string number, string info)
    {
      // assign incoming call instance to member variable
      incall = _manager.getCall(sessionId);
    }
    
    /// <summary>
    /// Call state changed
    /// </summary>
    /// <param name="sessionId"></param>
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

    /// <summary>
    /// Update windows controls
    /// </summary>
    /// <param name="sessionId"></param>
    void CallStateRefreshed(int sessionId)
    {
      // sessionId belongs to an outgoing call leg
      if (outcall != null) textBoxOutCallState.Text = outcall.StateId.ToString();

      if (incall != null) textBoxIncCallState.Text = incall.StateId.ToString();
    }

    /// <summary>
    /// Make call click handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonOutCall_Click(object sender, EventArgs e)
    {
      // check number of calls (allow only 1)
      if (_manager.Count > 0) return;

      // create call (local loop)
      outcall = _manager.createOutboundCall("sip:127.0.0.1");
    }

    private void buttonIncRelease_Click(object sender, EventArgs e)
    {
      if (incall != null) _manager.onUserRelease(incall.Session);
    }

    private void buttonIncAnswer_Click(object sender, EventArgs e)
    {
      if (incall != null) _manager.onUserAnswer(incall.Session);
    }

    private void buttonOutRelease_Click(object sender, EventArgs e)
    {
      if (outcall != null) _manager.onUserRelease(outcall.Session);
    }


  }
}