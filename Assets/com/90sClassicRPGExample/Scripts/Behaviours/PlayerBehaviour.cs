using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls;

namespace Com._90sClassicRPGExample.Behaviours{
	public class PlayerBehaviour : MonoBehaviour {
		#region ### Fields ###

		public PlayerStatsModul stats;

		#endregion
		#region ### Unity Callbacks ###

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			moveInput();
		}

		#endregion
		#region ### Methods ###

		void moveInput(){
			float speed = 5;
			Vector2 pos = transform.position;
			pos.y += Input.GetAxis("Vertical")*speed*Time.deltaTime;
			pos.x += Input.GetAxis("Horizontal")*speed*Time.deltaTime;
			transform.position = pos;
		}

		#endregion
	}
}