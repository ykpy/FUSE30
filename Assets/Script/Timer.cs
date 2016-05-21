using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float firstTime=5.0f;
    private Text mText;

    private 
	// Use this for initialization
	void Start () {
        mText = GetComponent<Text>();
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

