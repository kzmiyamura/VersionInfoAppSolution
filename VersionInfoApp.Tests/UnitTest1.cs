using System.Reflection;
using Xunit;

namespace VersionInfoApp.Tests
{
    public class VersionTests
    {
        [Fact]
        public void InformationalVersion_ShouldNotBeNullOrEmpty()
        {
            var mainAssembly = Assembly.Load("VersionInfoApp");
            var infoVersion = mainAssembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;

            Assert.False(string.IsNullOrEmpty(infoVersion));
            Assert.Matches(@"\+([0-9a-f]{7,40})", infoVersion); // Gitハッシュ形式を簡易確認
        }

        [Fact]
        public void AssemblyVersion_ShouldBeValid()
        {
            var mainAssembly = Assembly.Load("VersionInfoApp");
            var version = mainAssembly.GetName().Version;

            Assert.NotNull(version);
            Assert.True(version.Major >= 0);
        }
    }
}
