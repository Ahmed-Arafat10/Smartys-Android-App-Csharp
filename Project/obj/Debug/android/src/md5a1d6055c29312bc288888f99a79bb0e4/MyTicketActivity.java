package md5a1d6055c29312bc288888f99a79bb0e4;


public class MyTicketActivity
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
		mono.android.Runtime.register ("Project.Activities.MyTicketActivity, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyTicketActivity.class, __md_methods);
	}


	public MyTicketActivity ()
	{
		super ();
		if (getClass () == MyTicketActivity.class)
			mono.android.TypeManager.Activate ("Project.Activities.MyTicketActivity, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
