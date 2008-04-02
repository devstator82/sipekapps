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
    MyFactory _myFactory = new MyFactory();
    CCallManager _manager;

    public MakeCallForm()
    {
      InitializeComponent();

      // initialize Call Control
      _manager = CCallManager.getInstance();
      
      // Assign pjsipWrapper instance as abstractProxy 
      _myFactory.CommonProxy = CSipCommonProxy.GetInstance();
      // assign factory
      _manager.Factory = _myFactory;
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

    /// <summary>
    /// Simple Abstract proxy implementation
    /// Only IVoipProxy is non nullable. We dont't need others.
    /// </summary>
    public class MyFactory : AbstractFactory
    {
      ICallLogInterface _logger = new NullCallLogger();
      IVoipProxy _proxy = new NullVoipProxy();
      IConfiguratorInterface _config = new NullConfigurator();
      IMediaProxyInterface _media = new NullMediaProxy();

      #region AbstractFactory Members

      public ICallLogInterface CallLogger
      {
        get { return _logger; }
        set { ;}
      }

      public IVoipProxy CommonProxy
      {
        get { return _proxy; }
        set { _proxy = value; }
      }

      public IConfiguratorInterface Configurator
      {
        get { return _config; }
        set { ; }
      }

      public IMediaProxyInterface MediaProxy
      {
        get { return _media; }
        set { ; }
      }

      public ITimer createTimer()
      {
        return new NullTimer();
      }

      #endregion
    }
  }
}