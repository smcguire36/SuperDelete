﻿//Copyright 2015 Marcel Nita (marcel.nita@gmail.com)
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using System.Reflection;
using System.Text;

namespace SuperDelete.Internal
{
    internal class UsageInformation
    {
        public static void Print()
        {
            var appVersion = Assembly.
                GetExecutingAssembly().
                GetName().
                Version.
                ToString();

            var versionLine = String.Format(Resources.VersionLine, appVersion);
            Console.WriteLine(versionLine);

            StringBuilder args = new StringBuilder();
            foreach(var arg in ParsedCmdLineArgs.Args.Keys)
            {
                args.AppendFormat("[{0}]", arg);
            }

            Console.WriteLine(Resources.UsageLine, args.ToString());
        }
    }
}
