using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Search_Extension
{


    public class OpenBrowser : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> query { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string q = query.Get(context);
            ProcessStartInfo web = new ProcessStartInfo("www.google.com/search?" + q);
            Process.Start(web);
        }
    }
}
