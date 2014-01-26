using UnityEngine;
using System.Collections;

public class Rain:Environment {

	int rainTimer = 0;
	
	// Update is called once per frame
	public void Update (CharController character){}
	public void FixedUpdate(CharController character)
	{
		rainTimer++;
		if(rainTimer >= 60)
			{
				character.deathTimer++;
				rainTimer = 0;
			}
	}
	public void onEnter(CharController character){}
	public void onExit(CharController character){}
	public bool isDamaging(CharController character)
	{
		return true;
	}
}
