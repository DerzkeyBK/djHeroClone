using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public KeyCode Key;
    public bool Active=false;
    public GameObject Note;
    Color Old;
    public int Points;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Old = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            StartCoroutine(Pressed());
        }
        if (Input.GetKeyDown(Key)&&Active){
            Destroy(Note);
            AddScore();
            Active = false;
        }
    }
    

    void OnTriggerEnter2D(Collider2D Col){
        Active=true;
        if(Col.gameObject.tag=="Note"){
            Note= Col.gameObject;
        }
    }
    
    void OnTriggerExit2D(Collider2D Col){
        Active=false;
    }

    IEnumerator Pressed()
    {
        spriteRenderer.color = new Color(0,0,0);
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Old;
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + Points);
    }
}
