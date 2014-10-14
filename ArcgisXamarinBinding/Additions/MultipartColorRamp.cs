using Java.Util;

using Object = Java.Lang.Object;

namespace Com.Esri.Core.Renderer
{
    public partial class MultipartColorRamp
    {
        bool ICollection.Add(Object @object)
        {
            return ((IList)this).Add(@object);
        }

        bool IList.AddAll(System.Collections.ICollection collection)
        {
            return ((IList)this).AddAll(collection);
        }

        bool IList.ContainsAll(System.Collections.ICollection collection)
        {
            return ((IList)this).ContainsAll(collection);
        }

        public void Add(int location, Object @object)
        {
           ((IList)this).Add(location, @object);
        }

        public bool AddAll(int location, System.Collections.ICollection collection)
        {
            return ((IList)this).AddAll(location, collection);
        }

        bool IList.Add(Object @object)
        {
            return ((IList)this).Add(@object);
        }

        bool ICollection.AddAll(System.Collections.ICollection collection)
        {
            return ((IList)this).AddAll(collection);
        }

        bool ICollection.ContainsAll(System.Collections.ICollection collection)
        {
            return ((IList)this).ContainsAll(collection);
        }

        bool ICollection.RemoveAll(System.Collections.ICollection collection)
        {
            return ((IList)this).RemoveAll(collection);
        }

        bool IList.RetainAll(System.Collections.ICollection collection)
        {
            return ((IList)this).RetainAll(collection);
        }

        public Object Set(int location, Object @object)
        {
            return ((IList)this).Set(location, @object);
        }

        bool IList.RemoveAll(System.Collections.ICollection collection)
        {
            return ((IList)this).RemoveAll(collection);
        }

        bool ICollection.RetainAll(System.Collections.ICollection collection)
        {
            return ((IList)this).RemoveAll(collection);
        }

        Object IList.Get(int location)
        {
            return ((IList)this).Get(location);
        }

        System.Collections.IList IList.SubList(int start, int end)
        {
            return ((IList)this).SubList(start, end);
        }

        Object IList.Remove(int location)
        {
            return ((IList)this).Get(location);
        }
    }
}