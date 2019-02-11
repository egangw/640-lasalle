using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointLogic : MonoBehaviour
{

    public GameObject player;

    public bool teleport;

    private float heightAboveWaypoint = .01f;

	private AudioSource _audio_source			= null;

	[Header("Sounds")]
	public AudioClip clip_click					= null;	

	void Awake()
	{		
		_audio_source				= gameObject.GetComponent<AudioSource>();	
		_audio_source.clip		 	= clip_click;
		_audio_source.playOnAwake 	= false;
	}

    public void Move(GameObject waypoint)
    {
        if (!teleport)
        {
            iTween.MoveTo(player,
                iTween.Hash(
                    "position", new Vector3(waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z),
                    "time", 1f,
                    "easetype", "linear"
                )
            );
			_audio_source.Play();
        }
        else
        {
            player.transform.position = new Vector3(waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z);
        }
    }

}

