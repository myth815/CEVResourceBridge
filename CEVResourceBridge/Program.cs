using System;
using System.Collections.Generic;
using NDesk.Options;

namespace CEVResourceBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = string.Empty;
            string project = string.Empty;
            string sectors = string.Empty;
            bool help = false;
            OptionSet p = new OptionSet() {
                { "Mode=",      v => mode = v },
                { "Project=",   v => project = v },
                { "Sectors=",   v => sectors = v },
                { "h|?|help",   v => help = v != null },
            };
            List<string> extra = p.Parse(args);

            switch (mode)
            {
                case "ImportSectorInfos":
                    {

                        break;
                    }
            }
        }
    }
}
