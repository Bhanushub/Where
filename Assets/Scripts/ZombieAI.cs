using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theZombie;
    public float walkSpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int Gen;
    public GameObject RedFlash;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if(attackTrigger==false)
        {
            walkSpeed =0.01f;
            theZombie.GetComponent<Animation>().Play("walk1");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, walkSpeed);
           /* if(transform.position == thePlayer.transform.position)
            {
                attackTrigger = true;
            }*/
        }
        if(attackTrigger==true && isAttacking==false)
        {
            walkSpeed = 0f;
            theZombie.GetComponent<Animation>().Play("attack");
            StartCoroutine(CauseDamage());
        }
    }

    IEnumerator CauseDamage()
    {
        isAttacking = true;
        Gen = Random.Range(1, 4);
        yield return new WaitForSeconds(1f);
        Health.currentHealth -= 3;
       if(Gen==1)
        {
            hurtSound1.Play();
        }else if(Gen==2)
        {
            hurtSound2.Play();
        }else if(Gen==3)
        {
            hurtSound3.Play();
        }
        RedFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        RedFlash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        isAttacking = false;
    }

    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }
    
}
