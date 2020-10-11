using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrackRight : MonoBehaviour
{
    public float movement;
    SpriteRenderer spriteRenderer;
    public KeyCode Key;
    private float InitialPosition;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InitialPosition = spriteRenderer.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Key))
        {
            Move(InitialPosition + movement);
        }
        else
        {
            Move(InitialPosition);
        }
    }

    void Move(float position)
    {
        spriteRenderer.transform.SetPositionAndRotation(new Vector3(position, spriteRenderer.transform.position.y, spriteRenderer.transform.position.z), new Quaternion());
    }   
}
