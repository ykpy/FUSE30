using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float firstTime=5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        firstTime -= Time.deltaTime;
        if(firstTime<0)
        {
            Debug.Break();
        }
	}
}

