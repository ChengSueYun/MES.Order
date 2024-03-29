using System;
namespace MES.Order.UI
{
	/// <summary>
	/// Enum desgnating the desired output type.
	/// </summary>
	public enum AspxTypes
	{
		Page,
		UserControl,
	} // end public enum AspxTypes

	/// <summary>
	/// Enum designating the desired output language.
	/// </summary>
	public enum SourceLanguages
	{
		C_Sharp,
		VbNet,
	} // end public enum SourceLanguages

	/// <summary>
	/// Class that converts a Windows Forms form or control to an ASP.NET Web Forms page or control.
	/// </summary>
	public class Convert2Aspx
	{
		/// <summary>
		/// The z-index CSS style declaration.
		/// </summary>
		private int _ZIndex;
		/// <summary>
		/// The _Extension depends on the SourceLanguage cs / vb
		/// </summary>
		private string _Extension;
		/// <summary>
		/// The _CodeLanguage is used in the aspx header.
		/// </summary>
		private string _CodeLanguage;
		/// <summary>
		/// The _TypeExtension is aspx for a Page and ascx for a UserControl
		/// </summary>
		private string _TypeExtension;
		/// <summary>
		/// The _AspxHeaderType is Page / Control.
		/// </summary>
		private string _AspxHeaderType;
		/// <summary>
		/// The _FullName is automatic created from the rootControl that should
		/// be converted, if it is not assigned before the convert method is called. 
		/// </summary>
		private string _FullName;
		/// <summary>
		/// The _RootName is the name of the control or the usercontrol.
		/// </summary>
		private string _RootName;
		/// <summary>
		/// The namespace for the aspx Page / ascx Control.
		/// </summary>
		private string _Namespace;
		/// <summary>
		/// The ArrayList _WebControls store all WebControls.
		/// </summary>
		private System.Collections.ArrayList _WebControls;
		private AspxTypes _AspxType;
		private SourceLanguages _SourceLanguage;

		public string FullName
		{
			get{return this._FullName;;}
			set{this._FullName = value;}
		} // end public string FullName
		
		public string RootName
		{
			get{return this._RootName;;}
			set{this._RootName = value;}
		} // end public string RootName
		
		public string Namespace
		{
			get{return this._Namespace;;}
			set{this._Namespace = value;}
		} // end public string Namespace
		
		public AspxTypes AspxType
		{
			get{return this._AspxType;;}
			set
			{
				this._AspxType = value;
				switch(this._AspxType)
				{
					case AspxTypes.Page :
						this._TypeExtension = "aspx";
						this._AspxHeaderType = "Page";
						break;
					case AspxTypes.UserControl :
						this._TypeExtension = "ascx";
						this._AspxHeaderType = "Control";
						break;
				} // end switch(this._AspxType)
			} // end set
		} // end public suite4.net.WinForms2WebForms.AspxTypes AspxType
		
		public SourceLanguages SourceLanguage
		{
			get{return this._SourceLanguage;;}
			set
			{
				this._SourceLanguage = value;
				switch(this._SourceLanguage)
				{
					case SourceLanguages.C_Sharp :
						this._CodeLanguage = "C#";
						this._Extension = "cs";
						break;
					case SourceLanguages.VbNet :
						this._CodeLanguage = "VB";
						this._Extension = "vb";
						break;
				} // end switch(this._SourceLanguage)
			} // end set
		} // end public suite4.net.WinForms2WebForms.SourceLanguages SourceLanguage
		
		public Convert2Aspx()
		{
			this.AspxType = AspxTypes.Page;
			this.SourceLanguage = SourceLanguages.C_Sharp;
		} // end public Convert2Aspx()
		
		public Convert2Aspx(AspxTypes aspxType)
		{
			this.AspxType = aspxType;
			this.SourceLanguage = SourceLanguages.C_Sharp;
		} // end public Convert2Aspx(suite4.net.WinForms2WebForms.AspxTypes aspxType)
		
