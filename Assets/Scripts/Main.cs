using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityObservable;

namespace ShaderDemo
{
    public class Main : MonoBehaviour
    {
        public const int SHADER_ARRAY_SIZE = 1;
        [SerializeField] private ShaderUnit[] ShaderUnits;
        [SerializeField] private Light[] AllLight;
        [SerializeField] private Slider  _lightSlider;

        // [ メソッド: Start ]
        void Start()
        {
            this.Setup();
        }

        // [ メソッド: Update ]
        void Update()
        {
            this.LightUpdate();
        }

        // [ メソッド: 起動時初期化処理 ]
        public void Setup()
        {
            ShaderUnits = new ShaderUnit[SHADER_ARRAY_SIZE];
            for( int i = 0; i < ShaderUnits.Length; i++ )
            {
                ShaderUnits[i] = new ShaderUnit(this, $"Prefabs/ShaderMaterials/shader_{ i.ToString("00") }" );
            }

            AllLight = GameObject.FindObjectsOfType<Light>();
            for( int i = 0; i < AllLight.Length; i++)
            {
                AllLight[i].intensity = _lightSlider.value;
            }
        }

        //
        public void LightUpdate()
        { 
            for( int i = 0; i < AllLight.Length; i++ )
            {
                AllLight[i].intensity = _lightSlider.value;
            }
        }
    }
}
