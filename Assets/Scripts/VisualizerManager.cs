using UnityEngine;
using System.Collections;

public class VisualizerManager : MonoBehaviour {
	public int frequencyStart = 0;
	public int frequencyRange = 4096;
	
	private VisualizerLayout layout;
	private Visualizer[] visualizers;
	private float[] spectrumAnalysis;
	
	void Awake(){
		layout = GetComponent<VisualizerLayout>();
		layout.manager = this;
	}

	// Use this for initialization
	void Start () {
		spectrumAnalysis = new float[4096];
	}
	
	// Update is called once per frame
	void Update () {
		AudioListener.GetSpectrumData(spectrumAnalysis, 0, FFTWindow.BlackmanHarris);
	}

	public float GetSpectrumBySample(int sampleIndex){
		int datapointsPerSample = frequencyRange / layout.visualizerCount;
		float sample = 0.0f;
		// Average the datapoints for this sample
		for(int x = 0; x < datapointsPerSample; x++){
			int datapointIndex = frequencyStart + sampleIndex * datapointsPerSample + x;
			sample += spectrumAnalysis[datapointIndex];
		}
		return sample / datapointsPerSample * datapointsPerSample;
	}
}
