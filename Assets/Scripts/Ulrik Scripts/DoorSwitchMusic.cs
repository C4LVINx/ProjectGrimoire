using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitchMusic : MonoBehaviour
{
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private bool leadsInside;


    private void OnMouseDown()
    {
        if(leadsInside)
        {
            musicManager.EnterRoom2();
        }
        if (!leadsInside)
        {
            musicManager.EnterRoom1();
        }
    }
}
