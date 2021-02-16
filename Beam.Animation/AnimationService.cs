using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Beam.Animation.Services
{
    public class AnimationService
    {
        private IJSRuntime _jSRuntime;

        public static event Action BeamPassTriggered;

        public AnimationService(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        public ValueTask LoadAnimation(string elementId, int width, int height)
        {
            return _jSRuntime.InvokeVoidAsync("animatedBeam.loadAnimation", elementId, width, height);
        }
        [JSInvokable]
        public static Task BeamPassedBy()
        {
            return Task.Run(() => BeamPassTriggered?.Invoke());
        }

    }
}
