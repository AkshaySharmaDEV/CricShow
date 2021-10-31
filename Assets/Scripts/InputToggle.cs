using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputToggle : MonoBehaviour
{
    public GameObject ObjectToToggle;
    

    public bool toggleState;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

      


    public void toggleStateFunction()
    {
        if (toggleState)
        {
            Debug.Log("Toggle disabled!");
            // animator.SetTrigger("myToggleDisabledAnimation")
            
            ObjectToToggle.SetActive(false);
            toggleState=false;
        }
        else
        {
            Debug.Log("Toggle enabled!");
            // animator.SetTrigger("myToggleEnabledAnimation")
            ObjectToToggle.SetActive(true);
            toggleState=true;
        }
    }

    
}


