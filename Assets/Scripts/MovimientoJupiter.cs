using UnityEngine;
using System.Collections;

public class MovimientoJupiter : MonoBehaviour {

	public float gradosPorSegundo;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * gradosPorSegundo);
	}
	public void InteraccionConPlaneta(){
		Debug.Log ("Estas mirando a Jupiter");

	}
}
