package md5a1d6055c29312bc288888f99a79bb0e4;


public class WebSiteActivity_HelloWebViewClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_shouldOverrideUrlLoading:(Landroid/webkit/WebView;Ljava/lang/String;)Z:GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("Project.Activities.WebSiteActivity+HelloWebViewClient, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WebSiteActivity_HelloWebViewClient.class, __md_methods);
	}


	public WebSiteActivity_HelloWebViewClient ()
	{
		super ();
		if (getClass () == WebSiteActivity_HelloWebViewClient.class)
			mono.android.TypeManager.Activate ("Project.Activities.WebSiteActivity+HelloWebViewClient, Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1)
	{
		return n_shouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1);

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
