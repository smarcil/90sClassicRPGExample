using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls;
using Com._90sClassicRPGExample.Behaviours.Gmanagers;

namespace Com._90sClassicRPGExample.Behaviours{
	public class PlayerBehaviour : MonoBehaviour {
		#region ### Fields ###

		public PlayerStatsModul stats;
		public PlayerSceneMemoryModul memory;

		#endregion
		#region ### Unity Callbacks ###

		/// <summary>
		/// Awake is called when the script instance is being loaded.
		/// </summary>
		void Awake()
		{
			Collider2D c2d = gameObject.AddComponent<CircleCollider2D>();
			c2d.isTrigger = true;
			Rigidbody2D rb2d = gameObject.AddComponent<Rigidbody2D>();
			rb2d.gravityScale = 0;
		}

		// Use this for initialization
		void Start () {
			stats = MainGmanager.playerData.playerStats;
			memory = MainGmanager.playerMemory;
			if(memory != null){
				DoorBehaviour[] doors = FindObjectsOfType<DoorBehaviour>();
				Debug.Log(doors.Length);
				foreach(DoorBehaviour door in doors){
					Debug.Log(door.name);
					Debug.Log(memory.doorOutputName);
					if(door.name.ToLower() == memory.doorOutputName.ToLower()){
						transform.position = door.transform.position;
						setAngle(door);
					}
				}
			}
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

		void setAngle(DoorBehaviour door){
			switch(door.direction){
				case DoorBehaviour.DoorDirection.South:
					transform.rotation = Quaternion.AngleAxis(90, Vector3.back);
					break;
				case DoorBehaviour.DoorDirection.North:
					transform.rotation = Quaternion.AngleAxis(270, Vector3.back);
					break;
				case DoorBehaviour.DoorDirection.East:
					transform.rotation = Quaternion.AngleAxis(0, Vector3.back);
					break;
				case DoorBehaviour.DoorDirection.West:
					transform.rotation = Quaternion.AngleAxis(18, Vector3.back);
					break;
			}
		}

		#endregion
	}
}