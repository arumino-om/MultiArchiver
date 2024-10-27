using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiArchiveLibrary.Interface;
using MultiArchiveLibrary.Types;

namespace MultiArchiveLibrary.BuiltinArchivers
{
    public class ZipMetadata : IArchiverMetadata
    {
        public string GetArchiverName()
        {
            return "Zip";
        }

        public string GetArchiverDescription()
        {
            return "A simple zip archiver.";
        }

        public Version GetArchiverVersion()
        {
            return new Version(1, 0, 0, 0);
        }

        public Version GetArchiverInterfaceVersion()
        {
            return new Version(1, 0, 0, 0);
        }

        public IArchiver GetArchiver()
        {
            return new Zip();
        }

        public string[] GetSupportedExtensions()
        {
            return new[] { ".zip" };
        }
    }

    internal class Zip : IArchiver
    {
        public ConfigObject GetArchiveConfig()
        {
            return new ConfigObject()
            {
                Id = "ZipArchiveConfig",
                Items = new List<ConfigItem>()
                {
                    new ConfigItem()
                    {
                        Name = "Password",
                        ValueType = typeof(string),
                        Value = "",
                        Description = "The password to use for the archive."
                    },
                    new ConfigItem()
                    {
                        Name = "CompressionLevel",
                        ValueType = typeof(int),
                        Value = 0,
                        Description =
                            "The compression level to use. 0 is no compression, 9 is maximum compression."
                    }
                }
            };
        }

        public ConfigObject GetExtractConfig()
        {
            return new ConfigObject()
            {
                Id = "ZipExtractConfig",
                Items = new List<ConfigItem>()
                {
                    new ConfigItem()
                    {
                        Name = "Password",
                        ValueType = typeof(string),
                        Value = "",
                        Description = "The password to use for the archive."
                    }
                }
            };
        }

        public bool Archive(string archiveName, string rootPath, List<string> targetFiles, ConfigObject config)
        {
            if (config.Id != "ZipArchiveConfig")
            {
                throw new ArgumentException("Invalid config object for Zip archiver.");
            }

            // Archive the files
            ZipFile.CreateFromDirectory(rootPath, archiveName);

            return true;
        }

        public bool Extract(string extractArchiveFilename, string extractRootDirectory, ConfigObject config)
        {
            if (config.Id != "ZipExtractConfig")
            {
                throw new ArgumentException("Invalid config object for Zip archiver.");
            }

            // Extract the files
            ZipFile.ExtractToDirectory(extractArchiveFilename, extractRootDirectory);

            return true;
        }
    }
}
