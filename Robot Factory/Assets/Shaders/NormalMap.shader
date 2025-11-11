Shader "Custom/NormalMap"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalStrength ("Normal Strength", Range(0, 2)) = 1.0
        _Color ("Tint Color", Color) = (1,1,1,1)
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _NormalMap;
        
        struct Input
        {
            float2 uv_MainTex;
            float2 uv_NormalMap;
        };

        half _NormalStrength;
        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo (base color texture)
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            
            // Normal mapping
            fixed3 normalMap = UnpackNormal(tex2D(_NormalMap, IN.uv_NormalMap));
            normalMap.xy *= _NormalStrength; // Control normal strength
            o.Normal = normalize(normalMap);
            
            // Metallic and smoothness
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    
    FallBack "Diffuse"
}