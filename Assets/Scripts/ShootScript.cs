using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	public int Damage = 1;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 4);
	}
	
}
