using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Adding : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;
    public int ser2;
    public int ser3;
    public int SphereNum;
    public GameObject SphereParent;
    public bool Added = false;
    public bool GroupOne = false;

    public GameObject sphere;
    public GameObject loc;

    void Start()
    {

    }

    void Update()
    {
       // if (Added == true)
        //{

        //}
    }

    void Addition()
    {
        Debug.Log("Addition");
        //GameObject.Find("Sphere_Obj").transform.SetParent(SphereParent.transform);


        //GameObject.FindWithTag("Sphere").transform.SetParent(SphereParent.transform);
    }



    public void HandleInputData(int val)
    {
        
        
        if (val == 1)
        {

            Added = true;
            Debug.Log(Added);
            ser3 = 1;
           
        }
        else
        {
            Added = false;
            ser3 = 0;
        }

        //if (val == 1)
        //{
          //  ser3 = 2;

        //}

        

    }

    public void Add()
   {

       if (ser3 == 1)
        {
            Instantiate(sphere.gameObject, loc.transform.position, transform.rotation);
            //Added = true;

            Addition();
            Debug.Log("Sphere Added to Material 1");
        }

        //if (ser3 == 2)
        //{
           // Debug.Log("Sphere Added to Material 2");
        //}

    }
    //public void Remove()
   // {
      //  dropdown.options.RemoveAt(1);
   //     
   // }

    

}
