using UnityEngine;
using System.Collections;

public class Turtle:Status {

		int stateValue = 4;
        // Use this for initialization
        void otherMove(CharControl character);
        void jump(CharControl character);
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
		character.speed *= 0.5;
			isImmortal = true;
		}
		void onExit(CharController character)
		{
			character.speed *= 2;
			isImmortal = false;
		}
		bool isDamaging(CharController character)
		{
			return false;
		}
	int getStatusType(){
		return stateValue;
	}