using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public SpellName whatSpell;

    private void OnEnable()
    {
        RelicStateHandler.onSpellCast += Destroy;
    }
    private void OnDisable()
    {
        RelicStateHandler.onSpellCast -= Destroy;
    }

    private void Destroy(SpellName spellName)
    {
        if(spellName == whatSpell)
        {

        Destroy(gameObject);
        }
    }
}
