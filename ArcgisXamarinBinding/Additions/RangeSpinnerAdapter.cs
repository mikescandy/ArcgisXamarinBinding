using Android.Widget;

using Object = Java.Lang.Object;

namespace Com.Esri.Android.Map.Popup
{
    public partial class ArcGISEditAttributesAdapter
    {
        protected internal partial class RangeSpinnerAdapter
        {
            public override Object GetItem(int position)
            {
                return ((IAdapter)this).GetItem(position);
            }
        }
    }
}