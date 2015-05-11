using UnityEngine;
using System.Collections;

public class NormalizedBarVisualizer : Visualizer {	
	void Update() {
		float frequencyValue = layout.manager.GetSpectrumBySample(frequency);
		float newHeight = Mathf.Clamp(frequencyValue*(heightLimit+frequency*frequency), 0, heightLimit);
		
		GetComponent<Rigidbody>().useGravity = false;
		transform.localScale = new Vector3(1, newHeight, 1);
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localScale.y / 2, transform.localPosition.z);
	}
}
