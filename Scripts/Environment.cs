using UnityEngine;
using System.Collections;

public interface Environment {


	
	// Update is called once per frame
	void Update (CharacterController character);
	void FixedUpdate(CharacterController character);
	void onEnter(CharacterController character);
	void onExit(CharacterController character);
	bool isDamaging(CharacterController character);
}
