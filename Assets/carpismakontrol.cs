using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpismakontrol : MonoBehaviour {

     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="engel")
        {
            gameObject.SetActive(false);
            FindObjectOfType<olme>().GameOver();
        }
    }
}
