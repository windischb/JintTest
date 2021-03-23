using System;
using Jint;

namespace JintTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(opts =>
            {
                opts.AddExtensionMethods(typeof(StringExtensions));
            });

            var arr = engine.Execute("'yes,no'.split(',')").GetCompletionValue().AsArray();


        }
    }
}
