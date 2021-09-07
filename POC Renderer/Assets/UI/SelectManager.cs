using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public GameObject EnableModels;
    public static bool ModelDisabled = true;

    public GameObject EnableMaterials;
    public static bool MatDisabled = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
        
    }

    public void OpenMod()
    {
        if (ModelDisabled)

            EnableModels.SetActive(true);

        else
            EnableModels.SetActive(false);
    }

    public void OpenMat()
    {
        if (MatDisabled)

            EnableMaterials.SetActive(true);

        else
            EnableMaterials.SetActive(false);
    }
}
