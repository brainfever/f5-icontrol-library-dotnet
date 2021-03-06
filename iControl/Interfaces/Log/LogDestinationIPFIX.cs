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
	[System.Web.Services.WebServiceBindingAttribute(Name="Log.DestinationIPFIXBinding", Namespace="urn:iControl")]
	public partial class LogDestinationIPFIX : iControlInterface {
		public LogDestinationIPFIX() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void create(
		string [] destinations,
		string [] pools,
		string [] profiles
	) {
		this.Invoke("create", new object [] {
				destinations,
				pools,
				profiles});

	}
	public System.IAsyncResult Begincreate(string [] destinations,string [] pools,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			destinations,
			pools,
			profiles}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ipfix_destinations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void delete_all_ipfix_destinations(

	) {
		this.Invoke("delete_all_ipfix_destinations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ipfix_destinations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ipfix_destinations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ipfix_destinations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ipfix_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void delete_ipfix_destination(
		string [] destinations
	) {
		this.Invoke("delete_ipfix_destination", new object [] {
				destinations});

	}
	public System.IAsyncResult Begindelete_ipfix_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ipfix_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public void Enddelete_ipfix_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] destinations
	) {
		object [] results = this.Invoke("get_description", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
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
	// get_log_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LogDestinationIPFIXProtocolVersion [] get_log_protocol(
		string [] destinations
	) {
		object [] results = this.Invoke("get_log_protocol", new object [] {
				destinations});
		return ((LogDestinationIPFIXProtocolVersion [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_protocol(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_protocol", new object[] {
			destinations}, callback, asyncState);
	}
	public LogDestinationIPFIXProtocolVersion [] Endget_log_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LogDestinationIPFIXProtocolVersion [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pool(
		string [] destinations
	) {
		object [] results = this.Invoke("get_pool", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_serverssl_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_serverssl_profile(
		string [] destinations
	) {
		object [] results = this.Invoke("get_serverssl_profile", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_serverssl_profile(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_serverssl_profile", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_serverssl_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_delete_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_template_delete_delay(
		string [] destinations
	) {
		object [] results = this.Invoke("get_template_delete_delay", new object [] {
				destinations});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_delete_delay(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_delete_delay", new object[] {
			destinations}, callback, asyncState);
	}
	public long [] Endget_template_delete_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_template_retransmit_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_template_retransmit_interval(
		string [] destinations
	) {
		object [] results = this.Invoke("get_template_retransmit_interval", new object [] {
				destinations});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_template_retransmit_interval(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_template_retransmit_interval", new object[] {
			destinations}, callback, asyncState);
	}
	public long [] Endget_template_retransmit_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transport_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_transport_profile(
		string [] destinations
	) {
		object [] results = this.Invoke("get_transport_profile", new object [] {
				destinations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_transport_profile(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transport_profile", new object[] {
			destinations}, callback, asyncState);
	}
	public string [] Endget_transport_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_description(
		string [] destinations,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				destinations,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] destinations,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			destinations,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_log_protocol(
		string [] destinations,
		LogDestinationIPFIXProtocolVersion [] protocols
	) {
		this.Invoke("set_log_protocol", new object [] {
				destinations,
				protocols});

	}
	public System.IAsyncResult Beginset_log_protocol(string [] destinations,LogDestinationIPFIXProtocolVersion [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_protocol", new object[] {
			destinations,
			protocols}, callback, asyncState);
	}
	public void Endset_log_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_pool(
		string [] destinations,
		string [] pools
	) {
		this.Invoke("set_pool", new object [] {
				destinations,
				pools});

	}
	public System.IAsyncResult Beginset_pool(string [] destinations,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool", new object[] {
			destinations,
			pools}, callback, asyncState);
	}
	public void Endset_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_serverssl_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_serverssl_profile(
		string [] destinations,
		string [] profiles
	) {
		this.Invoke("set_serverssl_profile", new object [] {
				destinations,
				profiles});

	}
	public System.IAsyncResult Beginset_serverssl_profile(string [] destinations,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_serverssl_profile", new object[] {
			destinations,
			profiles}, callback, asyncState);
	}
	public void Endset_serverssl_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_delete_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_template_delete_delay(
		string [] destinations,
		long [] delays
	) {
		this.Invoke("set_template_delete_delay", new object [] {
				destinations,
				delays});

	}
	public System.IAsyncResult Beginset_template_delete_delay(string [] destinations,long [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_delete_delay", new object[] {
			destinations,
			delays}, callback, asyncState);
	}
	public void Endset_template_delete_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_template_retransmit_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_template_retransmit_interval(
		string [] destinations,
		long [] intervals
	) {
		this.Invoke("set_template_retransmit_interval", new object [] {
				destinations,
				intervals});

	}
	public System.IAsyncResult Beginset_template_retransmit_interval(string [] destinations,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_template_retransmit_interval", new object[] {
			destinations,
			intervals}, callback, asyncState);
	}
	public void Endset_template_retransmit_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transport_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Log/DestinationIPFIX", 
		RequestNamespace="urn:iControl:Log/DestinationIPFIX", ResponseNamespace="urn:iControl:Log/DestinationIPFIX")]
	public void set_transport_profile(
		string [] destinations,
		string [] profiles
	) {
		this.Invoke("set_transport_profile", new object [] {
				destinations,
				profiles});

	}
	public System.IAsyncResult Beginset_transport_profile(string [] destinations,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transport_profile", new object[] {
			destinations,
			profiles}, callback, asyncState);
	}
	public void Endset_transport_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Log.DestinationIPFIX.ProtocolVersion", Namespace = "urn:iControl")]
	public enum LogDestinationIPFIXProtocolVersion
	{
		IPFIX_LOG_PROTOCOL_UNKNOWN,
		IPFIX_LOG_PROTOCOL_IPFIX,
		IPFIX_LOG_PROTOCOL_NETFLOW_9,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