		/// <summary>
		/// The method converts the rootControl to an aspx page / usercontrol.
		/// </summary>
		/// <param name="rootControl">
		/// The rootControl that should be converted.
		/// </param>
		/// <param name="path">
		/// The path the aspx source should be written to.
		/// </param>
		public void Convert(System.Windows.Forms.Control rootControl, string path)
		{
			string tempFileName;
			System.IO.StreamWriter streamWriter;
			System.Text.StringBuilder stringBuilder;
			
			if(rootControl == null)
			{
				return;
			} // end if(rootControl == null)
			
			this.CheckNames(rootControl);
			this._WebControls = new System.Collections.ArrayList();
			this._ZIndex = 100;
			stringBuilder = new System.Text.StringBuilder();
			stringBuilder.AppendFormat("<%@ {0} language=\"{1}\" Codebehind=\"{2}.{3}.{4}\" AutoEventWireup=\"false\" Inherits=\"{5}\" %>{6}", this._AspxHeaderType, this._CodeLanguage, this._RootName, this._TypeExtension, this._Extension, this._FullName, System.Environment.NewLine);
			
			if(this._AspxType == AspxTypes.Page)
			{
				stringBuilder.Append("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\" >" + System.Environment.NewLine);
				stringBuilder.Append("<HTML>" + System.Environment.NewLine);
				stringBuilder.Append("<HEAD>" + System.Environment.NewLine);
				stringBuilder.AppendFormat("<title>{0}</title>{1}", rootControl.Text, System.Environment.NewLine);
				stringBuilder.Append("<meta name=\"GENERATOR\" Content=\"form.suite4.net\">" + System.Environment.NewLine);
				stringBuilder.AppendFormat("<meta name=\"CODE_LANGUAGE\" Content=\"{0}\">{1}", this._CodeLanguage, System.Environment.NewLine);
				stringBuilder.Append("<meta name=\"vs_defaultClientScript\" content=\"JavaScript\">" + System.Environment.NewLine);
				stringBuilder.Append("<meta name=\"vs_targetSchema\" content=\"http://schemas.microsoft.com/intellisense/ie5\">" + System.Environment.NewLine);
				stringBuilder.Append("</HEAD>" + System.Environment.NewLine);
				stringBuilder.Append("<body MS_POSITIONING=\"GridLayout\">" + System.Environment.NewLine);
				stringBuilder.AppendFormat("<form id=\"{0}\" method=\"post\" runat=\"server\">{1}", this._RootName, System.Environment.NewLine);
			} // end if(this._AspxType == suite4.net.WinForms2WebForms.AspxTypes.Page)
			
			this.ConvertControls(rootControl, stringBuilder);
			
			if(this._AspxType == AspxTypes.Page)
			{
				stringBuilder.Append("</form>" + System.Environment.NewLine);
				stringBuilder.Append("</body>" + System.Environment.NewLine);
				stringBuilder.Append("</HTML>" + System.Environment.NewLine);
			} // end if(this._AspxType == suite4.net.WinForms2WebForms.AspxTypes.Page)
			
			tempFileName = path + string.Format("\\{0}.{1}", this._RootName, this._TypeExtension);
			streamWriter = new System.IO.StreamWriter(tempFileName, false, System.Text.Encoding.Default);
			streamWriter.Write(stringBuilder.ToString());
			streamWriter.Flush();
			streamWriter.Close();
			streamWriter = null;
			stringBuilder = null;
			tempFileName = path + string.Format("\\{0}.{1}.{2}", this._RootName, this._TypeExtension, this._Extension);
			streamWriter = new System.IO.StreamWriter(tempFileName, false, System.Text.Encoding.Default);
			streamWriter.Write(this.BuildCodeBehind());
			streamWriter.Flush();
			streamWriter.Close();
			streamWriter = null;
		} // end public void Convert(System.Windows.Forms.Control rootControl, string path)

