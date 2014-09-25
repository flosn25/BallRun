using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject Player;
	public int y= 1;
	public int z = 3;
	// Use this for initialization
	void Start () {
		Time.timeScale=1;

	}
	
	// Update is called once per frame
	void Update () {/*übernimmt KameraPosition , bleibt leicht dahinter*/
		transform.position = new Vector3(Player.transform.position.x, y, Player.transform.position.z-z);
	}
}
