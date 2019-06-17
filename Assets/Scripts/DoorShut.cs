using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorShut : MonoBehaviour
{
    public GameObject Hinge;
    public GameObject TBox;
    public AudioSource ShuttingNoise;

    void OnTriggerEnter()
    {
        Hinge.GetComponent<Animation>().Play("Door2CloseAnim");
        ShuttingNoise.Play();
        TBox.SetActive(false);
    }
}
