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
    CCallManager _manager;

    public MakeCallForm()
    {
      InitializeComponent();

      // initialize Call Control
      _manager = CCallManager.getInstance();
      
      // Assign pjsipWrapper instance as abstractProxy 
      _manager.Factory.CommonProxy = CSipCommonProxy.GetInstance(); ;
      // initialize Call Control
      _manager.Initialize();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // create call
      CStateMachine call = _manager.createOutboundCall(textBox1.Text);
      // show the result
      int sessionId = (call == null ? -1 : call.Session); 
      label2.Text = (sessionId >= 0 ? "Success" : "Failed") + " (" + sessionId + ")";

    }

  }
}