using UnityEngine;
using System.Collections;

public class SphereVisualizer : Visualizer {	
	void Update() {
		float frequencyValue = layout.manager.GetSpectrumBySample(frequency);
		float newHeight = Mathf.Clamp(frequencyValue*(15+frequency*frequency), 5, 15);
		
		transform.localScale = new Vector3(newHeight, newHeight, newHeight);
		//transform.localPosition = new Vector3(transform.localPosition.x, transform.localScale.y / 2, transform.localPosition.z);
	}
}
