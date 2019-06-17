using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Hinge;
    public AudioSource creepySound;
    public GameObject ExtraCross;
   

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCast.Distance;
    }

    void OnMouseOver()
    {
        if (theDistance <= 1.5)
        {
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 1.5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Hinge.GetComponent<Animation>().Play("Door1OpenAnim");
                creepySound.Play();

            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
            
}

