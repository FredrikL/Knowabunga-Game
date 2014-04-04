using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x + 1.5f, player.transform.position.y, -5);
	}
}
