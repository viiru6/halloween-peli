using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peli : MonoBehaviour
{
    void Start()
    {
        GameObject.Instantiate(Resources.Load("Prefabs/mainmenu"));
    }
}