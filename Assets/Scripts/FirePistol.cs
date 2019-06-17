using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Flash;
    public AudioSource GunShot;
    public bool isFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Ammo.ammoCount>=1)
        {
            if(isFiring==false)
            {
                StartCoroutine(FiringPistol());
            }
        }

    }

    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        isFiring = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        Gun.GetComponent<Animation>().Play("PistolShotAnim");
        Flash.SetActive(true);
        Flash.GetComponent<Animation>().Play("MuzzleAnim");
        GunShot.Play();
        Ammo.ammoCount -= 1;
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
}
