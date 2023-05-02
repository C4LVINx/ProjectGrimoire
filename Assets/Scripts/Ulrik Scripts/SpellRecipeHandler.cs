using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu (fileName = "Recipe Handler", menuName = "Dead Rat Games/Recipe Handler")]
public class SpellRecipeHandler : ScriptableObject
{
    [SerializeField] private SpellrecipeScrub[] spellrecipes;
    /*
    public SpellrecipeScrub GetCompleteRecipe(RelicInventory inventory)
    {
        //Noe kult
        
        //return spellrecipes.First(recipe => recipe.IsRecipeComplete(inventory));
    }
    */
}
