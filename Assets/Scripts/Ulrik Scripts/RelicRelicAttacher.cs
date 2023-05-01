using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RelicRelicAttacher : MonoBehaviour
{
    private DraggableObject draggable;

    [SerializeField] private float overlapBoxScale = 1;

    private GameObject currentRelic;
    [SerializeField] private LayerMask RelicMask;

    [SerializeField] private Transform attachedRelicPos;
    private Collider2D detectedRelic;
    private void Start()
    {
        draggable = GetComponent<DraggableObject>();
    }


    private void Update()
    {
        if(currentRelic == null)
        {
            if (Physics2D.OverlapBox(attachedRelicPos.position, new Vector2(overlapBoxScale, overlapBoxScale), 0, RelicMask))
            {
                detectedRelic = Physics2D.OverlapBox(attachedRelicPos.position, new Vector2(overlapBoxScale, overlapBoxScale), 0, RelicMask);
                if (!detectedRelic.gameObject.GetComponent<DraggableObject>().isHeld && !draggable.isHeld)
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
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        //Check that it is being run in Play Mode, so it doesn't try to draw this in Editor mode

        //Draw a cube where the OverlapBox is (positioned where your GameObject is as well as a size)
        Gizmos.DrawWireCube(attachedRelicPos.position, new Vector2(overlapBoxScale, overlapBoxScale));
        // Gizmos.DrawWireCube(attachedRelicPos.position, new Vector2(scale, scale));
    }


}
