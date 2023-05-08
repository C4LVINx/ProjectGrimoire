using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Spell Recipe", menuName = "Dead Rat Games/Spell Recipe")]
public class SpellrecipeScrub : ScriptableObject
{
    [SerializeField] private RelicInventory inventory;
    [SerializeField] private string SpellDescription;

    public bool IsRecipeComplete(RelicInventory inventoryCheck)
    {
        if(inventory.firstSlotRune != inventoryCheck.firstSlotRune) return false;
        if(inventory.secondSlotRune != inventoryCheck.secondSlotRune) return false;
        if(inventory.secondRelicFirstRune != inventoryCheck.secondRelicFirstRune) return false;
        if(inventory.secondRelicSecondRune != inventoryCheck.secondRelicSecondRune) return false;
        return true;
    }
}
