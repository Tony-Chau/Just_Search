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

    public class SortWord : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> Word { get; set; }

        [Category("Output")]
        public OutArgument<string> fixedword { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string word = Word.Get(context);
            int index = word.IndexOf("computer search") + 16;
            int length = word.Length - index;
            fixedword.Set(context, word.Substring(index, length));
        }
    }
}
