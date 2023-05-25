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
    public bool hek = false;

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
    [SerializeField] private GameObject ObjectHek;

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
    public void collectHek()
    {
        hek = true;
    }

    public void Relic1Button()
    {
        if(relic1)
        {
            ObjectRelic1.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
    public void Relic2Button()
    {
        if (relic2)
        {
            ObjectRelic2.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }

    public void IhlButton()
    {
       if(ihl)
        {
            ObjectIhl.transform.position = new Vector3(-2.5f, -1, 0);
            //Instantiate(ObjectIhl, new Vector3(-2.5f, -1, 0), Quaternion.identity);
        }
    }

    public void TarosButton()
    {
        if (taros)
        {
            ObjectTaros.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }

    public void YohnButton()
    {
        if (yohn)
        {
            ObjectYohn.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }

    public void AhkButton()
    {
        if (ahk)
        {
            ObjectAhk.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
    public void TerButton()
    {
        if (ter)
        {
            ObjectTer.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }

    public void MaratButton()
    {
        if (marat)
        {
            ObjectMarat.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
    public void NekButton()
    {
        if (nek)
        {
            ObjectNek.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
    public void SethButton()
    {
        if (seth)
        {
            ObjectSeth.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
    public void HekButton()
    {
        if (hek)
        {
            ObjectHek.transform.position = new Vector3(-2.5f, -1, 0);
        }
    }
}
