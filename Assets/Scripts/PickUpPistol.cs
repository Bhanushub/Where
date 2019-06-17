using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPistol : MonoBehaviour
{
    public float theDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject ExtraCross;
    public GameObject Arrow;

    public GameObject Zombie;
   

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
            ActionText.GetComponent<Text>().text = "Pick up pistol.";
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
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                Arrow.SetActive(false);
                Zombie.SetActive(true);

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

