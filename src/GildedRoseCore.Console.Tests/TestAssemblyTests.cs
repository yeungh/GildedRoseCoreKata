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
            Item itemTenDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20}; //quality should be 21
            Item itemFourDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 20}; //quality should be 22

            app.HandleBackstagePasses(itemTenDays);
            app.HandleBackstagePasses(itemTenDays);
            Assert.Equal(itemTenDays.Quality, 21);
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
