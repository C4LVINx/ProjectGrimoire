using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    private int currentFrame;
    private float frameTimer;
    private int frameCount;


    [SerializeField] private List<CursorAnimation> cursorAnimationList;

    private CursorAnimation cursorAnimation;
    public enum CursorType
    {
        Idle, 
        Grab,
        Point
    }
    void Start()
    {
        SetActiveCursorAnimation(cursorAnimationList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0f)
        {
            frameTimer += cursorAnimation.frameRate;
            currentFrame = (currentFrame + 1) % frameCount;
            Cursor.SetCursor(cursorAnimation.textureArray[currentFrame], cursorAnimation.offset, CursorMode.Auto);
        }

        if (Input.GetKeyDown(KeyCode.T)) SetActiveCursorAnimation(cursorAnimationList[0]);
        if (Input.GetKeyDown(KeyCode.Y)) SetActiveCursorAnimation(cursorAnimationList[1]);
    }

    private void SetActiveCursorAnimation(CursorAnimation cursorAnimation)
    {
        this.cursorAnimation = cursorAnimation;
        currentFrame = 0;
        frameTimer = cursorAnimation.frameRate;
        frameCount = cursorAnimation.textureArray.Length;
    }

    [System.Serializable]
    public class CursorAnimation
    {
        public CursorType cursorType;
        public Texture2D[] textureArray;
        public float frameRate;
        public Vector2 offset;
    }
}
