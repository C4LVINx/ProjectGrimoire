using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicRunetracker : MonoBehaviour
{
    [SerializeField]private RelicRuneAttacher runeAttacher;
    public SpellName currentRuneSpell;
    public int currentRuneRelic;
    public int currentRuneSlot;
    private void Update()
    {
        GetRuneStats();
    }

    private void GetRuneStats()
    {
        if(runeAttacher.currentRune != null)
        {
            var runestats = runeAttacher.currentRune.GetComponent<Rune>().stats;
            currentRuneSpell = runestats.WhatSpell;
            currentRuneRelic = runestats.WhatRelic;
            currentRuneSlot = runestats.WhatSlot;
        }
        else
        {
            currentRuneSpell = 0;
            currentRuneRelic = 0;
            currentRuneSlot=0;
        }
    }
}
