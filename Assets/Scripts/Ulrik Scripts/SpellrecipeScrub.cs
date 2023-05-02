using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Spell Recipe", menuName = "Dead Rat Games/Spell Recipe")]
public class SpellrecipeScrub : ScriptableObject
{
    [SerializeField] private RelicInventory inventory;
    [SerializeField] private string SpellDescription;

    public bool IsRecipeComplete(SpellName SpellCheck, int RelicCheck, int SlotCheck)
    {
        /*
        if (SpellCheck != Spell) return false;
        if (RelicCheck != Relic) return false;
        if (SlotCheck != Slot) return false;
        */
        return true;
        
    }
}
