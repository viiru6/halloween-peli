using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuolemaruutu : peli
{
    GameObject kuolemaruu;
    private void Start()
    {
        kuolemaruu = GameObject.Find("kuolemaRuutu(Clone)");
    }
    public void restart()
    {
        kuolemaruu.SetActive(false);
        GameObject.Instantiate(pelaaja);

    }
}
