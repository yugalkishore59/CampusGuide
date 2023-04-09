using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControls : MonoBehaviour
{
    Camera cam;  
    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 50;
    public float zoomSpeed = 0.1f;
    public float minX=-25,maxX=25,minY=-50,maxY=50;
	
	void Start() {
        cam=gameObject.GetComponent<Camera>();
    }

	void Update () {
        if(Input.GetMouseButtonDown(0)){
            touchStart = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.touchCount == 2){
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * zoomSpeed);
        }else if(Input.GetMouseButton(0)){
            Vector3 direction = touchStart - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position += direction;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }
        zoom(Input.GetAxis("Mouse ScrollWheel"));
	}

    void zoom(float increment){
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }

    public void Resize(){
        cam.orthographicSize = zoomOutMax;
        transform.position= new Vector3(0,0,-10);
    }
}
