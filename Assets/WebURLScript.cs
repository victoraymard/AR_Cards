using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btnOne()
    {
        Application.OpenURL("http://victoraymard.yo.fr");
    }

    public void btnTwo()
    {
        Application.OpenURL("https://www.linkedin.com/in/victor-aymard-324b75150/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
