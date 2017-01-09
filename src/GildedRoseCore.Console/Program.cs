using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }


    public class Program
    {
        IList<Item> Items;

        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                            new Item
                                {
                                    Name = "Backstage passes to a TAFKAL80ETC concert",
                                    SellIn = 15,
                                    Quality = 20
                                },
                            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                        }

            };

            app.UpdateQuality();
            foreach(var item in app.Items)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Name, item.SellIn, item.Quality);
            }

            Console.ReadKey();
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality > 0)
                    {
                        DegradeQualityOfItems(item);
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        HandleBackstagePasses(item);
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                            {
                                DegradeQualityOfItems(item);
                            }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }

        private void DegradeQualityOfItems(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality = item.Quality - 1;
            }
        }

        private void HandleBackstagePasses(Item item)
        {
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }
                        }
        }

        
    }
}
