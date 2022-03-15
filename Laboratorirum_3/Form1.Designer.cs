
namespace Laboratorirum_3
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
            this.addPersonB = new System.Windows.Forms.Button();
            this.personsInfoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addPersonB
            // 
            this.addPersonB.Location = new System.Drawing.Point(10, 11);
            this.addPersonB.Name = "addPersonB";
            this.addPersonB.Size = new System.Drawing.Size(87, 27);
            this.addPersonB.TabIndex = 0;
            this.addPersonB.Text = "Add person";
            this.addPersonB.UseVisualStyleBackColor = true;
            this.addPersonB.Click += new System.EventHandler(this.addPersonB_Click);
            // 
            // personsInfoBox
            // 
            this.personsInfoBox.Location = new System.Drawing.Point(10, 104);
            this.personsInfoBox.Name = "personsInfoBox";
            this.personsInfoBox.Size = new System.Drawing.Size(237, 144);
            this.personsInfoBox.TabIndex = 1;
            this.personsInfoBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 288);
            this.Controls.Add(this.personsInfoBox);
            this.Controls.Add(this.addPersonB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPersonB;
        private System.Windows.Forms.RichTextBox personsInfoBox;
    }
}

