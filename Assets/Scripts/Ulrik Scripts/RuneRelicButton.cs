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
    public bool ter = false;
    public bool marat = false;
    public bool nek = false;
    public bool seth = false;

    [SerializeField] private GameObject ObjectRelic1;
    [SerializeField] private GameObject ObjectRelic2;

    [SerializeField] private GameObject ObjectIhl;
    [SerializeField] private GameObject ObjectTaros;
    [SerializeField] private GameObject ObjectYohn;
    [SerializeField] private GameObject ObjectAhk;
    [SerializeField] private GameObject ObjectTer;
    [SerializeField] private GameObject ObjectMarat;
    [SerializeField] private GameObject ObjectNek;
    [SerializeField] private GameObject ObjectSeth;

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
    public void collectTer()
    {
        ter = true;
    }
    public void collectMarat()
    {
        marat = true;
    }
    public void collectNek()
    {
        nek = true;
    }

    public void collectSeth()
    {
        seth = true;
    }

    public void Relic1Button()
    {
        if(relic1)
        {
            Instantiate(ObjectRelic1, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }
    public void Relic2Button()
    {
        if (relic2)
        {
            Instantiate(ObjectRelic2, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void IhlButton()
    {
       if(ihl)
        {
            Instantiate(ObjectIhl, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void TarosButton()
    {
        if (taros)
        {
            Instantiate(ObjectTaros, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void YohnButton()
    {
        if (yohn)
        {
            Instantiate(ObjectYohn, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void AhkButton()
    {
        if (ahk)
        {
            Instantiate(ObjectAhk, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }
    public void TerButton()
    {
        if (ter)
        {
            Instantiate(ObjectTer, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void MaratButton()
    {
        if (marat)
        {
            Instantiate(ObjectMarat, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }
    public void NekButton()
    {
        if (nek)
        {
            Instantiate(ObjectSeth, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }
    public void SethButton()
    {
        if (seth)
        {
            Instantiate(ObjectSeth, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }
}
