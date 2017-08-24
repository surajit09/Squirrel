using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirrel
{
    internal static class Util
    {
        public static List<Entry> LoadEntries()
            => JsonConvert.DeserializeObject<List<Entry>>(File.ReadAllText("log.txt"));
    }
}