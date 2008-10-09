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
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public List<IAccount> Accounts
    {
      get { return _acclist; }
    }

    public bool CFBFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFBNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool CFNRFlag
    {
      get
      {
        return false;
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFNRNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool CFUFlag
    {
      get
      {
        return false;
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string CFUNumber
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public List<string> CodecList
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public bool DNDFlag
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
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
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public int SIPPort
    {
      get
      {
        return 5060;
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public void Save()
    {
      throw new Exception("The method or operation is not implemented.");
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
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string DisplayName
    {
      get
      {
        return "Sipek Instant Softphone";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string DomainName
    {
      get
      {
        return "*";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string HostName
    {
      get
      {
        //return "sipserver.net";
        return "192.168.60.211:5070";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string Id
    {
      get
      {
        return "myId";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public int Index
    {
      get
      {
        return 0;
      }
      set
      {
        ;
      }
    }

    public string Password
    {
      get
      {
        //return "mypass";
        return "4444";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string ProxyAddress
    {
      get
      {
        return "";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public int RegState
    {
      get
      {
        throw new Exception("The method or operation is not implemented.");
      }
      set
      {
        //throw new Exception("The method or operation is not implemented.");
      }
    }

    public ETransportMode TransportMode
    {
      get
      {
        return ETransportMode.TM_UDP;
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    public string UserName
    {
      get
      {
        //return "myuser";
        return "4444";
      }
      set
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    #endregion
  }
}
