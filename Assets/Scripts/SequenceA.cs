using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class SequenceA : MonoBehaviour
{
    public GameObject Player;
    public GameObject FadeIn;
    public GameObject Dialog;
    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScreenPlay());
    }

    IEnumerator ScreenPlay()
    {
        yield return new WaitForSeconds(1.0f);
        FadeIn.SetActive(false);
        Dialog.GetComponent<Text>().text = "Where am I?";
        yield return new WaitForSeconds(2.0f);
        Dialog.GetComponent<Text>().text = "";
        Player.GetComponent<FirstPersonController>().enabled = true;



    }

}
