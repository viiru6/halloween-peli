using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public int MaxHealth = 100;
    int hp;

    private void Start()
    {
        hp = MaxHealth;
    }
    public void sattua(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Debug.Log("kuolla");
            Destroy(gameObject);
        }
    }
}
