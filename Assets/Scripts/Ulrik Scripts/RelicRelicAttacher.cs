using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RelicRelicAttacher : MonoBehaviour
{
    private DraggableObject draggable;
 

    [SerializeField] private float overlapBoxScale = 1f;
    [HideInInspector] public bool IsAttachable;

    public GameObject currentRelic;
    public GameObject RelicThisAttachedTo;
    [SerializeField] private LayerMask RelicMask;

    [SerializeField] public Transform attachedRelicPos;
    [SerializeField] public Transform attachedRelicLeft;
    private Collider2D detectedRelic;
    private void Start()
    {
        draggable = GetComponent<DraggableObject>();
      
    }


    private void Update()
    {
        DetectRelic();
        ChildRelic();
        RelicDetaching();
        //FixWhackBug();
    }

    private void DetectRelic()
    {
        if (currentRelic == null || RelicThisAttachedTo == null)
        {
            if (Physics2D.OverlapBox(attachedRelicPos.position + new Vector3(-0.4f, -0.6f, 0), new Vector2(overlapBoxScale, overlapBoxScale), 0, RelicMask))
            {
                detectedRelic = Physics2D.OverlapBox(attachedRelicPos.position + new Vector3(-0.4f, -0.6f, 0), new Vector2(overlapBoxScale, overlapBoxScale), 0, RelicMask);
                if (!detectedRelic.gameObject.GetComponent<DraggableObject>().isHeld && !draggable.isHeld && IsAttachable && detectedRelic.GetComponent<RelicRelicAttacher>().IsAttachable && !RelicThisAttachedTo)
                {
                    currentRelic = detectedRelic.gameObject;
                    currentRelic.GetComponent<RelicRelicAttacher>().RelicThisAttachedTo = gameObject;
                }

  
            }
            else
            {
                detectedRelic = null;
            }
        }

        if(currentRelic == gameObject)
        {
            currentRelic = null;
        }

        
    }

    private void FixWhackBug()
    {
        if(currentRelic != null)
        {
            if (currentRelic.GetComponent<RelicRelicAttacher>().RelicThisAttachedTo = currentRelic)
            {
                currentRelic.GetComponent<RelicRelicAttacher>().RelicThisAttachedTo = gameObject;
            }
        }
        
    }

    private void ChildRelic()
    {
        if(currentRelic != null)
        {

        

            if(currentRelic.GetComponent<DraggableObject>().isHeld)
            {
                transform.position = currentRelic.GetComponent<RelicRelicAttacher>().attachedRelicLeft.position;
            }
            else
            {
                currentRelic.transform.position = attachedRelicPos.position;
            }
        }
    }

    private void RelicDetaching()
    {
        if(draggable.isHeld)
        {
            IsAttachable = true;
            if(detectedRelic != null)
            {
                detectedRelic.GetComponent<RelicRelicAttacher>().IsAttachable = true;
            }
        }
        if(detectedRelic != null)
        {
            if (detectedRelic.GetComponent<DraggableObject>().isHeld)
            {
                IsAttachable = true;
            }
        }
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(currentRelic != null)
            {
                IsAttachable = false;
            currentRelic.GetComponent<RelicRelicAttacher>().IsAttachable = false;
                currentRelic.GetComponent<RelicRelicAttacher>().RelicThisAttachedTo = null;
            currentRelic = null;
          
            }

            if(RelicThisAttachedTo != null)
            {
                IsAttachable = false;
                RelicThisAttachedTo.GetComponent<RelicRelicAttacher>().IsAttachable=false;
                RelicThisAttachedTo.GetComponent<RelicRelicAttacher>().currentRelic = null;
                RelicThisAttachedTo = null;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        //Check that it is being run in Play Mode, so it doesn't try to draw this in Editor mode

        //Draw a cube where the OverlapBox is (positioned where your GameObject is as well as a size)
        Gizmos.DrawWireCube(attachedRelicPos.position + new Vector3(-0.4f,-0.8f,0), new Vector2(overlapBoxScale, overlapBoxScale));
        // Gizmos.DrawWireCube(attachedRelicPos.position, new Vector2(scale, scale));
    }


}
