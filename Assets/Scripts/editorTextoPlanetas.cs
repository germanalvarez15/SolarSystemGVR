using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class editorTextoPlanetas : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Text planeta = null;
	string llamaMarte="Marte";
	string llamaTierra="Tierra";
	string llamaJupiter="Jupiter";
    string llamaMercurio = "Mercurio";
    string llamaVenus = "Venus";


    public string Modulo;

    public Animator AnimatorJugadorPlanetas;

	void Start () {
        Modulo = "Marte";
        AnimatorJugadorPlanetas = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
	}

    public void SiguienteDerecha()
    {
        switch (Modulo)
        {
            case "Tierra":
                Modulo = "Marte";
                AnimatorJugadorPlanetas.SetTrigger("TierraMarte");
                break;

            case "Marte":
                Modulo = "Jupiter";
                AnimatorJugadorPlanetas.SetTrigger("MarteJupiter");
                break;

            case "Venus":
                Modulo = "Tierra";
                AnimatorJugadorPlanetas.SetTrigger("VenusTierra");
                break;

        }
    }

    public void SiguienteIzquierda()
    {
        switch (Modulo)
        {
            case "Marte":
                Modulo = "Tierra";
                AnimatorJugadorPlanetas.SetTrigger("MarteTierra");
                break;

            case "Tierra":
                Modulo = "Venus";
                AnimatorJugadorPlanetas.SetTrigger("TierraVenus");
                break;

            case "Jupiter":
                Modulo = "Marte";
                AnimatorJugadorPlanetas.SetTrigger("JupiterMarte");
                break;
        }
    }

    public void entraTextoMarte(){
		planeta.text = llamaMarte;
	}
	public void entraTextoTierra(){
		planeta.text = llamaTierra;
	}
	public void entraTextoJupiter(){
		planeta.text = llamaJupiter;
	}

    public void entraTextoMercurio()
    {
        planeta.text = llamaMercurio;
    }

    public void entraTextoVenus()
    {
        planeta.text = llamaVenus;
    }

    // Update is called once per frame
}
