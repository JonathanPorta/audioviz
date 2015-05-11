using UnityEngine;
using System.Collections;

public class GravityBarVisualizer : Visualizer {	
	void Update() {
		float frequencyValue = layout.manager.GetSpectrumBySample(frequency);
		float newHeight = Mathf.Clamp(frequencyValue*(heightLimit+frequency*frequency), 0, heightLimit);
		if(newHeight > transform.localPosition.y){
			transform.localPosition = new Vector3(transform.localPosition.x, newHeight, transform.localPosition.z);
		}
	}
}
