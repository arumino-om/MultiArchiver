using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArchiveLibrary.Interface
{
    public interface IArchiver
    {
        public object GetCreateArchiveOptions();
        public object GetExtractArchiveOptions();
        public bool CreateArchive(string createArchiveFilename, Dictionary<string, string> archiveTargetFiles, object createArchiveOptions);
        public bool ExtractArchive(string extractArchiveFilename, string extractRootDirectory, object extractArchiveOptions);
    }
}
