namespace AndroidForensic.Models
{
    public class ForensicData
    {
        public string? DeviceId { get; set; }
        public DateTime AnalysisDate { get; set; }
        public List<ExtractedFile>? Files { get; set; }
        public List<DeletedFileData>? DeletedFiles { get; set; }
        public List<AppData>? Applications { get; set; }
        public List<SystemLog>? Logs { get; set; }
        public Dictionary<string, string>? Metadata { get; set; }
    }

    public class ExtractedFile
    {
        public string? Path { get; set; }
        public string? Name { get; set; }
        public long Size { get; set; }
        public DateTime Modified { get; set; }
        public string? Hash { get; set; }
    }

    public class DeletedFileData
    {
        public string? FileName { get; set; }
        public long Size { get; set; }
        public float RecoveryConfidence { get; set; }
        public byte[]? DataSignature { get; set; }
    }

    public class AppData
    {
        public string? PackageName { get; set; }
        public string? AppName { get; set; }
        public string? Version { get; set; }
        public DateTime InstalledDate { get; set; }
        public bool IsSystemApp { get; set; }
    }

    public class SystemLog
    {
        public DateTime Timestamp { get; set; }
        public string? LogLevel { get; set; }
        public string? Message { get; set; }
        public string? Component { get; set; }
    }
}