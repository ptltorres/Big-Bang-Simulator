using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	float time = 7;
    float numScenes = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0) {
			time -= Time.deltaTime;
		} else {
			//load next level
			loadNextLevel();
		}
	}
	public void loadNextLevel(){
        if (numScenes < 2) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            numScenes++;
        }
	}
}
