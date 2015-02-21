using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace testLib
{
    public class HTMLWorker
    {
        public delegate void callback();

        public static void SomeFoo(callback callbackFoo)
        {
            callbackFoo();
        }
    }
}
