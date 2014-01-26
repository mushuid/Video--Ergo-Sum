using UnityEngine;
using System.Collections;

public class Turtle:Status {

		int stateValue = 4;
        // Use this for initialization
	public void otherMove(CharController character){}
	public bool jump(CharController character){
		return false;}
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
		character.speed *= 0.5f;
			character.isImmortal = true;
		}
	public void onExit(CharController character)
		{
			character.speed *= 2f;
			character.isImmortal = false;
		}
	public bool isDamaging(CharController character)
		{
			return false;
		}
	public int getStatusType(){
		return stateValue;
	}
}