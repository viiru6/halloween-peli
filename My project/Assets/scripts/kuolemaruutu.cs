using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuolemaruutu : peli
{
    public void restart()
    {
        gameObject.SetActive(false);
        GameObject.Instantiate(pelaaja);
    }
}
