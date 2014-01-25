using UnityEngine;
using System.Collections;

public class Flying:Status {

        // Use this for initialization
        void otherMove(CharControl character);
        void jump(CharControl character);
        bool left(CharControl character)
		{
			 -= velocity.X*0.5;
			return true;
		}
        bool right(CharControl character);
		{
			 += velocity.X*0.5;
			return true;
		}
        void up(CharacterController character);
        void down(CharacterController character);
        void fixedUpdate(CharacterController character);
        void onEnter(CharacterController character)
		{
			isImmortal = false
		}
		void onExit(CharacterController character)
		{
			isImmortal = true;
		}
		bool isDamaging(CharacterController character);