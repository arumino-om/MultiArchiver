using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiArchiveLibrary.Types;

namespace MultiArchiveLibrary.Interface
{
    public interface IArchiver
    {
        public ConfigObject GetArchiveConfig();
        public ConfigObject GetExtractConfig();
        public bool Archive(string archiveName, string rootPath, List<string> targetFiles, ConfigObject config);
        public bool Extract(string archiveName, string extractRootDirectory, ConfigObject config);
    }
}
