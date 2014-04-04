using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(3,3);
	public Vector2 direction = new Vector2(1,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = new Vector2(speed.x * direction.x, speed.y*direction.y) * Time.deltaTime;
		transform.Translate (pos);
	}
}
