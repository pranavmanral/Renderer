using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public int opt;

    public GameObject EnableModels;
    public static bool ModelDisabled = true;

    public GameObject EnableMaterials;
    public static bool MatDisabled = true;

    public GameObject EnableAdd;
    public static bool AddDisabled = true;

    public GameObject EnableAdd2;
    public static bool AddDisabled2 = true;

    public GameObject SphereAdded;
    public static bool SphereDisabled = true;
    public Transform theLocation;

    public GameObject optloc1;
    public static bool optlocDisabled = true;



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

    public void Optloc()
    {
        if (optlocDisabled)

            optloc1.SetActive(true);

        else
            optloc1.SetActive(false);
    }

    //public void AddSphere()
   // {
      //  opt++;

       // if (opt == 1)
       // {
        //    Instantiate(SphereAdded, theLocation.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
       // }
   // }

    public void AddSphere()
    {
        opt++;

        if (opt == 1)
        {
            if (SphereDisabled)

            {
                SphereAdded.SetActive(true);
                //SphereAdded.transform.SetParent(theLocation, true);
                SphereAdded.transform.position = theLocation.position;
            }

            else
                SphereAdded.SetActive(false);
        }
    }

    public void CloseMod()
    {
        if (ModelDisabled)

            EnableModels.SetActive(false);

        else
            EnableModels.SetActive(true);
    }

    public void OpenMat()
    {
        if (MatDisabled)

            EnableMaterials.SetActive(true);

        else
            EnableMaterials.SetActive(false);
    }

    public void CloseMat()
    {
        if (MatDisabled)

            EnableMaterials.SetActive(false);

        else
            EnableMaterials.SetActive(true);
    }

    public void AddModels1()
    {
        if (AddDisabled)

            EnableAdd.SetActive(true);

        else
            EnableAdd.SetActive(false);
    }
    public void CloseAddOp()
    {
        if (AddDisabled)

            EnableAdd.SetActive(false);

        else
            EnableAdd.SetActive(true);
    }

    public void AddModels2()
    {
        if (AddDisabled2)

            EnableAdd2.SetActive(true);

        else
            EnableAdd2.SetActive(false);
    }
    public void CloseAddOp2()
    {
        if (AddDisabled2)

            EnableAdd2.SetActive(false);

        else
            EnableAdd2.SetActive(true);
    }
}
