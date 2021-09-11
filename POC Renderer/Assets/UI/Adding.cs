using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adding : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;
    public int ser2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void HandleInputData(int val)
    {
        if (val == 1)
        {
            Debug.Log("Material 1");
            ser2++;
        }

        if (val == 2)
        {
            Debug.Log("Material 2");
            //ser2++;
        }

        

    }

    public void Add()
    {
        if (ser2 == 1)

            Debug.Log("Sphere Added into Material Group 1");

    }
    //public void Remove()
   // {
      //  dropdown.options.RemoveAt(1);
   //     
   // }

    

}
