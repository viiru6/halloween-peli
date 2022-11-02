using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaajaOsuma : MonoBehaviour
{
    public int damage = 5;
    playerStats ps;
    private void OnTriggerEnter(Collider collision)
    {
        ps = gameObject.AddComponent<playerStats>();
        if (collision.gameObject.tag == "enemy")
        {
            ps.sattua(damage);
        }
    }
}
