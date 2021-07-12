using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Pipe pipePuzzle;
    public LockCameraTrigger digitLock;

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = pipePuzzle.cursorIsVisible || digitLock.cursorIsVisible;
    }
}
