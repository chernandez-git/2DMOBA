using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject creep;
	public Vector2 spawnValues;
	public int creepCount;
	void Start (){
		SpawnCreeps ();
	}
	void SpawnCreeps(){
		for (int i=0;i<creepCount;i++) {
			Vector2 spawnPosition = new Vector2 (5, 5);
			Quaternion spawnRotation = new Quaternion ();
			Instantiate (creep, spawnPosition, spawnRotation);
		}
	}
}
