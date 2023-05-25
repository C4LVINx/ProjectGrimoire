using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    [SerializeField] private Transform DefaultPos;
    [SerializeField] private Transform Relic1Pos;
    [SerializeField] private Transform Relic2Pos;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Rune"))
        {
            Debug.Log("Object trashed");
            collision.gameObject.transform.position = DefaultPos.position;
        }
        if(collision.gameObject.CompareTag("Relic1"))
        {
            Debug.Log("Object trashed");
            collision.gameObject.transform.position = Relic1Pos.position;
        }
        if (collision.gameObject.CompareTag("Relic2"))
        {
            Debug.Log("Object trashed");
            collision.gameObject.transform.position = Relic2Pos.position;
        }
    }
}
