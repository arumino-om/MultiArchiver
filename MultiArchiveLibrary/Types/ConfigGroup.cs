using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArchiveLibrary.Types
{
    public class ConfigGroup
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public List<ConfigItem> Items { get; init; }
    }
}
