using UnityEngine;
using System.Collections;

public abstract class CharControl : MonoBehaviour {
	public int health;
	public string name;
	public int deathTimer;
	public bool onGround;
	public bool isImmortal;
	public int speed;
	public double gravity;
	public double jumpPower;
	public CharacterController controller;

	public ArrayList<Status> currentStatuses;
	public Environment environment;
	// Use this for initialization
	void Start (){
		health = 3;
		deathTimer = 0;
		onGround = true;
		speed = 4;
		gravity = 1;
		jumpPower = 1;
		currentStatuses = new ArrayList<Status>();
		environment = null;
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ();
	public void die(){
		Destroy (gameObject);
	}
	public void left();
	public void right();
	public void jump();

}
