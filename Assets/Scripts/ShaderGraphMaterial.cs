using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShaderDemo;

public class ShaderGraphMaterial : MonoBehaviour
{
    // [ �t�B�[���h ]
    private ShaderUnit _parent;
    private ShaderUnit.Parameter _parameter;
    private MeshRenderer _renderer;
    private Material _material;
    

    // [ ���\�b�h: Start ]
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _material = _renderer.material;
    }

    // [ ���\�b�h: Update ]
    void Update()
    {
        
    }

    // [ ���\�b�h: LateUpdate ]
    void LateUpdate()
    {
        
    }

    // [ ���\�b�h: ���������� ]
    public void Initialize( ShaderUnit parent )
    {
        _parent = parent;
        _parameter = parent.parameter;
    }
}
