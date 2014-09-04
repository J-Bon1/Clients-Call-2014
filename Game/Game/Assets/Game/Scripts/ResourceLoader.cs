using UnityEngine;
using System.Collections;
using System.IO;

public class ResourceLoader : MonoBehaviour {

	public string[] path;
	public Texture2D[] pictures;
	private FileInfo[] pictureInfo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void getAllFileInfos(){
		int i;
		int j;
		DirectoryInfo directory;
		pictures = new Texture2D[pictureAmmount()];
		for (i =0; i< path.Length; i++) {
			directory = new DirectoryInfo(path[i]);
			pictureInfo = directory.GetFiles ("*.png");
			for(j= 0; j < pictureInfo.Length; j++){
				FileStream stream = new FileStream(pictureInfo[i].FullName, FileMode.Open, FileAccess.Read);
				byte[] imageData = new byte[stream.Length];
				stream.Read(imageData, 0, (int) stream.Length);
				pictures[i] = new Texture2D(80,80);
				pictures[i].LoadImage(imageData);
				pictures[i].name = pictureInfo[i].Name;
			}
		}
	}
	private int pictureAmmount(){
		int i;
		DirectoryInfo directory;
		int pictureCounter = 0;
		for (i =0; i< path.Length; i++) {
			directory = new DirectoryInfo(path[i]);
			pictureInfo = directory.GetFiles ("*.png");
			pictureCounter += pictureInfo.Length;
		}
		return pictureCounter;
	}
}
