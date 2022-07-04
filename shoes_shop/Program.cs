using shoes_shop.controller;
using shoes_shop.model;
using System;

namespace shoes_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes s = new Shoes(11, "Crock", "Slapi", 50, 120, "hahahha","shoe2");
            ControllerShoes ctrl = new ControllerShoes();
            ctrl.addShoes(s);
            Console.WriteLine(ctrl.toSave());
            ctrl.load();
        }
    }
}
