using UnityEngine;
using System.Collections;

public class BarVisualizer : Visualizer {	
	void Update() {
		float frequencyValue = layout.manager.GetSpectrumBySample(frequency);
		float newHeight = Mathf.Clamp(frequencyValue*(heightLimit+frequency*frequency), 0, heightLimit);

		GetComponent<Rigidbody>().useGravity = false;
		transform.localScale = new Vector3(1, newHeight, 1);
	}
}
