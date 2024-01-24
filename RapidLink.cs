using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapid.OSTandPSTParser
{
  public class RapidLink
  {
    private MainForm _RapidForm;
    public RapidLink(MainForm _MainFrom)
    {
      _RapidForm = _MainFrom;
    }

    public MainForm RapidForm
    {
      get { return _RapidForm; }
      set { _RapidForm = value; }
    }
  }
}
