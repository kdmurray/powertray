using System;
using System.Collections.Generic;
using System.Text;

namespace PTSDK
{
  public interface IPlugin
    {
      string Name { get;}
      string DisplayName { get;}

      void Launch();
    }
}
