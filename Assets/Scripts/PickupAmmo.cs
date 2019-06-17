using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmo : MonoBehaviour
{
    public GameObject AmmoBox;
    public AudioSource Click;
    public GameObject AmmoDisplay;

    void OnTriggerEnter()
    {
        Click.Play();
        AmmoBox.SetActive(false);
        AmmoDisplay.SetActive(true);
        Ammo.ammoCount += 7;
    }
}
