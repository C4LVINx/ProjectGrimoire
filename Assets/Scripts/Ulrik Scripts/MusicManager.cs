using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private int room;
    [SerializeField]private AudioSource outdoorTheme;
    [SerializeField]private AudioSource indoorTheme;
    private void Start()
    {
        outdoorTheme.Play();
        indoorTheme.Stop();
    }
    private void Update()
    {
        switch(room)
        {
            case 1:

                break;
                case 2:
                break;
        }
    }

    public void EnterRoom1()
    {
        room = 1;
        outdoorTheme.Play();
        indoorTheme.Stop();
    }

    public void EnterRoom2()
    {
        room = 2;
        indoorTheme.Play();
        outdoorTheme.Stop();
    }
}
