using System;
using FocusOnXamarin.Models;
using Xamarin.Forms;

namespace FocusOnXamarin.ViewModels
{
    public class DetailPageViewModel
    {
        public Product Product { get; set; }

        public DetailPageViewModel()
        {
            Product = new Product
            {
                Name = "Stroopwaffles",
                Price = 0.89,
                Category = "Food",
                Quantity = 1,
                WeightInGrams = 378,
                Description = "These tasty stroopwaffles are a real treat with coffee or tea. A stroopwafel's wafer layers are made from a stiff dough of flour, butter, brown sugar, yeast, milk, and eggs that has been pressed in a hot waffle iron until crisped. While still warm, the waffles have their edges removed with a cookie cutter, which allows the remaining disc to be easily separated into top and bottom wafers. A caramel filling made from syrup, brown sugar, butter, and cinnamon—also warm—is spread between the wafers before the waffle is reassembled. The caramel sets as it cools, thereby binding the waffle halves together.\n\nAccording to Dutch culinary folklore, stroopwafels were allegedly first made in Gouda either during the late 18th century or the early 19th century by bakers repurposing scraps and crumbs by sweetening them with syrup. One story ascribes the invention of the stroopwafel to the baker Gerard Kamphuisen, which would date the first stroopwafels from somewhere between 1810, the year he opened his bakery, and 1840, the year of the oldest known recipe for syrup waffles. Stroopwafels were not found outside Gouda until 1870, by which point the city was home to around 100 syrup-waffle bakers.",
                ImageUrl = "https://static.ah.nl/image-optimization/static/product/AHI_43545239353939383432_1_LowRes_JPG.JPG?options=399,q85"
            };
        }
    }
}

