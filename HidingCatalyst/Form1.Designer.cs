namespace HidingCatalyst {
    partial class Catalyst {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(54, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(359, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.TextChanged += new System.EventHandler(this.Path_Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 79);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(401, 67);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(12, 152);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(401, 68);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(54, 39);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(359, 20);
            this.keyBox.TabIndex = 4;
            this.keyBox.TextChanged += new System.EventHandler(this.Key_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // Catalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathBox);
            this.Name = "Catalyst";
            this.Text = "f1l3 c4t4ly5t";
            this.Load += new System.EventHandler(this.Catalyst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label2;
    }
}

