using UnityEngine;
using System.Collections;


public class Fire:Status {
	
		int stateValue = 3;
		int fireCounter = 0;
		
        // Use this for initialization
	public void otherMove(CharController character){}
	public bool jump(CharController character)
	{
		return false;
	}
	public bool left(CharController character)
		{
			return false;
		}
	public bool right(CharController character)
		{
			return false;
		}
	public void up(CharController character){}
	public void down(CharController character){}
	public void fixedUpdate(CharController character)
		{
			fireCounter ++;
			if(fireCounter >=60)
				{
					character.deathTimer++;
					fireCounter = 0;
				}
		}
	public void onEnter(CharController character)
		{
			character.speed *= 2f;
		}
	public void onExit(CharController character)
		{
			character.speed *= 0.5f;
		}
	public bool isDamaging(CharController character)
		{
			return true;
		}
	public int getStatusType(){
			return stateValue;
		}

}