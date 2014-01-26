using UnityEngine;
using System.Collections;

public class Plumbum:Status {
		
	int stateValue = 2;

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
	public void fixedUpdate(CharController character){}
	public void onEnter(CharController character)
		{
			character.jumpPower *= .1f;
			character.veryDense = true;
		}
	public void onExit(CharController character)
		{
			character.jumpPower *= 10f;
			character.gravity*= 0.5f;
			character.veryDense = false;
		}
	public bool isDamaging(CharController character)
		{
			return false;
		}
	public int getStatusType(){
		return stateValue;
	}

}