using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicStateHandler : MonoBehaviour
{
    private RelicInventory relicInventory;
    public RelicInventory inventory => relicInventory;

    [SerializeField] private RelicRuneAttacher slot1RuneAttacher;
    [SerializeField] private RelicRuneAttacher slot2RuneAttacher;
    [SerializeField] private RelicRelicAttacher RelicAttacher;

    [SerializeField] private SpellRecipeHandler recipeHandler;

    private void OnMouseDown()
    {
        //When player clicks middle mouse button
        if (Input.GetMouseButtonDown(2))
        {
         //   recipeHandler.GetCompleteRecipe(relicInventory);
        }
    }

    private void Start()
    {
        relicInventory = new RelicInventory();
    }

    private void Update()
    {
        relicInventory.firstSlotRune = slot1RuneAttacher.currentRune.GetComponent<RuneStats>();
        relicInventory.secondSlotRune = slot2RuneAttacher.currentRune.GetComponent<RuneStats>();

        relicInventory.relicStateHandler = RelicAttacher.currentRelic.GetComponent<RelicStateHandler>();
    }
}
