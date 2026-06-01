namespace AndroidForensic.Models
{
    public class AndroidDevice
    {
        public string? DeviceId { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string? OSVersion { get; set; }
        public string? SerialNumber { get; set; }
        public long TotalStorage { get; set; }
        public long AvailableStorage { get; set; }
        public string? IMEI { get; set; }
        public bool IsConnected { get; set; }
    }
}