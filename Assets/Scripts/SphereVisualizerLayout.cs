using UnityEngine;
using System.Collections;

public class SphereVisualizerLayout : VisualizerLayout {

	public GameObject[] light;

	private bool firstRender = true;

	override public void Reset(){
		for(int i = 0; i < visualizers.Length; i++){
			if(visualizers[i] != null){
				Destroy(visualizers[i].gameObject);
			}
			
			GameObject g = Instantiate(prefabs[selection], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			g.GetComponent<Renderer>().material = material;
			g.transform.parent = transform;
			
			Visualizer v = g.GetComponent<Visualizer>();
			v.transform.localPosition = new Vector3(0, 0, 0);
			v.transform.rotation = transform.rotation;
			v.SetVisualizerLayout(this);
			v.SetFrequency(i);
			v.heightLimit = height;
			
			visualizers[i] = v;
		}
		if(firstRender)
			Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -75.0f);
		//Camera.main.transform.LookAt(transform.position);
		light[0].transform.LookAt(transform.position);
		light[1].transform.LookAt(transform.position);
		//light.GetComponent<Light>();
		firstRender = false;
	}
}
