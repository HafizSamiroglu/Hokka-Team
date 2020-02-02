using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    
    public Editor bul;
   
    private void Start()
    {
        
    }
    private void Update()
    {
      
    }
    private void OnMouseUp()
    {
        if (bul.slots[0].transform.position == bul.items[0].transform.position)
        {
            bul.EL1 = true;
        }

        if (bul.slots[1].transform.position == bul.items[1].transform.position)
        {
            bul.EL2 = true;
        }
        if (bul.slots[2].transform.position == bul.items[2].transform.position)
        {
            bul.EL3 = true;
        }
        if (bul.slots[3].transform.position == bul.items[3].transform.position)
        {
            bul.EL4 = true;
        }
        if (bul.slots[4].transform.position == bul.items[4].transform.position)
        {
            bul.EL5 = true;
        }
        if (bul.slots[5].transform.position == bul.items[5].transform.position)
        {
            bul.EL6 = true;
        }
        if (bul.slots[6].transform.position == bul.items[6].transform.position)
        {
            bul.EL7 = true;
        }
        if (bul.slots[7].transform.position == bul.items[7].transform.position)
        {
            bul.EL8 = true;
        }
        if (bul.slots[8].transform.position == bul.items[8].transform.position)
        {
            bul.EL9 = true;
        }
        if (bul.slots[9].transform.position == bul.items[9].transform.position)
        {
            bul.EL10 = true;
        }
        if (bul.slots[10].transform.position == bul.items[10].transform.position)
        {
            bul.EL11 = true;
        }
        if (bul.slots[11].transform.position == bul.items[11].transform.position)
        {
            bul.EL12 = true;
        }
        if (bul.slots[12].transform.position == bul.items[12].transform.position)
        {
            bul.EL13 = true;
        }
        if (bul.slots[13].transform.position == bul.items[13].transform.position)
        {
            bul.EL14 = true;
        }
        //Debug.Log("basildi");

        
    }

}
