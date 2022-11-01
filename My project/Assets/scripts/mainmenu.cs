using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void poistu()
    {
        Application.Quit();
    }
    public void pelaa()
    {
        GameObject menu;
        menu = GameObject.Find("mainmenu(Clone)");
        menu.SetActive(false); 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}