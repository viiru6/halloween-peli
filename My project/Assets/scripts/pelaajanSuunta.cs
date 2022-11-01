using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaajanSuunta : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
}
