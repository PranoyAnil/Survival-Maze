using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

//Source file name:GameController
    //Author’s name:Pranoy Anil
    //Last Modified by:Pranoy Anil
    //Date last Modified:27/3/16 
    //Program description: Assignment 03
    
public class GameController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;

	private Vector3 _playerSpawnPoint;
    private Vector3 _blueenemySpawnPoint;
    private Vector3 _greenenemySpawnPoint;
    private Vector3 _redenemySpawnPoint;
    

    // PUBLIC ACCESS METHODS
    public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

    

    public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "lives: " + this._livesValue;
			}
		}
	}

    
    // PUBLIC INSTANCE VARIABLES
    public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;
	public GameObject player;
    public GameObject blueenemy;
    public GameObject greenenemy;
    public GameObject redenemy;

    // Use this for initialization
    void Start () {
		this._initialize ();

		Instantiate (this.player, this._playerSpawnPoint, Quaternion.identity);
        Instantiate(this.blueenemy, this._blueenemySpawnPoint, Quaternion.identity);
        Instantiate(this.greenenemy, this._greenenemySpawnPoint, Quaternion.identity);
        Instantiate(this.redenemy, this._redenemySpawnPoint, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

	//PRIVATE METHODS ++++++++++++++++++

	//Initial Method
	private void _initialize() {
        
        this._blueenemySpawnPoint = new Vector3(-45f, 17.5f, 45f);
        this._greenenemySpawnPoint = new Vector3(-65f, 10.5f, 16.5f);
        this._redenemySpawnPoint = new Vector3(-65f, 10f, 55f);
        this._playerSpawnPoint = new Vector3 (-74f, 14f, 19f);
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.gameObject.SetActive (false);
		this.HighScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive(false);

	}

	private void _endGame() {
		this.HighScoreLabel.text = "High Score: " + this._scoreValue;
		this.GameOverLabel.gameObject.SetActive (true);
		this.HighScoreLabel.gameObject.SetActive (true);
		this.LivesLabel.gameObject.SetActive (false);
		this.ScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (true);
	}

	// PUBLIC METHODS

	public void RestartButtonClick() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

    
}
