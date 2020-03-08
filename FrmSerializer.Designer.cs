namespace cSharpSerializer
{
    partial class FrmSerializer
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
            this.BtnSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSerialize
            // 
            this.BtnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSerialize.Location = new System.Drawing.Point(168, 74);
            this.BtnSerialize.Name = "BtnSerialize";
            this.BtnSerialize.Size = new System.Drawing.Size(113, 50);
            this.BtnSerialize.TabIndex = 0;
            this.BtnSerialize.Text = "Serialize";
            this.BtnSerialize.UseVisualStyleBackColor = true;
            this.BtnSerialize.Click += new System.EventHandler(this.BtnSerialize_Click);
            // 
            // FrmSerializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSerialize);
            this.Name = "FrmSerializer";
            this.Text = "C# - Windows Forms - Serializer";
            this.Load += new System.EventHandler(this.FrmSerializer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSerialize;
    }
}

