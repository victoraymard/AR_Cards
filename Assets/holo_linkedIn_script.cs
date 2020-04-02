using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class holo_linkedIn_script : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator cubeAni;


    // Start is called before the first frame update
     void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton_living");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	//cubeAni.Play("cube_animation");
        Application.OpenURL("https://www.linkedin.com/in/victor-aymard-324b75150/");
    	Debug.Log("BTN right Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	//cubeAni.Play("none");
    	Debug.Log("BTN right Release");
    }

     public void btnLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/victor-aymard-324b75150/");
    }

    public void btnWebsite()
    {
        Application.OpenURL("http://victoraymard.yo.fr");
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

}
