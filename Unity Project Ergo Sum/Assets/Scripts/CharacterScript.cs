using UnityEngine;
using System.Collections;

public class CharacterScript : CharControl {


	// Use this for initialization


	// Update is called once per frame

	override void Update () {
		ArrayList<Status> newStatuses = grabStatuses();
		handleOnEnterandExit(currentStatuses, newStatuses);
		currentStatuses = newStatuses;
		if((anyStatusesDamaging() > deathTimer >= 4) && !isImmortal){
			die();
		}
		else{
			deathTimer = 0;
		}
		bool jumpchanged = false;
		bool leftchanged = false;
		bool rightchanged = false;
		foreach (Status status in currentStatuses){
			if(Input.GetKeyDown(KeyCode.Space)){
				bool temp = status.jump(this);
				if(temp){
					jumpchanged = true;
				}
			}
			if(Input.GetKeyDown(KeyCode.LeftArrow)){
				bool temp = status.left(this);
				if(temp){
					leftchanged = true;
				}
			}
			if(Input.GetKeyDown(KeyCode.RightArrow)){
				bool temp = status.right(this);
				if(temp){
					rightchanged = true;
				}
			}
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				status.down();
			}
			if(Input.GetKeyDown(KeyCode.RightShift)){
				status.otherMove();
			}
		}
		if(Input.GetKeyDown(KeyCode.Space) && !jumpchanged){

			jump();

		}
		if(Input.GetKeyDown(KeyCode.RightArrow) && !rightchanged){
			right();
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow) && !leftchanged){
			left();
		}
			
	}
	public override void right(){
		controller.Move(new Vector3(speed, 0 , 0));
	}
	public override void left(){
		controller.Move(new Vector3(-1 *speed, 0 , 0));
	}
	public override void jump(){
		if(controller.isGrounded){
			jumping = 2f;
			controller.Move(new Vector3(0, jumpPower/jumping, 0));
			jumping *= 2;
		}
		else if(jumping > 2f && jumping <= 32f){
			controller.Move(new Vector3(0, jumpPower/jumping, 0));
			jumping *= 2;
		}
	}
	void FixedUpdate() {
		foreach (Status status in currentStatuses){
			status.fixedUpdate(this);
		}
	}
	private void handleOnEnterandExit(ArrayList<Status> old, ArrayList<Status> newer){
		ArrayList<Status> added = new ArrayList<Status>();
		ArrayList<Status> removed = new ArrayList<Status>();
		foreach(Status a in old){
			bool isNotInNew = true;
			foreach(Status b in newer){
				if(b.getStatusType == a.getStatusType){
					isNotInNew = false;
				}
			}
			if(isNotInNew){
				removed.Add(a);
			}
		}
		foreach(Status a in newer){
			bool isNotInOld = true;
			foreach(Status b in old){
				if(b.getStatusType == a.getStatusType){
					isNotInOld = false;
				}
			}
			if(isNotInNew){
				added.Add(a);
			}
		}
		foreach(Status a in removed){
			a.onExit(this);
		}
		foreach(Status a in added){
			a.onEnter(this);
		}
	}
	override ArrayList<Status> grabStatuses(){
		ArrayList<Status> newList = new ArrayList<Status>();
	}
	private bool anyStatusesDamaging(){
		foreach (Status status in currentStatuses){
			if(status.isDamaging){
				return true;
			}
		}
		return false;
	}
	public void die(){
		health -= 1;

		if (health == 0){
			Destroy(gameObject);
		}
	}
}
