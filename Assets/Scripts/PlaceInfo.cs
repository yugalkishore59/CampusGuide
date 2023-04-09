using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceInfo : MonoBehaviour
{
    public GameObject placeInfo;
    GameObject SceneManagerObj;
    SceneManagerScript sceneManagerScript;

    void Start()
    {
        SceneManagerObj=GameObject.Find("SceneManagerObj");
        sceneManagerScript = SceneManagerObj.GetComponent<SceneManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            sceneManagerScript.CloseInfo();
            Destroy(gameObject);
        }
    }

    public void GoogleMapSatpura(){
        Application.OpenURL("https://goo.gl/maps/JfzCkFhxcMdjb8WKA");
    }
    public void GoogleMapKailashBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/rHFsBwk69AcufV867");
    }
    public void GoogleMapHimadriBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/dxFeVixn1LBjESEy6");
    }
    public void GoogleMapHimgiriBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/DduQc81CNm7VF9xw9");
    }
    public void GoogleMapUdaygiriBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/6h3xnVMN6d8JMoo97");
    }
    public void GoogleMapNeelkanthBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/GTWqp1xXDgY8Hirr9");
    }
    public void GoogleMapDhauladharBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/EsbCYS8wnehwK2S88");
    }
    public void GoogleMapVidyanchalBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/SBUYEqRqJVcGNHVGA");
    }
    public void GoogleMapShivalikBoysHostel(){
        Application.OpenURL("https://goo.gl/maps/Btxhoq9NpPn71cU96");
    }
    public void GoogleMapAmbikaHostel(){
        Application.OpenURL("https://goo.gl/maps/D6zNiqjhKbbz4yTn8");
    }
    public void GoogleMapParvatiHostel(){
        Application.OpenURL("https://goo.gl/maps/iPCxdDadyvaLtaJu5");
    }
    public void GoogleMapManimaheshHostel(){
        Application.OpenURL("https://goo.gl/maps/mq4iEAjJzSaYSc339");
    }
    public void GoogleMapAravaliHostel(){
        Application.OpenURL("https://goo.gl/maps/UkfjTM2PzdVzt1ux5");
    }
    public void GoogleMapNursery(){
        Application.OpenURL("https://goo.gl/maps/CmMLCWvSHqx9G5iUA");
    }
    public void GoogleMap4H(){
        Application.OpenURL("https://goo.gl/maps/LemDaoZ2T2Ltsj8s9");
    }
    public void GoogleMapMechanicalWorkshop(){
        Application.OpenURL("https://goo.gl/maps/C56cwiozWx8tuctt5");
    }
    public void GoogleMapsbi(){
        Application.OpenURL("https://goo.gl/maps/UCcHAq5HWnpEKjbH6");
    }
    public void GoogleMapsbiHiteshi(){
        Application.OpenURL("https://goo.gl/maps/N82WQtDZ7S42SpG58");
    }
    public void GoogleMapsbiPatanjali(){
        Application.OpenURL("https://goo.gl/maps/ag66jcAiU3R9nsEi8");
    }
    public void GoogleMapComputerCenter(){
        Application.OpenURL("https://goo.gl/maps/kq3GHYE5ikitzUx87");
    }
    public void GoogleMapComputerScienceDept(){
        Application.OpenURL("https://goo.gl/maps/zsTc4fGcTtTCc2NGA");
    }
    public void GoogleMapAdminBlock(){
        Application.OpenURL("https://goo.gl/maps/aFyVAqXmr3VE6sbi7");
    }
    public void GoogleMapLH(){
        Application.OpenURL("https://goo.gl/maps/BS9knzHWYZXNYdfFA");
    }
    public void GoogleMapLibrary(){
        Application.OpenURL("https://goo.gl/maps/i55oRDHsWbyrork66");
    }
    public void GoogleMapAudi(){
        Application.OpenURL("https://goo.gl/maps/Hq5nM4Ns26ynX8Fp8");
    }
    public void GoogleMapHealthCentre(){
        Application.OpenURL("https://goo.gl/maps/4xyosoXZwP1WfRZh7");
    }
    public void GoogleMapGate2(){
        Application.OpenURL("https://goo.gl/maps/ZVrLmUV1szSTUs7QA");
    }
    public void GoogleMapGate1(){
        Application.OpenURL("https://goo.gl/maps/st7nWaVn1tRTvrz6A");
    }
}
