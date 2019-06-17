using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public static int ammoCount;
    public GameObject AmmoDisplay;
    public int internalAmmo;

    void Update()
    {
        internalAmmo = ammoCount;
        AmmoDisplay.GetComponent<Text>().text = " " + ammoCount;
    }
}
