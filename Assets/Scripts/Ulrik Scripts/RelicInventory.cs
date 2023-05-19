using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public struct RelicInventory
{
    public RuneStats firstSlotRune;
    public RuneStats secondSlotRune;
    public RuneStats secondRelicFirstRune;
    public RuneStats secondRelicSecondRune;
    public bool hasTwoSlots;
}
