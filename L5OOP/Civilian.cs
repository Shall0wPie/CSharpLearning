﻿namespace ConsoleApp1.L5OOP;

public class Civilian : Customer
{
    public bool HaveLicense;
    
    public Civilian(string fullName, DateTime birthDate, WeaponType desiredWeapon, bool haveLicense) 
        : base(fullName, birthDate, desiredWeapon)
    {
        HaveLicense = haveLicense;
    }

    public override string ToString()
    {
        return "гражданский";
    }
}