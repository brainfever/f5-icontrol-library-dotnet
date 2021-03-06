namespace iControl {
	using System.Xml.Serialization;
	using System.Web.Services;
	using System.ComponentModel;
	using System.Web.Services.Protocols;
	using System;
	using System.Diagnostics;

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.ProfileVXLANBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingProfileVXLANProfileVXLANEncapsulationType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingProfileVXLANProfileVXLANFloodingType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfilePortNumber))]
	public partial class NetworkingProfileVXLAN : iControlInterface {
		public NetworkingProfileVXLAN() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encapsulation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingProfileVXLANProfileVXLANEncapsulationType [] get_encapsulation_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_encapsulation_type", new object [] {
				profile_names});
		return ((NetworkingProfileVXLANProfileVXLANEncapsulationType [])(results[0]));
	}
	public System.IAsyncResult Beginget_encapsulation_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encapsulation_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public NetworkingProfileVXLANProfileVXLANEncapsulationType [] Endget_encapsulation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingProfileVXLANProfileVXLANEncapsulationType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flooding_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingProfileVXLANProfileVXLANFloodingType [] get_flooding_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_flooding_type", new object [] {
				profile_names});
		return ((NetworkingProfileVXLANProfileVXLANFloodingType [])(results[0]));
	}
	public System.IAsyncResult Beginget_flooding_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flooding_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public NetworkingProfileVXLANProfileVXLANFloodingType [] Endget_flooding_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingProfileVXLANProfileVXLANFloodingType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public string [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfilePortNumber [] get_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_port", new object [] {
				profile_names});
		return ((CommonProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfilePortNumber [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_version(

	) {
		object [] results = this.Invoke("get_version", new object [] {
});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_version", new object[] {
}, callback, asyncState);
	}
	public string Endget_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encapsulation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void set_encapsulation_type(
		string [] profile_names,
		NetworkingProfileVXLANProfileVXLANEncapsulationType [] encapsulation_types
	) {
		this.Invoke("set_encapsulation_type", new object [] {
				profile_names,
				encapsulation_types});

	}
	public System.IAsyncResult Beginset_encapsulation_type(string [] profile_names,NetworkingProfileVXLANProfileVXLANEncapsulationType [] encapsulation_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encapsulation_type", new object[] {
			profile_names,
			encapsulation_types}, callback, asyncState);
	}
	public void Endset_encapsulation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flooding_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void set_flooding_type(
		string [] profile_names,
		NetworkingProfileVXLANProfileVXLANFloodingType [] flooding_types
	) {
		this.Invoke("set_flooding_type", new object [] {
				profile_names,
				flooding_types});

	}
	public System.IAsyncResult Beginset_flooding_type(string [] profile_names,NetworkingProfileVXLANProfileVXLANFloodingType [] flooding_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flooding_type", new object[] {
			profile_names,
			flooding_types}, callback, asyncState);
	}
	public void Endset_flooding_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/ProfileVXLAN", 
		RequestNamespace="urn:iControl:Networking/ProfileVXLAN", ResponseNamespace="urn:iControl:Networking/ProfileVXLAN")]
	public void set_port(
		string [] profile_names,
		CommonProfilePortNumber [] ports
	) {
		this.Invoke("set_port", new object [] {
				profile_names,
				ports});

	}
	public System.IAsyncResult Beginset_port(string [] profile_names,CommonProfilePortNumber [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port", new object[] {
			profile_names,
			ports}, callback, asyncState);
	}
	public void Endset_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileVXLAN.VXLANEncapsulationType", Namespace = "urn:iControl")]
	public enum NetworkingProfileVXLANVXLANEncapsulationType
	{
		PROFILE_VXLAN_ENCAPSULATION_TYPE_UNKNOWN,
		PROFILE_VXLAN_ENCAPSULATION_TYPE_VXLAN,
		PROFILE_VXLAN_ENCAPSULATION_TYPE_VXLAN_GPE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileVXLAN.VXLANFloodingType", Namespace = "urn:iControl")]
	public enum NetworkingProfileVXLANVXLANFloodingType
	{
		PROFILE_VXLAN_FLOODING_TYPE_UNKNOWN,
		PROFILE_VXLAN_FLOODING_TYPE_NONE,
		PROFILE_VXLAN_FLOODING_TYPE_MULTICAST,
		PROFILE_VXLAN_FLOODING_TYPE_MULTIPOINT,
		PROFILE_VXLAN_FLOODING_TYPE_REPLICATOR,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileVXLAN.ProfileVXLANEncapsulationType", Namespace = "urn:iControl")]
	public partial class NetworkingProfileVXLANProfileVXLANEncapsulationType
	{
		private NetworkingProfileVXLANVXLANEncapsulationType valueField;
		public NetworkingProfileVXLANVXLANEncapsulationType value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.ProfileVXLAN.ProfileVXLANFloodingType", Namespace = "urn:iControl")]
	public partial class NetworkingProfileVXLANProfileVXLANFloodingType
	{
		private NetworkingProfileVXLANVXLANFloodingType valueField;
		public NetworkingProfileVXLANVXLANFloodingType value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

}
