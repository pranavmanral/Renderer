using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MatGroupsDrop : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject MatGrp;
    public GameObject MatGrp2;
    public Transform theLoc;
    public int ser;
    public static bool MatGrpDis2 = true;
    public static bool MatGrpDis = true;

    public Transform theLoc2;

    public void HandleInputData(int val)
    {
        if (val == 1)
        {
            Debug.Log("1");
        }

        if (val == 2)
        {
            Debug.Log("2");
        }

        if (val == 3)
        {
            Debug.Log("3");
        }
        
    }

    public void CreateGroup()
    {
        ser++;
        if (ser == 1)
        {
            if (MatGrpDis)

                MatGrp.SetActive(true);

            else
                MatGrp.SetActive(false);

            Instantiate(MatGrp, theLoc.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            
        }

        if (ser == 2)
        {
            if (MatGrpDis2)

                MatGrp2.SetActive(true);

            else
                MatGrp2.SetActive(false);

            Instantiate(MatGrp2, theLoc2.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            
        }
       
    }

    

}
