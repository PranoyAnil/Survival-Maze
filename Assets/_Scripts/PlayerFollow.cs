using UnityEngine;
using System.Collections;

//Source file name:PlayerFollow
    //Author’s name:Pranoy Anil
    //Last Modified by:Pranoy Anil
    //Date last Modified:27/3/16 
    //Program description: Assignment 03

public class PlayerFollow : MonoBehaviour {
    //PUBLIC VARIABLE
   
    public float speed;

    //PRIVATE

    private Transform _transform;
    private GameObject _player;
    private GameController _gameController;
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._gameController = GameObject.FindWithTag("GameController").GetComponent("GameController") as GameController;
        this._player = GameObject.FindGameObjectWithTag("Player");
      }
	
	// Update is called once per frame
	void Update () {
        
        float step = speed * Time.deltaTime;

        this._transform.position = Vector3.MoveTowards(this._transform.position, _player.transform.position, step);
    }//end update
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            this._gameController.LivesValue -= 1;
        }
    }
    

}
