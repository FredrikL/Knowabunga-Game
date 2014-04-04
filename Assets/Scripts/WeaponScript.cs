using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	public Transform Ammo;

	public float FireRate = 0.25f;

	private float cooldown = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown > 0) {
			cooldown -= Time.deltaTime;
		}
	}

	public void Attack(bool isEnemy)
	{
		if (CanAttack) {

			var player = GetComponent<PlayerScript>();
			var offset = player.forward ? 0.4f : -0.4f;
						cooldown = FireRate;
			
						// Create a new shot
			var shotTransform = Instantiate (Ammo) as Transform;
			var pos = new Vector2(transform.position.x+offset, transform.position.y);
						// Assign position
						shotTransform.position = pos;
			var move = shotTransform.GetComponent<MoveScript>();
			if(!player.forward) {
				move.direction = new Vector2(-1,0);
			}	
				
				}
	}
	
	/// <summary>
	/// Is the weapon ready to create a new projectile?
	/// </summary>
	public bool CanAttack
	{
		get
		{
			return cooldown <= 0f;
		}
	}
}
