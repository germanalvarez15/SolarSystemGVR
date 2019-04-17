using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderParaVR : MonoBehaviour {

	// Use this for initialization
	string sistemaSolar;
	public float tiempoDeLlenado = 2f;
	private float timer;
	private bool gazeAt;
	private Coroutine fillBarRoutine;

	private Slider miSlider;
	void Start () {
		miSlider = GetComponent<Slider> ();
		if (miSlider == null)
			Debug.Log ("Por favor agrega un Slider a este GameObject");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PointerEnter(){
		gazeAt = true;
		fillBarRoutine = StartCoroutine (FillBar());
	}

	public void PointerExit(){
		gazeAt = false;
		if (fillBarRoutine != null) {
			StopCoroutine (fillBarRoutine);
		}

		timer = 0f;
		miSlider.value = 0f;
	}

	private IEnumerator FillBar(){
		timer = 0f;
		while (timer < tiempoDeLlenado) {
		
			timer += Time.deltaTime;

			miSlider.value = timer / tiempoDeLlenado;

			yield return null;

			if (gazeAt)
				continue;

			timer = 0f;
			miSlider.value = 0f;
			yield break;
		}

		cuandoLaBarraEstaLlena ();

	}
	public void cuandoLaBarraEstaLlena(){
		//SceneManager.LoadScene("sistemaSolarVR");
        UnityEngine.SceneManagement.SceneManager.LoadScene("sistemaSolarVR");
    }

}
