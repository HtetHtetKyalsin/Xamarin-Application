package md5d3554641622603d1129dde4927c86a90;


public class UserInputActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinAndroidAssignment.UserInputActivity, XamarinAndroidAssignment", UserInputActivity.class, __md_methods);
	}


	public UserInputActivity ()
	{
		super ();
		if (getClass () == UserInputActivity.class)
			mono.android.TypeManager.Activate ("XamarinAndroidAssignment.UserInputActivity, XamarinAndroidAssignment", "", this, new java.lang.Object[] {  });
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
