namespace Administrator
{
    partial class AdministratorForm
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
            this.split_container = new DevExpress.XtraEditors.SplitContainerControl();
            this.mmo_script = new DevExpress.XtraEditors.MemoEdit();
            this.mmo_result = new DevExpress.XtraEditors.MemoEdit();
            this.cbo_databases = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tool_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.btn_rollback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmo_script.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmo_result.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // split_container
            // 
            this.split_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split_container.Horizontal = false;
            this.split_container.Location = new System.Drawing.Point(6, 41);
            this.split_container.Name = "split_container";
            this.split_container.Panel1.Controls.Add(this.mmo_script);
            this.split_container.Panel1.Text = "Panel1";
            this.split_container.Panel2.Controls.Add(this.mmo_result);
            this.split_container.Panel2.Text = "Panel2";
            this.split_container.Size = new System.Drawing.Size(1052, 583);
            this.split_container.SplitterPosition = 184;
            this.split_container.TabIndex = 0;
            this.split_container.Text = "splitContainerControl1";
            // 
            // mmo_script
            // 
            this.mmo_script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmo_script.Location = new System.Drawing.Point(0, 0);
            this.mmo_script.Name = "mmo_script";
            this.mmo_script.Size = new System.Drawing.Size(1052, 184);
            this.mmo_script.TabIndex = 0;
            this.mmo_script.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.mmo_script_EditValueChanging);
            this.mmo_script.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmo_script_KeyDown);
            // 
            // mmo_result
            // 
            this.mmo_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmo_result.Location = new System.Drawing.Point(0, 0);
            this.mmo_result.Name = "mmo_result";
            this.mmo_result.Properties.ReadOnly = true;
            this.mmo_result.Size = new System.Drawing.Size(1052, 394);
            this.mmo_result.TabIndex = 1;
            // 
            // cbo_databases
            // 
            this.cbo_databases.FormattingEnabled = true;
            this.cbo_databases.Location = new System.Drawing.Point(6, 12);
            this.cbo_databases.Name = "cbo_databases";
            this.cbo_databases.Size = new System.Drawing.Size(200, 21);
            this.cbo_databases.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tool_label
            // 
            this.tool_label.Name = "tool_label";
            this.tool_label.Size = new System.Drawing.Size(118, 17);
            this.tool_label.Text = "toolStripStatusLabel1";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(212, 11);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(319, 11);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(75, 23);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // btn_rollback
            // 
            this.btn_rollback.Location = new System.Drawing.Point(400, 11);
            this.btn_rollback.Name = "btn_rollback";
            this.btn_rollback.Size = new System.Drawing.Size(75, 23);
            this.btn_rollback.TabIndex = 5;
            this.btn_rollback.Text = "Rollback";
            this.btn_rollback.UseVisualStyleBackColor = true;
            this.btn_rollback.Click += new System.EventHandler(this.btn_rollback_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.btn_rollback);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbo_databases);
            this.Controls.Add(this.split_container);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quero trabalhar!";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmo_script.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmo_result.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl split_container;
        private DevExpress.XtraEditors.MemoEdit mmo_script;
        private DevExpress.XtraEditors.MemoEdit mmo_result;
        private System.Windows.Forms.ComboBox cbo_databases;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tool_label;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_rollback;
    }
}

