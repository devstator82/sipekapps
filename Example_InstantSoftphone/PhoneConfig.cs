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
using System.Text;
using Sipek.Common;

namespace InstantSoftphone
{
  internal class PhoneConfig : IConfiguratorInterface
  {

    List<IAccount> _acclist = new List<IAccount>();

    internal PhoneConfig()
    {
      _acclist.Add(new AccountConfig());
    }

    #region IConfiguratorInterface Members

    public bool AAFlag
    {
      get
      {
        return false;
      }
      set {}
    }

    public List<IAccount> Accounts
    {
      get { return _acclist; }
    }

    public bool CFBFlag
    {
      get
      {
        return false;
      }
      set {}
    }

    public string CFBNumber
    {
      get
      {
        return "";
      }
      set{}
    }

    public bool CFNRFlag
    {
      get
      {
        return false;
      }
      set {}
    }

    public string CFNRNumber
    {
      get
      {
        return "";
      }
      set {}
    }

    public bool CFUFlag
    {
      get
      {
        return false;
      }
      set {}
    }

    public string CFUNumber
    {
      get
      {
        return "";
      }
      set{}
    }

    public List<string> CodecList
    {
      get
      {
        List<String> cl = new List<string>();
        cl.Add("PCMA");
        return cl;
      }
      set {}
    }

    public bool DNDFlag
    {
      get
      {
        return false;
      }
      set{}
    }

    public int DefaultAccountIndex
    {
      get { return 0; }
    }

    public bool IsNull
    {
      get { return false; }
    }

    public bool PublishEnabled
    {
      get
      {
        return false;
      }
      set {}
    }

    public int SIPPort
    {
      get
      {
        return 5060;
      }
      set{}
    }

    public void Save()
    {
      //TODO;
    }

    #endregion
  }

  class AccountConfig : IAccount
  {
    #region IAccount Members

    public string AccountName
    {
      get
      {
        return "Account";
      }
      set{}
    }

    public string DisplayName
    {
      get
      {
        return "Sipek Instant Softphone";
      }
      set {}
    }

    public string DomainName
    {
      get
      {
        return "*";
      }
      set{}
    }

    public string HostName
    {
      get
      {
        //return "sipserver.net";
        return "192.168.60.211:5070";
      }
      set{}
    }

    public string Id
    {
      get
      {
        return "myId";
      }
      set { }
    }

    public int Index
    {
      get
      {
        return 0;
      }
      set{}
    }

    public string Password
    {
      get
      {
        //return "mypass";
        return "4444";
      }
      set {}
    }

    public string ProxyAddress
    {
      get
      {
        return "";
      }
      set{}
    }

    public int RegState
    {
      get
      {
        return 0;
      }
      set{}
    }

    public ETransportMode TransportMode
    {
      get
      {
        return ETransportMode.TM_UDP;
      }
      set{}
    }

    public string UserName
    {
      get
      {
        //return "myuser";
        return "4444";
      }
      set{ }
    }

    #endregion
  }
}
