using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noteopening : MonoBehaviour
{
    public GameObject note;

    // Update is called once per frame
    public void ActivatingNote()
    {
        note.SetActive(true);
    }
    public void DeactivatingNote()
    {
        note.SetActive(false);
    }
}
