
namespace MouseHoverDispose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn1_Dispose = new System.Windows.Forms.Button();
            this.Lbl1_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1_Dispose
            // 
            this.Btn1_Dispose.BackColor = System.Drawing.Color.DimGray;
            this.Btn1_Dispose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_Dispose.Location = new System.Drawing.Point(288, 312);
            this.Btn1_Dispose.Name = "Btn1_Dispose";
            this.Btn1_Dispose.Size = new System.Drawing.Size(200, 70);
            this.Btn1_Dispose.TabIndex = 0;
            this.Btn1_Dispose.Text = "Dispose";
            this.Btn1_Dispose.UseVisualStyleBackColor = false;
            this.Btn1_Dispose.MouseHover += new System.EventHandler(this.Btn1_Dispose_MouseHover);
            // 
            // Lbl1_Count
            // 
            this.Lbl1_Count.AutoSize = true;
            this.Lbl1_Count.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl1_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1_Count.ForeColor = System.Drawing.Color.ForestGreen;
            this.Lbl1_Count.Location = new System.Drawing.Point(13, 13);
            this.Lbl1_Count.Name = "Lbl1_Count";
            this.Lbl1_Count.Size = new System.Drawing.Size(122, 32);
            this.Lbl1_Count.TabIndex = 1;
            this.Lbl1_Count.Text = "Count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MouseHoverDispose.Properties.Resources.inline_image_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Lbl1_Count);
            this.Controls.Add(this.Btn1_Dispose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1_Dispose;
        private System.Windows.Forms.Label Lbl1_Count;
    }
}

