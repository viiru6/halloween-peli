using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peli : MonoBehaviour
{
    public GameObject pelaaja;
    void Start()
    {
        pelaaja = GameObject.Find("pelaaja");
        GameObject.Instantiate(Resources.Load("Prefabs/mainmenu"));

    }
    private void Update()
    {
     if(pelaaja == null)
        {
            GameObject.Instantiate(Resources.Load("Prefabs/kuolemaRuutu"));
        }
    }
    
}