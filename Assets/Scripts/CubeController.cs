using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{
	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// 効果音(課題)
	private AudioSource audioSource;

	// Use this for initialization
	void Start()
	{
		// 効果音を割り当てる(課題)
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		// キューブを移動させる
		transform.Translate(this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
		}
	}

	// キューブの接触時に効果音を再生する(課題)
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "GroundTag" || collision.gameObject.tag == "CubeTag")
		{
			audioSource.Play();
		}
	}
}