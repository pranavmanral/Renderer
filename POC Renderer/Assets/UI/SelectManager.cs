using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectManager : MonoBehaviour
{
    public Adding adding;
    public GameObject Addbutt;
    public MatGroupsDrop matgroupsdrop;
    public int serialCube;
    public int serialSphere;
    public GameObject Obj_Sphere;
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

    public GameObject Cube;
    public Transform loc;
    public GameObject sphere;
    
    public int SphereNum;
    public int CubeNum;
    public TextMeshProUGUI Cubes;

    public TextMeshProUGUI Spheres;
    public GameObject sph;
    public static bool sphdis = true;
    public int SphNum;

    public TextMeshProUGUI SphAddText;
    public int NumSph;

    public GameObject RemoveButton;
    public static bool removeDis = true;

    public GameObject MatAdd1;
    public static bool Mat1Dis = true;

    public GameObject MatAdd2;
    public static bool Mat2Dis = true;
    

    public GameObject MatAdd3;
    public static bool Mat1Dis3 = true;

    public GameObject MatAdd4;
    public static bool Mat2Dis4 = true;

    public GameObject Options2;
    public static bool Options2Dis = true;




   // void Start()
    //{
        //adding = FindObjectOfType<Adding>();
    //}



    public void Options2Fun()
    {
        if (Options2Dis)
        {
            Options2.SetActive(true);
        }
        else
        {
            Options2.SetActive(false);
        }
    }


    public void Options2FunClose()
    {
        if (Options2Dis)
        {
            Options2.SetActive(false);
        }
        else
        {
            Options2.SetActive(true);
        }
    }

    /// <summary>
    /// ///
    /// </summary>






    public void AssMat3()
    {
        if (Mat1Dis3)
        {
            MatAdd3.SetActive(true);
        }
        else
        {
            MatAdd3.SetActive(false);
        }
    }

    public void AssMatClose3()
    {
        if (Mat1Dis3)
        {
            MatAdd3.SetActive(false);
        }
        else
        {
            MatAdd3.SetActive(true);
        }
    }

    public void AssMat4()
    {
        if (Mat2Dis4)
        {
            MatAdd4.SetActive(true);
        }
        else
        {
            MatAdd4.SetActive(false);
        }
    }

    public void AssMatClose4()
    {
        if (Mat2Dis4)
        {
            MatAdd4.SetActive(false);
        }
        else
        {
            MatAdd4.SetActive(true);
        }
    }


    


    public void AssMat()
    {
        if (Mat1Dis)
        {
            MatAdd1.SetActive(true);
        }
        else
        {
            MatAdd1.SetActive(false);
        }
    }

    public void AssMatClose()
    {
        if (Mat1Dis)
        {
            MatAdd1.SetActive(false);
        }
        else
        {
            MatAdd1.SetActive(true);
        }
    }

    public void AssMat2()
    {
        if (Mat2Dis)
        {
            MatAdd2.SetActive(true);
        }
        else
        {
            MatAdd2.SetActive(false);
        }
    }

    public void AssMat2Close()
    {
        if (Mat2Dis)
        {
            MatAdd2.SetActive(false);
        }
        else
        {
            MatAdd2.SetActive(true);
        }
    }



    void Start()
    {
        adding = FindObjectOfType<Adding>();
        matgroupsdrop = FindObjectOfType<MatGroupsDrop>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SphereNum > 0)
        {
            OpenRemove();
        }

        if (SphereNum <= 0)
        {
            RemoveDis();
            Addbutt.SetActive(false);
        }

        //Debug.Log(SphereNum);
        if (SphereNum == 0)
        {
            //Addbutt.SetActive(false);
            Debug.Log("Remove Button");
        }
        //else
       /// {
            //Addbutt.SetActive(true);
        //}
        //if(matgroupsdrop.ser == 0)
       // {

        //} 
        
    }
    public void OpenRemove()
    {
        if (removeDis)
        {
            RemoveButton.SetActive(true);
        }  
        else
        {
            RemoveButton.SetActive(false);
        }
    }

    public void RemoveDis()
    {
        if (removeDis)
        {
            RemoveButton.SetActive(false);
        }
        else
        {
            RemoveButton.SetActive(true);
        }
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
            
            //Instantiate(sphere.gameObject, loc.position, transform.rotation);
            SphereNum++;
            Spheres.text = SphereNum.ToString();
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
      public void SubtractSpheres()
    {
        if (SphereNum > 0)
        {
            SphereNum--;
            //Destroy(GameObject.FindWithTag("Sphere"));
            Spheres.text = SphereNum.ToString();
        }

        if (SphereNum <= 0)
        {
            //Destroy(GameObject.FindWithTag("Sphere"));
            SphereNum = 0;
            Spheres.text = SphereNum.ToString();
        }
    }

    public void SubtractSpheres2()
    {
        if (SphereNum > 0)
        {
            
            Destroy(GameObject.FindWithTag("Sphere"));
        }

        if (SphereNum <= 0)
        {
            Destroy(GameObject.FindWithTag("Sphere"));
            
        }
    }

    public void SphAdd()
    {
        if (sphdis)
        {
            sph.SetActive(true);

            //Spheres.text = SphereNum.ToString();
           // if (adding.GroupOne == true)
           // {
                if (SphereNum > 0)
                {

                    SphereNum--;

                    Spheres.text = SphereNum.ToString();

                    NumSph++;

                    SphAddText.text = NumSph.ToString();

                }
           // }
        }
        else
            sph.SetActive(false);
  
        
    }

    public void SphClose()
    {
        if (sphdis)

            sph.SetActive(false);

        else
            sph.SetActive(true);
    }
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
                Instantiate(Cube.gameObject, loc.position, transform.rotation);
                 CubeNum++;
                 Cubes.text = CubeNum.ToString();


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
