﻿using Assignment_18;
using System;

class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }

    public Laptop(string brand)
    {
        Brand = brand;
    }

    public bool Connect()
    {
        // Implementation for Connect method
        Console.WriteLine($"{Brand} laptop connected successfully.");
        return true;
    }

    public void Charge(int minutes)
    {
        // Implementation for Charge method
        Console.WriteLine($"{Brand} laptop is charging for {minutes} minutes.");
    }

    public string Display()
    {
        // Implementation for Display method
        return $"{Brand} laptop display: Desktop";
    }
}
