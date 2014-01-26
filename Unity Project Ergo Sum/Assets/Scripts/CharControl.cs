using UnityEngine;
using System.Collections;

public abstract class CharControl : MonoBehaviour {
	public const float jumpPower = 1.0f;
	
	public int health;
	public float jumping;
	public string name;
	public int deathTimer;
	public bool onGround;
	public bool isImmortal;
	public float speed;
	public float gravity;
	public float currentJumpPower;
	public CharacterController controller;
	public ArrayList<Status> currentStatuses;
	public Environment environment;
	// Use this for initialization
	void Start (){
		health = 3;
		deathTimer = 0.0f;
		jumping = 2f;
		onGround = true;
		speed = 4.0f;
		gravity = 1.0f;
		currentJumpPower = jumpPower;
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
	public ArrayList<Status> grabStatuses();

}
