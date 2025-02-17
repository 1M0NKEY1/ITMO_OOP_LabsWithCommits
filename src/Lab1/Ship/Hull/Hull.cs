﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public abstract class Hull
{
    public bool HullDestroyed { get; protected set; }
    protected int HullDefencePoint { get; set; }
    public abstract void Damage(int countOfObstacles, IList<Obstacles> obstacle, int iStep);

    public bool Defence()
    {
        if (HullDefencePoint > 0 && !HullDestroyed) return true;
        HullDestroyed = true;
        HullDefencePoint = 0;
        throw new CustomExceptions("Hull destroyed", "false");
    }
}