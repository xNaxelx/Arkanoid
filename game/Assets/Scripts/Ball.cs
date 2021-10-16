using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    [HideInInspector]public bool isStart = false;
    private Rigidbody _rb;
    private bool _isStart = true;
    private float _maxSpeed = 1;
    static int ballCount = 1;
    private Vector3 _velocityEditor;

    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _maxSpeed *= _speed;
        _velocityEditor = new Vector3();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            collision.gameObject.GetComponent<Block>().Knock();
        }
        else if (collision.gameObject.CompareTag("Lose"))
        {
            Destroy(gameObject);
            if(--ballCount == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                ballCount = 1;
            }
        } 
        else if (collision.gameObject.CompareTag("Platform"))
        {
            _velocityEditor.Set((transform.position.x - collision.transform.position.x) * 16, _rb.velocity.y, _rb.velocity.z);
            _rb.velocity = _velocityEditor;
        }
    }

    void Update()
    {
        if (isStart && _isStart)
        {
            _isStart = false;
            _rb.velocity = new Vector3(0, 1, 0) * _speed;
        }
        Debug.Log(_rb.velocity.magnitude);
        if(_rb.velocity.magnitude > _maxSpeed + 0.1)
        {
            _rb.velocity *= (_maxSpeed / _rb.velocity.magnitude);
        }
        else if(_rb.velocity.magnitude < _maxSpeed - 0.1)
        {
            _rb.velocity *= (_maxSpeed / _rb.velocity.magnitude);
        }

    }

}
