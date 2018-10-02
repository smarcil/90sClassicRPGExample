using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls{
	[System.Serializable]
	public class PlayerStatsModul {
		#region ### Fields ###

		[Range(3,18)]
		public int physique = 3;
		[Range(3,18)]
		public int mental = 3;
		[Range(3,18)]
		public int spirituel = 3;

		#endregion
		#region  ### Constructeur ###

		public PlayerStatsModul(){}

		public PlayerStatsModul(int pPhysique, int pMental, int pSpirituel){
			physique=pPhysique;
			mental=pMental;
			spirituel=pSpirituel;
		}

		#endregion
	}
}