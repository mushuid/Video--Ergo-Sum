using UnityEngine;
using System.Collections;

public class Fire:Status {
	
		int stateValue = 3
		int fireCounter = 0;
		
        // Use this for initialization
        void otherMove(CharControl character);
        bool jump(CharControl character);
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
        void fixedUpdate(CharController character)
		{
			fireCounter ++;
			if(fireCounter >=60)
				{
					deathTimer++;
					fireCounter = 0;
				}
		}
        void onEnter(CharController character);
		{
			speed *= 2f;
		}
		void onExit(CharController character);
		{
			speed *= 0.5f;
		}
		bool isDamaging(CharController character)
		{
			return true;
		}

}