using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class FirstTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject Dialog;
    public GameObject Marker;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlay());
    }

    IEnumerator ScenePlay()
    {
        Dialog.GetComponent<Text>().text = "What is that?";
        yield return new WaitForSeconds(1.5f);
        Dialog.GetComponent<Text>().text = "Looks like a gun.";
        yield return new WaitForSeconds(1.0f);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        Marker.SetActive(true);
        this.gameObject.SetActive(false);
        Dialog.GetComponent<Text>().text = " ";
    }
}
