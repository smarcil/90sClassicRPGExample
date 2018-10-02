using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

using Com._90sClassicRPGExample.Behaviours.PlayerBehaviourModuls;
using Com._90sClassicRPGExample.Behaviours.Gmanagers;

namespace Com._90sClassicRPGExample.Behaviours.Smanagers{
	public class MainMenuSmanager : MonoBehaviour {
		#region ### Serialize Fields ###

		[Header("Stat Dropdowns")]
		public Dropdown physique;
		public Dropdown mental;
		public Dropdown spritual;

		[Header("Buttons")]
		public Button goButton;

		#endregion
		#region ### Fields ###

		PlayerStatsModul playerStats = new PlayerStatsModul();

		#endregion
		#region ### Unity Callbacks ###

		// Use this for initialization
		void Start () {
			physique.onValueChanged.AddListener( (selectedIndex) => { physiqueValueChanged(selectedIndex); } );
			mental.onValueChanged.AddListener( (selectedIndex) => { mentalValueChanged(selectedIndex); } );
			spritual.onValueChanged.AddListener( spritualValueChanged );// you can make this too
			goButton.onClick.AddListener( () => { clickGoBtn(); } );
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		#endregion
		#region ### Methods ###

		void physiqueValueChanged(int selectedIndex){
			playerStats.physique = int.Parse( physique.options[selectedIndex].text );
		}

		void mentalValueChanged(int selectedIndex){
			playerStats.mental = int.Parse( mental.options[selectedIndex].text );
		}

		void spritualValueChanged(int selectedIndex){
			playerStats.spirituel = int.Parse( spritual.options[selectedIndex].text );
		}

		void clickGoBtn(){
			MainGmanager.playerData.playerStats = playerStats;
			SceneManager.LoadScene("WorldMap");
		}

		#endregion
	}
}