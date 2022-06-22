using shoes_shop.controller;
using shoes_shop.model;
using System;

namespace shoes_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerShoes shoe = new ControllerShoes();

            shoe.display();
        }
    }
}
