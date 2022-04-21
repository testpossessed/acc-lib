﻿namespace Acc.Lib.Models.Config.SeasonEntity;

public class Car
{
    public Info Info { get; set; } = null!;
    public List<Driver> Drivers { get; set; } = new List<Driver>();
}