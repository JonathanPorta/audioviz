using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	
	public float distanceMin;
	public float distanceMax;
	public float zoomSpeed = 100;
	
	private Vector3 moveDirection;
	private Camera camera;

	void Awake(){
		camera = GetComponent<Camera>();
	}

	void Start(){
		this.moveDirection = Vector3.zero;
	}
	
	void Update(){
		if(this.camera.orthographic){
			// Invert the axis so that is behaves the same as when the camera is in perspective mode
			camera.orthographicSize += -Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		}
		else{
			moveDirection = new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel"));
			moveDirection *= zoomSpeed;
			
			if(Input.GetAxis("Mouse ScrollWheel") != 0){
				transform.Translate(moveDirection, Space.Self);
			}
		}
	}
}