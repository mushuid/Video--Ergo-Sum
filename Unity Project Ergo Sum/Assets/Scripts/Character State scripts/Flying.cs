using UnityEngine;
using System.Collections;

public class Flying:Status {
		
		int stateValue = 1;
		int jumpDelay = 0;
		float jumping = 2f;
        // Use this for initialization
        void otherMove(CharControl character);
        bool jump(CharControl character)
		{
			if(jumpDelay == 0 || jumping < 8f){
				character.controller.Move(new Vector3(0, character.jumpPower/jumping, 0));
				jumping *= 2;
			}
				
			return true;
		}
        bool left(CharControl character){
				return false;
		}
        bool right(CharControl character)
			{
				return false;
			}
			void up(CharController character);
			void down(CharController character);
        void fixedUpdate(CharController character)
		{
			if(jumpDelay > 0)
				jumpDelay++;
			if(jumpDelay >=10)
			{
				jumpDelay = 0;
				jumping = 2f;
			}
		}
        void onEnter(CharController character)
		{
			gravity*=.5;
		}
		void onExit(CharController character)
		{
			gravity*=2;
		}
		bool isDamaging(CharController character)
		{
			return false;
		}
		int getStatusType(){
			return stateValue;
		}

}