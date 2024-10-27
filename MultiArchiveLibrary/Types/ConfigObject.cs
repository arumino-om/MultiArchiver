using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArchiveLibrary.Types
{
    public class ConfigObject
    {
        public string Id { get; init; }
        public List<ConfigGroup> Groups { get; init; }
        public List<ConfigItem> Items { get; init; }
    }
}
