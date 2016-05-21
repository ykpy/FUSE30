using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score = 0;
    
    void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addscore()
    {
        score += 10;
    }
      
}
