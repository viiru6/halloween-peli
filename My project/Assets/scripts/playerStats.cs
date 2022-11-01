using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    
    public int MaxHealth = 100;
    int hp;
    GameObject pelaaja;
    GameObject menuD;
    private void Start()
    {
        hp = MaxHealth;
    }
    [SerializeField]
    public void sattua(int damage)
    {
        bool menuOpen = false;
        pelaaja = GameObject.Find("pelaaja");
        Debug.Log(hp);
        hp -= damage;
        if (hp <= 0)
        {
            Debug.Log("kuolla");
            try
            {
                if (menuOpen)
                {
                    menuD = GameObject.Find("mainmenu(Clone)");
                    Destroy(menuD);
                    GameObject.Instantiate(Resources.Load("Prefabs/kuolemaRuutu"));
                    hp++;
                    menuOpen = true;
                }
            }
            catch { }
            Destroy(pelaaja);
        }
    }
}
