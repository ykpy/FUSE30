using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {
    public string nextScene;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            Application.LoadLevel(nextScene);
        }
	}
}
