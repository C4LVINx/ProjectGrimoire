using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRuneBox : MonoBehaviour
{
    [SerializeField] private Transform rune1;
    [SerializeField] private Transform rune2;
    [SerializeField] private Transform rune3;
    [SerializeField] private Transform rune4;

    [SerializeField] private GameObject runeTutorialTextButton;
    private bool hasPickedUpRune;

    public void Rune1First()
    {
        if(!hasPickedUpRune)
        {
            runeTutorialTextButton.SetActive(true);
            runeTutorialTextButton.transform.position = rune1.transform.position;
            hasPickedUpRune = true;
        }
        
    }

    public void Rune2First()
    {
        if (!hasPickedUpRune)
        {
            runeTutorialTextButton.SetActive(true);
            runeTutorialTextButton.transform.position = rune2.transform.position;
            hasPickedUpRune = true;
        }
    }
    public void Rune3First()
    {
        if (!hasPickedUpRune)
        {
            runeTutorialTextButton.SetActive(true);
            runeTutorialTextButton.transform.position = rune3.transform.position;
            hasPickedUpRune = true;
        }
    }
    public void Rune4First()
    {
        if (!hasPickedUpRune)
        {
            runeTutorialTextButton.SetActive(true);
            runeTutorialTextButton.transform.position = rune4.transform.position;
            hasPickedUpRune = true;
        }
    }
}
