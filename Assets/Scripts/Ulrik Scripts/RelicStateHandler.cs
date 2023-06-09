using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void SpellCast(SpellName spellName);

public class RelicStateHandler : MonoBehaviour
{
    private RelicInventory relicInventory;
    public RelicInventory inventory => relicInventory;

    [SerializeField] private RelicRuneAttacher slot1RuneAttacher;
    [SerializeField] private RelicRuneAttacher slot2RuneAttacher;
    [SerializeField] private RelicRelicAttacher RelicAttacher;

    [SerializeField] private SpellRecipeHandler recipeHandler;
    [SerializeField] private bool hasTwoSlots;

    public static event SpellCast onSpellCast;

    private void Start()
    {
        relicInventory = new RelicInventory();
        relicInventory.hasTwoSlots = hasTwoSlots;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            
            var recipe = recipeHandler.GetCompleteRecipe(relicInventory);
            if(recipe != null)
            {
                onSpellCast?.Invoke(recipe.SpellName);
            }
        }

        if (slot1RuneAttacher.currentRune != null)
        {

            relicInventory.firstSlotRune = slot1RuneAttacher.currentRune.GetComponent<Rune>().stats;
        }
        if(inventory.hasTwoSlots)
        {
            if(slot2RuneAttacher.currentRune != null)
            {
                relicInventory.secondSlotRune = slot2RuneAttacher.currentRune.GetComponent<Rune>().stats;
            }
        }
        if (RelicAttacher.currentRelic == null) return;

        var otherInventory = RelicAttacher.currentRelic.GetComponent<RelicStateHandler>().inventory;
        if(otherInventory.firstSlotRune != null)
        {
            relicInventory.secondRelicFirstRune = otherInventory.firstSlotRune;
        }
        if (!otherInventory.hasTwoSlots) return;
        if(otherInventory.secondSlotRune != null)
        {
            relicInventory.secondRelicSecondRune = otherInventory.secondSlotRune;
        }
        
    }
}
