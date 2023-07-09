using ELibrary.Standard.VB;
using static EWebFrameworkCore.Vendor.PathHandlers;

namespace EWebFrameworkCore.Vendor.Services
{
    /// <summary>
    /// Allow to create a disposable temporary file
    /// </summary>
    public class TemporaryFile : IDisposable
    {
        /// <summary>
        /// The file full path that was simulated. Not created on constructor
        /// </summary>
        public readonly string FileFullPath;

        /// <summary>
        /// Set to leave the file undeleted even if it exists
        /// </summary>
        private bool _leaveUnDisposed = false;

        public TemporaryFile() : this(JobCompatibleService.GetSessionTempFileName())
        { }

        /// <summary>
        /// Create a temporary file using your own file full path
        /// </summary>
        public TemporaryFile(string FileFullPath)
        {
            this.FileFullPath = FileFullPath;
        }


        /// <summary>
        /// Create a temporary file. Note the file is not physically created
        /// </summary>
        /// <param name="ExtWithDot">Just additional string to append</param>
        /// <param name="appendRandom">If you want to generate the randomString Part with it</param>
        public TemporaryFile(string ExtWithDot, bool appendRandom) : this(GetRandomTempFileName(pExtWithDot: ExtWithDot, appendRandom: appendRandom))
        { }

        /// <summary>
        /// This will create the directory path if it doesn't exists
        /// </summary>
        /// <returns></returns>
        public TemporaryFile CreatePath()
        {
            if (!Directory.Exists(DirectoryPath)) Directory.CreateDirectory(DirectoryPath);
            return this;
        }
        
        public TemporaryFile SetLeaveAsUndisposed(bool leaveUnDisposed = true)
        {
            _leaveUnDisposed = leaveUnDisposed;
            return this;
        }

        public string DirectoryPath => EIO.GetDirectoryFullPath(FileFullPath);

        /// <summary>
        /// Delete the file if it exists
        /// </summary>
        public void Dispose()
        {
            if(!_leaveUnDisposed) EIO.DeleteFileIfExists(this.FileFullPath);

            // https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1816
            GC.SuppressFinalize(this);
        }
    }
}