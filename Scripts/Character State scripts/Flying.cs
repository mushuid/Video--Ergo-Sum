using UnityEngine;
using System.Collections;

public class Flying:Status {
		
		int stateValue = 1;
		int jumpDelay = 0;
		float jumping = 2f;
        // Use this for initialization
	public void otherMove(CharController character){}
	public bool jump(CharController character)
		{
			if(jumpDelay == 0 || jumping < 8f){
				character.controller.Move(new Vector3(0, character.jumpPower/jumping, 0));
				jumping *= 2;
			}
				
			return true;
		}
	public bool left(CharController character){
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
			if(jumpDelay > 0)
				jumpDelay++;
			if(jumpDelay >=10)
			{
				jumpDelay = 0;
				jumping = 2f;
			}
		}
	public void onEnter(CharController character)
		{
			character.gravity *= .5f;
		}
	public void onExit(CharController character)
		{
			character.gravity *= 2f;
		}
	public bool isDamaging(CharController character)
		{
			return false;
		}
	public int getStatusType(){
			return stateValue;
		}

}