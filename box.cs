using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    private float startPosx;
    private float startPosY;
    private bool isBeingHeld = false;
    public GameObject slot;
   private float mesafe;

    private void Update()
    {
        mesafe = Vector2.Distance(this.transform.position, slot.transform.position);
     
        if(isBeingHeld== true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            if (mesafe <0.3f)
            {
                this.gameObject.transform.localPosition = slot.transform.position;
            }else 
            this.gameObject.transform.position = new Vector3(mousePos.x-startPosx, mousePos.y-startPosY, 0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosx = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }
      
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
