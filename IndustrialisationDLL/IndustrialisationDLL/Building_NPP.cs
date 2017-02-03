﻿using Verse;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Industrialisation
{
    public class Building_NPP : Building
    {
        private int Burnticks = 40;

        public override void Tick()
        {
            base.Tick();
            if (--Burnticks == 0)
            {
                   MoteMaker.ThrowSmoke(base.Position.ToVector3Shifted(), 3f);
                   MoteMaker.ThrowSmoke(base.Position.ToVector3Shifted(), 4f);
                   Burnticks = 40;
            }
        }
    }
}