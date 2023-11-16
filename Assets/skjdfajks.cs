using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skjdfajks : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(sfdjksd());
    }

    IEnumerator sfdjksd()
    {
        while(true)
        {
            GetComponent<Image>().enabled = false;
            yield return new WaitForSeconds(0.05f);
            GetComponent<Image>().enabled = true;

            yield return new WaitForSeconds(0.05f);
        }
         }
}
