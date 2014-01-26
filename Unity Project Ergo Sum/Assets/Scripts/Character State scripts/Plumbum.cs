using UnityEngine;
using System.Collections;

public class Plumbum:Status {
		
	int stateValue = 2;
		float tempJump = 0f;
        // Use this for initialization
        void otherMove(CharControl character);
        bool jump(CharControl character)
		{
		}
        bool left(CharControl character)
		{
			return false;
		}
        bool right(CharControl character)
		{
			return false;
		}
        void up(CharController character);
        void down(CharController character);
        void fixedUpdate(CharController character);
        void onEnter(CharController character)
		{
			character.jumpSpeed *= .1f;
			gravity*=2;
			veryDense = true;
		}
		void onExit(CharController character)
		{
			character.jumpSpeed *= 10;
			gravity*= 0.5;
			veryDense = false;
		}
		bool isDamaging(CharController character)
		{
			return false;
		}
	int getStatusType(){
		return stateValue;
	}

}