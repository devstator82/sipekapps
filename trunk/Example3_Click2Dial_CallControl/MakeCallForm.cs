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

namespace Example3_makeCall_CallControl
{

  public partial class MakeCallForm : Form
  {
    // create factory
    CCallManager _manager = CCallManager.Instance;

    public MakeCallForm()
    {
      InitializeComponent();

      // initialize Call Control and assign pjsip wrapper instance
      _manager.Initialize(pjsipStackProxy.Instance);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // create call
      IStateMachine call = _manager.createOutboundCall(textBox1.Text);
      // show the result
      int sessionId = (call == null ? -1 : call.Session); 
      label2.Text = (sessionId >= 0 ? "Success" : "Failed") + " (" + sessionId + ")";

    }

  }
}