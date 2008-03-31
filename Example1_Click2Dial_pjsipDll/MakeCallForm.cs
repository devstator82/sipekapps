using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Example1_makeCall
{
  public partial class MakeCallForm : Form
  {
    [DllImport("pjsipDll.dll")]
    private static extern int dll_init(int listenPort);
    [DllImport("pjsipDll.dll")]
    private static extern int dll_main();
    [DllImport("pjsipDll.dll")]
    private static extern int dll_makeCall(int accountId, string uri);

    public MakeCallForm()
    {
      InitializeComponent();
      
      // initialize psjip
      int status = dll_init(5060);
      status |= dll_main();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // make outgoing call with no account defined
      int sessionId = dll_makeCall(1, textBox1.Text);

      label2.Text = (sessionId >= 0 ? "Success" : "Failed") + " ("+sessionId+")";
    }
  }
}