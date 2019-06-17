using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{
    public int Mode;
    public GameObject Light;

    // Update is called once per frame
    void Update()
    {
        if(Mode==0)
        {
            StartCoroutine(AnimateLight());
        }
    }

    IEnumerator AnimateLight()
    {
        Mode = Random.Range(1, 4);
        if(Mode==1)
        {
            Light.GetComponent<Animation>().Play("TorchAnim1");
        }
        if(Mode==2)
        {
            Light.GetComponent<Animation>().Play("TorchAnim2");
        }
        if(Mode==3)
        {
            Light.GetComponent<Animation>().Play("TorchAnim3");
        }

        yield return new WaitForSeconds(1f);
        Mode = 0;


    }
}
