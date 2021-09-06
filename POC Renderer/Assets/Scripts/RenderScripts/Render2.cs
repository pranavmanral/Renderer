using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Render2 : MonoBehaviour
{
    Camera snapCam2;

    int resWidth = 256;
    int resHeight = 256;


    void Awake()
    {
        snapCam2 = GetComponent<Camera>();
        if (snapCam2.targetTexture == null)
        {
            snapCam2.targetTexture = new RenderTexture(resWidth, resHeight, 24);
        }
        else
        {
            resWidth = snapCam2.targetTexture.width;
            resHeight = snapCam2.targetTexture.height;

        }
        snapCam2.gameObject.SetActive(false);

    }

    // Update is called once per frame
    

    public void snap2()
    {
        snapCam2.gameObject.SetActive(true);
    }

    void LateUpdate()
    {
       if (snapCam2.gameObject.activeInHierarchy)
        {
            Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapCam2.Render();
            RenderTexture.active = snapCam2.targetTexture;
            snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            byte[] bytes = snapshot.EncodeToPNG();
            string fileName = SnapshotName2();
            System.IO.File.WriteAllBytes(fileName, bytes);
            Debug.Log("Snapped2!");
            snapCam2.gameObject.SetActive(false);
        } 
    }

    string SnapshotName2()
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}.png", Application.dataPath, resWidth, resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));


    }
}
