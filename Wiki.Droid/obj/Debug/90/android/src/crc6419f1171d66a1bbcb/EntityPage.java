package crc6419f1171d66a1bbcb;


public class EntityPage
	extends crc64a5a37c43dff01024.Page
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Wiki.Shared.Pages.EntityPage, Wiki.Droid", EntityPage.class, __md_methods);
	}


	public EntityPage (android.content.Context p0)
	{
		super (p0);
		if (getClass () == EntityPage.class)
			mono.android.TypeManager.Activate ("Wiki.Shared.Pages.EntityPage, Wiki.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
