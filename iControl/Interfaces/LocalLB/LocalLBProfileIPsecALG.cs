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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileIPsecALGBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPsecALGProfileIPsecALGStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileIPsecALG : iControlInterface {
		public LocalLBProfileIPsecALG() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPsecALGProfileIPsecALGStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileIPsecALGProfileIPsecALGStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileIPsecALGProfileIPsecALGStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPsecALGProfileIPsecALGStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_initial_connection_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_initial_connection_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_initial_connection_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_initial_connection_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_initial_connection_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_initial_connection_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	// get_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_profile", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_publisher", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pending_ike_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_pending_ike_connection_limit(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_pending_ike_connection_limit", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_pending_ike_connection_limit(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pending_ike_connection_limit", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_pending_ike_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPsecALGProfileIPsecALGStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileIPsecALGProfileIPsecALGStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPsecALGProfileIPsecALGStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPsecALGProfileIPsecALGStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
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
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_initial_connection_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_initial_connection_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_initial_connection_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_initial_connection_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_initial_connection_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_initial_connection_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_log_profile(
		string [] profile_names,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_profile", new object [] {
				profile_names,
				profiles});

	}
	public System.IAsyncResult Beginset_log_profile(string [] profile_names,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_profile", new object[] {
			profile_names,
			profiles}, callback, asyncState);
	}
	public void Endset_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_log_publisher(
		string [] profile_names,
		LocalLBProfileString [] publishers
	) {
		this.Invoke("set_log_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_log_publisher(string [] profile_names,LocalLBProfileString [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_settings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_log_settings(
		string [] profile_names,
		LocalLBProfileString [] publishers,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_settings", new object [] {
				profile_names,
				publishers,
				profiles});

	}
	public System.IAsyncResult Beginset_log_settings(string [] profile_names,LocalLBProfileString [] publishers,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_settings", new object[] {
			profile_names,
			publishers,
			profiles}, callback, asyncState);
	}
	public void Endset_log_settings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pending_ike_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileIPsecALG", 
		RequestNamespace="urn:iControl:LocalLB/ProfileIPsecALG", ResponseNamespace="urn:iControl:LocalLB/ProfileIPsecALG")]
	public void set_pending_ike_connection_limit(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_pending_ike_connection_limit", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_pending_ike_connection_limit(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pending_ike_connection_limit", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_pending_ike_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileIPsecALG.ProfileIPsecALGStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileIPsecALGProfileIPsecALGStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileIPsecALG.ProfileIPsecALGStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileIPsecALGProfileIPsecALGStatistics
	{
		private LocalLBProfileIPsecALGProfileIPsecALGStatisticEntry [] statisticsField;
		public LocalLBProfileIPsecALGProfileIPsecALGStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}