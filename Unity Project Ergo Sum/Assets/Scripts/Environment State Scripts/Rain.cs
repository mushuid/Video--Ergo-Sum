using UnityEngine;
using System.Collections;

public class Rain:Environment {

	rainTimer = 0;
	
	// Update is called once per frame
	void Update (CharacterController character);
	void FixedUpdate(CharacterController character)
	{
		rainTimer++
		if(RainTimer >= 60)
			{
				deathTimer++;
				rainTimer = 0;
			}
	}
	void onEnter(CharacterController character);
	void onExit(CharacterController character);
	bool isDamaging(CharacterController character);
}
