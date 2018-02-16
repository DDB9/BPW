using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour {

	public GameObject grassMagic;
	public GameObject waterMagic;
	public Transform magicSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("e")){
			fireGrass();
		}
		if (Input.GetKey("f")){
			fireWater();
		}
	}

	void fireGrass () {
		// Create the grass magic from the grassMagic prefab.
		var gMagic = (GameObject)Instantiate(
			grassMagic,
			magicSpawn.position,
			magicSpawn.rotation);

		// Add velocity to the magic.
		gMagic.GetComponent<Rigidbody>().velocity = gMagic.transform.forward * 6;

		// Destroy magic projectile after 2 seconds.
		Destroy(gMagic, 2.0f);
	}

	void fireWater() {
		// Create the water magic from the waterMagic prefab.
		var wMagic = (GameObject)Instantiate(
			waterMagic,
			magicSpawn.position,
			magicSpawn.rotation);

		// Add velocity to the magic.
		wMagic.GetComponent<Rigidbody>().velocity = wMagic.transform.forward * 10;

		// Destroy magic projectile after 5 seconds.
		Destroy(wMagic, 8.0f);
	}
}

