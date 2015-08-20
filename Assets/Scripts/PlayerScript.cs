using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int boostCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			boostCount += 1;
			//print(boostCount);
		} 

	}

	void OnCollisionEnter(Collision hit){
		if(hit.gameObject.tag == "wall"){
            if(boostCount > 2){
            	print("boom");
            }
            //print("hit");
        }
        
    }

    void OnTriggerExit(Collider other){
    	print("OK");
    	if(other.gameObject.tag == "cubeTrigger"){
    		other.GetComponent<Collider>().isTrigger = false;
    	}
    	
    }

}
