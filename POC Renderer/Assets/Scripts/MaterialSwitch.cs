using System.Collections;
using UnityEngine;

public class MaterialSwitch : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SwitchMat()
    {
       // if (gameObject.tag == "Obj_A")
       // {
            rend.sharedMaterial = material[0];
            //StartCoroutine(Switch());
        //if (gameObject.tag == "Obj_A"){

        //rend.sharedMaterial = material[0];
        
    }

    //IEnumerator Switch()
   // {

          //  yield return new WaitForSeconds(3);
          //  rend.sharedMaterial = material[0];

      //  yield return new WaitForSeconds(3);
       // rend.sharedMaterial = material[0];

       // yield return new WaitForSeconds(3);
      //  rend.sharedMaterial = material[0];

   // }





  public void SwitchMat2()
    {
        if (gameObject.tag == "Obj_A")
        {
            rend.sharedMaterial = material[1];
        }
    }
}
