using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    Rigidbody2D RB;
    public float Speed;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        int track = spriteRenderer.transform.position.x == 0 ? 2 : spriteRenderer.transform.position.x < 0 ? 1 : 3;
        switch (track)
        {
            case 1: 
                spriteRenderer.color = new Color(0.2039216f, 0.767f, 0f);
                break;
            case 2: 
                spriteRenderer.color = new Color(0.8941177f, 0f, 0f);
                break;
            case 3:
                spriteRenderer.color = new Color(0.1647059f, 0.227451f, 0.7f);
                break;
        }
           
    }
    // Start is called before the first frame update
    void Start()
    {
        RB.velocity = new Vector2(0, -4.3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
