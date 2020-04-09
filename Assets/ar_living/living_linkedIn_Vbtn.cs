using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class living_linkedIn_Vbtn : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
	public Animator cubeAni;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton_linkedIn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	cubeAni.Play("cube_animation");
        Application.OpenURL("https://www.linkedin.com/in/victor-aymard-324b75150/");
    	Debug.Log("BTN linkedin Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	cubeAni.Play("none");
    	Debug.Log("BTN linkedin Release");
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}
