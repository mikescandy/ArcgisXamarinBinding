 

using Android.Widget;

using Object = Java.Lang.Object;

namespace Com.Esri.Android.Map.Popup
{
    public partial class ArcGISAttachmentsAdapter
    {
        Object IAdapter.GetItem(int position)
        {
            return ((IAdapter)this).GetItem(position);
        }
    }
}