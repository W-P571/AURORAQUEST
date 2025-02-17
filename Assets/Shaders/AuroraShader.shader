Shader "Custom/AuroraShader" {
    Properties {
        _Color ("Base Color", Color) = (0.1, 0.6, 1, 1)
        _MainTex ("Texture", 2D) = "white" {}
        _TimeScale("Time Scale", Float) = 1.0
        _Speed("Animation Speed", Float) = 0.5
    }
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;
        fixed4 _Color;
        float _TimeScale;
        float _Speed;

        struct Input {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o) {
            // Animate the UV coordinates over time
            float2 uv = IN.uv_MainTex;
            uv.y += _Time.y * _Speed * _TimeScale;

            // Sample texture and blend with base color dynamically
            fixed4 tex = tex2D(_MainTex, uv);
            fixed dynamicFactor = sin(_Time.y * _Speed) * 0.5 + 0.5;
            o.Albedo = lerp(_Color.rgb, tex.rgb, dynamicFactor);
            o.Alpha = 1.0;
        }
        ENDCG
    }
    FallBack "Diffuse"
}