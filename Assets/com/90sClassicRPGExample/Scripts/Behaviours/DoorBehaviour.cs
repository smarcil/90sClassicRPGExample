using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using Com._90sClassicRPGExample.Behaviours.Gmanagers;
using Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls;

namespace Com._90sClassicRPGExample.Behaviours{
	public class DoorBehaviour : MonoBehaviour {
		#region ### Enums ###

		public enum DoorDirection{
			South,
			North,
			East,
			West
		}

		#endregion
		#region ### Serialize Fields ###

		public DoorDirection direction = DoorDirection.South;
		public Object sceneOutput;
		public string doorOutputName;
		private bool isRready = false;

		#endregion
		#region ### Unity Callback ###

		/// <summary>
		/// Awake is called when the script instance is being loaded.
		/// </summary>
		void Awake()
		{
			Collider2D c2d = gameObject.AddComponent<BoxCollider2D>();
			c2d.isTrigger = true;
			Rigidbody2D rb2d = gameObject.AddComponent<Rigidbody2D>();
			rb2d.gravityScale = 0;
		}

		/// <summary>
		/// Start is called on the frame when a script is enabled just before
		/// any of the Update methods is called the first time.
		/// </summary>
		void Start()
		{
			StartCoroutine( waitAfterChangeScene() );
		}

		/// <summary>
		/// Sent when another object enters a trigger collider attached to this
		/// object (2D physics only).
		/// </summary>
		/// <param name="other">The other Collider2D involved in this collision.</param>
		void OnTriggerEnter2D(Collider2D other)
		{
			OpenDoor(other);
		}

		#endregion
		#region ### Methods ###

		IEnumerator waitAfterChangeScene(){
			yield return new WaitForSeconds(1f);
			isRready = true;
		}

		void OpenDoor(Collider2D other){
			if(!isRready) return;
			if( string.IsNullOrEmpty(doorOutputName) )return;
			if( other.GetComponent<PlayerBehaviour>() == null )return;
			if(MainGmanager.playerMemory == null)MainGmanager.playerMemory = new PlayerSceneMemoryModul(); 
			MainGmanager.playerMemory.doorOutputName = doorOutputName;
			SceneManager.LoadScene(sceneOutput.name);
		}

		#endregion
	}
}