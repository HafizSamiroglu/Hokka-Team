using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstaEditor : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject[] items;
    public bool EL1, EL2, EL3, EL4, EL5, EL6, EL7, EL8, EL9, EL10, EL11, EL12, EL13, EL14, EL15, EL16, EL17, EL18, EL19, EL20, EL21, EL22;
    public Text timer;
    public GameObject PanelWin, PanelLose;
    public float timeLeft = 30;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        EL1 = false;
        EL2 = false;
        EL3 = false;
        EL4 = false;
        EL5 = false;
        EL6 = false;
        EL7 = false;
        EL8 = false;
        EL9 = false;
        EL10 = false;
        EL11 = false;
        EL12 = false;
        EL13 = false;
        EL14 = false;
        EL15 = false;
        EL16 = false;
        EL17 = false;
        EL18 = false;
        EL19 = false;
        EL20 = false;
        EL21 = false;
        EL22 = false;

        PanelLose.SetActive(false);
        PanelWin.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        
        timer.text = "" + Mathf.Round( timeLeft);
    }
    public void LateUpdate()
    {



        if (EL1 == true && EL2 == true && EL3 == true && EL4 == true && EL5 == true && EL6 == true && EL7 == true &&
             EL8 == true && EL9 == true && EL10 == true && EL11 == true && EL12 == true && EL13 == true && EL14 == true
             && EL15 == true && EL16 == true && EL17 == true && EL18 == true && EL19 == true && EL20 == true && EL21 == true && EL22 == true )
        {
            Time.timeScale = 0;
            PanelWin.SetActive(true);
        }
       else if (timeLeft <= 0)
        {
            PanelLose.SetActive(true);
            Time.timeScale = 0;
        } 


    }
}
