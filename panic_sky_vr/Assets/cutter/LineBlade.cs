using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 線を引いてカットするクラス
[RequireComponent(typeof(LineRenderer))]
public class LineBlade : MonoBehaviour
{

    public Cutter _cutter;

    private LineRenderer _lineRenderer;
    private Plane _plane;

    private Vector3 normal;
    private Vector3 position;

    private Vector3 startPos;
    private Vector3 endPos;

	public GameObject obj;

	public GameObject objG;

	private Collider objCol;
	private GameObject objA;
	private GameObject objB;

	public Collider cutCol;
	private  Transform pos;

    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
		_lineRenderer.enabled = false;

		objCol = GetComponent<Collider> ();
    }

    void Update()
    {
/*
        if (Input.GetMouseButtonDown(0))
        {
            var startMousePos = Input.mousePosition;
            startMousePos.z = 10.0f;
            startPos = Camera.main.ScreenToWorldPoint(startMousePos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            var endMousePos = Input.mousePosition;
            endMousePos.z = 10.0f;
            endPos = Camera.main.ScreenToWorldPoint(endMousePos);

            _lineRenderer.SetPositions(new Vector3[] { startPos, endPos });
            _lineRenderer.enabled = true;
            Create();
            var cutMesh = FindCutMesh();
            if(cutMesh != null){
                _cutter.Cut(_plane , cutMesh);
            }
            
        }
*/
    }

	void OnCollisionEnter(Collision col){
		objCol.isTrigger = true;
		GetComponent<Rigidbody> ().isKinematic = true;
		GetComponent<Rigidbody> ().isKinematic = false;
		if (col.gameObject.tag == "target"|| col.gameObject.tag == "Hostage") {
			objA = Instantiate (objG, col.contacts[0].point,new Quaternion());
			objB = Instantiate (objG, col.contacts[0].point,new Quaternion());
			objB.transform.parent = this.transform;
		}
		startPos = objA.transform.position;
	}

	void OnTriggerExit(Collider col){
		objCol.isTrigger = false;
		if (col.gameObject.tag == "target"|| col.gameObject.tag == "Hostage") {
			objB.transform.parent = null;
			endPos = objB.transform.position;
			cutCol = col;


			_lineRenderer.SetPositions (new Vector3[] { startPos, endPos });
//		_lineRenderer.enabled = true;
			Create ();
			var cutMesh = FindCutMesh ();
			if (cutMesh != null) {
				_cutter.Cut (_plane, cutMesh);
			}
		}
	}

    private CutMesh FindCutMesh()
    {
        RaycastHit hit;
        // 面倒だが、線の中心点をscreenposに変換してからrayを飛ばして切断オブジェクトを探している
        var screenPos = Camera.main.WorldToScreenPoint(position);
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        if (Physics.Raycast(ray, out hit , Mathf.Infinity))
        {
            var cutMesh = hit.collider.gameObject.GetComponent<CutMesh>();
            if (cutMesh != null)
            {
                return cutMesh;
            }
        }
        return null;

//		return cutCol.gameObject.GetComponent<CutMesh> ();
    }

	//切断面の作成
    private void Create()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _plane = new Plane();

        position = (_lineRenderer.GetPosition(0) + _lineRenderer.GetPosition(1)) / 2;
        var p1 = _lineRenderer.GetPosition(0) - position;
        normal = (Quaternion.Euler(0f, 0f, 90f) * p1).normalized;
        _plane.SetNormalAndPosition(normal, position);

    }

	//青い法線を表示
    void OnDrawGizmosSelected() 
    {
        float length = 10.0f;
        Gizmos.color = Color.blue;

        Gizmos.DrawLine(position, position + (normal * length));

    }

    public Plane Plane
    {
        get
        {
            return _plane;
        }
    }

}
