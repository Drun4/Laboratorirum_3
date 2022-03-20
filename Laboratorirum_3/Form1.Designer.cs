
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
            this.personsInfoBox = new System.Windows.Forms.RichTextBox();
            this.btn_showList = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addPerson
            // 
            this.btn_addPerson.Location = new System.Drawing.Point(288, 11);
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
            this.personListBox.Location = new System.Drawing.Point(11, 11);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(243, 244);
            this.personListBox.TabIndex = 2;
            // 
            // btn_addMore
            // 
            this.btn_addMore.Location = new System.Drawing.Point(288, 62);
            this.btn_addMore.Name = "btn_addMore";
            this.btn_addMore.Size = new System.Drawing.Size(87, 28);
            this.btn_addMore.TabIndex = 3;
            this.btn_addMore.Text = "Add more";
            this.btn_addMore.UseVisualStyleBackColor = true;
            this.btn_addMore.Click += new System.EventHandler(this.btn_addMore_Click);
            // 
            // personsInfoBox
            // 
            this.personsInfoBox.Location = new System.Drawing.Point(421, 31);
            this.personsInfoBox.Name = "personsInfoBox";
            this.personsInfoBox.Size = new System.Drawing.Size(216, 109);
            this.personsInfoBox.TabIndex = 1;
            this.personsInfoBox.Text = "";
            // 
            // btn_showList
            // 
            this.btn_showList.Location = new System.Drawing.Point(495, 192);
            this.btn_showList.Name = "btn_showList";
            this.btn_showList.Size = new System.Drawing.Size(75, 23);
            this.btn_showList.TabIndex = 4;
            this.btn_showList.Text = "Show List";
            this.btn_showList.UseVisualStyleBackColor = true;
            this.btn_showList.Click += new System.EventHandler(this.btn_showList_CLick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(288, 227);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(87, 28);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 267);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_showList);
            this.Controls.Add(this.btn_addMore);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.personsInfoBox);
            this.Controls.Add(this.btn_addPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addPerson;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Button btn_addMore;
        private System.Windows.Forms.RichTextBox personsInfoBox;
        private System.Windows.Forms.Button btn_showList;
        private System.Windows.Forms.Button btn_Edit;
    }
}

