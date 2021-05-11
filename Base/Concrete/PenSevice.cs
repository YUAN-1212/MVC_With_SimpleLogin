using Base.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Concrete
{
    public class PenSevice : IPen
    {
        string IPen.doDraw(string txt)
        {
            return string.Format("Use Draw : {0}", txt);
        }
        string IPen.doWrite(string txt)
        {
            return string.Format("Use Write : {0}", txt);
        }
    }
}
