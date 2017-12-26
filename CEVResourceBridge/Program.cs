using System;
using System.Collections.Generic;
using System.IO;
using NDesk.Options;
using CEVResourceBridge.Resources;
using CEVResourceBridge.Resources.CGF;
using CEVResourceBridge.Utils;

namespace CEVResourceBridge
{
    class Program
    {
        public enum ResourceType
        {
            CGF
        }

        static void Main(string[] args)
        {
            string __inputPath = string.Empty;
            string __outputPath = string.Empty;
            string __inputMode = string.Empty;
            string __outputMode = string.Empty;
            bool __help = false;
            OptionSet p = new OptionSet()
            {
                { "InputPath=",      v => __inputPath = v },
                { "OutputPath=",   v => __outputPath = v },
                { "InputMode=",   v => __inputMode = v },
                { "OutputMode=",   v => __outputMode = v },
                { "h|?|help",   v => __help = v != null },
            };

            List<string> extra = p.Parse(args);

            if (__help)
            {
                Console.WriteLine("args : ");
                Console.WriteLine("<InputPath> Input File Path");
                Console.WriteLine("<OutputPath> Output File Path");
                Console.WriteLine("<InputMode> Input File Mode");
                Console.WriteLine("<OutputMode> Output File Mode");
                Console.WriteLine("Example : Program.exe /InputPath='./a.cgf' /InputMode='cgf' /OutputPath='./a.geo' /OutputMode='geo'");
                return;
            }

            if (File.Exists(__inputPath))
            {
                byte[] __inputBytes = File.ReadAllBytes(__inputPath);

                ResourceType __inputResourceType = (ResourceType)Enum.Parse(typeof(ResourceType), __inputMode.ToUpper());
                IResource __resource = null;
                switch (__inputResourceType)
                {
                    case ResourceType.CGF:
                        {
                            __resource = new CGFResource();
                            __resource.fromOrginBytes(new ByteArray(__inputBytes));
                            break;
                        }
                }

                ResourceType __outputResourceType = (ResourceType)Enum.Parse(typeof(ResourceType), __outputMode.ToUpper());
                byte[] __outputBytes = null;
                switch (__outputResourceType)
                {
                    case ResourceType.CGF:
                        {
                            __outputBytes = __resource.toOrginBytes().ToArray();
                            break;
                        }
                }
                File.WriteAllBytes(__outputPath, __outputBytes);
            }
            else
            {
                throw new Exception("Input Path Not Exsit!");
            }
        }
    }
}
