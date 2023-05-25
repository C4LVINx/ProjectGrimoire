using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    Vector3 MousepositionOffsett;
    public bool isHeld;
    private Vector3 GetMouseworldposition()
    {
        //Get mouse position & Return world point
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        MousepositionOffsett = gameObject.transform.position - GetMouseworldposition();
        isHeld = true;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseworldposition() + MousepositionOffsett;
    }
    private void OnMouseUp()
    {
        isHeld = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        Debug.Log("Wow i am colliding");
        if (collision.gameObject.CompareTag("Trash"))
        {
            Destroy(gameObject);
        }
        */
    }

   
}