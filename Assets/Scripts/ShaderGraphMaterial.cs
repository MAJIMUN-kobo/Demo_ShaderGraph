using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShaderDemo;

public class ShaderGraphMaterial : MonoBehaviour
{
    // [ フィールド ]
    private ShaderUnit _parent;
    private ShaderUnit.Parameter _parameter;
    private MeshRenderer _renderer;
    private Material _material;
    

    // [ メソッド: Start ]
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _material = _renderer.material;
    }

    // [ メソッド: Update ]
    void Update()
    {
        
    }

    // [ メソッド: LateUpdate ]
    void LateUpdate()
    {
        
    }

    // [ メソッド: 初期化処理 ]
    public void Initialize( ShaderUnit parent )
    {
        _parent = parent;
        _parameter = parent.parameter;
    }
}
