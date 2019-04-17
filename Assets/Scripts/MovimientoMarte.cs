using UnityEngine;
using System.Collections;

public class MovimientoMarte : MonoBehaviour {

	public float degreesPerSecond;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * degreesPerSecond);
	}

	public void InteraccionConPlaneta(){
		Debug.Log ("Estas mirando a Marte");

	}
}
