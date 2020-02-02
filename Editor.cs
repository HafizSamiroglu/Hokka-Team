using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Editor : MonoBehaviour
{

    public GameObject[] slots;
    public GameObject[] items;
    public bool EL1, EL2, EL3, EL4, EL5, EL6, EL7, EL8, EL9, EL10, EL11, EL12, EL13, EL14;
    public GameObject PanelWin, PanelLose;
    public float timeLeft = 30;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timer.GetComponent<Text>();
        timer.GetComponent<Text>();
        EL1=false;
        EL2 =false;
        EL3 =false;
        EL4 =false;
        EL5 =false;
        EL6 =false;
        EL7 =false;
        EL8 =false;
        EL9 = false;
        EL10 = false;
        EL11 = false;
        EL12 = false;
        EL13 = false;
        EL14 = false;

        PanelLose.SetActive(false);
        PanelWin.SetActive(false);
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
       
        timer.text =""+  Mathf.Round( timeLeft);
    }

    // Update is called once per frame

    public void LateUpdate()
    {



       if (EL1 == true && EL2 == true && EL3 == true && EL4 == true && EL5 == true && EL6 == true && EL7 == true &&
            EL8 == true && EL9 == true && EL10 == true && EL11 == true && EL12 == true && EL13 == true && EL14 == true )
        {
            PanelWin.SetActive(true);
            Time.timeScale = 0;
            
        }
       else if(timeLeft<= 0)
        {
            PanelLose.SetActive(true);
            Time.timeScale = 0;
        }

    
    }
}
