using AndroidForensic.Models;

namespace AndroidForensic.Services
{
    public interface IForensicExtractionService
    {
        Task<ForensicData?> ExtractDeviceDataAsync(string deviceId, IProgress<double>? progress = null);
        Task<List<ExtractedFile>> ListFilesAsync(string deviceId, string path);
        Task<bool> DumpFileSystemAsync(string deviceId, string outputPath);
        Task<bool> ExtractDatabasesAsync(string deviceId, string outputPath);
        Task<List<DeletedFileData>> RecoverDeletedFilesAsync(string deviceId);
    }

    public class ForensicExtractionService : IForensicExtractionService
    {
        public async Task<ForensicData?> ExtractDeviceDataAsync(string deviceId, IProgress<double>? progress = null)
        {
            progress?.Report(25);
            await Task.Delay(100);
            progress?.Report(50);
            await Task.Delay(100);
            progress?.Report(100);
            return new ForensicData { DeviceId = deviceId, AnalysisDate = DateTime.Now };
        }

        public async Task<List<ExtractedFile>> ListFilesAsync(string deviceId, string path)
        {
            var files = new List<ExtractedFile>();
            await Task.Delay(100);
            return files;
        }

        public async Task<bool> DumpFileSystemAsync(string deviceId, string outputPath)
        {
            await Task.Delay(100);
            return true;
        }

        public async Task<bool> ExtractDatabasesAsync(string deviceId, string outputPath)
        {
            await Task.Delay(100);
            return true;
        }

        public async Task<List<DeletedFileData>> RecoverDeletedFilesAsync(string deviceId)
        {
            var deleted = new List<DeletedFileData>();
            await Task.Delay(100);
            return deleted;
        }
    }
}