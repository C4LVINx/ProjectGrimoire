using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicRelicAttacher : MonoBehaviour
{
    private DraggableObject draggable;

    [SerializeField] private float overlapBoxScale = 1;

    private GameObject currentRelic;
    [SerializeField] private LayerMask RelicMask;

    [SerializeField] private Transform attachedRelicPos;
    private Collider2D detectedRelic;
    private void start()
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

    
    
}
