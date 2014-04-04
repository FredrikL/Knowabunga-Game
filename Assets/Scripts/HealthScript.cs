﻿using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

		public int hp = 1;
		
		/// <summary>
		/// Enemy or player?
		/// </summary>
		public bool isEnemy = true;
		
		/// <summary>
		/// Inflicts damage and check if the object should be destroyed
		/// </summary>
		/// <param name="damageCount"></param>
		public void Damage(int damageCount)
		{
			hp -= damageCount;
			
			if (hp <= 0)
			{
				// Dead!
				Destroy(gameObject);
			}
		}
		
		void OnTriggerEnter2D(Collider2D otherCollider)
		{
			// Is this a shot?
			ShootScript shot = otherCollider.gameObject.GetComponent<ShootScript>();
			if (shot != null)
			{
					Damage(shot.Damage);
					
					// Destroy the shot
					Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
			}
		}
}