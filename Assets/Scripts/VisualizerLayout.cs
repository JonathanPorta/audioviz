using UnityEngine;
using System.Collections;

public class VisualizerLayout : MonoBehaviour {

	public int visualizerCount = 128;

	public float height;
	public float width;

	public Material material;
	public GameObject[] prefabs;
	public int selection = 0;

	public Visualizer[] visualizers;
	public VisualizerManager manager;

	// Use this for initialization
	void Start(){
		visualizers = new Visualizer[visualizerCount];
		Reset();
	}

	// Update is called once per frame
	void Update(){
		if(Input.GetButtonDown("Next Song")){
			Reset();
		}
		if(Input.GetButtonDown("Next Visualizer")){
			selection += 1;
			if(selection == prefabs.Length){
				selection = 0;
			}
			Reset();
		}
	}

	public void SetVisualizers(Visualizer[] visualizers){
		this.visualizers = visualizers;
		Reset();
	}

	virtual public void Reset(){}
}
