using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaajaOsuma : enemyStats
{
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            sattua(5);
        }

    }
}
