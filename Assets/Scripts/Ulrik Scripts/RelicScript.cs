using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicScript : MonoBehaviour
{
    [SerializeField] public GameObject currentRune;
    [SerializeField] public GameObject currentRelic;
    [SerializeField] public GameObject otherRelic;

    private DraggableObject draggable;
    [SerializeField] private LayerMask RuneMask;
    [SerializeField] private LayerMask RelicMask;
    [SerializeField]private float scale = 2;
    private SpriteRenderer spriteRenderer;
    private Collider2D detectedRune;
    private Collider2D detectedRelic;

    [SerializeField] private Transform attachedRunePos;
    [SerializeField] private Transform attachedRelicPos;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        draggable = GetComponent<DraggableObject>();
    }


    private void Update()
    {
        AttachedRuneFollows();
        DetectRune();
        ArtDissapersWhenHeld();
        //DetectOtherRelic();
        AttachedOtherRelicFollow();
    }
    private void DetectRune()
    {
        if (currentRune == null)
        {
            if (Physics2D.OverlapBox(transform.position, new Vector2(scale, scale), 0, RuneMask))
            {
                detectedRune = Physics2D.OverlapBox(transform.position, new Vector2(scale, scale), 0, RuneMask);
                if (!detectedRune.gameObject.GetComponent<DraggableObject>().isHeld && !draggable.isHeld)
                {
                    currentRune = detectedRune.gameObject;
                }
            }
            else
            {
                detectedRune = null;
            }




        }
    }



    private void AttachedRuneFollows()
    {
        if (currentRune != null)
        {
            currentRune.transform.position = attachedRunePos.position;

            if (currentRune.GetComponent<DraggableObject>().isHeld == true)
            {
                currentRune = null;
            }
        }
    }
    private void DetectOtherRelic()
    {
        if (currentRelic == null)
        {
            if (Physics2D.OverlapBox(attachedRelicPos.position, new Vector2(scale, scale), 0, RelicMask))
            {
                detectedRelic = Physics2D.OverlapBox(transform.position, new Vector2(scale, scale), 0, RelicMask);
                if (!detectedRelic.gameObject.GetComponent<DraggableObject>().isHeld && !draggable.isHeld && currentRelic != gameObject)
                {
                    currentRelic = detectedRelic.gameObject;
                }
            }
            else
            {
                detectedRelic = null;
            }
        }
    }
    private void AttachedOtherRelicFollow()
    {
        if (currentRelic == gameObject)
        {
            currentRelic = null;
        }
        if (currentRelic != null)
        {
            if (draggable.isHeld)
            {

                currentRelic.transform.position = attachedRelicPos.position;
            }
            /*
            if (currentRelic.GetComponent<Draggable>().isHeld == true)
            {
                currentRelic = null;
            }
            */
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Check that it is being run in Play Mode, so it doesn't try to draw this in Editor mode

        //Draw a cube where the OverlapBox is (positioned where your GameObject is as well as a size)
        Gizmos.DrawWireCube(transform.position, new Vector2(scale, scale));
        // Gizmos.DrawWireCube(attachedRelicPos.position, new Vector2(scale, scale));
    }

    private void ArtDissapersWhenHeld()
    {


        if (detectedRune)
        {

            spriteRenderer.enabled = true;
        }
        if (detectedRune == null)
        {
            spriteRenderer.enabled = false;
        }


    }
}
