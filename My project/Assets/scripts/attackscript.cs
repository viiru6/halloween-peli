using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackscript : MonoBehaviour
{
    public GameObject animaationLähde;
    public bool canAttack = true;
    public float attackCooldown;
    public AudioClip lyömisääni;
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
        Animator anim = animaationLähde.GetComponent<Animator>();
        anim.SetTrigger("attack");
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(lyömisääni);
        StartCoroutine(resetCooldown());
    }

    IEnumerator resetCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
