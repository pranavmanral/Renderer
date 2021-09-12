using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static TMPro.TMP_Dropdown;

public class MatGroupsDrop : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject MatGrp;
    public GameObject MatGrp2;
    public Transform theLoc;
    public int ser;
    public static bool MatGrpDis2 = true;
    public static bool MatGrpDis = true;
    List<string> Sphere = new List<string>() { "Sphere"};
    List<string> Sphere2 = new List<string>() { "Sphere" };
    public TMPro.TMP_Dropdown dropdown, dropdown2;


    List<string> Group1 = new List<string>() { "Material Group 1" };
    List<string> Group2 = new List<string>() { "Material Group 2" };

    public int addSphere2;

    public int addSphere;


    public Transform theLoc2;

    //public void HandleInputData(int val)
   // {
       // if (val == 1)
       // {
       //     Debug.Log("1");
       // }

       // if (val == 2)
      //  {
       //     Debug.Log("2");
        //}

        //if (val == 3)
       // {
        //    Debug.Log("3");
       // }
        
    //}

    public void CreateGroup()
    {
        ser++;
        if (ser == 1)
        {
            if (MatGrpDis)
            {

                dropdown.AddOptions(Group1);
                dropdown2.AddOptions(Group1);
                MatGrp.SetActive(true);
            }

            else
                MatGrp.SetActive(false);

            //Instantiate(MatGrp, theLoc.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            
        }

        if (ser == 2)
        {
            if (MatGrpDis2)
            {


                dropdown.AddOptions(Group2);
                dropdown2.AddOptions(Group2);
                MatGrp2.SetActive(true);
            }

            else
                MatGrp2.SetActive(false);

            //Instantiate(MatGrp2, theLoc2.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            
        }
       
    }

    public void RemoveGroups()
    {
        if (MatGrpDis2)
        {
            MatGrp2.SetActive(false);
            OptionData option2 = dropdown.options.Find(o => string.Equals(o.text, "Material Group 2"));
            dropdown.options.Remove(option2);
        }

        if (MatGrpDis)
        {
            MatGrp.SetActive(false);
            OptionData option = dropdown.options.Find(o => string.Equals(o.text, "Material Group 1"));
            dropdown.options.Remove(option);

        }

        ser = 0;

    }

    public void AddSphere2()
    {
        addSphere2++;

        if (addSphere2 == 1)
        {
            dropdown2.AddOptions(Sphere2);
        }

    }


    public void AddSphere()
    {
        addSphere++;

        if (addSphere == 1)
        {

            
        }


    }

    

}
