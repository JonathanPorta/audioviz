using UnityEngine;
using System.Collections;

public class BarVisualizerLayout : VisualizerLayout {
	override public void Reset(){
		for(int i = 0; i < visualizers.Length; i++){
			if(visualizers[i] != null){
				Destroy(visualizers[i].gameObject);
			}
			
			GameObject g = Instantiate(prefabs[selection], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			g.GetComponent<Renderer>().material = material;
			g.transform.parent = transform;
			
			Visualizer v = g.GetComponent<Visualizer>();
			v.transform.localPosition = new Vector3(i * 1.5f, 0, 0);
			v.transform.rotation = transform.rotation;
			v.SetVisualizerLayout(this);
			v.SetFrequency(i);
			v.heightLimit = height;
			
			visualizers[i] = v;

			Camera.main.transform.position = new Vector3(visualizerCount * 1.5f / 2, height / 2, -50.0f);
		}
	}
}
