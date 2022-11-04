using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuolemaruutu : peli
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void restart()
    {
        gameObject.SetActive(false);
        GameObject.Instantiate(pelaaja);
        spawnmanager.alive = true;
    }
}
