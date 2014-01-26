using UnityEngine;
using System.Collections;

public class Rain:Environment {

	int rainTimer = 0;
	
	// Update is called once per frame
	void Update (CharController character){}
	void FixedUpdate(CharController character)
	{
		rainTimer++;
		if(RainTimer >= 60)
			{
				deathTimer++;
				rainTimer = 0;
			}
	}
	void onEnter(CharController character){}
	void onExit(CharController character){}
	bool isDamaging(CharController character)
	{
		return true;
	}
}
