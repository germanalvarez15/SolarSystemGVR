using UnityEngine;
using System.Collections;

public class MovimientoTierra : MonoBehaviour {

	public float gradosPorSegundo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * gradosPorSegundo);
	}
	public void InteraccionConPlaneta(){
		Debug.Log ("Estas mirando a nuestra Tierra");

	}
}
