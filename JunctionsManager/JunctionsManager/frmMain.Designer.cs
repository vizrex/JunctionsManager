namespace JunctionsManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCreateJunction = new System.Windows.Forms.GroupBox();
            this.cmdBrowseDestination = new System.Windows.Forms.Button();
            this.cmdBrowseSource = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRemoveJunction = new System.Windows.Forms.GroupBox();
            this.cmdBrowseTarget = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpCreateJunction.SuspendLayout();
            this.grpRemoveJunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateJunction
            // 
            this.grpCreateJunction.Controls.Add(this.cmdBrowseDestination);
            this.grpCreateJunction.Controls.Add(this.cmdBrowseSource);
            this.grpCreateJunction.Controls.Add(this.txtDestinationFolder);
            this.grpCreateJunction.Controls.Add(this.label2);
            this.grpCreateJunction.Controls.Add(this.txtSourceFolder);
            this.grpCreateJunction.Controls.Add(this.label1);
            this.grpCreateJunction.Location = new System.Drawing.Point(13, 13);
            this.grpCreateJunction.Name = "grpCreateJunction";
            this.grpCreateJunction.Size = new System.Drawing.Size(420, 82);
            this.grpCreateJunction.TabIndex = 0;
            this.grpCreateJunction.TabStop = false;
            this.grpCreateJunction.Text = "Create Junction";
            // 
            // cmdBrowseDestination
            // 
            this.cmdBrowseDestination.Location = new System.Drawing.Point(378, 46);
            this.cmdBrowseDestination.Name = "cmdBrowseDestination";
            this.cmdBrowseDestination.Size = new System.Drawing.Size(27, 23);
            this.cmdBrowseDestination.TabIndex = 5;
            this.cmdBrowseDestination.Text = "...";
            this.cmdBrowseDestination.UseVisualStyleBackColor = true;
            this.cmdBrowseDestination.Click += new System.EventHandler(this.cmdBrowseDestination_Click);
            // 
            // cmdBrowseSource
            // 
            this.cmdBrowseSource.Location = new System.Drawing.Point(378, 20);
            this.cmdBrowseSource.Name = "cmdBrowseSource";
            this.cmdBrowseSource.Size = new System.Drawing.Size(27, 23);
            this.cmdBrowseSource.TabIndex = 4;
            this.cmdBrowseSource.Text = "...";
            this.cmdBrowseSource.UseVisualStyleBackColor = true;
            this.cmdBrowseSource.Click += new System.EventHandler(this.cmdBrowseSource_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(73, 48);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(299, 20);
            this.txtDestinationFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(73, 22);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(299, 20);
            this.txtSourceFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // grpRemoveJunction
            // 
            this.grpRemoveJunction.Controls.Add(this.cmdBrowseTarget);
            this.grpRemoveJunction.Controls.Add(this.txtTargetFolder);
            this.grpRemoveJunction.Controls.Add(this.label4);
            this.grpRemoveJunction.Location = new System.Drawing.Point(13, 101);
            this.grpRemoveJunction.Name = "grpRemoveJunction";
            this.grpRemoveJunction.Size = new System.Drawing.Size(420, 53);
            this.grpRemoveJunction.TabIndex = 1;
            this.grpRemoveJunction.TabStop = false;
            this.grpRemoveJunction.Text = "Remove Junction";
            // 
            // cmdBrowseTarget
            // 
            this.cmdBrowseTarget.Location = new System.Drawing.Point(378, 20);
            this.cmdBrowseTarget.Name = "cmdBrowseTarget";
            this.cmdBrowseTarget.Size = new System.Drawing.Size(27, 23);
            this.cmdBrowseTarget.TabIndex = 4;
            this.cmdBrowseTarget.Text = "...";
            this.cmdBrowseTarget.UseVisualStyleBackColor = true;
            this.cmdBrowseTarget.Click += new System.EventHandler(this.cmdBrowseTarget_Click);
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(73, 22);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(299, 20);
            this.txtTargetFolder.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Target:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(391, 161);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 28);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 197);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.grpRemoveJunction);
            this.Controls.Add(this.grpCreateJunction);
            this.Name = "frmMain";
            this.Text = "Junctions Manager";
            this.grpCreateJunction.ResumeLayout(false);
            this.grpCreateJunction.PerformLayout();
            this.grpRemoveJunction.ResumeLayout(false);
            this.grpRemoveJunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateJunction;
        private System.Windows.Forms.Button cmdBrowseDestination;
        private System.Windows.Forms.Button cmdBrowseSource;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRemoveJunction;
        private System.Windows.Forms.Button cmdBrowseTarget;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

