using UnityEngine;
using System.Collections;

public interface Status {
		int fireCounter = 0;
        // Use this for initialization
        void otherMove(CharacterController character);
        void jump(CharacterController character);
        bool left(CharacterController character)
		{
			 -= velocity.X*1.5;
			return true;
		}
        bool right(CharacterController character);
		{
			 += velocity.X*1.5;
			return true;
		}
        void up(CharacterController character);
        void down(CharacterController character);
        void fixedUpdate(CharacterController character)
		{
			fireCounter ++;
			if(fireCounter >=60)
				{
					deathTimer++;
					fireCounter = 0;
				}
		}
        void onEnter(CharacterController character);
		void onExit(CharacterController character);
		bool isDamaging(CharacterController character);

}