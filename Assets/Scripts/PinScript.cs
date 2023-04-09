using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
{
    public GameObject placeInfo;
    GameObject SceneManagerObj;
    SceneManagerScript sceneManagerScript;

    void Start()
    {
        SceneManagerObj=GameObject.Find("SceneManagerObj");
        sceneManagerScript = SceneManagerObj.GetComponent<SceneManagerScript>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.Escape))
        {
            sceneManagerScript.HomeScene();
        }
    }

    private void OnMouseUpAsButton() {
        ShowInfo();
    }

    public void ShowInfo(){
        Instantiate(placeInfo, new Vector3(0,0,0),Quaternion.identity);
        sceneManagerScript.OpenInfo();
    }
}
