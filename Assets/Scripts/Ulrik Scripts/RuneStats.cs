using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public struct RuneStats
{
    public Sprite RuneSprite;
    public SpellName WhatSpell;
    public int WhatRelic;
    public int WhatSlot;

    public bool Equals(RuneStats other) 
    {
        return WhatSpell == other.WhatSpell && WhatRelic == other.WhatRelic && WhatSlot == other.WhatSlot;
    }

    public override bool Equals(object obj)
    {
        return obj is RuneStats other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WhatSlot, WhatSpell, WhatRelic);
    }

    public static bool operator ==(RuneStats rhs, RuneStats lhs) { return rhs.Equals(lhs); }
    public static bool operator !=(RuneStats lhs, RuneStats rhs) { return !lhs.Equals(rhs); }
}
