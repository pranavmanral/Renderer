using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Render4 : MonoBehaviour
{
    Camera snapCam4;

    int resWidth = 256;
    int resHeight = 256;


    void Awake()
    {
        snapCam4 = GetComponent<Camera>();
        if (snapCam4.targetTexture == null)
        {
            snapCam4.targetTexture = new RenderTexture(resWidth, resHeight, 24);
        }
        else
        {
            resWidth = snapCam4.targetTexture.width;
            resHeight = snapCam4.targetTexture.height;

        }
        snapCam4.gameObject.SetActive(false);

    }

    // Update is called once per frame
    

    public void snap4()
    {
        snapCam4.gameObject.SetActive(true);
    }

    void LateUpdate()
    {
       if (snapCam4.gameObject.activeInHierarchy)
        {
            Texture2D snapshot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
            snapCam4.Render();
            RenderTexture.active = snapCam4.targetTexture;
            snapshot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            byte[] bytes = snapshot.EncodeToPNG();
            string fileName = SnapshotName4();
            System.IO.File.WriteAllBytes(fileName, bytes);
            Debug.Log("Snapped4!");
            snapCam4.gameObject.SetActive(false);
        } 
    }

    string SnapshotName4()
    {
        return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}.png", Application.dataPath, resWidth, resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));


    }
}
