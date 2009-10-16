using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Octopus.CDIndex {
    public class DlgItemProperties : BaseDialogs.FormDialogBase
    {
		private Label label1;
		private Label llItemName;
		private Label label3;
		private Label llVolumeUserName;
		private Label label5;
		private Label llPath;
		private TextBox tbKeywords;
		private Label label7;
        private ToolTip toolTip1;
		private System.ComponentModel.IContainer components = null;

		public DlgItemProperties() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgItemProperties));
            this.label1 = new System.Windows.Forms.Label();
            this.llItemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llVolumeUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.llPath = new System.Windows.Forms.Label();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.Font = null;
            this.toolTip1.SetToolTip(this.btnOK, resources.GetString("btnOK.ToolTip"));
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.Font = null;
            this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // llItemName
            // 
            this.llItemName.AccessibleDescription = null;
            this.llItemName.AccessibleName = null;
            resources.ApplyResources(this.llItemName, "llItemName");
            this.llItemName.Name = "llItemName";
            this.toolTip1.SetToolTip(this.llItemName, resources.GetString("llItemName.ToolTip"));
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // llVolumeUserName
            // 
            this.llVolumeUserName.AccessibleDescription = null;
            this.llVolumeUserName.AccessibleName = null;
            resources.ApplyResources(this.llVolumeUserName, "llVolumeUserName");
            this.llVolumeUserName.Name = "llVolumeUserName";
            this.toolTip1.SetToolTip(this.llVolumeUserName, resources.GetString("llVolumeUserName.ToolTip"));
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // llPath
            // 
            this.llPath.AccessibleDescription = null;
            this.llPath.AccessibleName = null;
            resources.ApplyResources(this.llPath, "llPath");
            this.llPath.AutoEllipsis = true;
            this.llPath.Name = "llPath";
            this.toolTip1.SetToolTip(this.llPath, resources.GetString("llPath.ToolTip"));
            // 
            // tbKeywords
            // 
            this.tbKeywords.AccessibleDescription = null;
            this.tbKeywords.AccessibleName = null;
            resources.ApplyResources(this.tbKeywords, "tbKeywords");
            this.tbKeywords.BackgroundImage = null;
            this.tbKeywords.Font = null;
            this.tbKeywords.Name = "tbKeywords";
            this.toolTip1.SetToolTip(this.tbKeywords, resources.GetString("tbKeywords.ToolTip"));
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Font = null;
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 60;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 120;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Blue Mirror Info";
            // 
            // DlgItemProperties
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.llPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.llVolumeUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.llItemName);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.Icon = null;
            this.Name = "DlgItemProperties";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.llItemName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.llVolumeUserName, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.llPath, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbKeywords, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		internal static bool ChangeItemProperties(ItemInDatabase itemInDatabase) {
			DlgItemProperties dlg = new DlgItemProperties();
			dlg.llItemName.Text = itemInDatabase.Name;
			dlg.llVolumeUserName.Text = itemInDatabase.GetVolumeUserName();
			dlg.llPath.Text = itemInDatabase.GetPath();
			dlg.tbKeywords.Text = itemInDatabase.Keywords;

			if (dlg.ShowDialog() == DialogResult.OK) {
				itemInDatabase.Keywords = dlg.tbKeywords.Text;
				return true;
			}
			else
				return false;

		}
	}
}

