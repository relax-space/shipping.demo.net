namespace shipping.demo.net
{
    partial class Form1
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.grpPushQuery = new System.Windows.Forms.GroupBox();
            this.btnPushQuery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCancel);
            this.grpCreate.Controls.Add(this.btnPushQuery);
            this.grpCreate.Controls.Add(this.btnQuery);
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCreate.Location = new System.Drawing.Point(0, 0);
            this.grpCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCreate.Size = new System.Drawing.Size(1625, 340);
            this.grpCreate.TabIndex = 0;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(24, 41);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(229, 98);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpQuery
            // 
            this.grpQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpQuery.Location = new System.Drawing.Point(0, 340);
            this.grpQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQuery.Size = new System.Drawing.Size(1625, 309);
            this.grpQuery.TabIndex = 1;
            this.grpQuery.TabStop = false;
            this.grpQuery.Text = "Query";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(298, 41);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(201, 98);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // grpPushQuery
            // 
            this.grpPushQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPushQuery.Location = new System.Drawing.Point(0, 649);
            this.grpPushQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPushQuery.Name = "grpPushQuery";
            this.grpPushQuery.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPushQuery.Size = new System.Drawing.Size(1625, 292);
            this.grpPushQuery.TabIndex = 2;
            this.grpPushQuery.TabStop = false;
            this.grpPushQuery.Text = "PushQuery";
            // 
            // btnPushQuery
            // 
            this.btnPushQuery.Location = new System.Drawing.Point(839, 41);
            this.btnPushQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPushQuery.Name = "btnPushQuery";
            this.btnPushQuery.Size = new System.Drawing.Size(208, 98);
            this.btnPushQuery.TabIndex = 2;
            this.btnPushQuery.Text = "PushQuery";
            this.btnPushQuery.UseVisualStyleBackColor = true;
            this.btnPushQuery.Click += new System.EventHandler(this.btnPushQuery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 41);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 98);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 941);
            this.Controls.Add(this.grpPushQuery);
            this.Controls.Add(this.grpQuery);
            this.Controls.Add(this.grpCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.GroupBox grpPushQuery;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnPushQuery;
        private System.Windows.Forms.Button btnCancel;
    }
}

