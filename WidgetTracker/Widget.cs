using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetTracker
{
    class Widget
    {

        public string Size { get; set; }
        public string Color { get; set; }



        public int Price()
        {
            var price = 0;
            if(Size== "large")
            {
                price += 20;
            }
            if(Size == "medium")
            {
                price += 10;
            }
            if(Size == "small")
            {
                price += 5;
            }
            if(Color == "red")
            {
                price += 15;
            }
            if(Color == "white")
            {
                price += 10;
            }
            if(Color == "blue")
            {
                price += 5;
            }

            return price;
        }

        public Widget()
        {

        }

        public Widget(string size, string color)
        {
            Size = size.ToLower();
            Color = color.ToLower();

        }
    }
}
