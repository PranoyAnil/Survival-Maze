using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {
    //PUBLIC VARIABLE
   
    public float speed;

    //PRIVATE

    private Transform _transform;
    private GameObject _player;
    
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this._player = GameObject.FindGameObjectWithTag("Player");
      }
	
	// Update is called once per frame
	void Update () {
        
        float step = speed * Time.deltaTime;
        _transform.position = Vector3.MoveTowards(_transform.position, _player.transform.position, step);
    }//end update

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (transform.gameObject.CompareTag("Enemy"))
    //    {
    //        this._gameController.LivesValue -= 1;
    //    }
  //  void OnCollisionEnter(Collision collision)
  //  {
  //      foreach (ContactPoint contact in collision.contacts)
  //      {
  //          Debug.DrawRay(contact.point, contact.normal, Color.white);
  //      }
  //      if (collision.relativeVelocity.magnitude > 2)
  //      { 
            

  //  }
  //}
}