		/// <summary>
		/// 
		/// </summary>
		/// <param name="rootControl"></param>
		/// <param name="stringBuilder"></param>
		private void ConvertControls(System.Windows.Forms.Control rootControl, System.Text.StringBuilder stringBuilder)
		{
			System.Web.UI.WebControls.Label webLabel;
			System.Web.UI.WebControls.TextBox webTextBox;
			System.Web.UI.HtmlControls.HtmlGenericControl webGroupBox;

			foreach(System.Windows.Forms.Control control in rootControl.Controls)
			{				
				if(control is System.Windows.Forms.Label)
				{
					webLabel = new System.Web.UI.WebControls.Label();
					webLabel.ID = control.Name;
					this._WebControls.Add(webLabel);
					stringBuilder.Append("<asp:Label");
					this.AddProperties(control, stringBuilder);
					stringBuilder.AppendFormat(">{0}</asp:Label>{1}", control.Text, System.Environment.NewLine);
				} // end else if(control is System.Windows.Forms.Label)
				else if(control is System.Windows.Forms.TextBox)
				{
					webTextBox = new System.Web.UI.WebControls.TextBox();
					webTextBox.ID = control.Name;
					this._WebControls.Add(webTextBox);
					stringBuilder.Append("<asp:TextBox");
					this.AddProperties(control, stringBuilder);
					stringBuilder.AppendFormat(">{0}</asp:TextBox>{1}", control.Text, System.Environment.NewLine);
				} // end else if(control is System.Windows.Forms.TextBox)
				else if(control is System.Windows.Forms.GroupBox)
				{
					stringBuilder.Append("<fieldset");
					stringBuilder.AppendFormat(" ID=\"{0}\" runat=\"server\"", control.Name);
					stringBuilder.AppendFormat(" style=\"POSITION: absolute; left: {0}px; top: {1}px; width:{2}px; height: {3}\"", control.Left, control.Top, control.Width, control.Height);
					stringBuilder.AppendFormat(">{0}", System.Environment.NewLine);
					stringBuilder.Append("<legend");
					stringBuilder.AppendFormat(" style=\"Z-INDEX: {0}; color:black; font-family:'{1}'; font-size:{2}pt; width=\"", this._ZIndex++, control.Font.FontFamily.Name, (int)control.Font.Size);
					stringBuilder.AppendFormat(">{0}</legend>{1}", control.Text, System.Environment.NewLine);
					this.ConvertControls(control, stringBuilder);
					stringBuilder.AppendFormat("</fieldset>{0}", System.Environment.NewLine);
					webGroupBox = new System.Web.UI.HtmlControls.HtmlGenericControl("fieldset");
					webGroupBox.ID = control.Name;
					this._WebControls.Add(webGroupBox);
				} // end else if(control is System.Windows.Forms.GroupBox)
			} // end foreach(System.Windows.Forms.Control control in rootControl.Controls)
		} // end private void ConvertControls(System.Windows.Forms.Control rootControl, System.Text.StringBuilder stringBuilder)

		/// <summary>
		/// The method assigns values to the _FullName, _RootName and _Namespace 
		/// private variables based on the rootControl' type properties.
		/// </summary>
		/// <param name="rootControl"></param>
		private void CheckNames(System.Windows.Forms.Control rootControl)
		{
			if(this._FullName == null)
			{
				this._FullName = rootControl.GetType().FullName;
			} // end if(this._FullName == null)
			if(this._RootName == null)
			{
				this._RootName = rootControl.GetType().Name;
			} // end if(this._RootName == null)
			if(this._Namespace == null)
			{
				this._Namespace = rootControl.GetType().Namespace;
			} // end if(this._Namespace == null)
		} // end private void CheckNames(System.Windows.Forms.Control rootControl)
		
		/// <summary>
		/// Add the properies from the Windows Control to aspx stringBuilder.
		/// </summary>
		/// <param name="control"></param>
		/// <param name="stringBuilder"></param>
		private void AddProperties(System.Windows.Forms.Control control, System.Text.StringBuilder stringBuilder)
		{
			stringBuilder.AppendFormat(" id=\"{0}\"", control.Name);
			stringBuilder.AppendFormat(" style=\"z-index:{0}; left:{1}px; top:{2}px; font-family:'{3}'; font-size:{4}pt; position:absolute;\"", this._ZIndex++, control.Left, control.Top, control.Font.FontFamily.Name, (int)control.Font.Size);
			stringBuilder.Append(" runat=\"server\"");
			stringBuilder.AppendFormat(" Width=\"{0}\"", control.Width);
			stringBuilder.AppendFormat(" Height=\"{0}\"", control.Height);
		
			if(control is System.Windows.Forms.TextBox)
			{
				stringBuilder.AppendFormat(" TabIndex=\"{0}\"", control.TabIndex);
			} // end if(control is System.Windows.Forms.TextBox)
		} // end private void AddProperties(System.Windows.Forms.Control control, System.Text.StringBuilder stringBuilder)

