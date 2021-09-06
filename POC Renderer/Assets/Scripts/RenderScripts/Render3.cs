using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Render3 : MonoBehaviour
{
    Camera snapCam3;

    int resWidth = 256;
    int resHeight = 256;


    void Awake()
    {
        snapCam3 = GetComponent<Camera>();
        if (snapCam3.targetTexture == null)
        {
            snapCam3.targetTexture = new RenderTexture(resWidth, resHeight, 24);
        }
        else
        {
            resWidth = snapCam3.targetTexture.width;
            resHeight = snapCam3.targetTexture.height;

        }
        snapCam3.gameObject.SetActive(false);

    }

    // Update is called once per frame
    

    public void snap3()
    {
        snapCam3.gameObject.SetActive(true);
    }

    void LateUpdate()
    {
       if (snapCam3.gameObject.activeInHierarchy)
        {
            Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapCam3.Render();
            RenderTexture.active = snapCam3.targetTexture;
            snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            byte[] bytes = snapshot.EncodeToPNG();
            string fileName = SnapshotName3();
            System.IO.File.WriteAllBytes(fileName, bytes);
            Debug.Log("Snapped3!");
            snapCam3.gameObject.SetActive(false);
        } 
    }

    string SnapshotName3()
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}.png", Application.dataPath, resWidth, resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));


    }
}
