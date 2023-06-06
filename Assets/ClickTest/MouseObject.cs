using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseObject : MonoBehaviour
{
    [SerializeField] private MouseCursor.CursorType cursorType;

    private void OnMouseEnter()
    {
        MouseCursor.Instance.SetActiveCursorType(cursorType);
    }

    private void OnMouseExit()
    {
        MouseCursor.Instance.SetActiveCursorType(MouseCursor.CursorType.Idle);
    }
}
