using UnityEngine;
using System.Collections;

public interface Status {

	// Use this for initialization
	void otherMove(CharacterController character);
	void jump(CharacterController character);
	void left(CharacterController character);
	void right(CharacterController character);
	void up(CharacterController character);
	void down(CharacterController character);
	void fixedUpdate(CharacterController character);
	void onEnter(CharacterController character);

}
