using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    private AudioSource audioSource;
    public List<AudioClip> triggerSounds;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
       int i = Random.Range(0, triggerSounds.Count);
       audioSource.PlayOneShot(triggerSounds[i]);
      
       
    }
}
