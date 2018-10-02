using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Com._90sClassicRPGExample.Behaviours;

namespace Com._90sClassicRPGExample.Behaviours.Gmanagers{
	public class WorldMapSmanager : MonoBehaviour {
		#region ### Serialize Fields ###

		public PlayerBehaviour player;

		#endregion
		
		// Use this for initialization
		void Start () {
			player.stats = MainGmanager.playerData.playerStats;
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}