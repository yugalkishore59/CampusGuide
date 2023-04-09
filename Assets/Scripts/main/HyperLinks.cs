using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HyperLinks : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OpenMap(){
        SceneManager.LoadScene("SampleScene");
    }
    public void CallAmbulance(){
        Application.OpenURL("tel:+917807093027");
    }
    public void CallTaxi(){
        Application.OpenURL("tel:+919817878327");
    }
    public void CheckResult(){
        Application.OpenURL("https://nith.ac.in/results");
    }
    public void PreviousYear(){
        Application.OpenURL("https://library.nith.ac.in/library/exam.php");
    }
    public void NithWebsite(){
        Application.OpenURL("https://nith.ac.in/");
    }
}
