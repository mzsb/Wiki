package crc646ea6d25a4a2eb494;


public class Fieldset
	extends crc64a5a37c43dff01024.UserControl
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Wiki.Shared.UserControls.Fieldset, Wiki.Droid", Fieldset.class, __md_methods);
	}


	public Fieldset (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Fieldset.class)
			mono.android.TypeManager.Activate ("Wiki.Shared.UserControls.Fieldset, Wiki.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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