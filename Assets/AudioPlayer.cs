using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Stop();
        Audio.PlayDelayed(0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
