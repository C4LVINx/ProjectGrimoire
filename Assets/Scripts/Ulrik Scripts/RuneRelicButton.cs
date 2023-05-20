using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneRelicButton : MonoBehaviour
{
    public bool relic1 = true;
    public bool relic2 = false;

    public bool ihl = true;
    public bool taros = false;
    public bool yohn = false;
    public bool ahk = false;

    [SerializeField] private GameObject ObjectRelic1;
    [SerializeField] private GameObject ObjectRelic2;

    [SerializeField] private GameObject ObjectIhl;
    [SerializeField] private GameObject ObjectTaros;
    [SerializeField] private GameObject ObjectYohn;
    [SerializeField] private GameObject ObjectAhk;

    public void collectRelic1()
    {
        relic1 = true;
    }

    public void collectRelic2()
    {
        relic2 = true;
    }

    public void collectIhl()
    {
        ihl = true;
    }

    public void collectTaros()
    {
        taros = true;
    }

    public void collectYohn()
    {
        yohn = true;
    }

    public void collectAhk()
    {
        ahk = true;
    }

    public void Relic1Button()
    {
        if(relic1)
        {
            Instantiate(ObjectRelic1, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
    public void Relic2Button()
    {
        if (relic2)
        {
            Instantiate(ObjectRelic2, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void IhlButton()
    {
       if(ihl)
        {
            Instantiate(ObjectIhl, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void TarosButton()
    {
        if (taros)
        {
            Instantiate(ObjectTaros, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void YohnButton()
    {
        if (yohn)
        {
            Instantiate(ObjectYohn, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public void AhkButton()
    {
        if (ahk)
        {
            Instantiate(ObjectAhk, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
