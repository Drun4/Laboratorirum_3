
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
            this.btn_addPerson = new System.Windows.Forms.Button();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.btn_addMore = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addPerson
            // 
            this.btn_addPerson.Location = new System.Drawing.Point(289, 26);
            this.btn_addPerson.Name = "btn_addPerson";
            this.btn_addPerson.Size = new System.Drawing.Size(87, 28);
            this.btn_addPerson.TabIndex = 0;
            this.btn_addPerson.Text = "Add person";
            this.btn_addPerson.UseVisualStyleBackColor = true;
            this.btn_addPerson.Click += new System.EventHandler(this.btn_addPerson_Click);
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 16;
            this.personListBox.Location = new System.Drawing.Point(12, 26);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(243, 244);
            this.personListBox.TabIndex = 2;
            // 
            // btn_addMore
            // 
            this.btn_addMore.Location = new System.Drawing.Point(289, 77);
            this.btn_addMore.Name = "btn_addMore";
            this.btn_addMore.Size = new System.Drawing.Size(87, 28);
            this.btn_addMore.TabIndex = 3;
            this.btn_addMore.Text = "Add more";
            this.btn_addMore.UseVisualStyleBackColor = true;
            this.btn_addMore.Click += new System.EventHandler(this.btn_addMore_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(289, 242);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(87, 28);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Person list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_addMore);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.btn_addPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPerson;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Button btn_addMore;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label1;
    }
}

