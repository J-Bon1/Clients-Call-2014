using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {


	public Texture2D picture;
	public Color color; 

	public GameObject cube;
	public GameObject plane;
	// change this later to picture
	public Texture2D dummypicture;

	// Use this for initialization
	void Start () {

	}
	public void create(){
		cube.renderer.material.color = color;
		plane.renderer.material.mainTexture = dummypicture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
