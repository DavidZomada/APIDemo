using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APIDemoApp.Utilities
{
    public class EventsTriggers
    {
        public EventsTriggers()
        {
        }
    }

    public class ScaleAction : TriggerAction<VisualElement>
    {
        protected override void Invoke(VisualElement sender)
        {
            //(sender as Frame).ScaleTo(0.5, 500, Easing.CubicOut);
        }
    }
}
