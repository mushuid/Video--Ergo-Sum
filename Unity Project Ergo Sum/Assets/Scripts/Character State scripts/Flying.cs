using UnityEngine;
using System.Collections;

public class Flying:Status {

        // Use this for initialization
        void otherMove(CharacterController character);
        void jump(CharacterController character);
        bool left(CharacterController character)
		{return false}
        bool right(CharacterController character);
		{return false}
        void up(CharacterController character);
        void down(CharacterController character);
        void fixedUpdate(CharacterController character);
        void onEnter(CharacterController character)
		{
			gravity*=.5;
		}
		void onExit(CharacterController character);
		{
			gravity*=2;
		}
		bool isDamaging(CharacterController character);

}