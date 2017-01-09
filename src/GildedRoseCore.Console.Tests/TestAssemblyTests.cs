using System.Collections.Generic;
using ConsoleApplication;
using Xunit;


namespace Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth() 
        {
            Assert.True(true);
        }

        [Fact]
        public void LegendaryItemsShouldNotDegradeTest()
        {
            
        }

        public void BackstagePassesShouldIncreaseInQualityAccordingToDaysLeftTest()
        {
            var app = new Program();
            new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20};
            
        }

        public void AgedBrieIncreasesInQualityAsDaysPassTest()
        {

        }
        
        public void ItemQualityNeverOverFiftyTest()
        {

        }

        public void OnceSellDatePassesDegradeQualityByDoubleTest()
        {

        }
    }
}
