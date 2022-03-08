Shader "Custom/transparency"
{
    Properties
    {
        _Color ("Chroma", Color) = (0,1,0,0) //色度
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Cutoff("Recorte", Range(0,0.9)) = 0.2
        _Sens("Sensibilidad", Range(0,.9)) = 0.3
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType" = "Transparent" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        float _Cutoff, _Sens;
        half3 _Color;

        struct Input
        {
            float2 uv_MainTex;
        };

        
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            half4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Emission = c.rgb;

            float aR = abs(c.r - _Color.r) < _Sens ? abs(c.r - _Color.r) : 1;
            float aG = abs(c.g - _Color.g) < _Sens ? abs(c.g - _Color.g) : 1;
            float aB = abs(c.b - _Color.b) < _Sens ? abs(c.b - _Color.b) : 1;

            float a = (aR + aG + aB) / 3;

            if (a < _Cutoff) {
                o.Alpha = 0;
            }
            else {
                o.Alpha = 1;
            }
        }
        ENDCG
    }
    FallBack "Diffuse"
}
