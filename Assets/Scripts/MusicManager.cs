using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] playlist;
	public int selection = 0;
	// Use this for initialization

	private AudioSource audioSource;

	void Awake(){
		audioSource = GetComponent<AudioSource>();
	}

	void Start(){
		SetSong(selection);
	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetButtonDown("Next Song")){
			selection += 1;
			if(selection == playlist.Length){
				selection = 0;
			}
			SetSong(selection);
		}
	}

	public void SetSong(int song){
		audioSource.clip = playlist[song];
		audioSource.Play();
	}
}
