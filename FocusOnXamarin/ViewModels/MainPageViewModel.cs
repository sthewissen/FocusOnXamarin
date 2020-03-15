using System;
using System.Collections.Generic;
using System.Linq;
using FocusOnXamarin.Models;

namespace FocusOnXamarin.ViewModels
{
    public class MainPageViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> CartContents { get; set; } = new List<Product>();

        public double TotalPrice => CartContents.Sum(x => x.Price * x.Quantity);

        public MainPageViewModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Name="Stroopwaffles",
                    Price=0.89,
                    Category="Food",
                    Quantity = 1,
                    WeightInGrams = 378,
                    Description = "These tasty stroopwaffles are a real treat with coffee or tea. A stroopwafel's wafer layers are made from a stiff dough of flour, butter, brown sugar, yeast, milk, and eggs that has been pressed in a hot waffle iron until crisped. While still warm, the waffles have their edges removed with a cookie cutter, which allows the remaining disc to be easily separated into top and bottom wafers. A caramel filling made from syrup, brown sugar, butter, and cinnamon—also warm—is spread between the wafers before the waffle is reassembled. The caramel sets as it cools, thereby binding the waffle halves together.\n\nAccording to Dutch culinary folklore, stroopwafels were allegedly first made in Gouda either during the late 18th century or the early 19th century by bakers repurposing scraps and crumbs by sweetening them with syrup. One story ascribes the invention of the stroopwafel to the baker Gerard Kamphuisen, which would date the first stroopwafels from somewhere between 1810, the year he opened his bakery, and 1840, the year of the oldest known recipe for syrup waffles. Stroopwafels were not found outside Gouda until 1870, by which point the city was home to around 100 syrup-waffle bakers.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_43545239353939383432_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Speculoospasta original",
                    Price=3.69,
                    Category="Food",
                    Quantity = 3,
                    WeightInGrams = 720,
                    Description = "On your sandwich... Speculoospasta. Made from the only real koffieleutjes. The unique taste of Speculoos on your sandwich in an extra large pot.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50393037353933_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Fresh juice orange-strawberry",
                    Price=1.69,
                    Category="Drinks",
                    Quantity = 5,
                    WeightInGrams = 500,
                    Description = "Nice and fresh! Our fresh juices are cold-pressed every morning. By using only fresh ingredients and never heating the juice, vitamins and minerals are retained to the maximum. Pressed today, tomorrow in your fridge. Without additives, fresher & easier is not possible.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50303033373630_10_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Baby food broccoli-beef-rice",
                    Price=1.43,
                    Category="Yuk",
                    Quantity = 102,
                    WeightInGrams = 250,
                    Description = "A complete meal for your little one. Always with a recognizable vegetable taste, this helps your child to recognize and appreciate the taste.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50323537383835_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Bananas",
                    Price=1.99,
                    Category="Fruit",
                    Quantity = 4,
                    WeightInGrams = 1000,
                    Description = "Bananas have a soft and sweet taste. The banana is the best-known tropical fruit.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_43545237303430353637_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Celery",
                    Price=1.09,
                    Category="Veggies",
                    Quantity = 6,
                    WeightInGrams = 103,
                    Description = "Celery has a fresh, crispy and slightly spicy taste. Delicious with a salad or as a healthy snack.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50323432303532_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Red pepper",
                    Price=0.89,
                    Category="Veggies",
                    Quantity = 2,
                    WeightInGrams = 482,
                    Description = "The red pepper is a bit sweeter in taste than the green variety. That is why it is ideal for a fresh pasta sauce or a healthy salad. Tip: try grilling the red pepper or stuffed from the oven.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50303133303732_3_LowRes_JPG.JPG?options=399,q85"
                }
            };

            CartContents = new List<Product> {
                new Product
                {
                    Name="Bananas",
                    Price=1.99,
                    Category="Fruit",
                    Quantity = 4,
                    WeightInGrams = 1000,
                    Description = "Bananas have a soft and sweet taste. The banana is the best-known tropical fruit.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_43545237303430353637_1_LowRes_JPG.JPG?options=399,q85"
                },
                new Product
                {
                    Name="Celery",
                    Price=1.09,
                    Category="Veggies",
                    Quantity = 6,
                    WeightInGrams = 103,
                    Description = "Celery has a fresh, crispy and slightly spicy taste. Delicious with a salad or as a healthy snack.",
                    ImageUrl="https://static.ah.nl/image-optimization/static/product/AHI_434d50323432303532_1_LowRes_JPG.JPG?options=399,q85"
                }
            };
        }
    }
}
