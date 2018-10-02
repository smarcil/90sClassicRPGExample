using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Com._90sClassicRPGExample.Data;

namespace Com._90sClassicRPGExample.Behaviours.Gmanagers{
	public class MainGmanager : MonoBehaviour {
		#region ### init ###

		static MainGmanager __instance;

		static MainGmanager getInstance(){
			if(__instance == null){ setInstance(); }
			return __instance;
		}

		static void setInstance(){
			GameObject go = new GameObject();
			go.AddComponent<MainGmanager>();
			GameObject.DontDestroyOnLoad(go);//keep the object active all along the game
			__instance = go.GetComponent<MainGmanager>();
			go.name = __instance.GetType().Name;
		}

		#endregion
		#region ### Fields ###

		PlayerData _playerData;

		#endregion

		#region ### Properties ###

		public static PlayerData playerData{
			get{
				if(getInstance()._playerData == null){
					getInstance()._playerData = Instantiate<PlayerData>( Resources.Load<PlayerData>("Com/90sClassicRPGExample/PlayerDataObject") );
				}
				return getInstance()._playerData;
			}
		}

		#endregion
		#region  ### Unity Callback ###

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		#endregion
		#region ### Methods ###

		

		#endregion
	}
}