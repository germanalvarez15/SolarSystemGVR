using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pasarDeNivel : MonoBehaviour {

	// Use this for initialization
	string sistemaSolar;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void pasoNivel(string sistemaSolar){
		//SceneManager.LoadScene(sistemaSolar);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sistemaSolar);

    }	
}
