using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skjdfajks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sfdjksd());
    }

    // Update is called once per frame
    void Update()
    {
        
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
