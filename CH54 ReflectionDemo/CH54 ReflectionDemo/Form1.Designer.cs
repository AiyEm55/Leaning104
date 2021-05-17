
namespace CH54_ReflectionDemo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsMethods = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsProperties = new System.Windows.Forms.ListBox();
            this.lsConstructors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDiscoverTypeInformation);
            this.splitContainer1.Panel1.Controls.Add(this.txtTypeName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsConstructors);
            this.splitContainer1.Panel2.Controls.Add(this.lsProperties);
            this.splitContainer1.Panel2.Controls.Add(this.lsMethods);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 688);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDiscoverTypeInformation
            // 
            this.btnDiscoverTypeInformation.Location = new System.Drawing.Point(557, 39);
            this.btnDiscoverTypeInformation.Name = "btnDiscoverTypeInformation";
            this.btnDiscoverTypeInformation.Size = new System.Drawing.Size(437, 41);
            this.btnDiscoverTypeInformation.TabIndex = 2;
            this.btnDiscoverTypeInformation.Text = "Dicover Type Information";
            this.btnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInformation.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(168, 46);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(345, 26);
            this.txtTypeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // lsMethods
            // 
            this.lsMethods.FormattingEnabled = true;
            this.lsMethods.ItemHeight = 20;
            this.lsMethods.Location = new System.Drawing.Point(16, 50);
            this.lsMethods.Name = "lsMethods";
            this.lsMethods.Size = new System.Drawing.Size(310, 524);
            this.lsMethods.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Construction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Methods";
            // 
            // lsProperties
            // 
            this.lsProperties.FormattingEnabled = true;
            this.lsProperties.ItemHeight = 20;
            this.lsProperties.Location = new System.Drawing.Point(368, 50);
            this.lsProperties.Name = "lsProperties";
            this.lsProperties.Size = new System.Drawing.Size(310, 524);
            this.lsProperties.TabIndex = 6;
            // 
            // lsConstructors
            // 
            this.lsConstructors.FormattingEnabled = true;
            this.lsConstructors.ItemHeight = 20;
            this.lsConstructors.Location = new System.Drawing.Point(732, 50);
            this.lsConstructors.Name = "lsConstructors";
            this.lsConstructors.Size = new System.Drawing.Size(310, 524);
            this.lsConstructors.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDiscoverTypeInformation;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsMethods;
        private System.Windows.Forms.ListBox lsConstructors;
        private System.Windows.Forms.ListBox lsProperties;
    }
}

