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

        [Fact]
        public void BackstagePassesShouldIncreaseInQualityAccordingToDaysLeftTest()
        {
            var app = new Program();
            Item itemFifteenDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20}; //no change
            Item itemTenDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0}; //quality should be 1
            Item itemFourDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 0}; //quality should be 2

            app.HandleBackstagePasses(itemTenDays);
            app.HandleBackstagePasses(itemFourDays);
            Assert.Equal(1, itemTenDays.Quality);
            Assert.Equal(2, itemFourDays.Quality);
        }

        [Fact]
        public void AgedBrieIncreasesInQualityAsDaysPassTest()
        {

        }
        
        [Fact]
        public void ItemQualityNeverOverFiftyTest()
        {

        }

        [Fact]
        public void OnceSellDatePassesDegradeQualityByDoubleTest()
        {

        }
    }
}
