namespace CEIS209_PayRoll_Project
{
    partial class MainForm
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 20;
            this.EmployeesListBox.Location = new System.Drawing.Point(22, 120);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(1289, 564);
            this.EmployeesListBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "November 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Keith Swoger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "CEIS 209";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payroll System";
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.PrintPaychecksButton.Location = new System.Drawing.Point(1095, 35);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(180, 48);
            this.PrintPaychecksButton.TabIndex = 12;
            this.PrintPaychecksButton.Text = "Print";
            this.PrintPaychecksButton.UseVisualStyleBackColor = true;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DisplayButton.Location = new System.Drawing.Point(909, 35);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(180, 48);
            this.DisplayButton.TabIndex = 11;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RemoveButton.Location = new System.Drawing.Point(723, 35);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(180, 48);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(537, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(180, 48);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 699);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintPaychecksButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}

