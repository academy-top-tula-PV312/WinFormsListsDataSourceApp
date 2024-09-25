namespace WinFormsListsDataSourceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listEmployees = new ListBox();
            btnDelete = new Button();
            viewList = new Button();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.Font = new Font("Segoe UI", 16F);
            listEmployees.FormattingEnabled = true;
            listEmployees.ItemHeight = 30;
            listEmployees.Location = new Point(12, 12);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(397, 424);
            listEmployees.TabIndex = 0;
            listEmployees.SelectedIndexChanged += listEmployees_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(432, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(251, 53);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // viewList
            // 
            viewList.Font = new Font("Segoe UI", 16F);
            viewList.Location = new Point(432, 383);
            viewList.Name = "viewList";
            viewList.Size = new Size(251, 53);
            viewList.TabIndex = 1;
            viewList.Text = "Delete Employee";
            viewList.UseVisualStyleBackColor = true;
            viewList.Click += viewList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 455);
            Controls.Add(viewList);
            Controls.Add(btnDelete);
            Controls.Add(listEmployees);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listEmployees;
        private Button btnDelete;
        private Button viewList;
    }
}
