using UnityEngine;
using System.Collections;

public interface Status {

	// Use this for initialization
	void otherMove(CharController character);
	bool jump(CharController character);
	bool left(CharController character);
	bool right(CharController character);
	void up(CharController character);
	void down(CharController character);
	void fixedUpdate(CharController character);
	void onEnter(CharController character);
	void onExit(CharController character);
	bool isDamaging(CharController character);
	int getStatusType();
}
