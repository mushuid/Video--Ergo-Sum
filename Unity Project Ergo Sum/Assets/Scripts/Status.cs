using UnityEngine;
using System.Collections;

public interface Status {

	// Use this for initialization
	void otherMove(CharControl character);
	void jump(CharControl character);
	bool left(CharControl character);
	bool right(CharControl character);
	void up(CharControl character);
	void down(CharControl character);
	void fixedUpdate(CharControl character);
	void onEnter(CharControl character);
	void onExit(CharControl character);
	bool isDamaging(CharControl character);
	int getStatusType();
}
