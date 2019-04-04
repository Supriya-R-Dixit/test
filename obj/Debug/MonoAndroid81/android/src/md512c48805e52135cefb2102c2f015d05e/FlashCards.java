package md512c48805e52135cefb2102c2f015d05e;


public class FlashCards
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Gurukul_MVP.FlashCards, Gurukul MVP", FlashCards.class, __md_methods);
	}


	public FlashCards ()
	{
		super ();
		if (getClass () == FlashCards.class)
			mono.android.TypeManager.Activate ("Gurukul_MVP.FlashCards, Gurukul MVP", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
