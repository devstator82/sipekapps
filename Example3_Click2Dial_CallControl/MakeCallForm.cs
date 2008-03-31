using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common.CallControl;
using Sipek.Sip;

namespace Example3_makeCall_CallControl
{
  public partial class MakeCallForm : Form
  {
    CCallManager manager;

    public MakeCallForm()
    {
      InitializeComponent();

      // initialize Call Control
      manager = CCallManager.getInstance();
      // Assign pjsipWrapper instance as abstractProxy 
      manager.Factory.CommonProxy = CSipCommonProxy.GetInstance();
      // initialize Call Control
      manager.Initialize();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // create call
      CStateMachine call = manager.createOutboundCall("1234");
      // show the result
      int sessionId = (call == null ? -1 : call.Session); 
      label2.Text = (sessionId >= 0 ? "Success" : "Failed") + " (" + sessionId + ")";

    }
  }
}