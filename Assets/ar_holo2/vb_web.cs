using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_web : MonoBehaviour, IVirtualButtonEventHandler
{

	public GameObject vbBtnObj;
	public Animator cubeAni;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("ingtualButton_living");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	cubeAni.Play("cube_animation");
        //Application.OpenURL("https://www.linkedin.com/in/victor-aymard-324b75150/");
        Application.OpenURL("http://victoraymard.yo.fr");
    	Debug.Log("BTN right Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	cubeAni.Play("none");
    	Debug.Log("BTN right Release");
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}