		/// <summary>
		/// The method builds the CodeDom and returns a string with the source.
		/// </summary>
		/// <returns></returns>
		private string BuildCodeBehind()
		{
			string resultString;
			System.IO.StringWriter stringWriter;
			System.CodeDom.CodeNamespace codeUsing;
			System.CodeDom.CodeNamespace codeNamespace;
			System.CodeDom.CodeCompileUnit codeCompileUnit;
			System.CodeDom.CodeTypeDeclaration codeTypeDeclaration;
			System.CodeDom.Compiler.CodeDomProvider codeDomProvider = null;
			System.CodeDom.Compiler.CodeGeneratorOptions codeGeneratorOptions;
			// Initialize Header with namespace and using declarations
			codeCompileUnit = new System.CodeDom.CodeCompileUnit();
			codeUsing = new System.CodeDom.CodeNamespace();
			codeUsing.Imports.Add(new System.CodeDom.CodeNamespaceImport("System"));
			codeNamespace = new System.CodeDom.CodeNamespace(this._Namespace);
			// Initialize TypeDeclaration private declaration
			codeTypeDeclaration = new System.CodeDom.CodeTypeDeclaration(this._RootName);
			
			switch(this._AspxType)
			{
				case AspxTypes.Page :
					codeTypeDeclaration.BaseTypes.Add(typeof(System.Web.UI.Page));
					break;
				case AspxTypes.UserControl :
					codeTypeDeclaration.BaseTypes.Add(typeof(System.Web.UI.UserControl));
					break;
			} // end switch(this._AspxType)
			
			this.GenerateFields(codeTypeDeclaration);
			this.BuildOnInitMethod(codeTypeDeclaration);
			this.BuildPageLoadMethod(codeTypeDeclaration);
			this.BuildInitializeComponentMethod(codeTypeDeclaration);
			codeNamespace.Types.Add(codeTypeDeclaration);
			codeCompileUnit.Namespaces.Add(codeUsing);
			codeCompileUnit.Namespaces.Add(codeNamespace);
			
			switch(this._SourceLanguage)
			{
				case SourceLanguages.C_Sharp :
					codeDomProvider = new Microsoft.CSharp.CSharpCodeProvider();
					break;
				case SourceLanguages.VbNet :
					codeDomProvider = new Microsoft.VisualBasic.VBCodeProvider();
					break;
			} // end switch(this._SourceLanguage)
			
			if(codeDomProvider != null)
			{
				// init codeGeneratorOptions
				codeGeneratorOptions = new System.CodeDom.Compiler.CodeGeneratorOptions();
				codeGeneratorOptions.BlankLinesBetweenMembers = false;
				codeGeneratorOptions.BracingStyle = "C";
				codeGeneratorOptions.ElseOnClosing = true;
				codeGeneratorOptions.IndentString = "\t";
				stringWriter = new System.IO.StringWriter();
				codeDomProvider.CreateGenerator().GenerateCodeFromCompileUnit(codeCompileUnit, stringWriter, codeGeneratorOptions);
				resultString = stringWriter.ToString();
				stringWriter.Close();
				return resultString;
			} // end if(codeDomProvider != null)
			
			return null;
		} // end private string BuildCodeBehind()
		
