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
            await expBody.FadeTo(0, this.AnimationLength);

            this.IsExpanded = !this.IsExpanded;
            if (this.IsExpanded)
            {
                expHeader.CornerRadius = new CornerRadius(20,20,0,0);
            }
            else
            {
                await pthArrow.RotateTo(0, this.AnimationLength);
            }

            if (this.IsExpanded)
            {
                await pthArrow.RotateTo(180, this.AnimationLength);
                await expBody.FadeTo(1, this.AnimationLength);
            }
            else
            {
                //await Task.Delay((int)this.AnimationLength - 10);
                expHeader.CornerRadius = new CornerRadius(20, 20, 20, 20);
            }
        }
    }
}
