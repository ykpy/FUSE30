using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float firstTime=5.0f;
    public string nextScene;
    private Text mText;

    private 
	// Use this for initialization
	void Start () {
        mText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
      
        firstTime -= Time.deltaTime;
        string TimerT = firstTime.ToString("000");

        mText.text = "Time:" + TimerT;

        if(firstTime<0)
        {
            Application.LoadLevel(nextScene);
        }
	}
}

