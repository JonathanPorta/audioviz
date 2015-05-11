using UnityEngine;
using System.Collections;

public class Visualizer : MonoBehaviour {
	
	public float heightLimit;
	public float widthLimit;

	protected VisualizerLayout layout;
	protected int frequency;

	// Update is called once per frame
	void Update() {
		//float frequencyValue = layout.manager.GetSpectrumBySample(frequency);
		//float newHeight = Mathf.Clamp(frequencyValue*(heightLimit+frequency*frequency), 0, heightLimit);
		//float newHeight = frequencyValue*(heightLimit+frequency*frequency);
		//if(newHeight > transform.position.y){
			//transform.position = new Vector3(transform.position.x, newHeight, transform.position.z);
		//}
		//transform.localScale = new Vector3(1, newHeight, 1);
		//GetComponent<Rigidbody>().useGravity = false;
		//transform.localScale = new Vector3(1, newHeight, 1);
	}

	public void SetVisualizerLayout(VisualizerLayout layout) {
		this.layout = layout;
	}

	public void SetFrequency(int frequency) {
		this.frequency = frequency;
	}
}
