using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitch2 : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchMatA()
    {
        rend.sharedMaterial = material[0];
    }

    public void SwitchMatB()
    {
        rend.sharedMaterial = material[1];
    }
}
