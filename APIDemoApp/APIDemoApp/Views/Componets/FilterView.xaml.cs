using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Shapes;

namespace APIDemoApp.Views.Componets
{
    public partial class FilterView : Expander
    {
        public FilterView()
        {
            InitializeComponent();
        }

        async void Arrow_Clicked(System.Object sender, System.EventArgs e)
        {
            this.IsExpanded = !this.IsExpanded;
            if (this.IsExpanded)
            {
                CollapseFrame.CornerRadius = new CornerRadius(20,20,0,0);
            }
            else
            {
                await Task.Delay((int)this.AnimationLength);
                CollapseFrame.CornerRadius = new CornerRadius(20, 20, 20, 20);
            }

            if (this.IsExpanded)
            {
                await (sender as Path).RotateTo(180, this.AnimationLength);
            }
            else
            {
                await (sender as Path).RotateTo(0, this.AnimationLength);
            }
        }
    }
}
