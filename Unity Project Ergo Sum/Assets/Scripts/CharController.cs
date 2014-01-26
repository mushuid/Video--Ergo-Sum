using UnityEngine;
using System.Collections;

public abstract class CharController : MonoBehaviour {
	public float jumpPower;	
	public int health;
	public float jumping;
	public string name;
	public int deathTimer;
	public bool onGround;
	public bool isImmortal;
	public bool veryDense;
	public float speed;
	public float gravity;
	public CharacterController controller;
	public ArrayList currentStatuses;
	public Environment environment;
	// Use this for initialization
	void Start (){
		health = 3;
		deathTimer = 0;
		jumping = 2f;
		onGround = true;
		speed = 4.0f;
		gravity = 1.0f;
		jumpPower = 1.0f;
		veryDense = false;
		currentStatuses = new ArrayList();
		environment = null;
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame

	public void die(){
		Destroy (gameObject);
	}
	public abstract void left();
	public abstract void right();
	public abstract void jump();
	public abstract ArrayList grabStatuses();

}