		/// <summary>
		/// Generate the declaration for all WebControls that are stored in the Arraylist _WebControls.
		/// </summary>
		/// <param name="typeDeclaration"></param>
		private void GenerateFields(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		{
			System.CodeDom.CodeMemberField memberField;
			
			foreach(System.Web.UI.Control webControl in this._WebControls)
			{
				memberField = new System.CodeDom.CodeMemberField(webControl.GetType(), webControl.ID);
				memberField.Attributes = System.CodeDom.MemberAttributes.Family;
				typeDeclaration.Members.Add(memberField);
			} // end foreach(System.Web.UI.WebControls.WebControl webControl in this._WebControls)
			
			// The following placeholder declaration is required by the Web Form Designer.
			// it is only necessary for Vb.Net
			if(this._SourceLanguage == SourceLanguages.VbNet)
			{
				memberField = new System.CodeDom.CodeMemberField(typeof(System.Object), "designerPlaceholderDeclaration");
				memberField.Attributes = System.CodeDom.MemberAttributes.Family;
				typeDeclaration.Members.Add(memberField);
			} // end if(this._SourceLanguage == suite4.net.WinForms2WebForms.SourceLanguages.VbNet)
		} // end private void GenerateFields(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		
		/// <summary>
		/// Build the code-behind Page_Load method.
		/// </summary>
		private void BuildPageLoadMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		{
			System.CodeDom.CodeMemberMethod codeMethodPageLoad;
			System.CodeDom.CodeParameterDeclarationExpression codeParameterExpression;
			// Add Page_Load method
			codeMethodPageLoad = new System.CodeDom.CodeMemberMethod();
			codeMethodPageLoad.Name = "Page_Load";
			// Add sender parameter
			codeParameterExpression = new System.CodeDom.CodeParameterDeclarationExpression(typeof(object), "sender");
			codeMethodPageLoad.Parameters.Add(codeParameterExpression);
			// Add eventargs parameter
			codeParameterExpression = new System.CodeDom.CodeParameterDeclarationExpression(typeof(System.EventArgs), "e");
			codeMethodPageLoad.Parameters.Add(codeParameterExpression);
			typeDeclaration.Members.Add(codeMethodPageLoad);
		} // end private void BuildPageLoadMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		
		/// <summary>
		/// Build the code-behind OnInit method.
		/// </summary>
		/// <param name="typeDeclaration"></param>
		private void BuildOnInitMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		{
			System.CodeDom.CodeMemberMethod codeMethodOnInit;
			System.CodeDom.CodeMethodInvokeExpression codeMethodInvoke;
			System.CodeDom.CodeParameterDeclarationExpression codeParameterExpression;
			codeMethodOnInit = new System.CodeDom.CodeMemberMethod();
			codeMethodOnInit.Name = "OnInit";
			codeMethodOnInit.Attributes = System.CodeDom.MemberAttributes.Family | System.CodeDom.MemberAttributes.Override;
			codeParameterExpression = new System.CodeDom.CodeParameterDeclarationExpression(typeof(System.EventArgs), "e");
			codeMethodOnInit.Parameters.Add(codeParameterExpression);
			codeMethodInvoke = new System.CodeDom.CodeMethodInvokeExpression(new System.CodeDom.CodeThisReferenceExpression(), "InitializeComponent");
			codeMethodOnInit.Statements.Add(codeMethodInvoke);
			codeMethodInvoke = new System.CodeDom.CodeMethodInvokeExpression(new System.CodeDom.CodeBaseReferenceExpression(), "OnInit", new System.CodeDom.CodeExpression[]{new System.CodeDom.CodeFieldReferenceExpression(null, "e")});
			codeMethodOnInit.Statements.Add(codeMethodInvoke);
			typeDeclaration.Members.Add(codeMethodOnInit);
		} // end private void BuildOnInitMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		
		/// <summary>
		/// Build the code-behind InitializeComponent method.
		/// </summary>
		/// <param name="typeDeclaration"></param>
		private void BuildInitializeComponentMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
		{
			System.CodeDom.CodeMemberMethod codeMethodInitializeComponent;
			System.CodeDom.CodeAttachEventStatement attachEventStatement;
			codeMethodInitializeComponent = new System.CodeDom.CodeMemberMethod();
			codeMethodInitializeComponent.Name = "InitializeComponent";
			attachEventStatement = new System.CodeDom.CodeAttachEventStatement();
			attachEventStatement.Event = new System.CodeDom.CodeEventReferenceExpression(new System.CodeDom.CodeThisReferenceExpression(), "Load");
			attachEventStatement.Listener = new System.CodeDom.CodeDelegateCreateExpression(new System.CodeDom.CodeTypeReference(typeof(System.EventHandler)), new System.CodeDom.CodeThisReferenceExpression(), "Page_Load");
			codeMethodInitializeComponent.Statements.Add(attachEventStatement);
			typeDeclaration.Members.Add(codeMethodInitializeComponent);
		} // end private void BuildInitializeComponentMethod(System.CodeDom.CodeTypeDeclaration typeDeclaration)
	} // end public class Convert2Aspx
} // end namespace suite4.net.WinForms2WebForms