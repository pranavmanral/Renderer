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
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    



    public void HandleInputData(int val)
    {
        
        
        if (val == 0)
        {
            
            
            ser3 = 1;
                
           
        }

        if (val == 1)
        {
            ser3 = 2;

        }

        

    }

    public void Add()
   {

       if (ser3 == 1)
        {
            Debug.Log("Material 1 Added");
        }

        if (ser3 == 2)
        {
            Debug.Log("Material 2 Added");
        }

    }
    //public void Remove()
   // {
      //  dropdown.options.RemoveAt(1);
   //     
   // }

    

}
