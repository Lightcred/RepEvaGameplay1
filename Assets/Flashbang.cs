using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashbang : MonoBehaviour
{
    public float delay = 0.05f;
    private void OnEnable()
    {
        StartCoroutine(Epilepsy());
    }

    IEnumerator Epilepsy()
    {
        while (true)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(delay);
            GetComponent<SpriteRenderer>().enabled = true;

            yield return new WaitForSeconds(delay);
        }
    }
}
