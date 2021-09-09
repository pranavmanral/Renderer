using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public int serialCube;
    public int serialSphere;

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
    public Transform theLocation2;

    public GameObject CubeAdded;
    public static bool CubeDisabled = true;

    public GameObject optloc1;
    public static bool optlocDisabled = true;

    public GameObject AddMat;
    public static bool AddMatDis = true;

    public GameObject AssignToGroup;
    public static bool AssignDis = true;

    public GameObject AssignToGroup2;
    public static bool AssignDis2 = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
        
    }

    public void Assign2()
    {
        if (AssignDis2)

            AssignToGroup2.SetActive(true);

        else
            AssignToGroup2.SetActive(false);
    }

    public void CloseAssign2()
    {
        if (AssignDis2)

            AssignToGroup2.SetActive(false);

        else
            AssignToGroup2.SetActive(true);
    }


    public void Assign()
    {
        if (AssignDis)

            AssignToGroup.SetActive(true);

        else
            AssignToGroup.SetActive(false);
    }

    public void CloseAssign()
    {
        if (AssignDis)

            AssignToGroup.SetActive(false);

        else
            AssignToGroup.SetActive(true);
    }

    public void MatAdd()
    {
        if (AddMatDis)

            AddMat.SetActive(true);

        else
            AddMat.SetActive(false);
    }
    public void CloseMatt()
    {
        if (AddMatDis)

            AddMat.SetActive(false);

        else
            AddMat.SetActive(true);
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
        //serialSphere++;

       // if (serialSphere <= 1) //&& serialCube == 0) 
        //{
            if (SphereDisabled)

            {
                SphereAdded.SetActive(true);
                //SphereAdded.transform.SetParent(theLocation, true);
                SphereAdded.transform.position = theLocation.position;
                //serialSphere--;
            }

            else

                //SphereAdded.transform.position = theLocation2.position;
           SphereAdded.SetActive(false);
       }
        //else
        //{

            //SphereAdded.transform.position = theLocation2.position;

       // }

        //serial = 0;

    
    public void AddCube()
    {
       // serialCube++;

       // if (serialCube <= 1 && serialSphere == 0)
       // {
            if (CubeDisabled)

            {
                CubeAdded.SetActive(true);
                //SphereAdded.transform.SetParent(theLocation, true);
                CubeAdded.transform.position = theLocation2.position;
                //serialCube--;
            }

            //else
               // CubeAdded.SetActive(false);
        //}
       // else
       // {

           // CubeAdded.transform.position = theLocation2.position;

        //}

        //serial = 0;

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
