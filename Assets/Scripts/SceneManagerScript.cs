using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    bool isInfoOpen=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HomeScene(){
        if(!isInfoOpen){
            SceneManager.LoadScene("Home");
        }
        
    }

    public void OpenInfo(){
        isInfoOpen=true;
    }

    public void CloseInfo(){
        isInfoOpen=false;
    }

}
