namespace MultiArchiveLibrary.Interface;

public interface IArchiverMetadata
{
    public string GetArchiverName();
    public string GetArchiverDescription();
    public Version GetArchiverVersion();
    
    public Version GetArchiverInterfaceVersion();
    public IArchiver GetArchiver();
    public string[] GetSupportedExtensions();
}