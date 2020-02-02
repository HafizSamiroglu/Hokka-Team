using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneNum()
    {
        SceneManager.LoadScene( number);
    }
    
}
