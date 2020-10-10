using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_Control : MonoBehaviour
{
    public GameObject vbBtnObj;
    public GameObject Avatar;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        Avatar = GameObject.Find("Drunk Walk");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //
        if (Avatar.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            Avatar.GetComponent<Animator>().Play("Defeated");
        }
        else if(Avatar.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Fall")){
            Avatar.GetComponent<Animator>().Play("Stand_Up");
        }
        Avatar.GetComponent<AudioSource>().Play();
        Debug.Log("Button pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Avatar.GetComponent<Transform>().localPosition = new Vector3(-0.033f,0.007f,0.505f);
        Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {
    }
}