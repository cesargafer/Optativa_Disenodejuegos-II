using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragSphere : MonoBehaviour
{
    // Start is called before the first frame update
     //void Start() {    }

    private float startPosX;
    private float startPosY;
    private bool estaSiendoRetenido = false;

    // Update is called once per frame
    void Update()
    {
     if(estaSiendoRetenido == true){
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
     }   
    }

    private void OnMouseDown(){
        
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click.");
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            estaSiendoRetenido = true;

        }
    }

    private void OnMouseUp()
    {
        estaSiendoRetenido = false;
    }
}
