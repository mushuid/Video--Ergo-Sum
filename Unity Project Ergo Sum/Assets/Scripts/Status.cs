using UnityEngine;
using System.Collections;

public interface Status {

	// Use this for initialization
	void otherMove(CharacterController character);
	void jump(CharacterController character);
	bool left(CharacterController character);
	bool right(CharacterController character);
	void up(CharacterController character);
	void down(CharacterController character);
	void fixedUpdate(CharacterController character);
	void onEnter(CharacterController character);
	void onExit (CharacterController character);

}
