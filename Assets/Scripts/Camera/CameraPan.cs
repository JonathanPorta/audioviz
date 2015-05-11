using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {
	
	public float distanceMin;
	public float distanceMax;
	public float speed = 10;
	
	private Vector3 moveDirection;
	
	void Start(){
		this.moveDirection = Vector3.zero;
	}
	
	void Update(){
		
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		moveDirection *= speed;
		
		if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") !=0){
			transform.Translate(moveDirection, Space.Self);
		}
	}
}