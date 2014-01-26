using UnityEngine;
using System.Collections;

public interface Environment {


	
	// Update is called once per frame
	void Update (CharController character);
	void FixedUpdate(CharController character);
	void onEnter(CharController character);
	void onExit(CharController character);
	bool isDamaging(CharController character);
}
