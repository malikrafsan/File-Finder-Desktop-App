﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler.Classes
{
    class Utils
    {
        public static string getDirName(string fullDir)
        {
            return fullDir.Split('\\').Last();
        }
    }
}
