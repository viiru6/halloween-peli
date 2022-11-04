using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackscript : MonoBehaviour
{
    public GameObject animaationL�hde;
    public bool canAttack = true;
    public float attackCooldown;
    public AudioClip ly�mis��ni;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (canAttack)
            {
                attack();
            }
        }
    }
    public void attack()
    {
        canAttack = false;
        Animator anim = animaationL�hde.GetComponent<Animator>();
        anim.SetTrigger("attack");
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(ly�mis��ni);
        StartCoroutine(resetCooldown());
    }

    IEnumerator resetCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
