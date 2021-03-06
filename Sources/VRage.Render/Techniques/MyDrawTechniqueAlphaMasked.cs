﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRageRender.Effects;
using VRageRender.Graphics;

namespace VRageRender.Techniques
{
    class MyDrawTechniqueAlphaMasked : MyDrawTechniqueBaseDNS
    {
        public override MyEffectBase PrepareAndBeginShader(MyRender.MyRenderSetup setup, MyLodTypeEnum lodType)
        {
            var shader = (MyEffectModelsDNS)MyRender.GetEffect(MyEffects.ModelDNS);
            SetupBaseEffect(shader, setup, lodType);

            shader.ApplyMasked();
            shader.Begin(0, SharpDX.Direct3D9.FX.None);
            return shader;
        }
    }
}
