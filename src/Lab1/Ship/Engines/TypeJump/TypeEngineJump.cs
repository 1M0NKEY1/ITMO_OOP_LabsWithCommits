﻿namespace Itmo.ObjectOrientedProgramming.Lab1.Ship.Engines.TypeJump;

public abstract class TypeEngineJump
{
    protected int CapacityGravityFuel { get; set; }
    public abstract int Duration(int astronomicUnits);
}