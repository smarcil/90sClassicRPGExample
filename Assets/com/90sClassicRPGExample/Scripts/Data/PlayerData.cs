using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls;

namespace Com._90sClassicRPGExample.Data{
	[CreateAssetMenu(fileName="PlayerDataObject", menuName="90sClassicRPGExample/PlayerData")]
	public class PlayerData : ScriptableObject  {
		#region ### Fields ###

		public PlayerStatsModul playerStats;

		#endregion
	}
}