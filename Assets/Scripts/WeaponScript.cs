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
						cooldown = FireRate;
			
						// Create a new shot
			var shotTransform = Instantiate (Ammo) as Transform;
			var pos = new Vector2(transform.position.x+0.4f, transform.position.y);
						// Assign position
						shotTransform.position = pos;
			
			
				
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
