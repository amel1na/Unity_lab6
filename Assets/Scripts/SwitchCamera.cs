using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera1;
    public GameObject Camera2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            SwitchCameraOne();
        }
    }
    public void SwitchCameraOne()
    {
        if( Camera1.activeSelf == true && Camera2.activeSelf == false )
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        else
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
    }
}
