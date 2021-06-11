using FancyCashRegister.Services.Data;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;


namespace FancyCashRegister.Test.UnitTests
{
    public class AdvertentieRepositoryTest
    {
        [Fact]
        public void Dummy()
        {
            true.Should().BeTrue();
        }

        [Fact]
        public void GetNextAdPath_WhenCalledThenAdFileFullPathReturned()
        {
            // Arrange
            var subject = new AdvertentieRepository();
            var regExAdFile = ConfigurationManager.AppSettings["RegexAdFile"];


            // Act
            var actualFirst = subject.GetNextAdPath();
            var actualSecond = subject.GetNextAdPath();



            // Assert
            actualFirst.Should().NotBeNullOrEmpty();

            Regex.IsMatch(Path.GetFileName(actualFirst), regExAdFile)
                .Should()
                .BeTrue();

            actualSecond.Should().NotBeNullOrEmpty();
            Regex.IsMatch(Path.GetFileName(actualSecond), regExAdFile)
                .Should()
                .BeTrue();

        }

        [Theory]
        [InlineData(2)]
        public void GetNextAdUri_WhenCalledThenAdFileUriReturned(int nrAdsToFetch)
        {
            /*
            // Arrange
            var subject = new AdvertentieRepository();
            var regExAdFile = ConfigurationManager.AppSettings["RegexAdFile"];
            var fetchedAdds = new List<Uri>();

            // Act - Assert
            for(int i = 0; i < nrAdsToFetch; i++)
            {
                var actualAdUri = subject.GetNextAdUri();
                actualAdUri.Should().NotBeNull();
                Regex.IsMatch(Path.GetFileName(actualAdUri.AbsolutePath), regExAdFile).Should().BeTrue();
                fetchedAdds.Add(actualAdUri);

            }

            // Check op duplicaten, elke ad zou een andere url moeten zijn
            // TODO: maar rouleert, deze test controleert dit NIET!
            var dups = fetchedAdds.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Any()
                .Should()
                .BeFalse();

            */
        }
    }
}
