using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class KeyPressPlay : MonoBehaviour
{
    public string tecla;
    public StudioEventEmitter sonidito;

    private void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            sonidito.Play();
        }
    }
}
