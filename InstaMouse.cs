using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaMouse : MonoBehaviour
{
    public InstaEditor bulu;

    private void Start()
    {

    }
    private void OnMouseUp()
    {
        if (bulu.slots[0].transform.position == bulu.items[0].transform.position)
        {
            bulu.EL1 = true;
        }

        if (bulu.slots[1].transform.position == bulu.items[1].transform.position)
        {
            bulu.EL2 = true;
        }
        if (bulu.slots[2].transform.position == bulu.items[2].transform.position)
        {
            bulu.EL3 = true;
        }
        if (bulu.slots[3].transform.position == bulu.items[3].transform.position)
        {
            bulu.EL4 = true;
        }
        if (bulu.slots[4].transform.position == bulu.items[4].transform.position)
        {
            bulu.EL5 = true;
        }
        if (bulu.slots[5].transform.position == bulu.items[5].transform.position)
        {
            bulu.EL6 = true;
        }
        if (bulu.slots[6].transform.position == bulu.items[6].transform.position)
        {
            bulu.EL7 = true;
        }
        if (bulu.slots[7].transform.position == bulu.items[7].transform.position)
        {
            bulu.EL8 = true;
        }
        if (bulu.slots[8].transform.position == bulu.items[8].transform.position)
        {
            bulu.EL9 = true;
        }
        if (bulu.slots[9].transform.position == bulu.items[9].transform.position)
        {
            bulu.EL10 = true;
        }
        if (bulu.slots[10].transform.position == bulu.items[10].transform.position)
        {
            bulu.EL11 = true;
        }
        if (bulu.slots[11].transform.position == bulu.items[11].transform.position)
        {
            bulu.EL12 = true;
        }
        if (bulu.slots[12].transform.position == bulu.items[12].transform.position)
        {
            bulu.EL13 = true;
        }
        if (bulu.slots[13].transform.position == bulu.items[13].transform.position)
        {
            bulu.EL14 = true;
        }if (bulu.slots[14].transform.position == bulu.items[14].transform.position)
        {
            bulu.EL15 = true;
        }if (bulu.slots[15].transform.position == bulu.items[15].transform.position)
        {
            bulu.EL16 = true;
        }if (bulu.slots[16].transform.position == bulu.items[16].transform.position)
        {
            bulu.EL17 = true;
        }if (bulu.slots[17].transform.position == bulu.items[17].transform.position)
        {
            bulu.EL18 = true;
        }if (bulu.slots[18].transform.position == bulu.items[18].transform.position)
        {
            bulu.EL19 = true;
        }if (bulu.slots[19].transform.position == bulu.items[19].transform.position)
        {
            bulu.EL20 = true;
        }if (bulu.slots[20].transform.position == bulu.items[20].transform.position)
        {
            bulu.EL21 = true;
        }if (bulu.slots[21].transform.position == bulu.items[21].transform.position)
        {
            bulu.EL22 = true;
        }
      

        //Debug.Log("basildi");


    }
}
