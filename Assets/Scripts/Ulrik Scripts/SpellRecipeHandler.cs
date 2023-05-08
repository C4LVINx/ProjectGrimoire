using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu (fileName = "Recipe Handler", menuName = "Dead Rat Games/Recipe Handler")]
public class SpellRecipeHandler : ScriptableObject
{
    [SerializeField] private SpellrecipeScrub[] spellrecipes;
    
    public SpellrecipeScrub GetCompleteRecipe(RelicInventory inventory)
    {
        //Noe kult
        
        var isRecipeComplete = spellrecipes.First(recipe => recipe.IsRecipeComplete(inventory));
        Debug.Log(isRecipeComplete);
        return isRecipeComplete;
    }
    
}
