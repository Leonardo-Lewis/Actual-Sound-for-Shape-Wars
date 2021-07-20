using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime; // NEW
    private AudioSource audioSource;
    public List<AudioClip> triggerSounds;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
        audioSource = GetComponent<AudioSource>();
        int i = Random.Range(0, triggerSounds.Count);
        audioSource.PlayOneShot(triggerSounds[i]);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
