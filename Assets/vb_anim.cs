using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{

	public GameObject vbBtnObj;
	public Animator cubeAni;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton_living");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	//cubeAni.Play("cube_animation");
        Application.OpenURL("http://victoraymard.yo.fr/");
    	Debug.Log("BTN web Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	cubeAni.Play("none");
    	Debug.Log("BTN web Release");
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}
