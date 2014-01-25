using UnityEngine;
using System.Collections;

public class Plumbum:Status {

        // Use this for initialization
        void otherMove(CharacterController character);
        void jump(CharacterController character)
		{
			return null;
		}
        bool left(CharacterController character)
		{
			return false;
		}
        bool right(CharacterController character);
		{
			return false;
		}
        void up(CharacterController character);
        void down(CharacterController character);
        void fixedUpdate(CharacterController character);
        void onEnter(CharacterController character);
		{
			gravity*=2;
			veryDense = true;
		}
		void onExit(CharacterController character);
		{
			gravity*= 0.5;
			veryDense = false;
		}
		bool isDamaging(CharacterController character);

}