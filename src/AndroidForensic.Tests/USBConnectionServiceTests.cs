using AndroidForensic.Services;
using Xunit;

namespace AndroidForensic.Tests
{
    public class USBConnectionServiceTests
    {
        [Fact]
        public async Task InitializeAsync_Should_Complete()
        {
            var service = new USBConnectionService();
            await service.InitializeAsync();
            Assert.True(true);
        }

        [Fact]
        public async Task DiscoverDevicesAsync_Should_Return_List()
        {
            var service = new USBConnectionService();
            var devices = await service.DiscoverDevicesAsync();
            Assert.NotNull(devices);
            Assert.IsType<List<Models.AndroidDevice>>(devices);
        }
    }
}