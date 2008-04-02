using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common;

namespace Example2_makeCall_abstractWrapper
{
  public partial class MakeCallForm : Form
  {
    CSipCommonProxy proxy;

    public MakeCallForm()
    {
      InitializeComponent();
      // PjsipWrapper initialization
      proxy = CSipCommonProxy.GetInstance();
      proxy.initialize();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // create call proxy ()
      CSipCallProxy call = new CSipCallProxy(new NullConfigurator());
      int sessionId = call.makeCall(textBox1.Text, 1);

      label2.Text = (sessionId >= 0 ? "Success" : "Failed") + " (" + sessionId + ")";
    }
  }
}