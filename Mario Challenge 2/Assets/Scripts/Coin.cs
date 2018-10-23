using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin: MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }


}

