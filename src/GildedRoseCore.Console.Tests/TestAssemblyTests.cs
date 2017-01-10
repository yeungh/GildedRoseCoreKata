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
            var app = new Program();
            var item = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};

            app.DegradeQualityOfAllItemsByOne(item);
            Assert.Equal(80, item.Quality);
        }

        [Fact]
        public void BackstagePassShouldIncreaseInQualityByOneIfUnderElevenDays()
        {
            var app = new Program();
            Item itemTenDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0}; //quality should be 1

            app.HandleBackstagePasses(itemTenDays);
            Assert.Equal(1, itemTenDays.Quality);
        }

        [Fact]
        public void BackstagePassShouldIncreaseInQualityByTwoIfUnderSixDays()
        {
            var app = new Program();
            Item itemFourDays = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 0}; //quality should be 2

            app.HandleBackstagePasses(itemFourDays);
            Assert.Equal(2, itemFourDays.Quality);
        }

        [Fact]
        public void AgedBrieIncreasesInQualityAsDaysPassTest()
        {
            var app = new Program();
            Item item = new Item {Name = "Aged Brie", SellIn = 0, Quality = 0};

            app.CheckQualityOfItems(item);

            Assert.Equal(1, item.Quality);
        }
        
        [Fact]
        public void ItemQualityNeverUpdateOverFiftyUnlessLegendaryItemTest()
        {
            var app = new Program();
            Item item = new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 50};

            app.CheckQualityOfItems(item);
            Assert.True(item.Quality <= 50);
        }

        [Fact]
        public void OnceSellDatePassesDegradeQualityByDoubleTest()
        {
            var app = new Program();
            Item item = new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = 7};

            app.CheckSellInDateHasPassed(item);
            Assert.Equal(6, item.Quality);
        }

        [Fact]
        public void DecreaseSellInDateByOne() 
        {
            var app = new Program();
            Item item = new Item {Name = "An item", SellIn = 4, Quality = 10};
            app.ReduceSellInDays(item);

            Assert.Equal(3, item.SellIn);
        }
    }
}
