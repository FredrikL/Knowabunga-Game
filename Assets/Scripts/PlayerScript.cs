using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(2,2);
	public float JumpForce = 250f;
	public bool moving = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		var anim = GetComponent<Animator> ();

		if (x != 0) {
						anim.SetBool ("moving", true);
				} else {
			anim.SetBool ("moving", false);
				}

		if (Input.GetKey (KeyCode.UpArrow) && CanJump()) {
						rigidbody2D.AddForce (new Vector2 (0, JumpForce));
				} 

		var movment = new Vector2(speed.x * x, 0);
		movment *= Time.deltaTime;
		transform.Translate (movment);

		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");

		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				weapon.Attack(false);
			}
		}
	}

	bool CanJump() {
		return transform.rigidbody2D.velocity.y == 0;
	}

}
