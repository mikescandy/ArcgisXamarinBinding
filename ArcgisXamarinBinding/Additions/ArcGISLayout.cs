using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Esri.Android.Map.Popup
{
    public partial class ArcGISLayout
    {
        View IPopupLayout.TitleView
        {
            get
            {
                return ((IPopupLayout)this).TitleView;
            }
            set
            {
                ((IPopupLayout)this).TitleView = value;
            }
        }

        IPopupStyle IPopupLayout.Style
        {
            get
            {
                return ((IPopupLayout)this).Style;
            }
        }



        View IPopupLayout.MediaView
        {
            get
            {
                return ((IPopupLayout)this).MediaView;
            }
            set
            {
                ((IPopupLayout)this).MediaView = value;
            }
        }

        View IPopupLayout.AttributesView
        {
            get
            {
                return ((IPopupLayout)this).AttributesView;
            }
            set
            {
                ((IPopupLayout)this).AttributesView = value;
            }
        }


        View IPopupLayout.AttachmentsView
        {
            get
            {
                return ((IPopupLayout)this).AttachmentsView;
            }
            set
            {
                ((IPopupLayout)this).AttachmentsView = value;
            }
        }
    }
}