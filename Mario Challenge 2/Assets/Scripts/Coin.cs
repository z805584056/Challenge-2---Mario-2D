using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin: MonoBehaviour
{

    //audio
    private AudioSource audioSource;
    public AudioClip coinClip;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /* void PlaySound()
     {
         audioSource.PlayOneShot(coinClip, 0.7f);
     }
     */
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            audioSource.PlayOneShot(coinClip,1f);
            Destroy(this.gameObject);
        }
    }

}

