using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_balls : MonoBehaviour
{
    public Transform startPosRot;
	public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 posAdd;

     if (Input.GetMouseButton(0)) {
     	
     	posAdd = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));

     	Instantiate(ball, startPosRot.position+posAdd, startPosRot.rotation);
     }   
    }
}
