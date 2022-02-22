
namespace UserManagementSystem.Views.Auth
{
    partial class FormPassword
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordDouble = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordDouble = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(236, 52);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordDouble
            // 
            this.labelPasswordDouble.AutoSize = true;
            this.labelPasswordDouble.Location = new System.Drawing.Point(236, 115);
            this.labelPasswordDouble.Name = "labelPasswordDouble";
            this.labelPasswordDouble.Size = new System.Drawing.Size(100, 13);
            this.labelPasswordDouble.TabIndex = 1;
            this.labelPasswordDouble.Text = "Повторите пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtPasswordDouble
            // 
            this.txtPasswordDouble.Location = new System.Drawing.Point(43, 115);
            this.txtPasswordDouble.Name = "txtPasswordDouble";
            this.txtPasswordDouble.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordDouble.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(43, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 256);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPasswordDouble);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPasswordDouble);
            this.Controls.Add(this.labelPassword);
            this.Name = "FormPassword";
            this.Text = "Пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordDouble;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordDouble;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}