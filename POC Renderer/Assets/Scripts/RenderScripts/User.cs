using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public Render snapCam;
    public Render2 snapCam2;
    public Render3 snapCam3;
    public Render4 snapCam4;
    public MaterialSwitch materialSwitch;
    public MaterialSwitch2 materialSwitch2;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
        //{

            

        //}
        
    }
    public void Click()
    {
        
        StartCoroutine(Snap3());

    }

    
    IEnumerator Snap3()
    {
        materialSwitch.SwitchMat();
        materialSwitch2.SwitchMatA();
        yield return new WaitForSeconds(3);
        snapCam.snap();
        Debug.Log("Snapped1");


        yield return new WaitForSeconds(2);
        materialSwitch2.SwitchMatB();
        yield return new WaitForSeconds(3);
        snapCam.snap();
        Debug.Log("Snapped2");



        yield return new WaitForSeconds(2);
        materialSwitch.SwitchMat2();
        materialSwitch2.SwitchMatA();
        yield return new WaitForSeconds(3);
        snapCam.snap();
        Debug.Log("Snapped3");






        yield return new WaitForSeconds(2);
        materialSwitch2.SwitchMatB();
        yield return new WaitForSeconds(3);
        snapCam.snap();
        Debug.Log("Snapped4");


        ////////////////////////////////////////////


        //yield return new WaitForSeconds(3);
        //Debug.Log("Loading");
        //snapCam2.snap2();

        //yield return new WaitForSeconds(3);
        //Debug.Log("Loading");
        //snapCam3.snap3();

        //yield return new WaitForSeconds(3);
        //Debug.Log("Loading");
        //snapCam4.snap4();

        //yield return new WaitForSeconds(2);

        //Debug.Log("Render Complete");
    }
}
